
namespace LeavingCertificate.UI
{
    partial class FrmStudent_Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdmNo = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.grpBoxStudent = new System.Windows.Forms.GroupBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.dtpDOA = new System.Windows.Forms.DateTimePicker();
            this.cboStream = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboEnrolled = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStudName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBoxStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adm No :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAdmNo
            // 
            this.txtAdmNo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAdmNo.Location = new System.Drawing.Point(142, 31);
            this.txtAdmNo.Name = "txtAdmNo";
            this.txtAdmNo.Size = new System.Drawing.Size(139, 29);
            this.txtAdmNo.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(418, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 29);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbl_Id
            // 
            this.lbl_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Id.Location = new System.Drawing.Point(470, 30);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(29, 27);
            this.lbl_Id.TabIndex = 15;
            // 
            // grpBoxStudent
            // 
            this.grpBoxStudent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpBoxStudent.Controls.Add(this.cboGender);
            this.grpBoxStudent.Controls.Add(this.label8);
            this.grpBoxStudent.Controls.Add(this.dtpDOB);
            this.grpBoxStudent.Controls.Add(this.dtpDOA);
            this.grpBoxStudent.Controls.Add(this.cboStream);
            this.grpBoxStudent.Controls.Add(this.cboCategory);
            this.grpBoxStudent.Controls.Add(this.cboEnrolled);
            this.grpBoxStudent.Controls.Add(this.label7);
            this.grpBoxStudent.Controls.Add(this.label6);
            this.grpBoxStudent.Controls.Add(this.btnDelete);
            this.grpBoxStudent.Controls.Add(this.lbl_Id);
            this.grpBoxStudent.Controls.Add(this.btnSave);
            this.grpBoxStudent.Controls.Add(this.label3);
            this.grpBoxStudent.Controls.Add(this.label4);
            this.grpBoxStudent.Controls.Add(this.label5);
            this.grpBoxStudent.Controls.Add(this.txtStudName);
            this.grpBoxStudent.Controls.Add(this.label2);
            this.grpBoxStudent.Controls.Add(this.txtAdmNo);
            this.grpBoxStudent.Controls.Add(this.label1);
            this.grpBoxStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBoxStudent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpBoxStudent.Location = new System.Drawing.Point(2, 2);
            this.grpBoxStudent.Name = "grpBoxStudent";
            this.grpBoxStudent.Size = new System.Drawing.Size(507, 293);
            this.grpBoxStudent.TabIndex = 3;
            this.grpBoxStudent.TabStop = false;
            this.grpBoxStudent.Text = "Add Student";
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(360, 136);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(139, 29);
            this.cboGender.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(281, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Gender :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(142, 206);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(139, 29);
            this.dtpDOB.TabIndex = 7;
            // 
            // dtpDOA
            // 
            this.dtpDOA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOA.Location = new System.Drawing.Point(142, 171);
            this.dtpDOA.Name = "dtpDOA";
            this.dtpDOA.Size = new System.Drawing.Size(139, 29);
            this.dtpDOA.TabIndex = 6;
            // 
            // cboStream
            // 
            this.cboStream.FormattingEnabled = true;
            this.cboStream.Location = new System.Drawing.Point(360, 101);
            this.cboStream.Name = "cboStream";
            this.cboStream.Size = new System.Drawing.Size(139, 29);
            this.cboStream.TabIndex = 4;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(142, 136);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(139, 29);
            this.cboCategory.TabIndex = 5;
            // 
            // cboEnrolled
            // 
            this.cboEnrolled.FormattingEnabled = true;
            this.cboEnrolled.Location = new System.Drawing.Point(142, 101);
            this.cboEnrolled.Name = "cboEnrolled";
            this.cboEnrolled.Size = new System.Drawing.Size(139, 29);
            this.cboEnrolled.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(10, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Date Of Birth :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Admission Date :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(300, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 29);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(287, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Stream :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enroled in :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Category :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStudName
            // 
            this.txtStudName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtStudName.Location = new System.Drawing.Point(142, 63);
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.Size = new System.Drawing.Size(357, 29);
            this.txtStudName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmStudent_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 298);
            this.Controls.Add(this.grpBoxStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmStudent_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmStudent_Add_Load);
            this.grpBoxStudent.ResumeLayout(false);
            this.grpBoxStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtAdmNo;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Label lbl_Id;
        public System.Windows.Forms.GroupBox grpBoxStudent;
        public System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtStudName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DateTimePicker dtpDOB;
        public System.Windows.Forms.DateTimePicker dtpDOA;
        public System.Windows.Forms.ComboBox cboStream;
        public System.Windows.Forms.ComboBox cboCategory;
        public System.Windows.Forms.ComboBox cboEnrolled;
        public System.Windows.Forms.ComboBox cboGender;
    }
}