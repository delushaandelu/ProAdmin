﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;

namespace ProAdmin
{
    public partial class frmManageBasicData : System.Windows.Forms.UserControl
    {
        //Declare Object of the Models
        basicdata_batch         model_batch         = new basicdata_batch();
        basicdata_university    model_university    = new basicdata_university();
        basicdata_school        model_school        = new basicdata_school();
        basicdata_subject       model_subject       = new basicdata_subject();
        basicdate_fee           model_fee           = new basicdate_fee();

        private static frmManageBasicData _instance;

        public static frmManageBasicData Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmManageBasicData();
                return _instance;
            }
        }

        public frmManageBasicData()
        {
            InitializeComponent();
            populate_batch_data_grid_view();
            populate_university_data_grid_view();
            populate_school_data_grid_view();
            populate_subject_data_grid_view();
            populate_batch_date_to_comboboc();
            populate_fee_data_grid_view();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear_fields();
        }

        private void clear_fields()
        {
            txtBatch.Text = null;
            txtUniversity.Text = null;
            txtschool.Text = null;
            txtsubject.Text = null;
            txtteacher.Text = null;
            cmbfeebatch.Text = null;
            txtfeeamount.Text = null;
            cmbfeestate.Text = null;
        }

        private void message_popup_ok(string messsage)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Caption = "Notification!";
            args.Text = messsage;
            args.Buttons = new DialogResult[] { DialogResult.OK };
            XtraMessageBox.Show(args).ToString();
        }


        //Pupulate Events
        private void populate_batch_data_grid_view()
        {
            dgvBatchView.AutoGenerateColumns = false;

            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                dgvBatchView.DataSource = db.basicdata_batch.ToList<basicdata_batch>();
            }
        }

        private void populate_university_data_grid_view()
        {
            dgvUniversityView.AutoGenerateColumns = false;

            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                dgvUniversityView.DataSource = db.basicdata_university.ToList<basicdata_university>();
            }
        }

        private void populate_school_data_grid_view()
        {
            dgvSchoolView.AutoGenerateColumns = false;

            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                dgvSchoolView.DataSource = db.basicdata_school.ToList<basicdata_school>();
            }
        }

        private void populate_subject_data_grid_view()
        {
            dgvSubjectView.AutoGenerateColumns = false;

            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                dgvSubjectView.DataSource = db.basicdata_subject.ToList<basicdata_subject>();
            }
        }

        private void populate_fee_data_grid_view()
        {
            dgvSubjectView.AutoGenerateColumns = false;

            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                dgvfee.DataSource = db.basicdate_fee.ToList<basicdate_fee>();
            }
        }

        private void populate_batch_date_to_comboboc()
        {
            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                var batch = db.basicdata_batch.Select(y => new { y.batchid, y.batch , y.batchstate}).Where(y => y.batchstate == "Active");
                cmbfeebatch.DataSource = batch.ToList();
                cmbfeebatch.DisplayMember = "batch";
                cmbfeebatch.SelectedItem = null;
            }
        }

        //Save Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBatch.Text != "")
            {
                model_batch.batch   = txtBatch.Text.Trim();
                model_batch.batchstate = cmbbatchstate.Text;
                model_batch.log     = DateTime.Now.ToString();

                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {

                    if (model_batch.batchid == 0)//Insert
                        db.basicdata_batch.Add(model_batch);
                    else //Update
                        db.Entry(model_batch).State = EntityState.Modified;

                    db.SaveChangesAsync();
                    clear_fields();
                    message_popup_ok("Data Record Saved!");
                    populate_batch_data_grid_view();

                    //Reset normal after changes done
                    model_batch.batchid = 0;
                    btnSave.Text = "Save";
                }
            }
            else
            {
                message_popup_ok("Empty fields found.");
            }

        }

        private void btnUniSave_Click(object sender, EventArgs e)
        {
            if (txtUniversity.Text != "")
            {
                model_university.uniname = txtUniversity.Text.Trim();
                model_university.log = DateTime.Now.ToString();

                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {

                    if (model_university.uniid == 0)//Insert
                        db.basicdata_university.Add(model_university);
                    else //Update
                        db.Entry(model_university).State = EntityState.Modified;

                    db.SaveChangesAsync();
                    clear_fields();
                    message_popup_ok("Data Record Saved!");
                    populate_university_data_grid_view();

                    //Reset normal after changes done
                    model_university.uniid = 0;
                    btnUniSave.Text = "Save";
                }
            }
            else
            {
                message_popup_ok("Empty fields found.");
            }
        }

        private void btnSchoolSave_Click(object sender, EventArgs e)
        {
            if (txtschool.Text != "")
            {
                model_school.schoolname = txtschool.Text.Trim();
                model_school.log = DateTime.Now.ToString();

                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {

                    if (model_school.schid == 0)//Insert
                        db.basicdata_school.Add(model_school);
                    else //Update
                        db.Entry(model_school).State = EntityState.Modified;

                    db.SaveChangesAsync();
                    clear_fields();
                    message_popup_ok("Data Record Saved!");
                    populate_school_data_grid_view();

                    //Reset normal after changes done
                    model_school.schid = 0;
                    btnSchoolSave.Text = "Save";
                }
            }
            else
            {
                message_popup_ok("Empty fields found.");
            }
        }

        private void btnsubsave_Click(object sender, EventArgs e)
        {
            if (txtsubject.Text != "" || txtteacher.Text != "")
            {
                model_subject.subject = txtsubject.Text.Trim();
                model_subject.teacher = txtteacher.Text.Trim();
                model_subject.log = DateTime.Now.ToString();

                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {

                    if (model_subject.subid == 0)//Insert
                        db.basicdata_subject.Add(model_subject);
                    else //Update
                        db.Entry(model_subject).State = EntityState.Modified;

                    db.SaveChangesAsync();
                    clear_fields();
                    message_popup_ok("Data Record Saved!");
                    populate_subject_data_grid_view();

                    //Reset normal after changes done
                    model_subject.subid = 0;
                    btnsubsave.Text = "Save";
                }
            }
            else
            {
                message_popup_ok("Empty fields found.");
            }
        }

        private void btnfeesave_Click(object sender, EventArgs e)
        {
            if (cmbfeebatch.Text != "" || txtfeeamount.Text != "" || cmbfeestate.Text != "")
            {
                model_fee.batch_ = cmbfeebatch.Text;
                model_fee.amount = txtfeeamount.Text;
                model_fee.state  = cmbfeestate.Text;

                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {

                    if (model_fee.id == 0)//Insert
                        db.basicdate_fee.Add(model_fee);
                    else //Update
                        db.Entry(model_fee).State = EntityState.Modified;

                    db.SaveChangesAsync();
                    clear_fields();
                    message_popup_ok("Data Record Saved!");
                    populate_fee_data_grid_view();

                    //Reset normal after changes done
                    model_fee.id = 0;
                    btnfeesave.Text = "Save";
                }
            }
            else
            {
                message_popup_ok("Empty fields found.");
            }
        }
        //Delete Button Events
        private void btnUniDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure to delete the record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    var entity = db.Entry(model_university);
                    if (entity.State == EntityState.Detached)
                        db.basicdata_university.Attach(model_university);
                    db.basicdata_university.Remove(model_university);
                    db.SaveChangesAsync();

                    populate_university_data_grid_view();
                    clear_fields();
                    btnSave.Text = "Save";

                    message_popup_ok("Data Deleted!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure to delete the record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    var entity = db.Entry(model_batch);
                    if (entity.State == EntityState.Detached)
                        db.basicdata_batch.Attach(model_batch);
                    db.basicdata_batch.Remove(model_batch);
                    db.SaveChangesAsync();

                    populate_batch_data_grid_view();
                    clear_fields();
                    btnSave.Text = "Save";

                    message_popup_ok("Data Deleted!");
                }
            }
        }

        private void btnSchoolDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure to delete the record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    var entity = db.Entry(model_school);
                    if (entity.State == EntityState.Detached)
                        db.basicdata_school.Attach(model_school);
                    db.basicdata_school.Remove(model_school);
                    db.SaveChangesAsync();

                    populate_school_data_grid_view();
                    clear_fields();
                    btnSchoolSave.Text = "Save";

                    message_popup_ok("Data Deleted!");
                }
            }
        }

        private void btnsubdelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure to delete the record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    var entity = db.Entry(model_subject);
                    if (entity.State == EntityState.Detached)
                        db.basicdata_subject.Attach(model_subject);
                    db.basicdata_subject.Remove(model_subject);
                    db.SaveChangesAsync();

                    populate_subject_data_grid_view();
                    clear_fields();
                    btnSchoolSave.Text = "Save";

                    message_popup_ok("Data Deleted!");
                }
            }
        }

        private void btnfeedelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure to delete the record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    var entity = db.Entry(model_fee);
                    if (entity.State == EntityState.Detached)
                        db.basicdate_fee.Attach(model_fee);
                    db.basicdate_fee.Remove(model_fee);
                    db.SaveChangesAsync();

                    populate_fee_data_grid_view();
                    clear_fields();
                    btnfeesave.Text = "Save";
                    btnfeedelete.Enabled = false;

                    message_popup_ok("Data Deleted!");
                }
            }
        }

        //Grid View Double Click Event
        private void dgvBatchView_DoubleClick(object sender, EventArgs e)
        {
            if (dgvBatchView.CurrentRow.Index != -1)
            {
                model_batch.batchid = Convert.ToInt32(dgvBatchView.CurrentRow.Cells["batchid"].Value);

                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    model_batch = db.basicdata_batch.Where(x => x.batchid == model_batch.batchid).FirstOrDefault();
                    txtBatch.Text = model_batch.batch;
                    cmbbatchstate.Text = model_batch.batchstate;
                    string now = DateTime.Now.ToString();
                    now = model_batch.log;
                }

                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private void dgvUniversityView_DoubleClick(object sender, EventArgs e)
        {
            if (dgvUniversityView.CurrentRow.Index != -1)
            {
                model_university.uniid = Convert.ToInt32(dgvUniversityView.CurrentRow.Cells["uniid"].Value);

                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    model_university = db.basicdata_university.Where(x => x.uniid == model_university.uniid).FirstOrDefault();
                    txtUniversity.Text = model_university.uniname;
                    string now = DateTime.Now.ToString();
                    now = model_university.log;
                }

                btnUniSave.Text = "Update";
                btnUniDelete.Enabled = true;
            }
        }

        private void dgvSchoolView_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSchoolView.CurrentRow.Index != -1)
            {
                model_school.schid = Convert.ToInt32(dgvSchoolView.CurrentRow.Cells["schid"].Value);

                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    model_school = db.basicdata_school.Where(x => x.schid == model_school.schid).FirstOrDefault();
                    txtschool.Text = model_school.schoolname;
                    string now = DateTime.Now.ToString();
                    now = model_school.log;
                }

                btnSchoolSave.Text = "Update";
                btnSchoolDelete.Enabled = true;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSubjectView.CurrentRow.Index != -1)
            {
                model_subject.subid = Convert.ToInt32(dgvSubjectView.CurrentRow.Cells["subid"].Value);

                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    model_subject = db.basicdata_subject.Where(x => x.subid == model_subject.subid).FirstOrDefault();
                    txtsubject.Text = model_subject.subject;
                    txtteacher.Text = model_subject.teacher;
                    string now = DateTime.Now.ToString();
                    now = model_subject.log;
                }

                btnsubsave.Text = "Update";
                btnsubdelete.Enabled = true;
            }
        }

        private void dgvfee_DoubleClick(object sender, EventArgs e)
        {
            if (dgvfee.CurrentRow.Index != -1)
            {
                model_fee.id = Convert.ToInt32(dgvfee.CurrentRow.Cells["id"].Value);

                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    model_fee = db.basicdate_fee.Where(x => x.id == model_fee.id).FirstOrDefault();
                    cmbfeestate.Text = model_fee.state;
                    cmbfeebatch.Text = model_fee.batch_;
                    txtfeeamount.Text = model_fee.amount;

                }

                btnfeesave.Text = "Update";
                btnfeedelete.Enabled = true;
            }
        }

    }
}