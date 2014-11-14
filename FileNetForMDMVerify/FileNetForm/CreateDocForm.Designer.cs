namespace FileNetForMDMVerify.FileNetForm
{
    partial class CreateDocForm
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
            this.gbCreate = new System.Windows.Forms.GroupBox();
            this.txtTimeAll = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFileMsg = new System.Windows.Forms.Label();
            this.lblExmple = new System.Windows.Forms.Label();
            this.gbBatch = new System.Windows.Forms.GroupBox();
            this.txtContentBatch = new System.Windows.Forms.TextBox();
            this.btnOpenBatch = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gbSingle = new System.Windows.Forms.GroupBox();
            this.txtContentSingle = new System.Windows.Forms.TextBox();
            this.btnOpenSingle = new System.Windows.Forms.Button();
            this.rdoBatch = new System.Windows.Forms.RadioButton();
            this.rdoSingle = new System.Windows.Forms.RadioButton();
            this.lblUploadType = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.cbCheckIn = new System.Windows.Forms.CheckBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.cbFileInFolder = new System.Windows.Forms.CheckBox();
            this.txtDocClass = new System.Windows.Forms.TextBox();
            this.txtMimeType = new System.Windows.Forms.TextBox();
            this.cbContent = new System.Windows.Forms.CheckBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cboxOS = new System.Windows.Forms.ComboBox();
            this.checkInLabel = new System.Windows.Forms.Label();
            this.folderNameLabel = new System.Windows.Forms.Label();
            this.fileLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.mimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.osLabel = new System.Windows.Forms.Label();
            this.ofdSingle = new System.Windows.Forms.OpenFileDialog();
            this.btnClose = new System.Windows.Forms.Button();
            this.fbdBatch = new System.Windows.Forms.FolderBrowserDialog();
            this.btnGetPropetties = new System.Windows.Forms.Button();
            this.gbCreate.SuspendLayout();
            this.gbBatch.SuspendLayout();
            this.gbSingle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCreate
            // 
            this.gbCreate.Controls.Add(this.btnGetPropetties);
            this.gbCreate.Controls.Add(this.txtTimeAll);
            this.gbCreate.Controls.Add(this.label2);
            this.gbCreate.Controls.Add(this.lblFileMsg);
            this.gbCreate.Controls.Add(this.lblExmple);
            this.gbCreate.Controls.Add(this.gbBatch);
            this.gbCreate.Controls.Add(this.gbSingle);
            this.gbCreate.Controls.Add(this.rdoBatch);
            this.gbCreate.Controls.Add(this.rdoSingle);
            this.gbCreate.Controls.Add(this.lblUploadType);
            this.gbCreate.Controls.Add(this.btnReset);
            this.gbCreate.Controls.Add(this.btnCreate);
            this.gbCreate.Controls.Add(this.statusLabel);
            this.gbCreate.Controls.Add(this.cbCheckIn);
            this.gbCreate.Controls.Add(this.txtFilePath);
            this.gbCreate.Controls.Add(this.cbFileInFolder);
            this.gbCreate.Controls.Add(this.txtDocClass);
            this.gbCreate.Controls.Add(this.txtMimeType);
            this.gbCreate.Controls.Add(this.cbContent);
            this.gbCreate.Controls.Add(this.txtTitle);
            this.gbCreate.Controls.Add(this.cboxOS);
            this.gbCreate.Controls.Add(this.checkInLabel);
            this.gbCreate.Controls.Add(this.folderNameLabel);
            this.gbCreate.Controls.Add(this.fileLabel);
            this.gbCreate.Controls.Add(this.classLabel);
            this.gbCreate.Controls.Add(this.mimeLabel);
            this.gbCreate.Controls.Add(this.label1);
            this.gbCreate.Controls.Add(this.titleLabel);
            this.gbCreate.Controls.Add(this.osLabel);
            this.gbCreate.Location = new System.Drawing.Point(24, 13);
            this.gbCreate.Name = "gbCreate";
            this.gbCreate.Size = new System.Drawing.Size(439, 607);
            this.gbCreate.TabIndex = 0;
            this.gbCreate.TabStop = false;
            this.gbCreate.Text = "上传文件";
            // 
            // txtTimeAll
            // 
            this.txtTimeAll.Location = new System.Drawing.Point(122, 566);
            this.txtTimeAll.Name = "txtTimeAll";
            this.txtTimeAll.Size = new System.Drawing.Size(199, 21);
            this.txtTimeAll.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 50;
            this.label2.Text = "耗时：";
            // 
            // lblFileMsg
            // 
            this.lblFileMsg.AutoSize = true;
            this.lblFileMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileMsg.Location = new System.Drawing.Point(117, 272);
            this.lblFileMsg.Name = "lblFileMsg";
            this.lblFileMsg.Size = new System.Drawing.Size(59, 13);
            this.lblFileMsg.TabIndex = 49;
            this.lblFileMsg.Text = "选择文件";
            // 
            // lblExmple
            // 
            this.lblExmple.AutoSize = true;
            this.lblExmple.Location = new System.Drawing.Point(120, 441);
            this.lblExmple.Name = "lblExmple";
            this.lblExmple.Size = new System.Drawing.Size(131, 12);
            this.lblExmple.TabIndex = 48;
            this.lblExmple.Text = "例如:/Test/haotao/all";
            // 
            // gbBatch
            // 
            this.gbBatch.Controls.Add(this.txtContentBatch);
            this.gbBatch.Controls.Add(this.btnOpenBatch);
            this.gbBatch.Controls.Add(this.linkLabel1);
            this.gbBatch.Location = new System.Drawing.Point(114, 207);
            this.gbBatch.Name = "gbBatch";
            this.gbBatch.Size = new System.Drawing.Size(303, 62);
            this.gbBatch.TabIndex = 47;
            this.gbBatch.TabStop = false;
            this.gbBatch.Text = "批量";
            // 
            // txtContentBatch
            // 
            this.txtContentBatch.Location = new System.Drawing.Point(6, 20);
            this.txtContentBatch.Name = "txtContentBatch";
            this.txtContentBatch.Size = new System.Drawing.Size(201, 21);
            this.txtContentBatch.TabIndex = 43;
            // 
            // btnOpenBatch
            // 
            this.btnOpenBatch.Location = new System.Drawing.Point(212, 18);
            this.btnOpenBatch.Name = "btnOpenBatch";
            this.btnOpenBatch.Size = new System.Drawing.Size(85, 23);
            this.btnOpenBatch.TabIndex = 44;
            this.btnOpenBatch.Text = "选择文件夹";
            this.btnOpenBatch.UseVisualStyleBackColor = true;
            this.btnOpenBatch.Click += new System.EventHandler(this.btnOpenBatch_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 44);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 12);
            this.linkLabel1.TabIndex = 45;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "查看文件夹中的文件";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // gbSingle
            // 
            this.gbSingle.Controls.Add(this.txtContentSingle);
            this.gbSingle.Controls.Add(this.btnOpenSingle);
            this.gbSingle.Location = new System.Drawing.Point(114, 144);
            this.gbSingle.Name = "gbSingle";
            this.gbSingle.Size = new System.Drawing.Size(303, 57);
            this.gbSingle.TabIndex = 46;
            this.gbSingle.TabStop = false;
            this.gbSingle.Text = "单条";
            // 
            // txtContentSingle
            // 
            this.txtContentSingle.Location = new System.Drawing.Point(6, 20);
            this.txtContentSingle.Name = "txtContentSingle";
            this.txtContentSingle.Size = new System.Drawing.Size(201, 21);
            this.txtContentSingle.TabIndex = 30;
            // 
            // btnOpenSingle
            // 
            this.btnOpenSingle.Location = new System.Drawing.Point(213, 18);
            this.btnOpenSingle.Name = "btnOpenSingle";
            this.btnOpenSingle.Size = new System.Drawing.Size(85, 23);
            this.btnOpenSingle.TabIndex = 31;
            this.btnOpenSingle.Text = "选择文件";
            this.btnOpenSingle.UseVisualStyleBackColor = true;
            this.btnOpenSingle.Click += new System.EventHandler(this.btnOpenSingle_Click);
            // 
            // rdoBatch
            // 
            this.rdoBatch.AutoSize = true;
            this.rdoBatch.Location = new System.Drawing.Point(182, 30);
            this.rdoBatch.Name = "rdoBatch";
            this.rdoBatch.Size = new System.Drawing.Size(47, 16);
            this.rdoBatch.TabIndex = 42;
            this.rdoBatch.Text = "批量";
            this.rdoBatch.UseVisualStyleBackColor = true;
            this.rdoBatch.CheckedChanged += new System.EventHandler(this.rdoBatch_CheckedChanged);
            // 
            // rdoSingle
            // 
            this.rdoSingle.AutoSize = true;
            this.rdoSingle.Location = new System.Drawing.Point(114, 30);
            this.rdoSingle.Name = "rdoSingle";
            this.rdoSingle.Size = new System.Drawing.Size(47, 16);
            this.rdoSingle.TabIndex = 41;
            this.rdoSingle.Text = "单条";
            this.rdoSingle.UseVisualStyleBackColor = true;
            this.rdoSingle.CheckedChanged += new System.EventHandler(this.rdoSingle_CheckedChanged);
            // 
            // lblUploadType
            // 
            this.lblUploadType.AutoSize = true;
            this.lblUploadType.Location = new System.Drawing.Point(7, 32);
            this.lblUploadType.Name = "lblUploadType";
            this.lblUploadType.Size = new System.Drawing.Size(89, 12);
            this.lblUploadType.TabIndex = 40;
            this.lblUploadType.Text = "选择上传模式：";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(246, 527);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 39;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(120, 527);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 38;
            this.btnCreate.Text = "创建";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(6, 502);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(111, 13);
            this.statusLabel.TabIndex = 37;
            this.statusLabel.Text = "点击创建添加文档";
            // 
            // cbCheckIn
            // 
            this.cbCheckIn.AutoSize = true;
            this.cbCheckIn.Location = new System.Drawing.Point(120, 474);
            this.cbCheckIn.Name = "cbCheckIn";
            this.cbCheckIn.Size = new System.Drawing.Size(15, 14);
            this.cbCheckIn.TabIndex = 36;
            this.cbCheckIn.UseVisualStyleBackColor = true;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(120, 417);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(201, 21);
            this.txtFilePath.TabIndex = 35;
            // 
            // cbFileInFolder
            // 
            this.cbFileInFolder.AutoSize = true;
            this.cbFileInFolder.Location = new System.Drawing.Point(122, 383);
            this.cbFileInFolder.Name = "cbFileInFolder";
            this.cbFileInFolder.Size = new System.Drawing.Size(15, 14);
            this.cbFileInFolder.TabIndex = 34;
            this.cbFileInFolder.UseVisualStyleBackColor = true;
            // 
            // txtDocClass
            // 
            this.txtDocClass.Location = new System.Drawing.Point(120, 345);
            this.txtDocClass.Name = "txtDocClass";
            this.txtDocClass.Size = new System.Drawing.Size(201, 21);
            this.txtDocClass.TabIndex = 33;
            this.txtDocClass.Text = "Document";
            // 
            // txtMimeType
            // 
            this.txtMimeType.Location = new System.Drawing.Point(120, 308);
            this.txtMimeType.Name = "txtMimeType";
            this.txtMimeType.Size = new System.Drawing.Size(201, 21);
            this.txtMimeType.TabIndex = 32;
            this.txtMimeType.Text = "text/plain";
            // 
            // cbContent
            // 
            this.cbContent.AutoSize = true;
            this.cbContent.Location = new System.Drawing.Point(69, 171);
            this.cbContent.Name = "cbContent";
            this.cbContent.Size = new System.Drawing.Size(15, 14);
            this.cbContent.TabIndex = 29;
            this.cbContent.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(120, 99);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(201, 21);
            this.txtTitle.TabIndex = 28;
            // 
            // cboxOS
            // 
            this.cboxOS.FormattingEnabled = true;
            this.cboxOS.Location = new System.Drawing.Point(120, 60);
            this.cboxOS.Name = "cboxOS";
            this.cboxOS.Size = new System.Drawing.Size(201, 20);
            this.cboxOS.TabIndex = 27;
            // 
            // checkInLabel
            // 
            this.checkInLabel.AutoSize = true;
            this.checkInLabel.Location = new System.Drawing.Point(7, 474);
            this.checkInLabel.Name = "checkInLabel";
            this.checkInLabel.Size = new System.Drawing.Size(41, 12);
            this.checkInLabel.TabIndex = 26;
            this.checkInLabel.Text = "签入：";
            // 
            // folderNameLabel
            // 
            this.folderNameLabel.AutoSize = true;
            this.folderNameLabel.Location = new System.Drawing.Point(7, 420);
            this.folderNameLabel.Name = "folderNameLabel";
            this.folderNameLabel.Size = new System.Drawing.Size(77, 12);
            this.folderNameLabel.TabIndex = 25;
            this.folderNameLabel.Text = "文件夹路径：";
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(6, 383);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(101, 12);
            this.fileLabel.TabIndex = 24;
            this.fileLabel.Text = "是否在文件夹内：";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(7, 348);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(53, 12);
            this.classLabel.TabIndex = 23;
            this.classLabel.Text = "文档类：";
            // 
            // mimeLabel
            // 
            this.mimeLabel.AutoSize = true;
            this.mimeLabel.Location = new System.Drawing.Point(7, 311);
            this.mimeLabel.Name = "mimeLabel";
            this.mimeLabel.Size = new System.Drawing.Size(65, 12);
            this.mimeLabel.TabIndex = 22;
            this.mimeLabel.Text = "文档类型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "是否包括内容：";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(7, 102);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(65, 12);
            this.titleLabel.TabIndex = 20;
            this.titleLabel.Text = "文档标题：";
            // 
            // osLabel
            // 
            this.osLabel.AutoSize = true;
            this.osLabel.Location = new System.Drawing.Point(7, 63);
            this.osLabel.Name = "osLabel";
            this.osLabel.Size = new System.Drawing.Size(77, 12);
            this.osLabel.TabIndex = 19;
            this.osLabel.Text = "选择存储库：";
            // 
            // ofdSingle
            // 
            this.ofdSingle.FileName = "openFileDialog1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(200, 626);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGetPropetties
            // 
            this.btnGetPropetties.Location = new System.Drawing.Point(327, 343);
            this.btnGetPropetties.Name = "btnGetPropetties";
            this.btnGetPropetties.Size = new System.Drawing.Size(84, 23);
            this.btnGetPropetties.TabIndex = 54;
            this.btnGetPropetties.Text = "获取属性";
            this.btnGetPropetties.UseVisualStyleBackColor = true;
            this.btnGetPropetties.Click += new System.EventHandler(this.btnGetPropetties_Click);
            // 
            // CreateDocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 652);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbCreate);
            this.Name = "CreateDocForm";
            this.Text = "添加文档";
            this.Load += new System.EventHandler(this.CreateDocForm_Load);
            this.gbCreate.ResumeLayout(false);
            this.gbCreate.PerformLayout();
            this.gbBatch.ResumeLayout(false);
            this.gbBatch.PerformLayout();
            this.gbSingle.ResumeLayout(false);
            this.gbSingle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCreate;
        private System.Windows.Forms.Label mimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label osLabel;
        private System.Windows.Forms.Label checkInLabel;
        private System.Windows.Forms.Label folderNameLabel;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.TextBox txtContentSingle;
        private System.Windows.Forms.CheckBox cbContent;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cboxOS;
        private System.Windows.Forms.OpenFileDialog ofdSingle;
        private System.Windows.Forms.Button btnOpenSingle;
        private System.Windows.Forms.TextBox txtMimeType;
        private System.Windows.Forms.TextBox txtDocClass;
        private System.Windows.Forms.CheckBox cbFileInFolder;
        private System.Windows.Forms.CheckBox cbCheckIn;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RadioButton rdoBatch;
        private System.Windows.Forms.RadioButton rdoSingle;
        private System.Windows.Forms.Label lblUploadType;
        private System.Windows.Forms.Button btnOpenBatch;
        private System.Windows.Forms.TextBox txtContentBatch;
        private System.Windows.Forms.GroupBox gbBatch;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox gbSingle;
        private System.Windows.Forms.Label lblExmple;
        private System.Windows.Forms.Label lblFileMsg;
        private System.Windows.Forms.FolderBrowserDialog fbdBatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimeAll;
        private System.Windows.Forms.Button btnGetPropetties;
    }
}