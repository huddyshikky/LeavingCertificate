using System;
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

        private void smnuRegisterStream_Click(object sender, EventArgs e)
        {
            FrmStreamDetails frmStreamDetails = new FrmStreamDetails();
            //frmSchoolDetails.MdiParent = this;
            frmStreamDetails.ShowDialog();
        }

        private void smnuRegisterStudent_Click(object sender, EventArgs e)
        {
            FrmStudentDetails frmStudentDetails = new FrmStudentDetails();
            //frmSchoolDetails.MdiParent = this;
            frmStudentDetails.ShowDialog();
        }
    }
}
