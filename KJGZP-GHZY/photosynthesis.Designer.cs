
namespace KJZP_GHZY
{
    partial class photosynthesis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(photosynthesis));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnDecryptKey = new System.Windows.Forms.Button();
            this.lblDecryptVal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.screenCKListBox = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.getScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(18, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(486, 505);
            this.webBrowser1.TabIndex = 1;
            // 
            // btnDecryptKey
            // 
            this.btnDecryptKey.Location = new System.Drawing.Point(19, 93);
            this.btnDecryptKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecryptKey.Name = "btnDecryptKey";
            this.btnDecryptKey.Size = new System.Drawing.Size(139, 27);
            this.btnDecryptKey.TabIndex = 21;
            this.btnDecryptKey.Text = "检查Key有效期";
            this.btnDecryptKey.UseVisualStyleBackColor = true;
            this.btnDecryptKey.Click += new System.EventHandler(this.btnDecryptKey_Click);
            // 
            // lblDecryptVal
            // 
            this.lblDecryptVal.AutoSize = true;
            this.lblDecryptVal.ForeColor = System.Drawing.Color.Red;
            this.lblDecryptVal.Location = new System.Drawing.Point(137, 138);
            this.lblDecryptVal.Name = "lblDecryptVal";
            this.lblDecryptVal.Size = new System.Drawing.Size(18, 17);
            this.lblDecryptVal.TabIndex = 20;
            this.lblDecryptVal.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "密钥到期时间：";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(128, 30);
            this.textBoxKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(295, 48);
            this.textBoxKey.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "有效密钥：";
            // 
            // screenCKListBox
            // 
            this.screenCKListBox.CheckOnClick = true;
            this.screenCKListBox.FormattingEnabled = true;
            this.screenCKListBox.Location = new System.Drawing.Point(24, 246);
            this.screenCKListBox.Margin = new System.Windows.Forms.Padding(4);
            this.screenCKListBox.Name = "screenCKListBox";
            this.screenCKListBox.Size = new System.Drawing.Size(399, 140);
            this.screenCKListBox.TabIndex = 22;
            this.screenCKListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.screenCKListBox_ItemCheck);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 32);
            this.button1.TabIndex = 23;
            this.button1.Text = "开始播放";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "光合作用";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "投屏屏幕：";
            // 
            // getScreen
            // 
            this.getScreen.Location = new System.Drawing.Point(313, 204);
            this.getScreen.Margin = new System.Windows.Forms.Padding(4);
            this.getScreen.Name = "getScreen";
            this.getScreen.Size = new System.Drawing.Size(100, 28);
            this.getScreen.TabIndex = 25;
            this.getScreen.Text = "获取投屏";
            this.getScreen.UseVisualStyleBackColor = true;
            this.getScreen.Click += new System.EventHandler(this.getScreen_Click);
            // 
            // photosynthesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 505);
            this.Controls.Add(this.getScreen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.screenCKListBox);
            this.Controls.Add(this.btnDecryptKey);
            this.Controls.Add(this.lblDecryptVal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "photosynthesis";
            this.Text = "光合作用";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.photosynthesis_KeyPress);
            this.Resize += new System.EventHandler(this.photosynthesis_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnDecryptKey;
        private System.Windows.Forms.Label lblDecryptVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox screenCKListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getScreen;
    }
}

