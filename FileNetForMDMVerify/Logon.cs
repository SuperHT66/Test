using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using FileNetForMDMVerify.FileNetForm;

namespace FileNetForMDMVerify
{
    public partial class Logon : Form
    {
        //单列,不允许生成多个Form
        MainForm form = null;

        public Logon()
        {
            InitializeComponent();
        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
            
            if (CheckRequiredFields())
            {
                if (form == null)
                {
                    form = new MainForm();
                    form.Show();
                    lblMsg.Text = "";
                }          
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.Dispose();
        }

        /// <summary>
        /// 验证用户名和密码
        /// </summary>
        /// <returns></returns>
        private bool CheckRequiredFields()
        {
            bool check = true;
            if (txtName.Text.Equals(""))
            {
                lblMsg.Text = "请输入用户名密码";
                check = false;
            }
            if (txtPwd.Text.Equals(""))
            {
                lblMsg.Text = "请输入用户名密码";
                check = false;
            }
            if (txtName.Text!=string.Empty&&txtName.Text!="haotao")
            {
                lblMsg.Text = "用户名密码错误";
                check = false;
            }
            if (txtPwd.Text != string.Empty && txtPwd.Text != "123456")
            {
                lblMsg.Text = "用户名密码错误";
                check = false;
            }
            return check;
        }
    }
}
