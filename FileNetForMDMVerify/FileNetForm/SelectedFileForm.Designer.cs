namespace FileNetForMDMVerify.FileNetForm
{
    partial class SelectedFileForm
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
            this.dgvSelectedFile = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedFile)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelectedFile
            // 
            this.dgvSelectedFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedFile.Location = new System.Drawing.Point(30, 12);
            this.dgvSelectedFile.Name = "dgvSelectedFile";
            this.dgvSelectedFile.RowTemplate.Height = 23;
            this.dgvSelectedFile.Size = new System.Drawing.Size(573, 332);
            this.dgvSelectedFile.TabIndex = 0;
            this.dgvSelectedFile.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvSelectedFile_RowPostPaint);
            // 
            // SelectedFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 356);
            this.Controls.Add(this.dgvSelectedFile);
            this.Name = "SelectedFileForm";
            this.Text = "所有文件";
            this.Load += new System.EventHandler(this.SelectedFileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelectedFile;
    }
}