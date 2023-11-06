
namespace KJGZP_SetKey
{
    partial class SetKeyFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetKeyFrom));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDecryptVal = new System.Windows.Forms.Label();
            this.btnDecryptKey = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.numberValidityVal = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbUnit = new System.Windows.Forms.ComboBox();
            this.btnSetKey = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberValidityVal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDecryptVal);
            this.groupBox1.Controls.Add(this.btnDecryptKey);
            this.groupBox1.Controls.Add(this.textBoxKey);
            this.groupBox1.Controls.Add(this.numberValidityVal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbUnit);
            this.groupBox1.Controls.Add(this.btnSetKey);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(472, 284);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "有限期设置";
            // 
            // lblDecryptVal
            // 
            this.lblDecryptVal.AutoSize = true;
            this.lblDecryptVal.ForeColor = System.Drawing.Color.Red;
            this.lblDecryptVal.Location = new System.Drawing.Point(131, 220);
            this.lblDecryptVal.Name = "lblDecryptVal";
            this.lblDecryptVal.Size = new System.Drawing.Size(18, 17);
            this.lblDecryptVal.TabIndex = 8;
            this.lblDecryptVal.Text = "--";
            // 
            // btnDecryptKey
            // 
            this.btnDecryptKey.Location = new System.Drawing.Point(22, 176);
            this.btnDecryptKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecryptKey.Name = "btnDecryptKey";
            this.btnDecryptKey.Size = new System.Drawing.Size(139, 27);
            this.btnDecryptKey.TabIndex = 7;
            this.btnDecryptKey.Text = "检查Key有效期";
            this.btnDecryptKey.UseVisualStyleBackColor = true;
            this.btnDecryptKey.Click += new System.EventHandler(this.btnDecryptKey_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(126, 112);
            this.textBoxKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(249, 48);
            this.textBoxKey.TabIndex = 6;
            // 
            // numberValidityVal
            // 
            this.numberValidityVal.Location = new System.Drawing.Point(126, 75);
            this.numberValidityVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberValidityVal.Name = "numberValidityVal";
            this.numberValidityVal.Size = new System.Drawing.Size(125, 22);
            this.numberValidityVal.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "密钥到期时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "有效期密钥：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "有效期时效：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "有效期单位：";
            // 
            // cbbUnit
            // 
            this.cbbUnit.FormattingEnabled = true;
            this.cbbUnit.Items.AddRange(new object[] {
            "分",
            "时",
            "日",
            "月",
            "年",
            "永久"});
            this.cbbUnit.Location = new System.Drawing.Point(126, 33);
            this.cbbUnit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cbbUnit.Name = "cbbUnit";
            this.cbbUnit.Size = new System.Drawing.Size(126, 24);
            this.cbbUnit.TabIndex = 1;
            this.cbbUnit.Text = "日";
            // 
            // btnSetKey
            // 
            this.btnSetKey.Location = new System.Drawing.Point(279, 71);
            this.btnSetKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetKey.Name = "btnSetKey";
            this.btnSetKey.Size = new System.Drawing.Size(96, 27);
            this.btnSetKey.TabIndex = 0;
            this.btnSetKey.Text = "生成密钥";
            this.btnSetKey.UseVisualStyleBackColor = true;
            this.btnSetKey.Click += new System.EventHandler(this.btnSetKey_Click);
            // 
            // SetKeyFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 327);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SetKeyFrom";
            this.Text = "生成密钥";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberValidityVal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDecryptVal;
        private System.Windows.Forms.Button btnDecryptKey;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.NumericUpDown numberValidityVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbUnit;
        private System.Windows.Forms.Button btnSetKey;
        private System.Windows.Forms.Label label1;
    }
}

