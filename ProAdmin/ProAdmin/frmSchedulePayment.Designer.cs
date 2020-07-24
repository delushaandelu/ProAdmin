namespace ProAdmin
{
    partial class frmSchedulePayment
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
            this.cmbsearchbybatch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtyear = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmonth = new DevExpress.XtraScheduler.UI.MonthEdit();
            this.dgvpaymentschedule = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.cmbbatch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feemonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblmonth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtyear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpaymentschedule)).BeginInit();
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
            this.tabPane1.RegularSize = new System.Drawing.Size(1254, 691);
            this.tabPane1.SelectedPage = this.tabNavigationPage3;
            this.tabPane1.Size = new System.Drawing.Size(1254, 691);
            this.tabPane1.TabIndex = 8;
            this.tabPane1.Text = "Manage Payment Schedule";
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Manage Class Shedules";
            this.tabNavigationPage3.Controls.Add(this.groupControl1);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1254, 654);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblmonth);
            this.groupControl1.Controls.Add(this.cmbsearchbybatch);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txtyear);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtmonth);
            this.groupControl1.Controls.Add(this.dgvpaymentschedule);
            this.groupControl1.Controls.Add(this.btndelete);
            this.groupControl1.Controls.Add(this.btnsave);
            this.groupControl1.Controls.Add(this.cmbbatch);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Location = new System.Drawing.Point(27, 23);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1081, 591);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Control";
            // 
            // cmbsearchbybatch
            // 
            this.cmbsearchbybatch.FormattingEnabled = true;
            this.cmbsearchbybatch.Location = new System.Drawing.Point(342, 107);
            this.cmbsearchbybatch.Name = "cmbsearchbybatch";
            this.cmbsearchbybatch.Size = new System.Drawing.Size(204, 21);
            this.cmbsearchbybatch.TabIndex = 65;
            this.cmbsearchbybatch.SelectedValueChanged += new System.EventHandler(this.cmbsearchbybatch_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Search by Batch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Year";
            // 
            // txtyear
            // 
            this.txtyear.Enabled = false;
            this.txtyear.Location = new System.Drawing.Point(251, 55);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(100, 20);
            this.txtyear.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Month";
            // 
            // txtmonth
            // 
            this.txtmonth.Location = new System.Drawing.Point(71, 55);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtmonth.Size = new System.Drawing.Size(100, 20);
            this.txtmonth.TabIndex = 60;
            // 
            // dgvpaymentschedule
            // 
            this.dgvpaymentschedule.AllowUserToAddRows = false;
            this.dgvpaymentschedule.AllowUserToDeleteRows = false;
            this.dgvpaymentschedule.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvpaymentschedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpaymentschedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.batch,
            this.feemonth,
            this.year,
            this.state});
            this.dgvpaymentschedule.Location = new System.Drawing.Point(21, 139);
            this.dgvpaymentschedule.Name = "dgvpaymentschedule";
            this.dgvpaymentschedule.ReadOnly = true;
            this.dgvpaymentschedule.Size = new System.Drawing.Size(826, 428);
            this.dgvpaymentschedule.TabIndex = 58;
            this.dgvpaymentschedule.DoubleClick += new System.EventHandler(this.dgvpaymentschedule_DoubleClick);
            // 
            // btndelete
            // 
            this.btndelete.Enabled = false;
            this.btndelete.Location = new System.Drawing.Point(772, 53);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(691, 53);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // cmbbatch
            // 
            this.cmbbatch.FormattingEnabled = true;
            this.cmbbatch.Location = new System.Drawing.Point(421, 55);
            this.cmbbatch.Name = "cmbbatch";
            this.cmbbatch.Size = new System.Drawing.Size(204, 21);
            this.cmbbatch.TabIndex = 6;
            this.cmbbatch.SelectedValueChanged += new System.EventHandler(this.cmbbatch_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Batch";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // batch
            // 
            this.batch.DataPropertyName = "batch";
            this.batch.HeaderText = "Batch";
            this.batch.Name = "batch";
            this.batch.ReadOnly = true;
            // 
            // feemonth
            // 
            this.feemonth.DataPropertyName = "feemonth";
            this.feemonth.HeaderText = "Month";
            this.feemonth.Name = "feemonth";
            this.feemonth.ReadOnly = true;
            // 
            // year
            // 
            this.year.DataPropertyName = "year";
            this.year.HeaderText = "Year";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "State";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // lblmonth
            // 
            this.lblmonth.AutoSize = true;
            this.lblmonth.Location = new System.Drawing.Point(78, 58);
            this.lblmonth.Name = "lblmonth";
            this.lblmonth.Size = new System.Drawing.Size(0, 13);
            this.lblmonth.TabIndex = 66;
            // 
            // frmSchedulePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPane1);
            this.Name = "frmSchedulePayment";
            this.Size = new System.Drawing.Size(1254, 691);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtyear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpaymentschedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvpaymentschedule;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox cmbbatch;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraScheduler.UI.MonthEdit txtmonth;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtyear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbsearchbybatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn feemonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.Label lblmonth;
    }
}
