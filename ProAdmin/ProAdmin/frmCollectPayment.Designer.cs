namespace ProAdmin
{
    partial class frmCollectPayment
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
            this.txtmonth = new DevExpress.XtraScheduler.UI.MonthEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmessage = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmonth.Properties)).BeginInit();
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
            this.tabPane1.RegularSize = new System.Drawing.Size(1098, 632);
            this.tabPane1.SelectedPage = this.tabNavigationPage3;
            this.tabPane1.Size = new System.Drawing.Size(1098, 632);
            this.tabPane1.TabIndex = 9;
            this.tabPane1.Text = "Manage Attandance Register";
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Receive payment";
            this.tabNavigationPage3.Controls.Add(this.groupControl1);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1098, 595);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtmonth);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.lblmessage);
            this.groupControl1.Controls.Add(this.txtyear);
            this.groupControl1.Controls.Add(this.btnregister);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtstudentid);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(26, 20);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(683, 366);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Fee Payment";
            // 
            // txtmonth
            // 
            this.txtmonth.Location = new System.Drawing.Point(63, 32);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtmonth.Size = new System.Drawing.Size(100, 20);
            this.txtmonth.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Year";
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.ForeColor = System.Drawing.Color.Red;
            this.lblmessage.Location = new System.Drawing.Point(154, 239);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 24);
            this.lblmessage.TabIndex = 6;
            this.lblmessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtyear
            // 
            this.txtyear.Enabled = false;
            this.txtyear.Location = new System.Drawing.Point(241, 31);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(100, 21);
            this.txtyear.TabIndex = 5;
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(286, 176);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(75, 23);
            this.btnregister.TabIndex = 4;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Month";
            // 
            // txtstudentid
            // 
            this.txtstudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentid.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtstudentid.Location = new System.Drawing.Point(158, 121);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(349, 38);
            this.txtstudentid.TabIndex = 0;
            this.txtstudentid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtstudentid.VisibleChanged += new System.EventHandler(this.txtstudentid_VisibleChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ENTER THE STUDENT ID";
            // 
            // frmCollectPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPane1);
            this.Name = "frmCollectPayment";
            this.Size = new System.Drawing.Size(1098, 632);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmonth.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraScheduler.UI.MonthEdit txtmonth;
    }
}
