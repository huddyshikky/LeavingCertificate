using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LeavingCertificate.UI
{
    public partial class FrmStreamDetails : Form
    {
        public FrmStreamDetails()
        {
            InitializeComponent();
        }

        private void LblAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmStream_Add Frm = new FrmStream_Add();
            Frm.btnSave.Text = "Save";
            Frm.ShowDialog();
        }
    }
}
