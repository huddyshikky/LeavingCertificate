
namespace LeavingCertificate
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransact = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuRegisterStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuRegisterStream = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuRegisterSchool = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuCreateLeaving = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuPrintLeaving = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegister,
            this.mnuTransact,
            this.mnuReports});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuRegister
            // 
            this.mnuRegister.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnuRegisterSchool,
            this.smnuRegisterStream,
            this.smnuRegisterStudent});
            this.mnuRegister.Name = "mnuRegister";
            this.mnuRegister.Size = new System.Drawing.Size(61, 20);
            this.mnuRegister.Text = "Register";
            // 
            // mnuTransact
            // 
            this.mnuTransact.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnuCreateLeaving});
            this.mnuTransact.Name = "mnuTransact";
            this.mnuTransact.Size = new System.Drawing.Size(62, 20);
            this.mnuTransact.Text = "Transact";
            // 
            // mnuReports
            // 
            this.mnuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnuPrintLeaving});
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(59, 20);
            this.mnuReports.Text = "Reports";
            // 
            // smnuRegisterStudent
            // 
            this.smnuRegisterStudent.Name = "smnuRegisterStudent";
            this.smnuRegisterStudent.Size = new System.Drawing.Size(180, 22);
            this.smnuRegisterStudent.Text = "Student Details";
            // 
            // smnuRegisterStream
            // 
            this.smnuRegisterStream.Name = "smnuRegisterStream";
            this.smnuRegisterStream.Size = new System.Drawing.Size(180, 22);
            this.smnuRegisterStream.Text = "Stream Details";
            // 
            // smnuRegisterSchool
            // 
            this.smnuRegisterSchool.Name = "smnuRegisterSchool";
            this.smnuRegisterSchool.Size = new System.Drawing.Size(180, 22);
            this.smnuRegisterSchool.Text = "School Details";
            // 
            // smnuCreateLeaving
            // 
            this.smnuCreateLeaving.Name = "smnuCreateLeaving";
            this.smnuCreateLeaving.Size = new System.Drawing.Size(209, 22);
            this.smnuCreateLeaving.Text = "Create Leaving Certificate";
            // 
            // smnuPrintLeaving
            // 
            this.smnuPrintLeaving.Name = "smnuPrintLeaving";
            this.smnuPrintLeaving.Size = new System.Drawing.Size(200, 22);
            this.smnuPrintLeaving.Text = "Print Leaving Certificate";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 426);
            this.panel1.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esenta Leaving Certificate System @2022";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuRegister;
        private System.Windows.Forms.ToolStripMenuItem smnuRegisterSchool;
        private System.Windows.Forms.ToolStripMenuItem smnuRegisterStream;
        private System.Windows.Forms.ToolStripMenuItem smnuRegisterStudent;
        private System.Windows.Forms.ToolStripMenuItem mnuTransact;
        private System.Windows.Forms.ToolStripMenuItem smnuCreateLeaving;
        private System.Windows.Forms.ToolStripMenuItem mnuReports;
        private System.Windows.Forms.ToolStripMenuItem smnuPrintLeaving;
        private System.Windows.Forms.Panel panel1;
    }
}

