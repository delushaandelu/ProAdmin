namespace ProAdmin
{
    partial class frmStudentIDCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentIDCard));
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtfind = new DevExpress.XtraEditors.TextEdit();
            this.groupId = new System.Windows.Forms.GroupBox();
            this.cmbOpenSnip = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.txtsavefilename = new DevExpress.XtraEditors.TextEdit();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picbatcode = new System.Windows.Forms.PictureBox();
            this.lbljoiningdate = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.lblbatch = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.lblregid = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtfind.Properties)).BeginInit();
            this.groupId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsavefilename.Properties)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbatcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClear.Location = new System.Drawing.Point(161, 79);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 68;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(35, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 65;
            this.label2.Tag = "";
            this.label2.Text = "Reg ID :";
            // 
            // btnsearch
            // 
            this.btnsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsearch.BackgroundImage")));
            this.btnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnsearch.Location = new System.Drawing.Point(242, 32);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(31, 29);
            this.btnsearch.TabIndex = 67;
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(88, 37);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(148, 20);
            this.txtfind.TabIndex = 66;
            // 
            // groupId
            // 
            this.groupId.Controls.Add(this.cmbOpenSnip);
            this.groupId.Controls.Add(this.label37);
            this.groupId.Controls.Add(this.txtsavefilename);
            this.groupId.Controls.Add(this.groupBox4);
            this.groupId.Controls.Add(this.groupBox2);
            this.groupId.Location = new System.Drawing.Point(38, 117);
            this.groupId.Name = "groupId";
            this.groupId.Size = new System.Drawing.Size(976, 419);
            this.groupId.TabIndex = 96;
            this.groupId.TabStop = false;
            this.groupId.Text = "Geneate ID Card";
            this.groupId.Visible = false;
            // 
            // cmbOpenSnip
            // 
            this.cmbOpenSnip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbOpenSnip.Location = new System.Drawing.Point(368, 345);
            this.cmbOpenSnip.Name = "cmbOpenSnip";
            this.cmbOpenSnip.Size = new System.Drawing.Size(229, 23);
            this.cmbOpenSnip.TabIndex = 90;
            this.cmbOpenSnip.Text = "Open Sinpping Window to Save ID Card";
            this.cmbOpenSnip.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label37.Location = new System.Drawing.Point(29, 345);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(88, 13);
            this.label37.TabIndex = 89;
            this.label37.Tag = "";
            this.label37.Text = "Save File Name :";
            // 
            // txtsavefilename
            // 
            this.txtsavefilename.Location = new System.Drawing.Point(123, 342);
            this.txtsavefilename.Name = "txtsavefilename";
            this.txtsavefilename.Size = new System.Drawing.Size(208, 20);
            this.txtsavefilename.TabIndex = 88;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.label44);
            this.groupBox4.Controls.Add(this.label43);
            this.groupBox4.Controls.Add(this.label41);
            this.groupBox4.Controls.Add(this.label39);
            this.groupBox4.Controls.Add(this.label35);
            this.groupBox4.Controls.Add(this.pictureBox4);
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Location = new System.Drawing.Point(503, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(450, 270);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label44.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label44.Location = new System.Drawing.Point(179, 176);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(91, 15);
            this.label44.TabIndex = 10;
            this.label44.Text = "077 4009942";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label43.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label43.Location = new System.Drawing.Point(113, 161);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(225, 15);
            this.label43.TabIndex = 9;
            this.label43.Text = "Higher Education Center Kotagala";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label41.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label41.Location = new System.Drawing.Point(179, 129);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(86, 15);
            this.label41.TabIndex = 8;
            this.label41.Text = "The Director";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label39.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label39.Location = new System.Drawing.Point(175, 113);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(96, 15);
            this.label39.TabIndex = 7;
            this.label39.Text = "Mr P. Sathivel";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label35.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold);
            this.label35.ForeColor = System.Drawing.SystemColors.Control;
            this.label35.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label35.Location = new System.Drawing.Point(87, 16);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(333, 37);
            this.label35.TabIndex = 4;
            this.label35.Text = "HEC PVT LTD  Kotagala";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox4.Image = global::ProAdmin.Properties.Resources.graduation;
            this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox4.Location = new System.Drawing.Point(11, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(0, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(450, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.picbatcode);
            this.groupBox2.Controls.Add(this.lbljoiningdate);
            this.groupBox2.Controls.Add(this.label42);
            this.groupBox2.Controls.Add(this.lblbatch);
            this.groupBox2.Controls.Add(this.label40);
            this.groupBox2.Controls.Add(this.lblregid);
            this.groupBox2.Controls.Add(this.label38);
            this.groupBox2.Controls.Add(this.lblname);
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(27, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 270);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // picbatcode
            // 
            this.picbatcode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picbatcode.Location = new System.Drawing.Point(136, 203);
            this.picbatcode.Name = "picbatcode";
            this.picbatcode.Size = new System.Drawing.Size(297, 50);
            this.picbatcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbatcode.TabIndex = 13;
            this.picbatcode.TabStop = false;
            // 
            // lbljoiningdate
            // 
            this.lbljoiningdate.AutoSize = true;
            this.lbljoiningdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbljoiningdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbljoiningdate.Location = new System.Drawing.Point(232, 171);
            this.lbljoiningdate.Name = "lbljoiningdate";
            this.lbljoiningdate.Size = new System.Drawing.Size(96, 15);
            this.lbljoiningdate.TabIndex = 12;
            this.lbljoiningdate.Text = "Joining Date :";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label42.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label42.Location = new System.Drawing.Point(133, 170);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(96, 15);
            this.label42.TabIndex = 11;
            this.label42.Text = "Joining Date :";
            // 
            // lblbatch
            // 
            this.lblbatch.AutoSize = true;
            this.lblbatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblbatch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblbatch.Location = new System.Drawing.Point(232, 145);
            this.lblbatch.Name = "lblbatch";
            this.lblbatch.Size = new System.Drawing.Size(59, 15);
            this.lblbatch.TabIndex = 10;
            this.lblbatch.Text = "Reg ID :";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label40.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label40.Location = new System.Drawing.Point(133, 145);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(95, 15);
            this.label40.TabIndex = 9;
            this.label40.Text = "Batch            :";
            // 
            // lblregid
            // 
            this.lblregid.AutoSize = true;
            this.lblregid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblregid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblregid.Location = new System.Drawing.Point(232, 113);
            this.lblregid.Name = "lblregid";
            this.lblregid.Size = new System.Drawing.Size(59, 15);
            this.lblregid.TabIndex = 8;
            this.lblregid.Text = "Reg ID :";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label38.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label38.Location = new System.Drawing.Point(133, 113);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(95, 15);
            this.label38.TabIndex = 7;
            this.label38.Text = "Reg ID          :";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblname.Location = new System.Drawing.Point(232, 82);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(53, 15);
            this.lblname.TabIndex = 6;
            this.lblname.Text = "Name :";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label36.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label36.Location = new System.Drawing.Point(133, 81);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(93, 15);
            this.label36.TabIndex = 5;
            this.label36.Text = "Name           :";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProAdmin.Properties.Resources.user;
            this.pictureBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox5.Location = new System.Drawing.Point(22, 81);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(105, 119);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox3.Image = global::ProAdmin.Properties.Resources.graduation;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(10, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(79, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "HEC PVT LTD  Kotagala";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(0, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmStudentIDCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupId);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtfind);
            this.Name = "frmStudentIDCard";
            this.Size = new System.Drawing.Size(1084, 579);
            this.Load += new System.EventHandler(this.frmStudentIDCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtfind.Properties)).EndInit();
            this.groupId.ResumeLayout(false);
            this.groupId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsavefilename.Properties)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbatcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsearch;
        private DevExpress.XtraEditors.TextEdit txtfind;
        private System.Windows.Forms.GroupBox groupId;
        private System.Windows.Forms.Button cmbOpenSnip;
        private System.Windows.Forms.Label label37;
        private DevExpress.XtraEditors.TextEdit txtsavefilename;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picbatcode;
        private System.Windows.Forms.Label lbljoiningdate;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label lblbatch;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label lblregid;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
