using LeavingCertificate.Models.Enums;
using LeavingCertificate.Services;
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
    public partial class FrmStudentDetails : Form
    {
        public FrmStudentDetails()
        {
            InitializeComponent();
        }

        private void FrmStudentDetails_Load(object sender, EventArgs e)
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
            StudentService studentService = new StudentService();
            var students = studentService.GetAll();
            StudentdataGridView.Rows.Clear();

            foreach (var student in students)
            {
                StudentdataGridView.Rows.Add(student.Id, student.StudName, student.ClassFirstEnrolled, student.Gender,student.Stream.StreamName);
            }
        }

        private void LblAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmStudent_Add Frm_AddUpdate = new FrmStudent_Add(this);
            Frm_AddUpdate.btnSave.Text = "Save";
            Frm_AddUpdate.grpBoxStudent.Text = "Add Student";
            Frm_AddUpdate.ShowDialog();
        }

        private void StudentdataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = StudentdataGridView.SelectedRows[0];
            FrmStudent_Add Frm_AddUpdate = new FrmStudent_Add(this);
            Frm_AddUpdate.btnSave.Text = "Update";
            Frm_AddUpdate.grpBoxStudent.Text = "Update Student";

            Frm_AddUpdate.lbl_Id.Text = dr.Cells[0].Value.ToString();
            
            Frm_AddUpdate.ShowDialog();
        }
    }
}
