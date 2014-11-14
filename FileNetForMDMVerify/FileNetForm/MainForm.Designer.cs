namespace FileNetForMDMVerify.FileNetForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.txtCEPwd = new System.Windows.Forms.TextBox();
            this.txtCEName = new System.Windows.Forms.TextBox();
            this.txtCEURL = new System.Windows.Forms.TextBox();
            this.lblCEPwd = new System.Windows.Forms.Label();
            this.lblCEName = new System.Windows.Forms.Label();
            this.lblCEURL = new System.Windows.Forms.Label();
            this.btnCreateDoc = new System.Windows.Forms.Button();
            this.btnGetDoc = new System.Windows.Forms.Button();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbConnection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnection
            // 
            this.gbConnection.Controls.Add(this.lblMsg);
            this.gbConnection.Controls.Add(this.btnConnection);
            this.gbConnection.Controls.Add(this.txtCEPwd);
            this.gbConnection.Controls.Add(this.txtCEName);
            this.gbConnection.Controls.Add(this.txtCEURL);
            this.gbConnection.Controls.Add(this.lblCEPwd);
            this.gbConnection.Controls.Add(this.lblCEName);
            this.gbConnection.Controls.Add(this.lblCEURL);
            this.gbConnection.Location = new System.Drawing.Point(12, 12);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(419, 228);
            this.gbConnection.TabIndex = 0;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "连接CE";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(19, 180);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 12);
            this.lblMsg.TabIndex = 6;
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(302, 147);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(75, 45);
            this.btnConnection.TabIndex = 5;
            this.btnConnection.Text = "连接";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // txtCEPwd
            // 
            this.txtCEPwd.Location = new System.Drawing.Point(103, 108);
            this.txtCEPwd.Name = "txtCEPwd";
            this.txtCEPwd.Size = new System.Drawing.Size(274, 21);
            this.txtCEPwd.TabIndex = 4;
            this.txtCEPwd.Text = "q1w2e3r4";
            // 
            // txtCEName
            // 
            this.txtCEName.Location = new System.Drawing.Point(103, 76);
            this.txtCEName.Name = "txtCEName";
            this.txtCEName.Size = new System.Drawing.Size(274, 21);
            this.txtCEName.TabIndex = 4;
            this.txtCEName.Text = "p8admin";
            // 
            // txtCEURL
            // 
            this.txtCEURL.Location = new System.Drawing.Point(103, 42);
            this.txtCEURL.Name = "txtCEURL";
            this.txtCEURL.Size = new System.Drawing.Size(274, 21);
            this.txtCEURL.TabIndex = 3;
            this.txtCEURL.Text = "http://10.27.221.48:9080/wsi/FNCEWS40MTOM/";
            // 
            // lblCEPwd
            // 
            this.lblCEPwd.AutoSize = true;
            this.lblCEPwd.Location = new System.Drawing.Point(19, 111);
            this.lblCEPwd.Name = "lblCEPwd";
            this.lblCEPwd.Size = new System.Drawing.Size(47, 12);
            this.lblCEPwd.TabIndex = 2;
            this.lblCEPwd.Text = "CE 密码";
            // 
            // lblCEName
            // 
            this.lblCEName.AutoSize = true;
            this.lblCEName.Location = new System.Drawing.Point(19, 79);
            this.lblCEName.Name = "lblCEName";
            this.lblCEName.Size = new System.Drawing.Size(59, 12);
            this.lblCEName.TabIndex = 1;
            this.lblCEName.Text = "CE 用户名";
            // 
            // lblCEURL
            // 
            this.lblCEURL.AutoSize = true;
            this.lblCEURL.Location = new System.Drawing.Point(19, 45);
            this.lblCEURL.Name = "lblCEURL";
            this.lblCEURL.Size = new System.Drawing.Size(41, 12);
            this.lblCEURL.TabIndex = 0;
            this.lblCEURL.Text = "CE URL";
            // 
            // btnCreateDoc
            // 
            this.btnCreateDoc.Location = new System.Drawing.Point(114, 33);
            this.btnCreateDoc.Name = "btnCreateDoc";
            this.btnCreateDoc.Size = new System.Drawing.Size(75, 34);
            this.btnCreateDoc.TabIndex = 12;
            this.btnCreateDoc.Text = "添加文档";
            this.btnCreateDoc.UseVisualStyleBackColor = true;
            this.btnCreateDoc.Click += new System.EventHandler(this.btnCreateDoc_Click);
            // 
            // btnGetDoc
            // 
            this.btnGetDoc.Location = new System.Drawing.Point(210, 33);
            this.btnGetDoc.Name = "btnGetDoc";
            this.btnGetDoc.Size = new System.Drawing.Size(75, 34);
            this.btnGetDoc.TabIndex = 13;
            this.btnGetDoc.Text = "获取文档";
            this.btnGetDoc.UseVisualStyleBackColor = true;
            this.btnGetDoc.Click += new System.EventHandler(this.btnGetDoc_Click);
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(21, 33);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(75, 34);
            this.btnCreateFolder.TabIndex = 14;
            this.btnCreateFolder.Text = "新建文件夹";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(304, 33);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 34);
            this.btnQuery.TabIndex = 15;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.btnCreateFolder);
            this.groupBox1.Controls.Add(this.btnGetDoc);
            this.groupBox1.Controls.Add(this.btnCreateDoc);
            this.groupBox1.Location = new System.Drawing.Point(12, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 93);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(198, 370);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 428);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbConnection);
            this.Name = "MainForm";
            this.Text = "Content Engine .NET";
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.Label lblCEPwd;
        private System.Windows.Forms.Label lblCEName;
        private System.Windows.Forms.Label lblCEURL;
        private System.Windows.Forms.TextBox txtCEPwd;
        private System.Windows.Forms.TextBox txtCEName;
        private System.Windows.Forms.TextBox txtCEURL;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnCreateDoc;
        private System.Windows.Forms.Button btnGetDoc;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
    }
}