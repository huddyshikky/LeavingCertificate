using LeavingCertificate.Models;
using LeavingCertificate.Services;
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
        SchoolDetailService SchoolDetailService = new SchoolDetailService();
        int Pk = 0;
        public FrmSchoolDetails()
        {
            InitializeComponent();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate entries
                if (string.IsNullOrEmpty(txtSchName.Text))
                {
                    MessageBox.Show("School Name must not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSchName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtSchAddress.Text))
                {
                    MessageBox.Show("School Address must not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSchAddress.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtSchCity.Text))
                {
                    MessageBox.Show("City must not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSchCity.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtSchTel.Text))
                {
                    MessageBox.Show("School Telephone must not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSchTel.Focus();
                    return;
                }

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

                if (btnSave.Text=="Save") //new record
                {
                    if (SchoolDetailService.Add(SchoolDetail))
                    {
                        MessageBox.Show("School Details Added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add School Details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else //update record
                {
                    SchoolDetail.Id = Pk;
                    if (SchoolDetailService.Update(SchoolDetail))
                    {
                        MessageBox.Show("School Details Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to Update School Details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

                   
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmSchoolDetails_Load(object sender, EventArgs e)
        {
            try
            {

                Clear();
                LoadInitialData();

            }
            catch (Exception ex)
            {
                Clear();
                MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadInitialData()
        {
            //GET FIRST DETAILS
            var SchoolData = SchoolDetailService.GetSchoolDetail();


            if (SchoolData != null)
            {
                Pk = SchoolData.Id;
                txtSchName.Text = SchoolData.schname;
                txtSchAddress.Text = SchoolData.schaddr;
                txtSchCity.Text = SchoolData.city;
                txtSchMotto.Text = SchoolData.schmotto;
                txtSchEmail.Text = SchoolData.schemail;
                txtSchWeb.Text = SchoolData.schweb;
                txtSchTel.Text = SchoolData.schtel;
                btnSave.Text = "Update";

            }
        }
        private void Clear()
        {
            txtSchName.Clear();
            txtSchAddress.Clear();
            txtSchCity.Clear();
            txtSchMotto.Clear();
            txtSchEmail.Clear();
            txtSchWeb.Clear();
            txtSchTel.Clear();
            btnSave.Text = "Save";
        }
    }
}
