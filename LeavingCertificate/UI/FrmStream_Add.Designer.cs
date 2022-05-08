
namespace LeavingCertificate.UI
{
    partial class FrmStream_Add
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
            this.grpBoxStream = new System.Windows.Forms.GroupBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtStream = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxStream.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxStream
            // 
            this.grpBoxStream.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpBoxStream.Controls.Add(this.lbl_Id);
            this.grpBoxStream.Controls.Add(this.btnDelete);
            this.grpBoxStream.Controls.Add(this.btnSave);
            this.grpBoxStream.Controls.Add(this.txtStream);
            this.grpBoxStream.Controls.Add(this.label1);
            this.grpBoxStream.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBoxStream.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpBoxStream.Location = new System.Drawing.Point(0, 3);
            this.grpBoxStream.Name = "grpBoxStream";
            this.grpBoxStream.Size = new System.Drawing.Size(334, 116);
            this.grpBoxStream.TabIndex = 2;
            this.grpBoxStream.TabStop = false;
            this.grpBoxStream.Text = "Add Stream";
            // 
            // lbl_Id
            // 
            this.lbl_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Id.Location = new System.Drawing.Point(299, 29);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(29, 27);
            this.lbl_Id.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(96, 63);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 29);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(214, 63);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 29);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtStream
            // 
            this.txtStream.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtStream.Location = new System.Drawing.Point(96, 28);
            this.txtStream.Name = "txtStream";
            this.txtStream.Size = new System.Drawing.Size(199, 29);
            this.txtStream.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stream :";
            // 
            // FrmStream_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 118);
            this.Controls.Add(this.grpBoxStream);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStream_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStream_Add_FormClosing);
            this.Load += new System.EventHandler(this.FrmStream_Add_Load);
            this.grpBoxStream.ResumeLayout(false);
            this.grpBoxStream.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtStream;
        public System.Windows.Forms.GroupBox grpBoxStream;
        public System.Windows.Forms.Label lbl_Id;
        public System.Windows.Forms.Button btnDelete;
    }
}