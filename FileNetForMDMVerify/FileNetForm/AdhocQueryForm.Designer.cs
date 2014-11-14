namespace FileNetForMDMVerify.FileNetForm
{
    partial class AdhocQueryForm
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
            this.gbQuery = new System.Windows.Forms.GroupBox();
            this.lblSelectOS = new System.Windows.Forms.Label();
            this.cmbSelectOS = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.gbSQL = new System.Windows.Forms.GroupBox();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lblWhere = new System.Windows.Forms.Label();
            this.txtWhere = new System.Windows.Forms.TextBox();
            this.maxCheckBox = new System.Windows.Forms.CheckBox();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.gvResult = new System.Windows.Forms.DataGridView();
            this.statusLabel = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbQuery.SuspendLayout();
            this.gbSQL.SuspendLayout();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // gbQuery
            // 
            this.gbQuery.Controls.Add(this.statusLabel);
            this.gbQuery.Controls.Add(this.gbResult);
            this.gbQuery.Controls.Add(this.gbSQL);
            this.gbQuery.Controls.Add(this.cmbSelectOS);
            this.gbQuery.Controls.Add(this.lblSelectOS);
            this.gbQuery.Location = new System.Drawing.Point(27, 22);
            this.gbQuery.Name = "gbQuery";
            this.gbQuery.Size = new System.Drawing.Size(456, 545);
            this.gbQuery.TabIndex = 0;
            this.gbQuery.TabStop = false;
            this.gbQuery.Text = "查询";
            // 
            // lblSelectOS
            // 
            this.lblSelectOS.AutoSize = true;
            this.lblSelectOS.Location = new System.Drawing.Point(17, 26);
            this.lblSelectOS.Name = "lblSelectOS";
            this.lblSelectOS.Size = new System.Drawing.Size(77, 12);
            this.lblSelectOS.TabIndex = 0;
            this.lblSelectOS.Text = "选择存储库：";
            // 
            // cmbSelectOS
            // 
            this.cmbSelectOS.FormattingEnabled = true;
            this.cmbSelectOS.Location = new System.Drawing.Point(109, 23);
            this.cmbSelectOS.Name = "cmbSelectOS";
            this.cmbSelectOS.Size = new System.Drawing.Size(309, 20);
            this.cmbSelectOS.TabIndex = 1;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(6, 31);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(41, 12);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "SELECT";
            // 
            // gbSQL
            // 
            this.gbSQL.Controls.Add(this.btnClear);
            this.gbSQL.Controls.Add(this.btnQuery);
            this.gbSQL.Controls.Add(this.maxCheckBox);
            this.gbSQL.Controls.Add(this.txtRows);
            this.gbSQL.Controls.Add(this.txtWhere);
            this.gbSQL.Controls.Add(this.txtFrom);
            this.gbSQL.Controls.Add(this.lblWhere);
            this.gbSQL.Controls.Add(this.txtSelect);
            this.gbSQL.Controls.Add(this.lblFrom);
            this.gbSQL.Controls.Add(this.lblSelect);
            this.gbSQL.Location = new System.Drawing.Point(19, 66);
            this.gbSQL.Name = "gbSQL";
            this.gbSQL.Size = new System.Drawing.Size(418, 213);
            this.gbSQL.TabIndex = 2;
            this.gbSQL.TabStop = false;
            this.gbSQL.Text = "查询语句";
            // 
            // txtSelect
            // 
            this.txtSelect.Location = new System.Drawing.Point(90, 28);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(309, 21);
            this.txtSelect.TabIndex = 1;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(6, 72);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(29, 12);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "FROM";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(90, 69);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(309, 21);
            this.txtFrom.TabIndex = 1;
            // 
            // lblWhere
            // 
            this.lblWhere.AutoSize = true;
            this.lblWhere.Location = new System.Drawing.Point(6, 116);
            this.lblWhere.Name = "lblWhere";
            this.lblWhere.Size = new System.Drawing.Size(35, 12);
            this.lblWhere.TabIndex = 0;
            this.lblWhere.Text = "WHERE";
            // 
            // txtWhere
            // 
            this.txtWhere.Location = new System.Drawing.Point(90, 113);
            this.txtWhere.Name = "txtWhere";
            this.txtWhere.Size = new System.Drawing.Size(309, 21);
            this.txtWhere.TabIndex = 1;
            // 
            // maxCheckBox
            // 
            this.maxCheckBox.AutoSize = true;
            this.maxCheckBox.Location = new System.Drawing.Point(8, 165);
            this.maxCheckBox.Name = "maxCheckBox";
            this.maxCheckBox.Size = new System.Drawing.Size(72, 16);
            this.maxCheckBox.TabIndex = 22;
            this.maxCheckBox.Text = "Max Rows";
            this.maxCheckBox.UseVisualStyleBackColor = true;
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(90, 163);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(54, 21);
            this.txtRows.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(205, 161);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 46);
            this.btnQuery.TabIndex = 23;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(324, 161);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 46);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.gvResult);
            this.gbResult.Location = new System.Drawing.Point(19, 332);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(418, 200);
            this.gbResult.TabIndex = 3;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "查询结果";
            // 
            // gvResult
            // 
            this.gvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResult.Location = new System.Drawing.Point(8, 15);
            this.gvResult.Name = "gvResult";
            this.gvResult.RowTemplate.Height = 23;
            this.gvResult.Size = new System.Drawing.Size(404, 179);
            this.gvResult.TabIndex = 0;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(16, 295);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(59, 13);
            this.statusLabel.TabIndex = 17;
            this.statusLabel.Text = "查询状态";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(207, 574);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 31);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AdhocQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 617);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbQuery);
            this.Name = "AdhocQueryForm";
            this.Text = "查询文档";
            this.Load += new System.EventHandler(this.AdhocQueryForm_Load);
            this.gbQuery.ResumeLayout(false);
            this.gbQuery.PerformLayout();
            this.gbSQL.ResumeLayout(false);
            this.gbSQL.PerformLayout();
            this.gbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbQuery;
        private System.Windows.Forms.Label lblSelectOS;
        private System.Windows.Forms.ComboBox cmbSelectOS;
        private System.Windows.Forms.GroupBox gbSQL;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.TextBox txtWhere;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label lblWhere;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.CheckBox maxCheckBox;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.DataGridView gvResult;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button btnClose;
    }
}