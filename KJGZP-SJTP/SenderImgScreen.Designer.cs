
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(188, 523);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
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
            this.label1.Location = new System.Drawing.Point(38, 525);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "设置循环时间（秒）";
            // 
            // screenCKListBox
            // 
            this.screenCKListBox.CheckOnClick = true;
            this.screenCKListBox.FormattingEnabled = true;
            this.screenCKListBox.Location = new System.Drawing.Point(41, 199);
            this.screenCKListBox.Margin = new System.Windows.Forms.Padding(4);
            this.screenCKListBox.Name = "screenCKListBox";
            this.screenCKListBox.Size = new System.Drawing.Size(404, 157);
            this.screenCKListBox.TabIndex = 9;
            this.screenCKListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.screenCKListBox_ItemCheck);
            // 
            // getScreen
            // 
            this.getScreen.Location = new System.Drawing.Point(345, 163);
            this.getScreen.Margin = new System.Windows.Forms.Padding(4);
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
            this.StartStopButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(100, 28);
            this.StartStopButton.TabIndex = 7;
            this.StartStopButton.Text = "开始循环";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // btnScreenSpring
            // 
            this.btnScreenSpring.Location = new System.Drawing.Point(52, 383);
            this.btnScreenSpring.Margin = new System.Windows.Forms.Padding(4);
            this.btnScreenSpring.Name = "btnScreenSpring";
            this.btnScreenSpring.Size = new System.Drawing.Size(100, 28);
            this.btnScreenSpring.TabIndex = 7;
            this.btnScreenSpring.Text = "投屏春天";
            this.btnScreenSpring.UseVisualStyleBackColor = true;
            this.btnScreenSpring.Click += new System.EventHandler(this.btnScreenSpring_Click);
            // 
            // btnScreenSummer
            // 
            this.btnScreenSummer.Location = new System.Drawing.Point(188, 383);
            this.btnScreenSummer.Margin = new System.Windows.Forms.Padding(4);
            this.btnScreenSummer.Name = "btnScreenSummer";
            this.btnScreenSummer.Size = new System.Drawing.Size(100, 28);
            this.btnScreenSummer.TabIndex = 7;
            this.btnScreenSummer.Text = "投屏夏天";
            this.btnScreenSummer.UseVisualStyleBackColor = true;
            this.btnScreenSummer.Click += new System.EventHandler(this.btnScreenSummer_Click);
            // 
            // btnScreenAutumn
            // 
            this.btnScreenAutumn.Location = new System.Drawing.Point(52, 454);
            this.btnScreenAutumn.Margin = new System.Windows.Forms.Padding(4);
            this.btnScreenAutumn.Name = "btnScreenAutumn";
            this.btnScreenAutumn.Size = new System.Drawing.Size(100, 28);
            this.btnScreenAutumn.TabIndex = 7;
            this.btnScreenAutumn.Text = "投屏秋天";
            this.btnScreenAutumn.UseVisualStyleBackColor = true;
            this.btnScreenAutumn.Click += new System.EventHandler(this.btnScreenAutumn_Click);
            // 
            // btnScreenWinter
            // 
            this.btnScreenWinter.Location = new System.Drawing.Point(188, 454);
            this.btnScreenWinter.Margin = new System.Windows.Forms.Padding(4);
            this.btnScreenWinter.Name = "btnScreenWinter";
            this.btnScreenWinter.Size = new System.Drawing.Size(100, 28);
            this.btnScreenWinter.TabIndex = 7;
            this.btnScreenWinter.Text = "投屏冬天";
            this.btnScreenWinter.UseVisualStyleBackColor = true;
            this.btnScreenWinter.Click += new System.EventHandler(this.btnScreenWinter_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(150, 25);
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
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "有效密钥：";
            // 
            // lblDecryptVal
            // 
            this.lblDecryptVal.AutoSize = true;
            this.lblDecryptVal.ForeColor = System.Drawing.Color.Red;
            this.lblDecryptVal.Location = new System.Drawing.Point(159, 133);
            this.lblDecryptVal.Name = "lblDecryptVal";
            this.lblDecryptVal.Size = new System.Drawing.Size(18, 17);
            this.lblDecryptVal.TabIndex = 15;
            this.lblDecryptVal.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "密钥到期时间：";
            // 
            // btnDecryptKey
            // 
            this.btnDecryptKey.Location = new System.Drawing.Point(41, 88);
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
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "投屏屏幕：";
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 623);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartScreen";
            this.Text = "四季图片投屏";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
    }
}

