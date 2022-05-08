using LeavingCertificate.Models;
using LeavingCertificate.Models.Enums;
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
    public partial class FrmStudent_Add : Form
    {
        StudentService studentService = new StudentService();
        FrmStudentDetails Frm_StuDet;
        public FrmStudent_Add(FrmStudentDetails Frm_StuDet)
        {
            InitializeComponent();

            this.Frm_StuDet = Frm_StuDet;

            populateothercombos();
            populatestreamCombo();


        }
        private void populateothercombos()
        {

            cboEnrolled.DataSource = Enum.GetValues(typeof(EnrolledEnum));
            cboCategory.DataSource = Enum.GetValues(typeof(StudCatEnum));
            cboGender.DataSource = Enum.GetValues(typeof(GenderEnum));
        }
        private void populatestreamCombo()
        {
            StreamService streamService = new StreamService();
            List<Stream> streams = streamService.GetAll();

            //Insert the Default Item to List.
            streams.Insert(0, new Stream
            {
                Id = 0,
                StreamName = "Please select"
            });

            //Assign Entity as DataSource.
            cboStream.DataSource = streams;
            cboStream.DisplayMember = "StreamName";
            cboStream.ValueMember = "Id";
           
        }

        private void AddDataToUpdate()
        {
            StudentService studentService = new StudentService();
            var students = studentService.GetOne(int.Parse(lbl_Id.Text));

            txtAdmNo.Text = students.AdmNo.ToString();
            txtStudName.Text = students.StudName.ToString();
            cboEnrolled.SelectedItem = students.ClassFirstEnrolled;
            cboCategory.SelectedItem = students.Category;
            dtpDOB.Value = students.DateOfBirth;
            dtpDOA.Value = students.DateOfAdmission;
            cboGender.SelectedItem = students.Gender;
            cboStream.SelectedIndex = cboStream.FindStringExact(students.Stream.StreamName.ToString());
            //cboStream.SelectedValue = (Stream)students.Stream;
        }
        private void FrmStudent_Add_Load(object sender, EventArgs e)
        {
            AddDataToUpdate();
        }
        private void clear()
        {
            txtAdmNo.Clear();
            txtStudName.Clear();
            cboEnrolled.SelectedIndex = 0;
            cboStream.SelectedIndex = 0;
            cboCategory.SelectedIndex = 0;
            dtpDOA.Format = DateTimePickerFormat.Custom;
            dtpDOA.CustomFormat = "yyyy-MM-dd";
            dtpDOB.Format = DateTimePickerFormat.Custom;
            dtpDOB.CustomFormat = "yyyy-MM-dd";
            dtpDOA.Value = DateTime.Now.Date;
            dtpDOB.Value = DateTime.Now.Date;

            txtAdmNo.Focus();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate entries
                if (string.IsNullOrEmpty(txtAdmNo.Text))
                {
                    MessageBox.Show("Admission Number must not be empty", "Esent@ Leaving Cert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAdmNo.Focus();
                    return;
                }
                if (!int.TryParse(txtAdmNo.Text.Trim(), out _))
                {
                    MessageBox.Show("Admission Number should be Numeric", "Esent@ Leaving Cert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAdmNo.Focus();
                    return;
                }
                if (int.Parse(txtAdmNo.Text.Trim()) == 0)
                {
                    MessageBox.Show("Zero cannot be used as admission number", "Esent@ Leaving Cert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAdmNo.Focus();
                    return ;
                }
                if (string.IsNullOrEmpty(txtStudName.Text))
                {
                    MessageBox.Show("Student Name MUST not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStudName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(cboEnrolled.Text))
                {
                    MessageBox.Show("Enrollment MUST not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboEnrolled.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(cboStream.Text))
                {
                    MessageBox.Show("Stream MUST not be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboStream.Focus();
                    return;
                }
                Stream stream = (Stream)cboStream.SelectedItem;
                Student student = new Student()
                {
                    AdmNo = int.Parse(txtAdmNo.Text.Trim()),
                    StudName = txtStudName.Text.Trim(),
                    ClassFirstEnrolled = (EnrolledEnum)cboEnrolled.SelectedItem,
                    Category = (StudCatEnum)cboCategory.SelectedItem,
                    DateOfBirth = dtpDOB.Value.Date,
                    DateOfAdmission = dtpDOA.Value.Date,
                    Gender = (GenderEnum)cboCategory.SelectedItem,
                    StreamId = stream.Id,
                    LeavingCert = new LeavingCertDetail
                    {
                        Comment = "Was a very hardworking student",
                        ClassOfLeaving = "Form 4"
                    }

                };

                if (btnSave.Text == "Save") //new record
                {
                    if (studentService.Add(student))
                    {
                        MessageBox.Show("Student details Added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        txtAdmNo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add Student details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else //update record
                {
                    student.Id = int.Parse(lbl_Id.Text.Trim());
                    if (studentService.Update(student))
                    {
                        MessageBox.Show("Stream Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        Frm_StuDet.LoadData();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (MessageBox.Show($"Are you sure you want to delete AdmNo: {txtAdmNo.Text} Name: {txtStudName.Text}? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    int Id= int.Parse(lbl_Id.Text.Trim()); 
                    
                    if (studentService.Delete(Id))
                    {
                        MessageBox.Show("Student Deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        Frm_StuDet.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Delete Student", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
