using FileNet.Api.Core;
using FileNetForMDMVerify.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FileNetForMDMVerify.FileNetForm
{
    public partial class DocPropetties : Form
    {
        private CEConnection ce;

        public DocPropetties(CEConnection c)
        {
            InitializeComponent();
            ce = c;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
