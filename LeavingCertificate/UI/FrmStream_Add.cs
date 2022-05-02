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
    public partial class FrmStream_Add : Form
    {
        public FrmStream_Add()
        {
            InitializeComponent();
        }

        private void FrmStream_Add_Load(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            txtStream.Clear();
            txtStream.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate entries
                if (string.IsNullOrEmpty(txtStream.Text))
                {
                    MessageBox.Show("Stream Name must not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStream.Focus();
                    return;
                }

                Stream stream = new Stream()
                {
                    StreamName = txtStream.Text,
                };

                if (btnSave.Text == "Save") //new record
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
    }
}
