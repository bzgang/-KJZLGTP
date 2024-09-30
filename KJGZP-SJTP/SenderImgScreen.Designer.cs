
namespace KJGZP_SJTP
{
    partial class StartScreen
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.screenCKListBox = new System.Windows.Forms.CheckedListBox();
            this.getScreen = new System.Windows.Forms.Button();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.btnScreenSpring = new System.Windows.Forms.Button();
            this.btnScreenSummer = new System.Windows.Forms.Button();
            this.btnScreenAutumn = new System.Windows.Forms.Button();
            this.btnScreenWinter = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDecryptVal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDecryptKey = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxShowSpring = new System.Windows.Forms.PictureBox();
            this.pictureBoxShowSummer = new System.Windows.Forms.PictureBox();
            this.pictureBoxShowAutumn = new System.Windows.Forms.PictureBox();
            this.pictureBoxShowWinter = new System.Windows.Forms.PictureBox();
            this.lblSpring = new System.Windows.Forms.Label();
            this.lblSummer = new System.Windows.Forms.Label();
            this.lblAutumn = new System.Windows.Forms.Label();
            this.lblWinter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowSpring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowSummer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowAutumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowWinter)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(188, 523);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(132, 22);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 526);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "设置循环时间（秒）";
            // 
            // screenCKListBox
            // 
            this.screenCKListBox.CheckOnClick = true;
            this.screenCKListBox.FormattingEnabled = true;
            this.screenCKListBox.Location = new System.Drawing.Point(41, 199);
            this.screenCKListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.screenCKListBox.Name = "screenCKListBox";
            this.screenCKListBox.Size = new System.Drawing.Size(404, 140);
            this.screenCKListBox.TabIndex = 9;
            this.screenCKListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.screenCKListBox_ItemCheck);
            // 
            // getScreen
            // 
            this.getScreen.Location = new System.Drawing.Point(345, 162);
            this.getScreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getScreen.Name = "getScreen";
            this.getScreen.Size = new System.Drawing.Size(100, 28);
            this.getScreen.TabIndex = 8;
            this.getScreen.Text = "获取投屏";
            this.getScreen.UseVisualStyleBackColor = true;
            this.getScreen.Click += new System.EventHandler(this.getScreen_Click);
            // 
            // StartStopButton
            // 
            this.StartStopButton.Location = new System.Drawing.Point(345, 519);
            this.StartStopButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(100, 28);
            this.StartStopButton.TabIndex = 7;
            this.StartStopButton.Text = "开始循环";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // btnScreenSpring
            // 
            this.btnScreenSpring.Location = new System.Drawing.Point(41, 383);
            this.btnScreenSpring.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnScreenSpring.Name = "btnScreenSpring";
            this.btnScreenSpring.Size = new System.Drawing.Size(100, 28);
            this.btnScreenSpring.TabIndex = 7;
            this.btnScreenSpring.Text = "投屏春天";
            this.btnScreenSpring.UseVisualStyleBackColor = true;
            this.btnScreenSpring.Click += new System.EventHandler(this.btnScreenSpring_Click);
            // 
            // btnScreenSummer
            // 
            this.btnScreenSummer.Location = new System.Drawing.Point(285, 383);
            this.btnScreenSummer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnScreenSummer.Name = "btnScreenSummer";
            this.btnScreenSummer.Size = new System.Drawing.Size(100, 28);
            this.btnScreenSummer.TabIndex = 7;
            this.btnScreenSummer.Text = "投屏夏天";
            this.btnScreenSummer.UseVisualStyleBackColor = true;
            this.btnScreenSummer.Click += new System.EventHandler(this.btnScreenSummer_Click);
            // 
            // btnScreenAutumn
            // 
            this.btnScreenAutumn.Location = new System.Drawing.Point(41, 454);
            this.btnScreenAutumn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnScreenAutumn.Name = "btnScreenAutumn";
            this.btnScreenAutumn.Size = new System.Drawing.Size(100, 28);
            this.btnScreenAutumn.TabIndex = 7;
            this.btnScreenAutumn.Text = "投屏秋天";
            this.btnScreenAutumn.UseVisualStyleBackColor = true;
            this.btnScreenAutumn.Click += new System.EventHandler(this.btnScreenAutumn_Click);
            // 
            // btnScreenWinter
            // 
            this.btnScreenWinter.Location = new System.Drawing.Point(285, 454);
            this.btnScreenWinter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnScreenWinter.Name = "btnScreenWinter";
            this.btnScreenWinter.Size = new System.Drawing.Size(100, 28);
            this.btnScreenWinter.TabIndex = 7;
            this.btnScreenWinter.Text = "投屏冬天";
            this.btnScreenWinter.UseVisualStyleBackColor = true;
            this.btnScreenWinter.Click += new System.EventHandler(this.btnScreenWinter_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(149, 25);
            this.textBoxKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(295, 48);
            this.textBoxKey.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "有效密钥：";
            // 
            // lblDecryptVal
            // 
            this.lblDecryptVal.AutoSize = true;
            this.lblDecryptVal.ForeColor = System.Drawing.Color.Red;
            this.lblDecryptVal.Location = new System.Drawing.Point(159, 133);
            this.lblDecryptVal.Name = "lblDecryptVal";
            this.lblDecryptVal.Size = new System.Drawing.Size(15, 16);
            this.lblDecryptVal.TabIndex = 15;
            this.lblDecryptVal.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "密钥到期时间：";
            // 
            // btnDecryptKey
            // 
            this.btnDecryptKey.Location = new System.Drawing.Point(41, 89);
            this.btnDecryptKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecryptKey.Name = "btnDecryptKey";
            this.btnDecryptKey.Size = new System.Drawing.Size(139, 27);
            this.btnDecryptKey.TabIndex = 16;
            this.btnDecryptKey.Text = "检查Key有效期";
            this.btnDecryptKey.UseVisualStyleBackColor = true;
            this.btnDecryptKey.Click += new System.EventHandler(this.btnDecryptKey_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "投屏屏幕：";
            // 
            // pictureBoxShowSpring
            // 
            this.pictureBoxShowSpring.Location = new System.Drawing.Point(162, 363);
            this.pictureBoxShowSpring.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxShowSpring.Name = "pictureBoxShowSpring";
            this.pictureBoxShowSpring.Size = new System.Drawing.Size(108, 66);
            this.pictureBoxShowSpring.TabIndex = 18;
            this.pictureBoxShowSpring.TabStop = false;
            // 
            // pictureBoxShowSummer
            // 
            this.pictureBoxShowSummer.Location = new System.Drawing.Point(402, 363);
            this.pictureBoxShowSummer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxShowSummer.Name = "pictureBoxShowSummer";
            this.pictureBoxShowSummer.Size = new System.Drawing.Size(108, 66);
            this.pictureBoxShowSummer.TabIndex = 18;
            this.pictureBoxShowSummer.TabStop = false;
            // 
            // pictureBoxShowAutumn
            // 
            this.pictureBoxShowAutumn.Location = new System.Drawing.Point(162, 434);
            this.pictureBoxShowAutumn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxShowAutumn.Name = "pictureBoxShowAutumn";
            this.pictureBoxShowAutumn.Size = new System.Drawing.Size(108, 66);
            this.pictureBoxShowAutumn.TabIndex = 18;
            this.pictureBoxShowAutumn.TabStop = false;
            // 
            // pictureBoxShowWinter
            // 
            this.pictureBoxShowWinter.Location = new System.Drawing.Point(402, 434);
            this.pictureBoxShowWinter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxShowWinter.Name = "pictureBoxShowWinter";
            this.pictureBoxShowWinter.Size = new System.Drawing.Size(108, 66);
            this.pictureBoxShowWinter.TabIndex = 18;
            this.pictureBoxShowWinter.TabStop = false;
            // 
            // lblSpring
            // 
            this.lblSpring.AutoSize = true;
            this.lblSpring.Location = new System.Drawing.Point(40, 414);
            this.lblSpring.Name = "lblSpring";
            this.lblSpring.Size = new System.Drawing.Size(15, 16);
            this.lblSpring.TabIndex = 19;
            this.lblSpring.Text = "--";
            // 
            // lblSummer
            // 
            this.lblSummer.AutoSize = true;
            this.lblSummer.Location = new System.Drawing.Point(284, 413);
            this.lblSummer.Name = "lblSummer";
            this.lblSummer.Size = new System.Drawing.Size(15, 16);
            this.lblSummer.TabIndex = 20;
            this.lblSummer.Text = "--";
            // 
            // lblAutumn
            // 
            this.lblAutumn.AutoSize = true;
            this.lblAutumn.Location = new System.Drawing.Point(42, 485);
            this.lblAutumn.Name = "lblAutumn";
            this.lblAutumn.Size = new System.Drawing.Size(15, 16);
            this.lblAutumn.TabIndex = 19;
            this.lblAutumn.Text = "--";
            // 
            // lblWinter
            // 
            this.lblWinter.AutoSize = true;
            this.lblWinter.Location = new System.Drawing.Point(286, 485);
            this.lblWinter.Name = "lblWinter";
            this.lblWinter.Size = new System.Drawing.Size(15, 16);
            this.lblWinter.TabIndex = 20;
            this.lblWinter.Text = "--";
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 623);
            this.Controls.Add(this.lblWinter);
            this.Controls.Add(this.lblSummer);
            this.Controls.Add(this.lblAutumn);
            this.Controls.Add(this.lblSpring);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDecryptKey);
            this.Controls.Add(this.lblDecryptVal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.screenCKListBox);
            this.Controls.Add(this.getScreen);
            this.Controls.Add(this.btnScreenWinter);
            this.Controls.Add(this.btnScreenAutumn);
            this.Controls.Add(this.btnScreenSummer);
            this.Controls.Add(this.btnScreenSpring);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.pictureBoxShowWinter);
            this.Controls.Add(this.pictureBoxShowAutumn);
            this.Controls.Add(this.pictureBoxShowSummer);
            this.Controls.Add(this.pictureBoxShowSpring);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "StartScreen";
            this.Text = "四季图片投屏";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowSpring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowSummer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowAutumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowWinter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox screenCKListBox;
        private System.Windows.Forms.Button getScreen;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.Button btnScreenSpring;
        private System.Windows.Forms.Button btnScreenSummer;
        private System.Windows.Forms.Button btnScreenAutumn;
        private System.Windows.Forms.Button btnScreenWinter;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDecryptVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDecryptKey;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxShowSpring;
        private System.Windows.Forms.PictureBox pictureBoxShowSummer;
        private System.Windows.Forms.PictureBox pictureBoxShowAutumn;
        private System.Windows.Forms.PictureBox pictureBoxShowWinter;
        private System.Windows.Forms.Label lblSpring;
        private System.Windows.Forms.Label lblSummer;
        private System.Windows.Forms.Label lblAutumn;
        private System.Windows.Forms.Label lblWinter;
    }
}

