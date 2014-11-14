using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using FileNet.Api.Core;
using FileNet.Api.Constants;
using FileNet.Api.Exception;

using FileNetForMDMVerify.Library;


namespace FileNetForMDMVerify.FileNetForm
{
    public partial class CreateDocForm : Form
    {
        private CEConnection ce;

        private ArrayList dirs;//批量上传时存储所选择文件夹下的文件名

        public CreateDocForm(CEConnection c)
        {
            InitializeComponent();
            ce = c;
        }

        private void CreateDocForm_Load(object sender, EventArgs e)
        {
            EnabledInit();
            BindObjectStores();
            statusLabel.Text = "请选择上传文件模式";
        }

        /// <summary>
        /// 绑定ObjectStores
        /// </summary>
        private void BindObjectStores()
        {
            ArrayList osNames = ce.GetOSNames();
            cboxOS.Items.Clear();
            for (int i = 0; i < osNames.Count; i++)
            {
                cboxOS.Items.Add(osNames[i]);
            }
        }

        /// <summary>
        /// 验证输入参数
        /// </summary>
        /// <returns></returns>
        private bool CheckRequiredFields()
        {
            bool check = true;
            if (!rdoSingle.Checked && !rdoBatch.Checked)
            {
                statusLabel.Text = "请选择上传文件模式";
                check = false;
            }
            if (cboxOS.SelectedItem == null)
            {
                statusLabel.Text = "请选择FileNet存储库";
                check = false;
            }
            else
            {
                if (txtTitle.Text.Equals(""))
                {
                    txtTitle.Text = "请输入文档标题";
                    check = false;
                }
                if (cbContent.Checked)
                {
                    if (txtContentSingle.Text.Trim().Equals("") && txtContentBatch.Text.Trim().Equals(""))
                    {
                        lblFileMsg.Text = "请选择需要上传的文件";
                        check = false;
                    }
                }
            }
            if (txtFilePath.Text.Trim().Equals(""))
            {
                statusLabel.Text = "请输入上传文档路径";
                check = false;
            }
            return check;
        }

