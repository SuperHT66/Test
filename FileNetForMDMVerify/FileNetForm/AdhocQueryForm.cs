using System;
using System.Collections;
using System.Windows.Forms;
using System.Data;

using FileNetForMDMVerify.Library;
using FileNet.Api.Exception;
using FileNet.Api.Core;
using FileNet.Api.Collection;
using FileNet.Api.Query;
using FileNet.Api.Meta;
using FileNet.Api.Property;
using FileNet.Api.Constants;
using FileNet.Api.Admin;

namespace FileNetForMDMVerify.FileNetForm
{
    public partial class AdhocQueryForm : Form
    {
        private CEConnection ce;

        public AdhocQueryForm(CEConnection c)
        {
            ce = c;
            InitializeComponent();
        }

        private void AdhocQueryForm_Load(object sender, EventArgs e)
        {
            //加载Object Store
            ArrayList osNames = ce.GetOSNames();
            cmbSelectOS.Items.Clear();
            for (int i = 0; i < osNames.Count; i++)
            {
                cmbSelectOS.Items.Add(osNames[i]);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string select = txtSelect.Text.Trim();//Objects实例，properties属性，class definitions类定义
            string from = txtFrom.Text.Trim();//document class文档类 
            string where = txtWhere.Text.Trim();//properties条件
            int row = 0;

            #region 测试objclass,Property
            IObjectStore os1 = (IObjectStore)ce.FetchOS((String)cmbSelectOS.SelectedItem);
            PropertyFilter pf = new PropertyFilter();
            pf.AddIncludeType(0, null, true, FilteredPropertyType.ANY, null);
            // Fetch selected class description from the server
            string strPropDescSymbolicName = string.Empty;
            string objPropDefSymbolicName = string.Empty; 
            IClassDescription objClassDesc = Factory.ClassDescription.FetchInstance(os1, "ProjectCode", pf);
            IClassDefinition objClassDef = Factory.ClassDefinition.FetchInstance(os1, "ProjectCode", pf);
            IPropertyDescriptionList objPropDescs = objClassDesc.PropertyDescriptions;
            IPropertyDefinitionList objPropDefs = objClassDef.PropertyDefinitions;

            int a = objPropDescs.Count;
            int b = objPropDefs.Count;
            bool? isht = false;
            bool? isht1 = false;
            string strPropDescSymbolicNames = string.Empty;

            foreach (IPropertyDescription objPropDesc in objPropDescs)
            {
                if (isht == objPropDesc.IsSystemOwned)
                {
                    strPropDescSymbolicName += objPropDesc.SymbolicName + ",";
                    strPropDescSymbolicNames += objPropDesc.DisplayName + ",";
                }
            }
            foreach (IPropertyDefinition objPropDef in objPropDefs)
            {
                if (isht == objPropDef.IsSystemOwned)
                    objPropDefSymbolicName += objPropDef.SymbolicName + ",";
            }

            IClassDefinition objClassDef11 = Factory.ClassDefinition.FetchInstance(os1, "Document", null);
            //IClassDefinition objClassDefNew = objClassDef11.DisplayNames();

            #endregion

            try
            {
                if (CheckRequiredFields())//判断查询条件是否完整
                {
                    IObjectStore os = (IObjectStore)ce.FetchOS((String)cmbSelectOS.SelectedItem);
                    if (maxCheckBox.Checked)
                    {
                        if (!(txtRows.Text.Equals("")))
                            row = Int32.Parse(txtRows.Text.Trim());
                    }
                    IRepositoryRowSet rrs = CEUtil.FetchResultRowSet(os, select, from, where, row);

                    bool firstpass = true;
                    DataTable table = new DataTable();

                    IEnumerator ie = rrs.GetEnumerator();
                    while (ie.MoveNext())
                    {
                        IRepositoryRow rr = (IRepositoryRow)ie.Current;
                        if (firstpass)
                        {
                            ArrayList names = CEUtil.GetRowPropertiesName(rr);
                            for (int i = 0; i < names.Count; i++)
                                table.Columns.Add(new DataColumn((String)names[i]));
                            firstpass = false;
                        }
                        table.Rows.Add(CEUtil.GetResultRow(rr));
                    }
                    gvResult.DataSource = table;
                    statusLabel.Text = "查询执行成功"; 
                }
            }
            catch (EngineRuntimeException ere)
            {
                statusLabel.Text = ere.Message;
                System.Console.WriteLine(ere.StackTrace);
            }
        }

        /// <summary>
        /// 清空查询条件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSelect.Text = "";
            txtFrom.Text = "";
            txtWhere.Text = "";
            maxCheckBox.Checked = false;
            txtRows.Text = "";
            gvResult.DataSource = null;
            statusLabel.Text = "查询状态";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            base.Dispose();
        }

        /// <summary>
        /// 判断查询条件是否完整
        /// </summary>
        /// <returns></returns>
        private bool CheckRequiredFields()
        {
            bool check = true;
            if (cmbSelectOS.SelectedItem == null)
            {
                statusLabel.Text = "请选择存储库";
                check = false;
            }
            else
            {
                if (txtSelect.Text.Equals(""))
                {
                    txtSelect.Text = "SELECT查询项不能为空";
                    check = false;
                }
                if (txtFrom.Text.Equals(""))
                {
                    txtFrom.Text = "From查询项不能为空";
                    check = false;
                }
                if (maxCheckBox.Checked)
                {
                    if (txtRows.Text.Equals(""))
                    {
                        statusLabel.Text = "最大行数不能为空";
                        check = false;
                    }
                }
            }
            return check;
        }
    }
}
