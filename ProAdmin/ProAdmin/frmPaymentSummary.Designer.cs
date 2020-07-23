namespace ProAdmin
{
    partial class frmPaymentSummary
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtmonth = new DevExpress.XtraScheduler.UI.MonthEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnprocess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbbatch = new System.Windows.Forms.ComboBox();
            this.dgvscol = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.dgvpadi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.dgvnotpadi = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.dgvsolview = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvscol)).BeginInit();
            this.dgvscol.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpadi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnotpadi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsolview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
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
            this.tabPane1.RegularSize = new System.Drawing.Size(1131, 626);
            this.tabPane1.SelectedPage = this.tabNavigationPage3;
            this.tabPane1.Size = new System.Drawing.Size(1131, 626);
            this.tabPane1.TabIndex = 9;
            this.tabPane1.Text = "Manage Attandance Summary";
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Manage Class Shedules";
            this.tabNavigationPage3.Controls.Add(this.splitContainer1);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1131, 589);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvscol);
            this.splitContainer1.Size = new System.Drawing.Size(1131, 589);
            this.splitContainer1.SplitterDistance = 196;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtmonth);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtyear);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.btnprocess);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.cmbbatch);
            this.groupControl1.Location = new System.Drawing.Point(13, 16);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(656, 179);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Summary Process Query";
            // 
            // txtmonth
            // 
            this.txtmonth.Location = new System.Drawing.Point(79, 66);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtmonth.Size = new System.Drawing.Size(100, 20);
            this.txtmonth.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Year";
            // 
            // txtyear
            // 
            this.txtyear.Enabled = false;
            this.txtyear.Location = new System.Drawing.Point(257, 65);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(100, 21);
            this.txtyear.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Month";
            // 
            // btnprocess
            // 
            this.btnprocess.Location = new System.Drawing.Point(257, 114);
            this.btnprocess.Name = "btnprocess";
            this.btnprocess.Size = new System.Drawing.Size(107, 23);
            this.btnprocess.TabIndex = 4;
            this.btnprocess.Text = "Process....";
            this.btnprocess.UseVisualStyleBackColor = true;
            this.btnprocess.Click += new System.EventHandler(this.btnprocess_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sheduled Batch";
            // 
            // cmbbatch
            // 
            this.cmbbatch.FormattingEnabled = true;
            this.cmbbatch.Location = new System.Drawing.Point(496, 65);
            this.cmbbatch.Name = "cmbbatch";
            this.cmbbatch.Size = new System.Drawing.Size(121, 21);
            this.cmbbatch.TabIndex = 1;
            // 
            // dgvscol
            // 
            this.dgvscol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvscol.Location = new System.Drawing.Point(0, 0);
            this.dgvscol.Name = "dgvscol";
            this.dgvscol.SelectedTabPage = this.xtraTabPage1;
            this.dgvscol.Size = new System.Drawing.Size(1131, 389);
            this.dgvscol.TabIndex = 0;
            this.dgvscol.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.dgvpadi);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1129, 366);
            this.xtraTabPage1.Text = "Paid";
            // 
            // dgvpadi
            // 
            this.dgvpadi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvpadi.Location = new System.Drawing.Point(0, 0);
            this.dgvpadi.MainView = this.gridView1;
            this.dgvpadi.Name = "dgvpadi";
            this.dgvpadi.Size = new System.Drawing.Size(1129, 366);
            this.dgvpadi.TabIndex = 0;
            this.dgvpadi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvpadi;
            this.gridView1.Name = "gridView1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.dgvnotpadi);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1129, 366);
            this.xtraTabPage2.Text = "Not Paid";
            // 
            // dgvnotpadi
            // 
            this.dgvnotpadi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvnotpadi.Location = new System.Drawing.Point(0, 0);
            this.dgvnotpadi.MainView = this.gridView2;
            this.dgvnotpadi.Name = "dgvnotpadi";
            this.dgvnotpadi.Size = new System.Drawing.Size(1129, 366);
            this.dgvnotpadi.TabIndex = 0;
            this.dgvnotpadi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.dgvnotpadi;
            this.gridView2.Name = "gridView2";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.dgvsolview);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1129, 366);
            this.xtraTabPage3.Text = "Scholarships";
            // 
            // dgvsolview
            // 
            this.dgvsolview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvsolview.Location = new System.Drawing.Point(0, 0);
            this.dgvsolview.MainView = this.gridView3;
            this.dgvsolview.Name = "dgvsolview";
            this.dgvsolview.Size = new System.Drawing.Size(1129, 366);
            this.dgvsolview.TabIndex = 1;
            this.dgvsolview.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.dgvsolview;
            this.gridView3.Name = "gridView3";
            // 
            // frmPaymentSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPane1);
            this.Name = "frmPaymentSummary";
            this.Size = new System.Drawing.Size(1131, 626);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvscol)).EndInit();
            this.dgvscol.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpadi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnotpadi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsolview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button btnprocess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbbatch;
        private DevExpress.XtraTab.XtraTabControl dgvscol;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl dgvpadi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl dgvnotpadi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl dgvsolview;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraScheduler.UI.MonthEdit txtmonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label label4;
    }
}
