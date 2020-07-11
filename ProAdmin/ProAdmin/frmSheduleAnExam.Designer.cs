namespace ProAdmin
{
    partial class frmSheduleAnExam
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbbatch = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbexamtype = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbstate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpenddate = new System.Windows.Forms.DateTimePicker();
            this.dtpstartdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvExamSchedule = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exam_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsubdelete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsubsave = new System.Windows.Forms.Button();
            this.txtexam = new DevExpress.XtraEditors.TextEdit();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.dgvAllExam = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.txtsearch)).BeginInit();
            this.txtsearch.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtexam.Properties)).BeginInit();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Controls.Add(this.tabNavigationPage2);
            this.txtsearch.Controls.Add(this.tabNavigationPage1);
            this.txtsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtsearch.Location = new System.Drawing.Point(0, 0);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage2,
            this.tabNavigationPage1});
            this.txtsearch.RegularSize = new System.Drawing.Size(1070, 536);
            this.txtsearch.SelectedPage = this.tabNavigationPage2;
            this.txtsearch.Size = new System.Drawing.Size(1070, 536);
            this.txtsearch.TabIndex = 8;
            this.txtsearch.Text = "Schedule an Exam";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Schedule an Exam";
            this.tabNavigationPage2.Controls.Add(this.groupBox4);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1070, 499);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbbatch);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cmbexamtype);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.cmbstate);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.dtpenddate);
            this.groupBox4.Controls.Add(this.dtpstartdate);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.dgvExamSchedule);
            this.groupBox4.Controls.Add(this.btnsubdelete);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnsubsave);
            this.groupBox4.Controls.Add(this.txtexam);
            this.groupBox4.Location = new System.Drawing.Point(18, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1033, 312);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Exam Data";
            // 
            // cmbbatch
            // 
            this.cmbbatch.FormattingEnabled = true;
            this.cmbbatch.Location = new System.Drawing.Point(86, 68);
            this.cmbbatch.Name = "cmbbatch";
            this.cmbbatch.Size = new System.Drawing.Size(208, 21);
            this.cmbbatch.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Batch";
            // 
            // cmbexamtype
            // 
            this.cmbexamtype.FormattingEnabled = true;
            this.cmbexamtype.Items.AddRange(new object[] {
            "TERM_EXAM",
            "MONTHELY_EXAM"});
            this.cmbexamtype.Location = new System.Drawing.Point(86, 183);
            this.cmbexamtype.Name = "cmbexamtype";
            this.cmbexamtype.Size = new System.Drawing.Size(208, 21);
            this.cmbexamtype.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Exam Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Eg : (YEAR_MONTH) - 2020_01";
            // 
            // cmbstate
            // 
            this.cmbstate.FormattingEnabled = true;
            this.cmbstate.Items.AddRange(new object[] {
            "Active",
            "Closed"});
            this.cmbstate.Location = new System.Drawing.Point(86, 152);
            this.cmbstate.Name = "cmbstate";
            this.cmbstate.Size = new System.Drawing.Size(208, 21);
            this.cmbstate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Active";
            // 
            // dtpenddate
            // 
            this.dtpenddate.Location = new System.Drawing.Point(85, 123);
            this.dtpenddate.Name = "dtpenddate";
            this.dtpenddate.Size = new System.Drawing.Size(208, 20);
            this.dtpenddate.TabIndex = 2;
            // 
            // dtpstartdate
            // 
            this.dtpstartdate.Location = new System.Drawing.Point(86, 95);
            this.dtpstartdate.Name = "dtpstartdate";
            this.dtpstartdate.Size = new System.Drawing.Size(208, 20);
            this.dtpstartdate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Start Date";
            // 
            // dgvExamSchedule
            // 
            this.dgvExamSchedule.AllowUserToAddRows = false;
            this.dgvExamSchedule.AllowUserToDeleteRows = false;
            this.dgvExamSchedule.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvExamSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.exam,
            this.batch,
            this.start_date,
            this.end_date,
            this.state,
            this.exam_type});
            this.dgvExamSchedule.Location = new System.Drawing.Point(338, 19);
            this.dgvExamSchedule.Name = "dgvExamSchedule";
            this.dgvExamSchedule.ReadOnly = true;
            this.dgvExamSchedule.Size = new System.Drawing.Size(679, 221);
            this.dgvExamSchedule.TabIndex = 8;
            this.dgvExamSchedule.DoubleClick += new System.EventHandler(this.dgvExamSchedule_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // exam
            // 
            this.exam.DataPropertyName = "exam";
            this.exam.HeaderText = "exam";
            this.exam.Name = "exam";
            this.exam.ReadOnly = true;
            // 
            // batch
            // 
            this.batch.DataPropertyName = "batch";
            this.batch.HeaderText = "batch";
            this.batch.Name = "batch";
            this.batch.ReadOnly = true;
            // 
            // start_date
            // 
            this.start_date.DataPropertyName = "start_date";
            this.start_date.HeaderText = "start_date";
            this.start_date.Name = "start_date";
            this.start_date.ReadOnly = true;
            // 
            // end_date
            // 
            this.end_date.DataPropertyName = "end_date";
            this.end_date.HeaderText = "end_date";
            this.end_date.Name = "end_date";
            this.end_date.ReadOnly = true;
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "state";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // exam_type
            // 
            this.exam_type.DataPropertyName = "exam_type";
            this.exam_type.HeaderText = "exam_type";
            this.exam_type.Name = "exam_type";
            this.exam_type.ReadOnly = true;
            // 
            // btnsubdelete
            // 
            this.btnsubdelete.Enabled = false;
            this.btnsubdelete.Location = new System.Drawing.Point(116, 223);
            this.btnsubdelete.Name = "btnsubdelete";
            this.btnsubdelete.Size = new System.Drawing.Size(75, 23);
            this.btnsubdelete.TabIndex = 6;
            this.btnsubdelete.Text = "Delete";
            this.btnsubdelete.UseVisualStyleBackColor = true;
            this.btnsubdelete.Click += new System.EventHandler(this.btnsubdelete_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(210, 223);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Exam ID";
            // 
            // btnsubsave
            // 
            this.btnsubsave.Location = new System.Drawing.Point(22, 223);
            this.btnsubsave.Name = "btnsubsave";
            this.btnsubsave.Size = new System.Drawing.Size(75, 23);
            this.btnsubsave.TabIndex = 5;
            this.btnsubsave.Text = "Save";
            this.btnsubsave.UseVisualStyleBackColor = true;
            this.btnsubsave.Click += new System.EventHandler(this.btnsubsave_Click);
            // 
            // txtexam
            // 
            this.txtexam.Location = new System.Drawing.Point(86, 26);
            this.txtexam.Name = "txtexam";
            this.txtexam.Size = new System.Drawing.Size(208, 20);
            this.txtexam.TabIndex = 0;
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Exam Schedules Rich View";
            this.tabNavigationPage1.Controls.Add(this.dgvAllExam);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1070, 499);
            // 
            // dgvAllExam
            // 
            this.dgvAllExam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllExam.Location = new System.Drawing.Point(0, 0);
            this.dgvAllExam.MainView = this.gridView1;
            this.dgvAllExam.Name = "dgvAllExam";
            this.dgvAllExam.Size = new System.Drawing.Size(1070, 499);
            this.dgvAllExam.TabIndex = 1;
            this.dgvAllExam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvAllExam;
            this.gridView1.Name = "gridView1";
            // 
            // frmSheduleAnExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtsearch);
            this.Name = "frmSheduleAnExam";
            this.Size = new System.Drawing.Size(1070, 536);
            ((System.ComponentModel.ISupportInitialize)(this.txtsearch)).EndInit();
            this.txtsearch.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtexam.Properties)).EndInit();
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane txtsearch;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpenddate;
        private System.Windows.Forms.DateTimePicker dtpstartdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvExamSchedule;
        private System.Windows.Forms.Button btnsubdelete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsubsave;
        private DevExpress.XtraEditors.TextEdit txtexam;
        private System.Windows.Forms.ComboBox cmbstate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbexamtype;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam;
        private System.Windows.Forms.DataGridViewTextBoxColumn batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam_type;
        private System.Windows.Forms.ComboBox cmbbatch;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraGrid.GridControl dgvAllExam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
