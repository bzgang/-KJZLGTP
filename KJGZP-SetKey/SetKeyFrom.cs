using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KJGZP_SetKey
{
    public partial class SetKeyFrom : Form
    {
        public SetKeyFrom()
        {
            InitializeComponent();
        }

        CryptKeyHelper cryptHelper = new CryptKeyHelper();
        private void btnSetKey_Click(object sender, EventArgs e)
        {
            string dataUnit = cbbUnit.SelectedItem.ToString();
            int validityVal = Convert.ToInt32(numberValidityVal.Value);
            DateTime currentDate = DateTime.Now;
            if (string.IsNullOrEmpty(dataUnit))
            {
                MessageBox.Show("请选择有效期单位.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (validityVal <= 0)
            {
                MessageBox.Show("有效期时效为" + validityVal + ",有效期限过短,请确认.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (dataUnit == "日")
            {
                currentDate = currentDate.AddDays(validityVal);
            }
            else if (dataUnit == "月")
            {
                currentDate = currentDate.AddMonths(validityVal);
            }
            else if (dataUnit == "年")
            {
                currentDate = currentDate.AddYears(validityVal);
            }
            else if (dataUnit == "永久")
            {
                currentDate = DateTime.MaxValue;
            }
            else if (dataUnit == "分")
            {
                currentDate = currentDate.AddMinutes(validityVal);
            }
            else if (dataUnit == "时")
            {
                currentDate = currentDate.AddHours(validityVal);
            }
            string dtime = currentDate.ToString("yyyy-MM-dd HH:mm:ss");
            string encryptKey = cryptHelper.Encrypt(dtime, "bzg");

            this.textBoxKey.Text = encryptKey;
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
    }
}
