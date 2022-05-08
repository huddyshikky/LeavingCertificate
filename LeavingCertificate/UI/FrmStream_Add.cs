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
    public partial class FrmStream_Add : Form
    {
        StreamService streamService = new StreamService();

        FrmStreamDetails Frm_StrDet;
        public FrmStream_Add(FrmStreamDetails Frm_StrDet)
        {
            InitializeComponent();
            this.Frm_StrDet = Frm_StrDet;
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
                    if (streamService.Add(stream))
                    {
                        MessageBox.Show("Stream Added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        txtStream.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add Stream", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else //update record
                {
                    stream.Id = int.Parse(lbl_Id.Text.Trim());
                    if (streamService.Update(stream))
                    {
                        MessageBox.Show("Stream Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        Frm_StrDet.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Update Stream", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmStream_Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            //FrmStreamDetails.close
            //FrmStreamDetails frm = new FrmStreamDetails();
            ////frm.Close();
            //frm.Close();
        }

        private void FrmStream_Add_Load(object sender, EventArgs e)
        {

        }
    }
}