        #region radio选择状态
        private void rdoSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSingle.Checked)
            {
                txtContentSingle.Enabled = true;
                btnOpenSingle.Enabled = true;
                txtContentBatch.Enabled = false;
                btnOpenBatch.Enabled = false;
                linkLabel1.Enabled = false;
            }
            else if (rdoBatch.Checked)
            {
                txtContentBatch.Enabled = true;
                btnOpenBatch.Enabled = true;
                linkLabel1.Enabled = true;
                txtContentSingle.Enabled = false;
                btnOpenSingle.Enabled = false;
            }
        }

        /// <summary>
        /// 初试化单条和批量上传状态
        /// </summary>
        private void EnabledInit()
        {
            txtContentSingle.Enabled = false;
            btnOpenSingle.Enabled = false;
            txtContentBatch.Enabled = false;
            btnOpenBatch.Enabled = false;
            linkLabel1.Enabled = false;
        }

        private void rdoBatch_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSingle.Checked)
            {
                txtContentSingle.Enabled = true;
                btnOpenSingle.Enabled = true;
                txtContentBatch.Enabled = false;
                btnOpenBatch.Enabled = false;
                linkLabel1.Enabled = false;
            }
            else if (rdoBatch.Checked)
            {
                txtContentBatch.Enabled = true;
                btnOpenBatch.Enabled = true;
                linkLabel1.Enabled = true;
                txtContentSingle.Enabled = false;
                btnOpenSingle.Enabled = false;
            }
        }
        #endregion


        /// <summary>
        /// 单条选择文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenSingle_Click(object sender, EventArgs e)
        {
            ofdSingle.ShowDialog();
            txtContentSingle.Text = ofdSingle.FileName;   
        }

        /// <summary>
        /// 批量选择文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenBatch_Click(object sender, EventArgs e)
        {
            fbdBatch.ShowDialog();
            txtContentBatch.Text = fbdBatch.SelectedPath;
            dirs = new ArrayList();
            dirs = GetFileName(txtContentBatch.Text);
        }

        /// <summary>
        /// 查看所选择的文件(批量上传时使用)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectedFileForm form = new SelectedFileForm(dirs);
            form.Show();
        }

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string file = string.Empty;
            ArrayList list = null;
            if (rdoSingle.Checked)
                file = txtContentSingle.Text;
            if (rdoBatch.Checked)
                list = dirs;
            string mime = txtMimeType.Text;
            string title = txtTitle.Text;

            string className = txtDocClass.Text;
            try
            {
                if (CheckRequiredFields())
                {
                    if (rdoSingle.Checked)
                    {
                        DateTime singletime1 = DateTime.Now;
                        IDocument doc = null;
                        IObjectStore os = ce.FetchOS((String)cboxOS.SelectedItem);
                        
                        if (cbContent.Checked)
                            doc = CEUtil.CreateDocument(true, file, mime, title, os, className);
                        else
                            doc = CEUtil.CreateDocument(false, null, mime, title, os, className);
                        doc.Save(RefreshMode.REFRESH);
                        if (cbFileInFolder.Checked)
                        {
                            string folder = txtFilePath.Text;
                            if (folder.Length == 0)
                                folder = "/";
                            IReferentialContainmentRelationship rcr = CEUtil.FileContainable(os, doc, folder);
                            rcr.Save(RefreshMode.REFRESH);
                        }
                        if (cbCheckIn.Checked)
                            CEUtil.checkInDoc(doc);
                        statusLabel.Text = "文档" + title + "创建成功";
                        DateTime singletime2 = DateTime.Now;
                        txtTimeAll.Text = DateDiff(singletime1,singletime2);
                    }
                    if (rdoBatch.Checked)
                    {
                        
                        DateTime batchtime1 = DateTime.Now;
                        #region 方式一
                        //for (int i = 0; i < list.Count; i++)
                        //{
                        //    string tname = title + i.ToString();
                            
                        //    file = list[i].ToString();
                        //    IDocument doc = null;
                        //    IObjectStore os = ce.FetchOS((String)cboxOS.SelectedItem);
                        //    if (cbContent.Checked)
                        //        doc = CEUtil.CreateDocument(true, file, mime, tname, os, className);
                        //    else
                        //        doc = CEUtil.CreateDocument(false, null, mime, tname, os, className);
                        //    doc.Save(RefreshMode.REFRESH);
                        //    if (cbFileInFolder.Checked)
                        //    {
                        //        string folder = txtFilePath.Text;
                        //        if (folder.Length == 0)
                        //            folder = "/";
                        //        IReferentialContainmentRelationship rcr = CEUtil.FileContainable(os, doc, folder);
                        //        rcr.Save(RefreshMode.REFRESH);
                        //    }
                        //    if (cbCheckIn.Checked)
                        //        CEUtil.checkInDoc(doc);
                        //}
                        #endregion

                        #region 方式二
                        IDocument doc = null;
                        IObjectStore os = null;
                        IReferentialContainmentRelationship rcr = null;
                        for (int i = 0; i < list.Count; i++)
                        {
                            string tname = title + i.ToString();

                            file = list[i].ToString();
                            os = ce.FetchOS((String)cboxOS.SelectedItem);
                            if (cbContent.Checked)
                                doc = CEUtil.CreateDocument(true, file, mime, tname, os, className);
                            else
                                doc = CEUtil.CreateDocument(false, null, mime, tname, os, className);
                            doc.Save(RefreshMode.REFRESH);
                            if (cbFileInFolder.Checked)
                            {
                                string folder = txtFilePath.Text;
                                if (folder.Length == 0)
                                    folder = "/";
                                rcr = CEUtil.FileContainable(os, doc, folder);
                                rcr.Save(RefreshMode.REFRESH);
                            }
                            if (cbCheckIn.Checked)
                                CEUtil.checkInDoc(doc);
                        }
                        #endregion
                        statusLabel.Text = "文档" + title + "创建成功";
                        DateTime batchtime2 = DateTime.Now;
                        txtTimeAll.Text = DateDiff(batchtime1, batchtime2);
                    }
                }
            }
            catch (EngineRuntimeException ere)
            {
                statusLabel.Text = ere.Message;
                System.Console.WriteLine(ere.StackTrace);
            }
        }

        /// <summary>
        /// 重置界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtContentSingle.Text = "";
            txtContentBatch.Text = "";
            txtFilePath.Text = "";
            txtMimeType.Text = "text/plain";
            txtDocClass.Text = "Document";
            statusLabel.Text = "点击创建添加文档";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            base.Dispose();
        }

        //获取所有文件名
        private ArrayList GetFileName(string dirPath)
        {
            ArrayList list = new ArrayList();

            if (Directory.Exists(dirPath))
            {
                list.AddRange(Directory.GetFiles(dirPath));
            }
            return list;
        }

        /// <summary>
        /// 已重载.计算两个日期的时间间隔,返回的是时间间隔的日期差的绝对值.
        /// </summary>
        /// <param name="DateTime1">第一个日期和时间</param>
        /// <param name="DateTime2">第二个日期和时间</param>
        /// <returns></returns>
        private string DateDiff(DateTime DateTime1, DateTime DateTime2)
        {
            string dateDiff = null;
            try
            {
                TimeSpan ts1 = new TimeSpan(DateTime1.Ticks);
                TimeSpan ts2 = new TimeSpan(DateTime2.Ticks);
                TimeSpan ts = ts1.Subtract(ts2).Duration();
                dateDiff = ts.Days.ToString() + "天"
                        + ts.Hours.ToString() + "小时"
                        + ts.Minutes.ToString() + "分钟"
                        + ts.Seconds.ToString() + "秒"
                        + ts.Milliseconds.ToString() + "毫秒";
            }
            catch
            {

            }
            return dateDiff;
        }

        private void btnGetPropetties_Click(object sender, EventArgs e)
        {
            DocPropetties docProFrom = new DocPropetties(ce);
            docProFrom.Show();
        }
    }
}
