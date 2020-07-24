namespace ProAdmin
{
    partial class frmReportStudentDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.PrintStudentInfrobybatchandschool = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.linkLabel1);
            this.groupControl1.Controls.Add(this.PrintStudentInfrobybatchandschool);
            this.groupControl1.Location = new System.Drawing.Point(42, 42);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(414, 153);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Student Information";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(22, 84);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(177, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Print Student Information By Batch ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PrintStudentInfrobybatchandschool
            // 
            this.PrintStudentInfrobybatchandschool.AutoSize = true;
            this.PrintStudentInfrobybatchandschool.Location = new System.Drawing.Point(22, 48);
            this.PrintStudentInfrobybatchandschool.Name = "PrintStudentInfrobybatchandschool";
            this.PrintStudentInfrobybatchandschool.Size = new System.Drawing.Size(229, 13);
            this.PrintStudentInfrobybatchandschool.TabIndex = 4;
            this.PrintStudentInfrobybatchandschool.TabStop = true;
            this.PrintStudentInfrobybatchandschool.Text = "Print Student Information By Batch and School";
            this.PrintStudentInfrobybatchandschool.Click += new System.EventHandler(this.PrintStudentInfrobybatchandschool_Click);
            // 
            // frmReportStudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "frmReportStudentDetails";
            this.Size = new System.Drawing.Size(1219, 664);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.LinkLabel PrintStudentInfrobybatchandschool;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
