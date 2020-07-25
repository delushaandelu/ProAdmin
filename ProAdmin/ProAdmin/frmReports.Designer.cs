namespace ProAdmin
{
    partial class frmReports
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
            this.lblstudentadminon = new System.Windows.Forms.LinkLabel();
            this.lblemptystudentlist = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.PrintStudentInfrobybatchandschool = new System.Windows.Forms.LinkLabel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblattandance = new System.Windows.Forms.LinkLabel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lblreportbatch = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblstudentadminon);
            this.groupControl1.Controls.Add(this.lblemptystudentlist);
            this.groupControl1.Controls.Add(this.linkLabel1);
            this.groupControl1.Controls.Add(this.PrintStudentInfrobybatchandschool);
            this.groupControl1.Location = new System.Drawing.Point(42, 42);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(414, 171);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Student Information";
            // 
            // lblstudentadminon
            // 
            this.lblstudentadminon.AutoSize = true;
            this.lblstudentadminon.Location = new System.Drawing.Point(22, 34);
            this.lblstudentadminon.Name = "lblstudentadminon";
            this.lblstudentadminon.Size = new System.Drawing.Size(147, 13);
            this.lblstudentadminon.TabIndex = 7;
            this.lblstudentadminon.TabStop = true;
            this.lblstudentadminon.Text = "Print Student Admission Form";
            this.lblstudentadminon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblstudentadminon_LinkClicked);
            // 
            // lblemptystudentlist
            // 
            this.lblemptystudentlist.AutoSize = true;
            this.lblemptystudentlist.Location = new System.Drawing.Point(22, 143);
            this.lblemptystudentlist.Name = "lblemptystudentlist";
            this.lblemptystudentlist.Size = new System.Drawing.Size(171, 13);
            this.lblemptystudentlist.TabIndex = 6;
            this.lblemptystudentlist.TabStop = true;
            this.lblemptystudentlist.Text = "Print Student Empty Signing Sheet";
            this.lblemptystudentlist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblemptystudentlist_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(22, 105);
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
            this.PrintStudentInfrobybatchandschool.Location = new System.Drawing.Point(22, 69);
            this.PrintStudentInfrobybatchandschool.Name = "PrintStudentInfrobybatchandschool";
            this.PrintStudentInfrobybatchandschool.Size = new System.Drawing.Size(229, 13);
            this.PrintStudentInfrobybatchandschool.TabIndex = 4;
            this.PrintStudentInfrobybatchandschool.TabStop = true;
            this.PrintStudentInfrobybatchandschool.Text = "Print Student Information By Batch and School";
            this.PrintStudentInfrobybatchandschool.Click += new System.EventHandler(this.PrintStudentInfrobybatchandschool_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblattandance);
            this.groupControl2.Location = new System.Drawing.Point(481, 42);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(414, 82);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "Attandance Information";
            // 
            // lblattandance
            // 
            this.lblattandance.AutoSize = true;
            this.lblattandance.Location = new System.Drawing.Point(22, 34);
            this.lblattandance.Name = "lblattandance";
            this.lblattandance.Size = new System.Drawing.Size(176, 13);
            this.lblattandance.TabIndex = 7;
            this.lblattandance.TabStop = true;
            this.lblattandance.Text = "Print Student Attandance Summary";
            this.lblattandance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblattandance_LinkClicked);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.lblreportbatch);
            this.groupControl3.Location = new System.Drawing.Point(42, 240);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(414, 82);
            this.groupControl3.TabIndex = 9;
            this.groupControl3.Text = "Examiniation Information";
            // 
            // lblreportbatch
            // 
            this.lblreportbatch.AutoSize = true;
            this.lblreportbatch.Location = new System.Drawing.Point(22, 34);
            this.lblreportbatch.Name = "lblreportbatch";
            this.lblreportbatch.Size = new System.Drawing.Size(166, 13);
            this.lblreportbatch.TabIndex = 7;
            this.lblreportbatch.TabStop = true;
            this.lblreportbatch.Text = "Exam Results by Batch and Exam";
            this.lblreportbatch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblreportbatch_LinkClicked);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmReports";
            this.Size = new System.Drawing.Size(1219, 664);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.LinkLabel PrintStudentInfrobybatchandschool;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lblemptystudentlist;
        private System.Windows.Forms.LinkLabel lblstudentadminon;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.LinkLabel lblattandance;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.LinkLabel lblreportbatch;
    }
}
