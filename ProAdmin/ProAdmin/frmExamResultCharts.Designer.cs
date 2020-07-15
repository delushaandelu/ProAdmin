namespace ProAdmin
{
    partial class frmExamResultCharts
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
            this.txtsearch = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvGenerateOverallReport = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.txtsearch)).BeginInit();
            this.txtsearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenerateOverallReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Controls.Add(this.tabPane1);
            this.txtsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtsearch.Location = new System.Drawing.Point(0, 0);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.RegularSize = new System.Drawing.Size(1159, 591);
            this.txtsearch.SelectedPage = null;
            this.txtsearch.Size = new System.Drawing.Size(1159, 591);
            this.txtsearch.TabIndex = 9;
            this.txtsearch.Text = "Manage User Information";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Over All Mark Sheet";
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1159, 554);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer1.Size = new System.Drawing.Size(1159, 554);
            this.splitContainer1.SplitterDistance = 34;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvGenerateOverallReport
            // 
            this.dgvGenerateOverallReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGenerateOverallReport.Location = new System.Drawing.Point(0, 0);
            this.dgvGenerateOverallReport.MainView = this.gridView1;
            this.dgvGenerateOverallReport.Name = "dgvGenerateOverallReport";
            this.dgvGenerateOverallReport.Size = new System.Drawing.Size(1159, 516);
            this.dgvGenerateOverallReport.TabIndex = 0;
            this.dgvGenerateOverallReport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvGenerateOverallReport;
            this.gridView1.Name = "gridView1";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage3,
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(1159, 591);
            this.tabPane1.SelectedPage = this.tabNavigationPage3;
            this.tabPane1.Size = new System.Drawing.Size(1159, 591);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "Chart By Batch";
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Chart By Batch";
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1159, 554);
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Chart By Student";
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1159, 554);
            // 
            // frmExamResultCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtsearch);
            this.Name = "frmExamResultCharts";
            this.Size = new System.Drawing.Size(1159, 591);
            ((System.ComponentModel.ISupportInitialize)(this.txtsearch)).EndInit();
            this.txtsearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenerateOverallReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane txtsearch;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl dgvGenerateOverallReport;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
    }
}
