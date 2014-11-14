using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FileNet.Api.Exception;


using FileNetForMDMVerify.Library;

namespace FileNetForMDMVerify.FileNetForm
{
    public partial class MainForm : Form
    {

        private CEConnection ce;

        public MainForm()
        {
            InitializeComponent();
            EnableButtons(false);
            ce = new CEConnection();
        }

        /// <summary>
        /// 连接CE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnection_Click(object sender, EventArgs e)
        {
            string user = txtCEName.Text.Trim();
            string pass = txtCEPwd.Text.Trim();
            string uri = txtCEURL.Text.Trim();
            try
            {
                if (CheckRequiredFields())
                {
                    ce.EstablishCredentials(user, pass, uri);
                    lblMsg.Text = "CE连接成功";
                    btnConnection.Enabled = false;
                    EnableButtons(true);
                }
            }
            catch (EngineRuntimeException ere)
            {
                lblMsg.Text = ere.Message;
                System.Console.WriteLine(ere.StackTrace);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            base.Dispose();
        }


        /// <summary>
        /// 验证文本框参数
        /// </summary>
        /// <returns></returns>
        private bool CheckRequiredFields()
        {
            bool check = true;
            if (txtCEURL.Text.Equals(""))
            {
                txtCEURL.Text = "请输入CE URL";
                check = false;
            }
            if (txtCEName.Text.Equals(""))
            {
                txtCEName.Text = "请输入CE 用户名";
                check = false;
            }
            if (txtCEPwd.Text.Equals(""))
            {
                txtCEPwd.Text = "请输入CE 密码";
                check = false;
            }
            return check;
        }

        /// <summary>
        /// 启用功能区按钮
        /// </summary>
        private void EnableButtons(bool isEnabled)
        {
            if (isEnabled)
            {
                btnCreateFolder.Enabled = true;
                btnCreateDoc.Enabled = true;
                btnGetDoc.Enabled = true;
                btnQuery.Enabled = true;
            }
            else
            {
                btnCreateFolder.Enabled = false;
                btnCreateDoc.Enabled = false;
                btnGetDoc.Enabled = false;
                btnQuery.Enabled = false;
            }
        }

        /// <summary>
        /// 新建文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateFolder_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 新建文档
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateDoc_Click(object sender, EventArgs e)
        {
            CreateDocForm form = new CreateDocForm(ce);
            form.Show();
        }

        /// <summary>
        /// 获取文档
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetDoc_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            AdhocQueryForm form = new AdhocQueryForm(ce);
            form.Show();
        }     
    }
}
