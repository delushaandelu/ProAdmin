namespace ProAdmin
{
    partial class frmAttandanceSummary
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
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtdate = new DevExpress.XtraEditors.DateEdit();
            this.cmbbatch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnprocess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage3});
            this.tabPane1.RegularSize = new System.Drawing.Size(1211, 654);
            this.tabPane1.SelectedPage = this.tabNavigationPage3;
            this.tabPane1.Size = new System.Drawing.Size(1211, 654);
            this.tabPane1.TabIndex = 8;
            this.tabPane1.Text = "Manage Attandance Summary";
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Manage Class Shedules";
            this.tabNavigationPage3.Controls.Add(this.groupControl1);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1211, 617);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnprocess);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.cmbbatch);
            this.groupControl1.Controls.Add(this.txtdate);
            this.groupControl1.Location = new System.Drawing.Point(19, 25);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(656, 179);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Summary Process Query";
            // 
            // txtdate
            // 
            this.txtdate.EditValue = null;
            this.txtdate.Location = new System.Drawing.Point(160, 67);
            this.txtdate.Name = "txtdate";
            this.txtdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtdate.Size = new System.Drawing.Size(100, 20);
            this.txtdate.TabIndex = 0;
            this.txtdate.SelectionChanged += new System.EventHandler(this.txtdate_SelectionChanged);
            // 
            // cmbbatch
            // 
            this.cmbbatch.FormattingEnabled = true;
            this.cmbbatch.Location = new System.Drawing.Point(416, 67);
            this.cmbbatch.Name = "cmbbatch";
            this.cmbbatch.Size = new System.Drawing.Size(121, 21);
            this.cmbbatch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sheduled Batch";
            // 
            // btnprocess
            // 
            this.btnprocess.Location = new System.Drawing.Point(257, 112);
            this.btnprocess.Name = "btnprocess";
            this.btnprocess.Size = new System.Drawing.Size(107, 23);
            this.btnprocess.TabIndex = 4;
            this.btnprocess.Text = "Process....";
            this.btnprocess.UseVisualStyleBackColor = true;
            this.btnprocess.Click += new System.EventHandler(this.btnprocess_Click);
            // 
            // frmAttandanceSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPane1);
            this.Name = "frmAttandanceSummary";
            this.Size = new System.Drawing.Size(1211, 654);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbatch;
        private DevExpress.XtraEditors.DateEdit txtdate;
        private System.Windows.Forms.Button btnprocess;
    }
}
