﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeavingCertificate.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void smnuRegisterSchool_Click(object sender, EventArgs e)
        {
            FrmSchoolDetails frmSchoolDetails = new FrmSchoolDetails();
            //frmSchoolDetails.MdiParent = this;
            frmSchoolDetails.ShowDialog();
        }
    }
}
