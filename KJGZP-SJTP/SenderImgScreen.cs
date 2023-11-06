using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KJGZP_SJTP
{
    public partial class StartScreen : Form
    {

        private Image imageToDisplay;//当前投屏图片
        private bool isRunning = false;//投屏状态 
        public int lookUpcount = 0;//获取四季图片文件夹中最少图片量循环
        private string validKey = "";//严重key的有效期
        private int currentImageIndex = 1;//当前投屏图片index
        PictureBox pictureBoxSpring = new PictureBox(); //图片控件，加载春天图片
        PictureBox pictureBoxSummer = new PictureBox(); //图片控件，加载夏天图片
        PictureBox pictureBoxAutumn = new PictureBox(); //图片控件，加载秋天图片
        PictureBox pictureBoxWinter = new PictureBox(); //图片控件，加载冬天图片
        Dictionary<string, string> dicSrping = new Dictionary<string, string>();
        Dictionary<string, string> dicSummer = new Dictionary<string, string>();
        Dictionary<string, string> dicAutumn = new Dictionary<string, string>();
        Dictionary<string, string> dicWinter = new Dictionary<string, string>();
        CryptKeyHelper cryptHelper = new CryptKeyHelper();
        public StartScreen()
        {
            InitializeComponent();
            GetScreen();
            //LoadImages("春", pictureBoxSpring);
            //LoadImages("夏", pictureBoxSummer);
            //LoadImages("秋", pictureBoxAutumn);
            //LoadImages("冬", pictureBoxWinter);
        }
        private void btnDecryptKey_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxKey.Text))
            {
                MessageBox.Show("请输入要检查的密钥.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string decryptKey = cryptHelper.Decrypt(this.textBoxKey.Text, "bzg");

                this.lblDecryptVal.Text = decryptKey;
            }
            catch (Exception ex)
            {
                this.lblDecryptVal.Text = "输入为无效密钥.";
            }
        }

        private void getScreen_Click(object sender, EventArgs e)
        {
            GetScreen();
        }
        private void GetScreen()
        {
            if (screenCKListBox != null)
            {
                screenCKListBox.Items.Clear();
            }
            Screen[] screens = Screen.AllScreens;
            foreach (Screen screen in screens)
            {
                // 在界面中列出可用的屏幕，让用户选择
                screenCKListBox.Items.Add(screen.DeviceName);
            }
        }

        /// <summary>
        /// 投屏春天
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScreenSpring_Click(object sender, EventArgs e)
        {
            LoadImages("春", pictureBoxSpring);
            WhitchSeasonToScreen("春", pictureBoxSpring);
        }
        /// <summary>
        /// 投屏夏天
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScreenSummer_Click(object sender, EventArgs e)
        {
            LoadImages("夏", pictureBoxSummer);
            WhitchSeasonToScreen("夏", pictureBoxSummer);
        }
        /// <summary>
        /// 投屏秋天
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScreenAutumn_Click(object sender, EventArgs e)
        {
            LoadImages("秋", pictureBoxAutumn);
            WhitchSeasonToScreen("秋", pictureBoxAutumn);
        }
        /// <summary>
        /// 投屏冬天
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScreenWinter_Click(object sender, EventArgs e)
        {
            LoadImages("冬", pictureBoxWinter);
            WhitchSeasonToScreen("冬", pictureBoxWinter);
        }
        /// <summary>
        /// 选择投屏屏幕，并设置图片
        /// </summary>
        /// <param name="season"></param>
        /// <param name="pictureBox"></param>
        private void WhitchSeasonToScreen(string season, PictureBox pictureBox)
        {
            validKey = CheckValidKey();
            if (string.IsNullOrEmpty(validKey)) { return; }
            Screen[] selectedScreens = GetSelectedScreens();
            if (selectedScreens.Count() <= 0)
            {
                MessageBox.Show("请选择投屏屏幕", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var imagePath = "";
            if (season == "春")
            {
                imagePath = dicSrping[season + "01"];
            }
            else if (season == "夏")
            {
                imagePath = dicSummer[season + "01"];
            }
            else if (season == "秋")
            {
                imagePath = dicAutumn[season + "01"];
            }
            else if (season == "冬")
            {
                imagePath = dicWinter[season + "01"];
            }
            Image image = Image.FromFile(imagePath);
            // 初始化显示第一张图片 
            imageToDisplay = image;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = imageToDisplay;
            StartScreenSharing(selectedScreens, pictureBox);
        }

        private string CheckValidKey()
        {
            if (string.IsNullOrEmpty(textBoxKey.Text))
            {
                MessageBox.Show("请输入正确的密钥.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            try
            {
                string decryptKey = cryptHelper.Decrypt(this.textBoxKey.Text, "bzg");

                return decryptKey;
            }
            catch (Exception ex)
            {
                MessageBox.Show("输入的密钥无效.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
        }
        /// <summary>
        /// 获取选择的投屏
        /// </summary>
        /// <returns></returns>
        private Screen[] GetSelectedScreens()
        {
            List<Screen> selectedScreens = new List<Screen>();
            // 在界面中选择要投屏的屏幕 
            Screen[] screens = Screen.AllScreens; //所有屏幕，判断选择的投屏
            for (int i = 0; i < screenCKListBox.Items.Count; i++)
            {
                if (screenCKListBox.GetItemChecked(i))
                {
                    foreach (Screen screen in screens)
                    {
                        if (screen.DeviceName == screenCKListBox.Items[i])
                        {
                            selectedScreens.Add(screen);
                        }
                    }

                }
            }
            return selectedScreens.ToArray();
        }


        /// <summary>
        /// 开始投屏
        /// </summary>
        /// <param name="selectedScreens">所选投屏屏幕</param>
        /// <param name="pictureBox">投屏图片</param>
        private void StartScreenSharing(Screen[] selectedScreens, PictureBox pictureBox)
        {
            // 获取选择的屏幕 
            foreach (Screen screen in selectedScreens)
            {
                pictureBox.Location = new Point(0, 0);//new Point(screen.Bounds.Left, screen.Bounds.Top);
                pictureBox.Size = new Size(screen.Bounds.Width, screen.Bounds.Height);
                // 将图片显示在指定屏幕上
                Form screenForm = new Form();
                screenForm.FormBorderStyle = FormBorderStyle.None;
                screenForm.WindowState = FormWindowState.Maximized;
                screenForm.StartPosition = FormStartPosition.Manual;
                screenForm.Bounds = screen.Bounds;
                screenForm.Controls.Add(pictureBox);
                screenForm.Show();
            }
        }

        /// <summary>
        /// 加载图片
        /// </summary>
        /// <param name="seasonFloder">季节文件夹目录</param>
        /// <param name="pictureBox">季节的图片控件</param>
        private void LoadImages(string seasonFloder, PictureBox pictureBox)
        {
            Dictionary<string, string> dicSeason = new Dictionary<string, string>();
            // dicSeason.Clear();
            string picPath = Application.StartupPath;
            // 添加图片到列表 
            DirectoryInfo dir = new DirectoryInfo(picPath + "\\Images\\" + seasonFloder);
            FileSystemInfo[] fsinfos = dir.GetFiles();
            //遍历检索的文件和子目录
            int i = 0;
            foreach (FileSystemInfo fsinfo in fsinfos)
            {
                if (".PNG,.JPG,.JPEG,.GIF".ToLower().Contains(fsinfo.Extension.ToLower()))
                {
                    i++;
                    Image image = Image.FromFile(fsinfo.FullName);
                    // images.Add(image);
                    dicSeason.Add(seasonFloder + i.ToString().PadLeft(2, '0'), fsinfo.FullName);
                }
            }
            if (seasonFloder == "春")
            {
                dicSrping = dicSeason;
            }
            else if (seasonFloder == "夏")
            {
                dicSummer = dicSeason;
            }
            else if (seasonFloder == "秋")
            {
                dicAutumn = dicSeason;
            }
            else if (seasonFloder == "冬")
            {
                dicWinter = dicSeason;
            }
            // 初始化显示第一张图片 
            //imageToDisplay = images[0];
            //pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox.Image = imageToDisplay;
        }

        /// <summary>
        /// 开始循环播放投屏图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                StopScreenSharing();
            }
            else
            {
                validKey = CheckValidKey();
                if (string.IsNullOrEmpty(validKey)) { return; }
                StartStopButton.Text = "停止投屏";
                isRunning = true;
                InitializeImageTimer();
            }
        }


        /// <summary>
        /// 加载定时播放，设置间隔区间
        /// </summary>
        private void InitializeImageTimer()
        {
            //获取最小数组循环
            int[] arr = { dicSrping.Count(), dicSummer.Count(), dicAutumn.Count(), dicWinter.Count() };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    //从小到达排序
                    if (arr[i] < arr[j])
                    {
                        int number = arr[i];
                        arr[i] = arr[j];
                        arr[j] = number;
                    }
                }
            }
            lookUpcount = arr[0];//获取多个图片组的最小数，循环播放
            int timerInterval = Convert.ToInt32(numericUpDown1.Value <= 0 ? 1 : numericUpDown1.Value);

            // 设置定时器，以便每隔一定时间切换图片
            timer1.Interval = timerInterval * 1000; // 秒
            timer1.Tick += new EventHandler(ImageTimer_Tick);
            timer1.Start();
        }

        /// <summary>
        /// 设置定时播放图片，并配置是否根据周期结束播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImageTimer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = Convert.ToDateTime(validKey);
            TimeSpan ts = dateTime.Subtract(DateTime.Now);
            if (ts.Days <= 0 && ts.Hours <= 0 && ts.Minutes <= 0 && ts.Seconds <= 0)
            {
                StopScreenSharing();
                return;
            }
            // 切换到下一张图片 
            currentImageIndex = (currentImageIndex + 1) % (lookUpcount + 1);
            if (currentImageIndex > lookUpcount || currentImageIndex <= 0)
            {
                currentImageIndex = 1;
            }
            // imageToDisplay = images[currentImageIndex];
            pictureBoxSpring.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                pictureBoxSpring.Image = Image.FromFile(dicSrping["春" + currentImageIndex.ToString().PadLeft(2, '0')]);
            }
            catch (Exception)
            {
            }

            pictureBoxSummer.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                pictureBoxSummer.Image = Image.FromFile(dicSummer["夏" + currentImageIndex.ToString().PadLeft(2, '0')]);
            }
            catch (Exception)
            {
            }
            pictureBoxAutumn.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                pictureBoxAutumn.Image = Image.FromFile(dicAutumn["秋" + currentImageIndex.ToString().PadLeft(2, '0')]);
            }
            catch (Exception)
            {
            }
            pictureBoxWinter.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                pictureBoxWinter.Image = Image.FromFile(dicWinter["冬" + currentImageIndex.ToString().PadLeft(2, '0')]);
            }
            catch (Exception)
            {
            }

        }
        /// <summary>
        /// 停止循环，并退出投屏
        /// </summary>
        private void StopScreenSharing()
        {
            isRunning = false;
            StartStopButton.Text = "开始循环";
            // 关闭所有投屏窗口
            foreach (Form form in Application.OpenForms)
            {
                form.Close();
            }
        }

        /// <summary>
        /// 设置选择内容，只能单选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void screenCKListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < screenCKListBox.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    screenCKListBox.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }
    }
}
