using LeavingCertificate.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LeavingCertificate.UI
{
    public partial class FrmSchoolDetails : Form
    {
        public FrmSchoolDetails()
        {
            InitializeComponent();
        }
        ApplicationDbContext db = new ApplicationDbContext();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SchoolDetail SchoolDetail = new SchoolDetail()
                {
                    schname = txtSchName.Text,
                    schaddr = txtSchAddress.Text,
                    city = txtSchCity.Text,
                    schmotto = txtSchMotto.Text,
                    schemail = txtSchEmail.Text,
                    schweb = txtSchWeb.Text,
                    schtel = txtSchTel.Text,
                };

                using (db)
                {
                    db.SchoolDetails.Add(SchoolDetail);
                    if (db.SaveChanges()>0)
                    {
                        MessageBox.Show("School Details Added successfully","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add School Details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
