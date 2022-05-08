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
    public partial class FrmStreamDetails : Form
    {
        public FrmStreamDetails()
        {
            InitializeComponent();
        }

        private void LblAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmStream_Add Frm_AddUpdate = new FrmStream_Add(this);
            Frm_AddUpdate.btnSave.Text = "Save";
            Frm_AddUpdate.grpBoxStream.Text = "Add Stream";
            Frm_AddUpdate.ShowDialog();
        }

        private void FrmStreamDetails_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void LoadData()
        {
            StreamService streamService = new StreamService();
            var streams = streamService.GetAll();
            StreamdataGridView.Rows.Clear();

            foreach (var stream in streams)
            {
                StreamdataGridView.Rows.Add(stream.Id, stream.StreamName);
            }
        }

        private void StreamdataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = StreamdataGridView.SelectedRows[0]; 
            FrmStream_Add Frm_AddUpdate = new FrmStream_Add(this);
            Frm_AddUpdate.btnSave.Text = "Update";
            Frm_AddUpdate.grpBoxStream.Text = "Update Stream";
            Frm_AddUpdate.lbl_Id.Text = dr.Cells[0].Value.ToString();
            Frm_AddUpdate.txtStream.Text = dr.Cells[1].Value.ToString();
            Frm_AddUpdate.ShowDialog();

        }
    }
}
