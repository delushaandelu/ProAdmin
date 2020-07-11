namespace ProAdmin
{
    partial class frmExamResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExamResults));
            this.txtsearch = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvStudentResultData = new System.Windows.Forms.DataGridView();
            this.exam_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.average_marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avg_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.English = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.git = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.txtschool = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbatch = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.txtstudentname = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtavgstate = new DevExpress.XtraEditors.TextEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btngenerate = new System.Windows.Forms.Button();
            this.txtaverage = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttotal = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtgit = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtenglish = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsubject3 = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsubject2 = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsubject1 = new DevExpress.XtraEditors.TextEdit();
            this.btnexamsearch = new System.Windows.Forms.Button();
            this.btnstudentsearch = new System.Windows.Forms.Button();
            this.cmbexam = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstudentid = new DevExpress.XtraEditors.TextEdit();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvGenerateOverallReport = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbgenbatch = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbgenexam = new System.Windows.Forms.ComboBox();
            this.btngenReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtsearch)).BeginInit();
            this.txtsearch.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentResultData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtschool.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbatch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstudentname.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtavgstate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaverage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtenglish.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsubject3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsubject2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsubject1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstudentid.Properties)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenerateOverallReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Controls.Add(this.tabNavigationPage1);
            this.txtsearch.Controls.Add(this.tabNavigationPage2);
            this.txtsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtsearch.Location = new System.Drawing.Point(0, 0);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.txtsearch.RegularSize = new System.Drawing.Size(1239, 629);
            this.txtsearch.SelectedPage = this.tabNavigationPage1;
            this.txtsearch.Size = new System.Drawing.Size(1239, 629);
            this.txtsearch.TabIndex = 8;
            this.txtsearch.Text = "Manage User Information";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Manage Marks Sheet";
            this.tabNavigationPage1.Controls.Add(this.groupBox4);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1239, 592);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Controls.Add(this.dgvStudentResultData);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtschool);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtbatch);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtstudentname);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.btnexamsearch);
            this.groupBox4.Controls.Add(this.btnstudentsearch);
            this.groupBox4.Controls.Add(this.cmbexam);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtstudentid);
            this.groupBox4.Location = new System.Drawing.Point(32, 36);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1195, 449);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Exam Data";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRefresh.Location = new System.Drawing.Point(506, 163);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(31, 29);
            this.btnRefresh.TabIndex = 85;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvStudentResultData
            // 
            this.dgvStudentResultData.AllowUserToAddRows = false;
            this.dgvStudentResultData.AllowUserToDeleteRows = false;
            this.dgvStudentResultData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStudentResultData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentResultData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exam_date,
            this.exam,
            this.subject_1,
            this.subject_2,
            this.subject_3,
            this.total_marks,
            this.average_marks,
            this.avg_state,
            this.English,
            this.git});
            this.dgvStudentResultData.Location = new System.Drawing.Point(499, 160);
            this.dgvStudentResultData.Name = "dgvStudentResultData";
            this.dgvStudentResultData.ReadOnly = true;
            this.dgvStudentResultData.Size = new System.Drawing.Size(679, 257);
            this.dgvStudentResultData.TabIndex = 84;
            // 
            // exam_date
            // 
            this.exam_date.DataPropertyName = "exam_date";
            this.exam_date.HeaderText = "Exam Date";
            this.exam_date.Name = "exam_date";
            this.exam_date.ReadOnly = true;
            // 
            // exam
            // 
            this.exam.DataPropertyName = "exam";
            this.exam.HeaderText = "Exam";
            this.exam.Name = "exam";
            this.exam.ReadOnly = true;
            // 
            // subject_1
            // 
            this.subject_1.DataPropertyName = "subject_1";
            this.subject_1.HeaderText = "Economics";
            this.subject_1.Name = "subject_1";
            this.subject_1.ReadOnly = true;
            // 
            // subject_2
            // 
            this.subject_2.DataPropertyName = "subject_2";
            this.subject_2.HeaderText = "Business Studies";
            this.subject_2.Name = "subject_2";
            this.subject_2.ReadOnly = true;
            // 
            // subject_3
            // 
            this.subject_3.DataPropertyName = "subject_3";
            this.subject_3.HeaderText = "Accouniting";
            this.subject_3.Name = "subject_3";
            this.subject_3.ReadOnly = true;
            // 
            // total_marks
            // 
            this.total_marks.DataPropertyName = "total_marks";
            this.total_marks.HeaderText = "Total Marks";
            this.total_marks.Name = "total_marks";
            this.total_marks.ReadOnly = true;
            // 
            // average_marks
            // 
            this.average_marks.DataPropertyName = "average_marks";
            this.average_marks.HeaderText = "Average Marks";
            this.average_marks.Name = "average_marks";
            this.average_marks.ReadOnly = true;
            // 
            // avg_state
            // 
            this.avg_state.DataPropertyName = "avg_state";
            this.avg_state.HeaderText = "Average State";
            this.avg_state.Name = "avg_state";
            this.avg_state.ReadOnly = true;
            // 
            // English
            // 
            this.English.DataPropertyName = "English";
            this.English.HeaderText = "English";
            this.English.Name = "English";
            this.English.ReadOnly = true;
            // 
            // git
            // 
            this.git.DataPropertyName = "git";
            this.git.HeaderText = "Git";
            this.git.Name = "git";
            this.git.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(446, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 83;
            this.label12.Text = "School";
            // 
            // txtschool
            // 
            this.txtschool.Enabled = false;
            this.txtschool.Location = new System.Drawing.Point(499, 79);
            this.txtschool.Name = "txtschool";
            this.txtschool.Size = new System.Drawing.Size(169, 20);
            this.txtschool.TabIndex = 82;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(252, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 81;
            this.label11.Text = "Batch";
            // 
            // txtbatch
            // 
            this.txtbatch.Enabled = false;
            this.txtbatch.Location = new System.Drawing.Point(293, 79);
            this.txtbatch.Name = "txtbatch";
            this.txtbatch.Size = new System.Drawing.Size(120, 20);
            this.txtbatch.TabIndex = 80;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 79;
            this.label10.Text = "Student Name";
            // 
            // txtstudentname
            // 
            this.txtstudentname.Enabled = false;
            this.txtstudentname.Location = new System.Drawing.Point(97, 79);
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(120, 20);
            this.txtstudentname.TabIndex = 78;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtavgstate);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btngenerate);
            this.groupBox1.Controls.Add(this.txtaverage);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txttotal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtgit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtenglish);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtsubject3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtsubject2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtsubject1);
            this.groupBox1.Location = new System.Drawing.Point(19, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 263);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exam Data";
            // 
            // txtavgstate
            // 
            this.txtavgstate.EditValue = "0";
            this.txtavgstate.Enabled = false;
            this.txtavgstate.Location = new System.Drawing.Point(334, 116);
            this.txtavgstate.Name = "txtavgstate";
            this.txtavgstate.Size = new System.Drawing.Size(90, 20);
            this.txtavgstate.TabIndex = 95;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(253, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 94;
            this.label13.Text = "Average State";
            // 
            // btnclear
            // 
            this.btnclear.Enabled = false;
            this.btnclear.Location = new System.Drawing.Point(365, 142);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(80, 23);
            this.btnclear.TabIndex = 93;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Enabled = false;
            this.btnupdate.Location = new System.Drawing.Point(262, 142);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(80, 23);
            this.btnupdate.TabIndex = 92;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btngenerate
            // 
            this.btngenerate.Enabled = false;
            this.btngenerate.Location = new System.Drawing.Point(42, 142);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(188, 23);
            this.btngenerate.TabIndex = 91;
            this.btngenerate.Text = "Generate Total and Average";
            this.btngenerate.UseVisualStyleBackColor = true;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // txtaverage
            // 
            this.txtaverage.EditValue = "0";
            this.txtaverage.Enabled = false;
            this.txtaverage.Location = new System.Drawing.Point(334, 75);
            this.txtaverage.Name = "txtaverage";
            this.txtaverage.Size = new System.Drawing.Size(90, 20);
            this.txtaverage.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "Average";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 88;
            this.label8.Text = "Total";
            // 
            // txttotal
            // 
            this.txttotal.EditValue = "0";
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(334, 32);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(90, 20);
            this.txttotal.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "GIT";
            // 
            // txtgit
            // 
            this.txtgit.EditValue = "0";
            this.txtgit.Enabled = false;
            this.txtgit.Location = new System.Drawing.Point(140, 219);
            this.txtgit.Name = "txtgit";
            this.txtgit.Size = new System.Drawing.Size(90, 20);
            this.txtgit.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "English";
            // 
            // txtenglish
            // 
            this.txtenglish.EditValue = "0";
            this.txtenglish.Enabled = false;
            this.txtenglish.Location = new System.Drawing.Point(140, 183);
            this.txtenglish.Name = "txtenglish";
            this.txtenglish.Size = new System.Drawing.Size(90, 20);
            this.txtenglish.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Accounting";
            // 
            // txtsubject3
            // 
            this.txtsubject3.EditValue = "0";
            this.txtsubject3.Enabled = false;
            this.txtsubject3.Location = new System.Drawing.Point(140, 108);
            this.txtsubject3.Name = "txtsubject3";
            this.txtsubject3.Size = new System.Drawing.Size(90, 20);
            this.txtsubject3.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Business Studies";
            // 
            // txtsubject2
            // 
            this.txtsubject2.EditValue = "0";
            this.txtsubject2.Enabled = false;
            this.txtsubject2.Location = new System.Drawing.Point(140, 69);
            this.txtsubject2.Name = "txtsubject2";
            this.txtsubject2.Size = new System.Drawing.Size(90, 20);
            this.txtsubject2.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Economics";
            // 
            // txtsubject1
            // 
            this.txtsubject1.EditValue = "0";
            this.txtsubject1.Enabled = false;
            this.txtsubject1.Location = new System.Drawing.Point(140, 32);
            this.txtsubject1.Name = "txtsubject1";
            this.txtsubject1.Size = new System.Drawing.Size(90, 20);
            this.txtsubject1.TabIndex = 77;
            // 
            // btnexamsearch
            // 
            this.btnexamsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexamsearch.BackgroundImage")));
            this.btnexamsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnexamsearch.Enabled = false;
            this.btnexamsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexamsearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnexamsearch.Location = new System.Drawing.Point(688, 21);
            this.btnexamsearch.Name = "btnexamsearch";
            this.btnexamsearch.Size = new System.Drawing.Size(31, 29);
            this.btnexamsearch.TabIndex = 62;
            this.btnexamsearch.UseVisualStyleBackColor = true;
            this.btnexamsearch.Click += new System.EventHandler(this.btnexamsearch_Click);
            // 
            // btnstudentsearch
            // 
            this.btnstudentsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnstudentsearch.BackgroundImage")));
            this.btnstudentsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnstudentsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstudentsearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnstudentsearch.Location = new System.Drawing.Point(309, 21);
            this.btnstudentsearch.Name = "btnstudentsearch";
            this.btnstudentsearch.Size = new System.Drawing.Size(31, 29);
            this.btnstudentsearch.TabIndex = 61;
            this.btnstudentsearch.UseVisualStyleBackColor = true;
            this.btnstudentsearch.Click += new System.EventHandler(this.btnstudentsearch_Click);
            // 
            // cmbexam
            // 
            this.cmbexam.Enabled = false;
            this.cmbexam.FormattingEnabled = true;
            this.cmbexam.Location = new System.Drawing.Point(411, 26);
            this.cmbexam.Name = "cmbexam";
            this.cmbexam.Size = new System.Drawing.Size(257, 21);
            this.cmbexam.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Exam ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Student ID";
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(97, 26);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(208, 20);
            this.txtstudentid.TabIndex = 0;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Over All Mark Sheet";
            this.tabNavigationPage2.Controls.Add(this.splitContainer1);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1239, 592);
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
            this.splitContainer1.Panel1.Controls.Add(this.btngenReport);
            this.splitContainer1.Panel1.Controls.Add(this.label15);
            this.splitContainer1.Panel1.Controls.Add(this.cmbgenexam);
            this.splitContainer1.Panel1.Controls.Add(this.label14);
            this.splitContainer1.Panel1.Controls.Add(this.cmbgenbatch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvGenerateOverallReport);
            this.splitContainer1.Size = new System.Drawing.Size(1239, 592);
            this.splitContainer1.SplitterDistance = 37;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvGenerateOverallReport
            // 
            this.dgvGenerateOverallReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGenerateOverallReport.Location = new System.Drawing.Point(0, 0);
            this.dgvGenerateOverallReport.MainView = this.gridView1;
            this.dgvGenerateOverallReport.Name = "dgvGenerateOverallReport";
            this.dgvGenerateOverallReport.Size = new System.Drawing.Size(1239, 551);
            this.dgvGenerateOverallReport.TabIndex = 0;
            this.dgvGenerateOverallReport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvGenerateOverallReport;
            this.gridView1.Name = "gridView1";
            // 
            // cmbgenbatch
            // 
            this.cmbgenbatch.FormattingEnabled = true;
            this.cmbgenbatch.Location = new System.Drawing.Point(75, 11);
            this.cmbgenbatch.Name = "cmbgenbatch";
            this.cmbgenbatch.Size = new System.Drawing.Size(159, 21);
            this.cmbgenbatch.TabIndex = 1;
            this.cmbgenbatch.SelectedValueChanged += new System.EventHandler(this.cmbgenbatch_SelectedValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Batch";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(271, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Exam";
            // 
            // cmbgenexam
            // 
            this.cmbgenexam.FormattingEnabled = true;
            this.cmbgenexam.Location = new System.Drawing.Point(310, 11);
            this.cmbgenexam.Name = "cmbgenexam";
            this.cmbgenexam.Size = new System.Drawing.Size(347, 21);
            this.cmbgenexam.TabIndex = 3;
            // 
            // btngenReport
            // 
            this.btngenReport.Location = new System.Drawing.Point(681, 9);
            this.btngenReport.Name = "btngenReport";
            this.btngenReport.Size = new System.Drawing.Size(96, 23);
            this.btngenReport.TabIndex = 5;
            this.btngenReport.Text = "Generate";
            this.btngenReport.UseVisualStyleBackColor = true;
            this.btngenReport.Click += new System.EventHandler(this.btngenReport_Click);
            // 
            // frmExamResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtsearch);
            this.Name = "frmExamResults";
            this.Size = new System.Drawing.Size(1239, 629);
            ((System.ComponentModel.ISupportInitialize)(this.txtsearch)).EndInit();
            this.txtsearch.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentResultData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtschool.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbatch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstudentname.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtavgstate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaverage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtenglish.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsubject3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsubject2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsubject1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstudentid.Properties)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenerateOverallReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane txtsearch;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbexam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtstudentid;
        private System.Windows.Forms.Button btnexamsearch;
        private System.Windows.Forms.Button btnstudentsearch;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtstudentname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btngenerate;
        private DevExpress.XtraEditors.TextEdit txtaverage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txttotal;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtgit;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtenglish;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtsubject3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtsubject2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtsubject1;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.TextEdit txtschool;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit txtbatch;
        private System.Windows.Forms.DataGridView dgvStudentResultData;
        private System.Windows.Forms.Button btnclear;
        private DevExpress.XtraEditors.TextEdit txtavgstate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_marks;
        private System.Windows.Forms.DataGridViewTextBoxColumn average_marks;
        private System.Windows.Forms.DataGridViewTextBoxColumn avg_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn English;
        private System.Windows.Forms.DataGridViewTextBoxColumn git;
        private System.Windows.Forms.Button btnRefresh;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbgenexam;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbgenbatch;
        private DevExpress.XtraGrid.GridControl dgvGenerateOverallReport;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btngenReport;
    }
}
