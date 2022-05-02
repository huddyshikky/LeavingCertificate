
namespace LeavingCertificate.UI
{
    partial class FrmStreamDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StreamdataGridView = new System.Windows.Forms.DataGridView();
            this.LblAdd = new System.Windows.Forms.LinkLabel();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stream = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StreamdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.LblAdd);
            this.groupBox1.Controls.Add(this.StreamdataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 250);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stream Details";
            // 
            // StreamdataGridView
            // 
            this.StreamdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StreamdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StreamdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Stream});
            this.StreamdataGridView.Location = new System.Drawing.Point(16, 79);
            this.StreamdataGridView.Name = "StreamdataGridView";
            this.StreamdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StreamdataGridView.Size = new System.Drawing.Size(376, 155);
            this.StreamdataGridView.TabIndex = 15;
            // 
            // LblAdd
            // 
            this.LblAdd.AutoSize = true;
            this.LblAdd.Location = new System.Drawing.Point(16, 41);
            this.LblAdd.Name = "LblAdd";
            this.LblAdd.Size = new System.Drawing.Size(74, 21);
            this.LblAdd.TabIndex = 16;
            this.LblAdd.TabStop = true;
            this.LblAdd.Text = "Add New";
            this.LblAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblAdd_LinkClicked);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Stream
            // 
            this.Stream.HeaderText = "Stream";
            this.Stream.Name = "Stream";
            // 
            // FrmStreamDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 251);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmStreamDetails";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StreamdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView StreamdataGridView;
        private System.Windows.Forms.LinkLabel LblAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stream;
    }
}