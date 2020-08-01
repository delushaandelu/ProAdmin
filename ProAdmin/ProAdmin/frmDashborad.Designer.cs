namespace ProAdmin
{
    partial class frmDashborad
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accManageStudent = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accBasicData = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement9 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement10 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement11 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement12 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.E = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement14 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement15 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement16 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement17 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement18 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.accordionControlElement13 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(260, 31);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(795, 678);
            this.panelContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement13,
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.accordionControlElement5,
            this.accordionControlElement9,
            this.E,
            this.accordionControlElement17});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 678);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accManageStudent,
            this.accBasicData});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Primary Data Setting";
            // 
            // accManageStudent
            // 
            this.accManageStudent.Name = "accManageStudent";
            this.accManageStudent.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accManageStudent.Text = "User Settings";
            this.accManageStudent.Click += new System.EventHandler(this.accManageStudent_Click);
            // 
            // accBasicData
            // 
            this.accBasicData.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accBasicData.Name = "accBasicData";
            this.accBasicData.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accBasicData.Text = "Basic Data Setting";
            this.accBasicData.Click += new System.EventHandler(this.accBasicData_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement4,
            this.accordionControlElement3});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Students Data";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Student Basic Data Control";
            this.accordionControlElement4.Click += new System.EventHandler(this.accordionControlElement4_Click);
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Genarate Student ID";
            this.accordionControlElement3.Click += new System.EventHandler(this.accordionControlElement3_Click);
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement6,
            this.accordionControlElement7,
            this.accordionControlElement8});
            this.accordionControlElement5.Expanded = true;
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Text = "Exams Condination";
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement6.Text = "Shedule an Exam";
            this.accordionControlElement6.Click += new System.EventHandler(this.accordionControlElement6_Click);
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement7.Text = "Exam Results Details";
            this.accordionControlElement7.Click += new System.EventHandler(this.accordionControlElement7_Click);
            // 
            // accordionControlElement8
            // 
            this.accordionControlElement8.Name = "accordionControlElement8";
            this.accordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement8.Text = "Exam Results in Chart";
            this.accordionControlElement8.Click += new System.EventHandler(this.accordionControlElement8_Click);
            // 
            // accordionControlElement9
            // 
            this.accordionControlElement9.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement10,
            this.accordionControlElement11,
            this.accordionControlElement12});
            this.accordionControlElement9.Expanded = true;
            this.accordionControlElement9.Name = "accordionControlElement9";
            this.accordionControlElement9.Text = "Attandance";
            // 
            // accordionControlElement10
            // 
            this.accordionControlElement10.Name = "accordionControlElement10";
            this.accordionControlElement10.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement10.Text = "Schedule Class";
            this.accordionControlElement10.Click += new System.EventHandler(this.accordionControlElement10_Click);
            // 
            // accordionControlElement11
            // 
            this.accordionControlElement11.Name = "accordionControlElement11";
            this.accordionControlElement11.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement11.Text = "Mark Attandance";
            this.accordionControlElement11.Click += new System.EventHandler(this.accordionControlElement11_Click);
            // 
            // accordionControlElement12
            // 
            this.accordionControlElement12.Name = "accordionControlElement12";
            this.accordionControlElement12.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement12.Text = "Attandance Summary";
            this.accordionControlElement12.Click += new System.EventHandler(this.accordionControlElement12_Click);
            // 
            // E
            // 
            this.E.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement14,
            this.accordionControlElement15,
            this.accordionControlElement16});
            this.E.Expanded = true;
            this.E.Name = "E";
            this.E.Text = "Fee Payment";
            // 
            // accordionControlElement14
            // 
            this.accordionControlElement14.Name = "accordionControlElement14";
            this.accordionControlElement14.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement14.Text = "Payment Schedule";
            this.accordionControlElement14.Click += new System.EventHandler(this.accordionControlElement14_Click);
            // 
            // accordionControlElement15
            // 
            this.accordionControlElement15.Name = "accordionControlElement15";
            this.accordionControlElement15.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement15.Text = "Collect Payment";
            this.accordionControlElement15.Click += new System.EventHandler(this.accordionControlElement15_Click);
            // 
            // accordionControlElement16
            // 
            this.accordionControlElement16.Name = "accordionControlElement16";
            this.accordionControlElement16.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement16.Text = "Payment Summary";
            this.accordionControlElement16.Click += new System.EventHandler(this.accordionControlElement16_Click);
            // 
            // accordionControlElement17
            // 
            this.accordionControlElement17.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement18});
            this.accordionControlElement17.Expanded = true;
            this.accordionControlElement17.Name = "accordionControlElement17";
            this.accordionControlElement17.Text = "Reports";
            // 
            // accordionControlElement18
            // 
            this.accordionControlElement18.Name = "accordionControlElement18";
            this.accordionControlElement18.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement18.Text = "Manage Reports";
            this.accordionControlElement18.Click += new System.EventHandler(this.accordionControlElement18_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barToolbarsListItem1,
            this.skinDropDownButtonItem1});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1055, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barButtonItem1);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.skinDropDownButtonItem1);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1.Caption = "Logout";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barToolbarsListItem1
            // 
            this.barToolbarsListItem1.Caption = "barToolbarsListItem1";
            this.barToolbarsListItem1.Id = 0;
            this.barToolbarsListItem1.Name = "barToolbarsListItem1";
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 1;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // accordionControlElement13
            // 
            this.accordionControlElement13.Name = "accordionControlElement13";
            this.accordionControlElement13.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement13.Text = "Dashboard";
            this.accordionControlElement13.Click += new System.EventHandler(this.accordionControlElement13_Click_1);
            // 
            // frmDashborad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 709);
            this.ControlContainer = this.panelContainer;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frmDashborad";
            this.NavigationControl = this.accordionControl1;
            this.Text = "ProAdmin v0.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer panelContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accBasicData;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accManageStudent;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarToolbarsListItem barToolbarsListItem1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement9;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement10;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement11;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement12;
        private DevExpress.XtraBars.Navigation.AccordionControlElement E;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement14;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement15;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement16;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement17;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement18;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement13;
    }
}