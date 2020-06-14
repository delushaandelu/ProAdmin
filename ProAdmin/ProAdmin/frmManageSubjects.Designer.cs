namespace ProAdmin
{
    partial class frmManageSubjects
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBatch = new DevExpress.XtraGrid.GridControl();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBatch = new DevExpress.XtraEditors.TextEdit();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage4 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BatchId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Batch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastModified = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Controls.Add(this.tabNavigationPage4);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3,
            this.tabNavigationPage4});
            this.tabPane1.RegularSize = new System.Drawing.Size(1118, 661);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1118, 661);
            this.tabPane1.TabIndex = 5;
            this.tabPane1.Text = "Manage Subjects";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Manage Batch";
            this.tabNavigationPage1.Controls.Add(this.groupBox1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1118, 624);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBatch);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtBatch);
            this.groupBox1.Location = new System.Drawing.Point(26, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 242);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // dgvBatch
            // 
            gridLevelNode1.RelationName = "Level1";
            this.dgvBatch.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgvBatch.Location = new System.Drawing.Point(304, 19);
            this.dgvBatch.MainView = this.gridView1;
            this.dgvBatch.Name = "dgvBatch";
            this.dgvBatch.Size = new System.Drawing.Size(523, 207);
            this.dgvBatch.TabIndex = 6;
            this.dgvBatch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1,
            this.gridView1});
            this.dgvBatch.DoubleClick += new System.EventHandler(this.dgvBatch_DoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(112, 84);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(206, 84);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Batch : ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 84);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBatch
            // 
            this.txtBatch.Location = new System.Drawing.Point(73, 39);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(208, 20);
            this.txtBatch.TabIndex = 0;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Manage University";
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1118, 624);
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Manage School";
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1118, 624);
            // 
            // tabNavigationPage4
            // 
            this.tabNavigationPage4.Caption = "Manage Subject";
            this.tabNavigationPage4.Name = "tabNavigationPage4";
            this.tabNavigationPage4.Size = new System.Drawing.Size(1118, 624);
            // 
            // tileView1
            // 
            this.tileView1.GridControl = this.dgvBatch;
            this.tileView1.Name = "tileView1";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BatchId,
            this.Batch,
            this.LastModified});
            this.gridView1.GridControl = this.dgvBatch;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // BatchId
            // 
            this.BatchId.FieldName = "batchid";
            this.BatchId.Name = "BatchId";
            this.BatchId.Visible = true;
            this.BatchId.VisibleIndex = 0;
            // 
            // Batch
            // 
            this.Batch.FieldName = "batch";
            this.Batch.Name = "Batch";
            this.Batch.Visible = true;
            this.Batch.VisibleIndex = 1;
            // 
            // LastModified
            // 
            this.LastModified.FieldName = "log";
            this.LastModified.Name = "LastModified";
            this.LastModified.Visible = true;
            this.LastModified.VisibleIndex = 2;
            // 
            // frmManageSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPane1);
            this.Name = "frmManageSubjects";
            this.Size = new System.Drawing.Size(1118, 661);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage4;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtBatch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private DevExpress.XtraGrid.GridControl dgvBatch;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn BatchId;
        private DevExpress.XtraGrid.Columns.GridColumn Batch;
        private DevExpress.XtraGrid.Columns.GridColumn LastModified;
    }
}
