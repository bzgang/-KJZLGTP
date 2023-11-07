using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WebBrowserUtils;

namespace KJZP_GHZY
{
    public partial class photosynthesis : Form
    {

        CryptKeyHelper cryptHelper = new CryptKeyHelper();
        private bool isRunning = false;//投屏状态 
        string keyString = ConfigurationManager.AppSettings["keyString"];
        public photosynthesis()
        {
            WebBrowserUtil.SetWebBrowserFeatures(11);
            InitializeComponent();
            try
            {
                //string webBrowserUrl = ConfigurationManager.ConnectionStrings["webBrowserUrl"].ConnectionString; //txtUrl.Text;// "";
                //webBrowser1.Navigate(webBrowserUrl + "?winfrom=true");

            }
            catch (Exception)
            {

                MessageBox.Show("请检查播放动画地址配置.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadScreenList();
            textBoxKey.Text = keyString;
            //StartScreenSharing();
        }

        public void LoadScreenList()
        {
            screenCKListBox.Items.Clear();
            Screen[] screens = Screen.AllScreens;
            foreach (Screen screen in screens)
            {
                // 在界面中列出可用的屏幕，让用户选择
                screenCKListBox.Items.Add(screen.DeviceName);
            }
        }
        // 将图片显示在指定屏幕上
        Form screenForm = new Form();
        private string StartScreenSharing()
        {
            // 获取选择的屏幕
            //Screen[] selectedScreens = Screen.AllScreens;
            Screen[] selectedScreens = GetSelectedScreens();
            if (selectedScreens.Count() <= 0)
            {
                MessageBox.Show("请选择投屏屏幕", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
            foreach (Screen screen in selectedScreens)
            {

                screenForm.FormBorderStyle = FormBorderStyle.None;
                screenForm.WindowState = FormWindowState.Maximized;
                screenForm.StartPosition = FormStartPosition.Manual;
                screenForm.Opacity = 1;
                screenForm.KeyPreview = true;
                screenForm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(ScreenForm_KeyPress);
                screenForm.Bounds = screen.Bounds;
                screenForm.Controls.Add(webBrowser1);
                screenForm.Show();
            }
            return "success";
        }

        private void ScreenForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isRunning)
            {
                if (e.KeyChar == (char)Keys.Escape)//按下ESC //27
                {
                    MessageBox.Show("投屏即将结束！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button1.Text = "开始播放";
                    isRunning = !isRunning;
                    screenForm.Hide();
                    return;

                }
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
                SaveKey();
            }
            catch (Exception ex)
            {
                this.lblDecryptVal.Text = "输入为无效密钥.";
            }
        }
        public void SaveKey()
        {
            // 读取 App.config 文件
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // 获取 AppSettings 节点
            var appSettings = config.AppSettings;

            // 修改配置
            appSettings.Settings["keyString"].Value = textBoxKey.Text;

            // 保存配置
            config.Save(ConfigurationSaveMode.Modified);
        }
        private string validKey = "";//严重key的有效期
        private void button1_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                button1.Text = "开始播放";
                StopScreenSharing();
                return;
            }
            else
            {

                validKey = CheckValidKey();
                if (string.IsNullOrEmpty(validKey)) { return; }
                string webBrowserUrl = ConfigurationManager.ConnectionStrings["webBrowserUrl"].ConnectionString; //txtUrl.Text;// "";

                if (string.IsNullOrEmpty(webBrowserUrl))
                {
                    MessageBox.Show("请检查播放动画地址配置.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    webBrowser1.Navigate(webBrowserUrl + "?winfrom=true");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("播放动画地址错误,请检查.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(StartScreenSharing())) { return; };
                InitializeImageTimer();
                button1.Text = "停止播放";
                isRunning = true;
                //this.Hide();//隐藏窗体
            }

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
                SaveKey();
                return decryptKey;
            }
            catch (Exception ex)
            {

                MessageBox.Show("输入的密钥无效.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
        }
        private void InitializeImageTimer()
        {
            // 设置定时器，检查key是否有效
            timer1.Interval = 60 * 60 * 1000; // 单位毫秒   每小时刷新一次
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
        }
        /// <summary>
        /// 停止循环，并退出投屏
        /// </summary>
        private void StopScreenSharing()
        {
            // 关闭所有投屏窗口
            foreach (Form form in Application.OpenForms)
            {
                webBrowser1.Dispose();
                form.Close();
            }
        }

        /// <summary>
        /// 最小化到托盘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void photosynthesis_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = true;//显示托盘图标
                this.Hide();//隐藏窗体
                this.ShowInTaskbar = false;
            }
        }

        /// <summary>
        /// 点击托盘图标,恢复窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.ShowInTaskbar == false)//该值决定一个 Form 对象是否出现在 Windows 任务栏中
                notifyIcon1.Visible = true;
            this.ShowInTaskbar = true;
            this.Show();
            this.Activate();
            this.WindowState = FormWindowState.Normal;
        }

        private void getScreen_Click(object sender, EventArgs e)
        {
            LoadScreenList();
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

        private void photosynthesis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isRunning)
            {
                if (e.KeyChar == (char)Keys.Escape)//按下ESC //27
                {
                    button1.Text = "开始播放";
                    StopScreenSharing();
                    return;
                }
            }
        }
    }
}
