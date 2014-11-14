using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FileNetForMDMVerify.FileNetForm
{
    public partial class SelectedFileForm : Form
    {

        public ArrayList list;
        

        public SelectedFileForm(ArrayList list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void SelectedFileForm_Load(object sender, EventArgs e)
        {
            dgvSelectedFile.DataSource = ToDataTable(list);
            dgvSelectedFile.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 
            
        }

        public static DataTable ToDataTable(ArrayList list)
        {
            DataTable result = new DataTable();
            result.Columns.Add("文件名");
            if (list != null)
            {
                if (list.Count > 0)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        DataRow dr = result.NewRow();
                        dr["文件名"] = list[i].ToString();
                        result.Rows.Add(dr);
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// DataGridView显示行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSelectedFile_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
               e.RowBounds.Location.Y,
               dgvSelectedFile.RowHeadersWidth - 4,
               e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dgvSelectedFile.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dgvSelectedFile.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
    }
}
