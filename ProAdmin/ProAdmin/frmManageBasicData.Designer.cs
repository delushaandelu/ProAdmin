namespace ProAdmin
{
    partial class frmManageBasicData
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
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBatchView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBatch = new DevExpress.XtraEditors.TextEdit();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvUniversityView = new System.Windows.Forms.DataGridView();
            this.btnUniDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUniSave = new System.Windows.Forms.Button();
            this.txtUniversity = new DevExpress.XtraEditors.TextEdit();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage4 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.Log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvSchoolView = new System.Windows.Forms.DataGridView();
            this.btnSchoolDelete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSchoolSave = new System.Windows.Forms.Button();
            this.txtschool = new DevExpress.XtraEditors.TextEdit();
            this.schid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvSubjectView = new System.Windows.Forms.DataGridView();
            this.btnsubdelete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsubsave = new System.Windows.Forms.Button();
            this.txtsubject = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtteacher = new DevExpress.XtraEditors.TextEdit();
            this.subid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sublog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatch.Properties)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniversityView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUniversity.Properties)).BeginInit();
            this.tabNavigationPage3.SuspendLayout();
            this.tabNavigationPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchoolView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtschool.Properties)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtteacher.Properties)).BeginInit();
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
            this.groupBox1.Controls.Add(this.dgvBatchView);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtBatch);
            this.groupBox1.Location = new System.Drawing.Point(29, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 242);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Batch Settings";
            // 
            // dgvBatchView
            // 
            this.dgvBatchView.AllowUserToAddRows = false;
            this.dgvBatchView.AllowUserToDeleteRows = false;
            this.dgvBatchView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBatchView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatchView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.batchid,
            this.batch,
            this.Log});
            this.dgvBatchView.Location = new System.Drawing.Point(338, 19);
            this.dgvBatchView.Name = "dgvBatchView";
            this.dgvBatchView.ReadOnly = true;
            this.dgvBatchView.Size = new System.Drawing.Size(493, 204);
            this.dgvBatchView.TabIndex = 6;
            this.dgvBatchView.DoubleClick += new System.EventHandler(this.dgvBatchView_DoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(112, 84);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(206, 84);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
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
            this.btnSave.TabIndex = 1;
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
            this.tabNavigationPage2.Controls.Add(this.groupBox2);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1118, 624);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvUniversityView);
            this.groupBox2.Controls.Add(this.btnUniDelete);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnUniSave);
            this.groupBox2.Controls.Add(this.txtUniversity);
            this.groupBox2.Location = new System.Drawing.Point(29, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(848, 242);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "University Settings";
            // 
            // dgvUniversityView
            // 
            this.dgvUniversityView.AllowUserToAddRows = false;
            this.dgvUniversityView.AllowUserToDeleteRows = false;
            this.dgvUniversityView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUniversityView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUniversityView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uniid,
            this.uniname,
            this.dataGridViewTextBoxColumn3});
            this.dgvUniversityView.Location = new System.Drawing.Point(338, 19);
            this.dgvUniversityView.Name = "dgvUniversityView";
            this.dgvUniversityView.ReadOnly = true;
            this.dgvUniversityView.Size = new System.Drawing.Size(493, 204);
            this.dgvUniversityView.TabIndex = 6;
            this.dgvUniversityView.DoubleClick += new System.EventHandler(this.dgvUniversityView_DoubleClick);
            // 
            // btnUniDelete
            // 
            this.btnUniDelete.Enabled = false;
            this.btnUniDelete.Location = new System.Drawing.Point(118, 84);
            this.btnUniDelete.Name = "btnUniDelete";
            this.btnUniDelete.Size = new System.Drawing.Size(75, 23);
            this.btnUniDelete.TabIndex = 2;
            this.btnUniDelete.Text = "Delete";
            this.btnUniDelete.UseVisualStyleBackColor = true;
            this.btnUniDelete.Click += new System.EventHandler(this.btnUniDelete_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "University : ";
            // 
            // btnUniSave
            // 
            this.btnUniSave.Location = new System.Drawing.Point(24, 84);
            this.btnUniSave.Name = "btnUniSave";
            this.btnUniSave.Size = new System.Drawing.Size(75, 23);
            this.btnUniSave.TabIndex = 1;
            this.btnUniSave.Text = "Save";
            this.btnUniSave.UseVisualStyleBackColor = true;
            this.btnUniSave.Click += new System.EventHandler(this.btnUniSave_Click);
            // 
            // txtUniversity
            // 
            this.txtUniversity.Location = new System.Drawing.Point(84, 39);
            this.txtUniversity.Name = "txtUniversity";
            this.txtUniversity.Size = new System.Drawing.Size(208, 20);
            this.txtUniversity.TabIndex = 0;
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Manage School";
            this.tabNavigationPage3.Controls.Add(this.groupBox3);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1118, 624);
            // 
            // tabNavigationPage4
            // 
            this.tabNavigationPage4.Caption = "Manage Subject";
            this.tabNavigationPage4.Controls.Add(this.groupBox4);
            this.tabNavigationPage4.Name = "tabNavigationPage4";
            this.tabNavigationPage4.Size = new System.Drawing.Size(1118, 624);
            // 
            // Log
            // 
            this.Log.DataPropertyName = "log";
            this.Log.HeaderText = "Log";
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.Width = 200;
            // 
            // batch
            // 
            this.batch.DataPropertyName = "batch";
            this.batch.HeaderText = "Batch";
            this.batch.Name = "batch";
            this.batch.ReadOnly = true;
            // 
            // batchid
            // 
            this.batchid.DataPropertyName = "batchid";
            this.batchid.HeaderText = "Batch Id";
            this.batchid.Name = "batchid";
            this.batchid.ReadOnly = true;
            this.batchid.Visible = false;
            // 
            // uniid
            // 
            this.uniid.DataPropertyName = "uniid";
            this.uniid.HeaderText = "Uni ID";
            this.uniid.Name = "uniid";
            this.uniid.ReadOnly = true;
            this.uniid.Visible = false;
            // 
            // uniname
            // 
            this.uniname.DataPropertyName = "uniname";
            this.uniname.HeaderText = "University";
            this.uniname.Name = "uniname";
            this.uniname.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "log";
            this.dataGridViewTextBoxColumn3.HeaderText = "Log";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSchoolView);
            this.groupBox3.Controls.Add(this.btnSchoolDelete);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnSchoolSave);
            this.groupBox3.Controls.Add(this.txtschool);
            this.groupBox3.Location = new System.Drawing.Point(29, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(848, 242);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "School Settings";
            // 
            // dgvSchoolView
            // 
            this.dgvSchoolView.AllowUserToAddRows = false;
            this.dgvSchoolView.AllowUserToDeleteRows = false;
            this.dgvSchoolView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSchoolView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchoolView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.schid,
            this.schoolname,
            this.dataGridViewTextBoxColumn4});
            this.dgvSchoolView.Location = new System.Drawing.Point(338, 19);
            this.dgvSchoolView.Name = "dgvSchoolView";
            this.dgvSchoolView.ReadOnly = true;
            this.dgvSchoolView.Size = new System.Drawing.Size(493, 204);
            this.dgvSchoolView.TabIndex = 6;
            this.dgvSchoolView.DoubleClick += new System.EventHandler(this.dgvSchoolView_DoubleClick);
            // 
            // btnSchoolDelete
            // 
            this.btnSchoolDelete.Enabled = false;
            this.btnSchoolDelete.Location = new System.Drawing.Point(112, 84);
            this.btnSchoolDelete.Name = "btnSchoolDelete";
            this.btnSchoolDelete.Size = new System.Drawing.Size(75, 23);
            this.btnSchoolDelete.TabIndex = 2;
            this.btnSchoolDelete.Text = "Delete";
            this.btnSchoolDelete.UseVisualStyleBackColor = true;
            this.btnSchoolDelete.Click += new System.EventHandler(this.btnSchoolDelete_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(206, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "School : ";
            // 
            // btnSchoolSave
            // 
            this.btnSchoolSave.Location = new System.Drawing.Point(18, 84);
            this.btnSchoolSave.Name = "btnSchoolSave";
            this.btnSchoolSave.Size = new System.Drawing.Size(75, 23);
            this.btnSchoolSave.TabIndex = 1;
            this.btnSchoolSave.Text = "Save";
            this.btnSchoolSave.UseVisualStyleBackColor = true;
            this.btnSchoolSave.Click += new System.EventHandler(this.btnSchoolSave_Click);
            // 
            // txtschool
            // 
            this.txtschool.Location = new System.Drawing.Point(73, 39);
            this.txtschool.Name = "txtschool";
            this.txtschool.Size = new System.Drawing.Size(208, 20);
            this.txtschool.TabIndex = 0;
            // 
            // schid
            // 
            this.schid.DataPropertyName = "schid";
            this.schid.HeaderText = "School ID";
            this.schid.Name = "schid";
            this.schid.ReadOnly = true;
            this.schid.Visible = false;
            // 
            // schoolname
            // 
            this.schoolname.DataPropertyName = "schoolname";
            this.schoolname.HeaderText = "School Name";
            this.schoolname.Name = "schoolname";
            this.schoolname.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "log";
            this.dataGridViewTextBoxColumn4.HeaderText = "Log";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtteacher);
            this.groupBox4.Controls.Add(this.dgvSubjectView);
            this.groupBox4.Controls.Add(this.btnsubdelete);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnsubsave);
            this.groupBox4.Controls.Add(this.txtsubject);
            this.groupBox4.Location = new System.Drawing.Point(29, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(848, 242);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Subject Settings";
            // 
            // dgvSubjectView
            // 
            this.dgvSubjectView.AllowUserToAddRows = false;
            this.dgvSubjectView.AllowUserToDeleteRows = false;
            this.dgvSubjectView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSubjectView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjectView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subid,
            this.subject,
            this.teacher,
            this.sublog});
            this.dgvSubjectView.Location = new System.Drawing.Point(338, 19);
            this.dgvSubjectView.Name = "dgvSubjectView";
            this.dgvSubjectView.ReadOnly = true;
            this.dgvSubjectView.Size = new System.Drawing.Size(493, 204);
            this.dgvSubjectView.TabIndex = 6;
            this.dgvSubjectView.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // btnsubdelete
            // 
            this.btnsubdelete.Enabled = false;
            this.btnsubdelete.Location = new System.Drawing.Point(112, 107);
            this.btnsubdelete.Name = "btnsubdelete";
            this.btnsubdelete.Size = new System.Drawing.Size(75, 23);
            this.btnsubdelete.TabIndex = 3;
            this.btnsubdelete.Text = "Delete";
            this.btnsubdelete.UseVisualStyleBackColor = true;
            this.btnsubdelete.Click += new System.EventHandler(this.btnsubdelete_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(206, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "School : ";
            // 
            // btnsubsave
            // 
            this.btnsubsave.Location = new System.Drawing.Point(18, 107);
            this.btnsubsave.Name = "btnsubsave";
            this.btnsubsave.Size = new System.Drawing.Size(75, 23);
            this.btnsubsave.TabIndex = 2;
            this.btnsubsave.Text = "Save";
            this.btnsubsave.UseVisualStyleBackColor = true;
            this.btnsubsave.Click += new System.EventHandler(this.btnsubsave_Click);
            // 
            // txtsubject
            // 
            this.txtsubject.Location = new System.Drawing.Point(73, 39);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(208, 20);
            this.txtsubject.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Teacher :";
            // 
            // txtteacher
            // 
            this.txtteacher.Location = new System.Drawing.Point(73, 65);
            this.txtteacher.Name = "txtteacher";
            this.txtteacher.Size = new System.Drawing.Size(208, 20);
            this.txtteacher.TabIndex = 1;
            // 
            // subid
            // 
            this.subid.DataPropertyName = "subid";
            this.subid.HeaderText = "subid";
            this.subid.Name = "subid";
            this.subid.ReadOnly = true;
            this.subid.Visible = false;
            // 
            // subject
            // 
            this.subject.DataPropertyName = "subject";
            this.subject.HeaderText = "subject";
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            // 
            // teacher
            // 
            this.teacher.DataPropertyName = "teacher";
            this.teacher.HeaderText = "teacher";
            this.teacher.Name = "teacher";
            this.teacher.ReadOnly = true;
            // 
            // sublog
            // 
            this.sublog.DataPropertyName = "log";
            this.sublog.HeaderText = "Log";
            this.sublog.Name = "sublog";
            this.sublog.ReadOnly = true;
            // 
            // frmManageBasicData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPane1);
            this.Name = "frmManageBasicData";
            this.Size = new System.Drawing.Size(1118, 661);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatch.Properties)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniversityView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUniversity.Properties)).EndInit();
            this.tabNavigationPage3.ResumeLayout(false);
            this.tabNavigationPage4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchoolView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtschool.Properties)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtteacher.Properties)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvBatchView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvUniversityView;
        private System.Windows.Forms.Button btnUniDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUniSave;
        private DevExpress.XtraEditors.TextEdit txtUniversity;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchid;
        private System.Windows.Forms.DataGridViewTextBoxColumn batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Log;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniid;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvSchoolView;
        private System.Windows.Forms.Button btnSchoolDelete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSchoolSave;
        private DevExpress.XtraEditors.TextEdit txtschool;
        private System.Windows.Forms.DataGridViewTextBoxColumn schid;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvSubjectView;
        private System.Windows.Forms.Button btnsubdelete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsubsave;
        private DevExpress.XtraEditors.TextEdit txtsubject;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtteacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn subid;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn sublog;
    }
}
