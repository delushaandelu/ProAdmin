using System;
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
    public partial class frmExamResults : System.Windows.Forms.UserControl
    {
        public frmExamResults()
        {
            InitializeComponent();
            get_basicdate_for_generate_marks();
        }

        basicdata_student   model_students      = new basicdata_student();
        basicdate_schedule  model_examschedule  = new basicdate_schedule();
        data_examresults    model_results       = new data_examresults();
        view_exam_results_summary view_exam_result_summary = new view_exam_results_summary();
                

        private static frmExamResults _instance;

        public static frmExamResults Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmExamResults();
                return _instance;
            }
        }

        public void populated_overall_mark_sheet()
        {
            if (cmbgenbatch.Text != null || cmbgenexam.Text != null)
            {
                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    view_exam_result_summary.exam = cmbgenexam.Text;
                    view_exam_result_summary.batch = cmbgenbatch.Text;
                    dgvGenerateOverallReport.DataSource = db.view_exam_results_summary.Where(x => x.batch == cmbgenbatch.Text && x.exam == cmbgenexam.Text).ToList<view_exam_results_summary>();
                }
            }
            else
            {
                message_popup_ok("Invalud Data Query!");
            }
        }

        public void populate_all_student_exam_marks_data()
        {
            dgvStudentResultData.AutoGenerateColumns = false;
            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                model_results.regid = txtstudentid.Text;
                dgvStudentResultData.DataSource = db.data_examresults.Where(x => x.regid == model_results.regid).ToList<data_examresults>();
            }
        }

        private void clear()
        {
            txtstudentid.Text       = null;
            cmbexam.Text            = null;
            cmbexam.Enabled         = false;
            btnexamsearch.Enabled   = false;
            txtstudentname.Text     = null;
            txtbatch.Text           = null;
            txtschool.Text          = null;
            txtsubject1.Text        = "0";
            txtsubject2.Text        = "0";
            txtsubject3.Text        = "0";
            txtenglish.Text         = "0";
            txtgit.Text             = "0";
            txttotal.Text           = "0";
            txtaverage.Text         = "0";
            txtavgstate.Text        = "0";
            populate_all_student_exam_marks_data();


        }

        private void btnstudentsearch_Click(object sender, EventArgs e)
        {
            if (txtstudentid.Text != null)
            {
                model_students.regid = txtstudentid.Text;
                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    if (db.basicdata_student.Where(data => data.regid == txtstudentid.Text).Any())
                    {

                        model_students          = db.basicdata_student.Where(x => x.regid == model_students.regid).FirstOrDefault();
                        txtstudentname.Text     = model_students.Firstname;
                        txtbatch.Text           = model_students.Batch;
                        txtschool.Text          = model_students.Al_school;
                        cmbexam.Enabled         = true;
                        btnexamsearch.Enabled   = true;
                        get_student_exam_vale_list();
                    }
                    else
                    {
                        clear();
                        MessageBox.Show("Invalud Student Registration ID. Please Try Again!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalud Student Registration ID. Please Try Again!");
                clear();
            }

            populate_all_student_exam_marks_data();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnexamsearch_Click(object sender, EventArgs e)
        {
            if (txtstudentid.Text != null && cmbexam.Text != null)
            {
                model_results.regid = txtstudentid.Text;
                model_results.exam = cmbexam.Text;

                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    if (db.data_examresults.Where(data => data.regid == txtstudentid.Text && data.exam == cmbexam.Text).Any())
                    {
                        model_results       = db.data_examresults.Where(data => data.regid == txtstudentid.Text && data.exam == cmbexam.Text).FirstOrDefault();
                        txtsubject1.Text    = model_results.subject_1.ToString();
                        txtsubject2.Text    = model_results.subject_2.ToString();
                        txtsubject3.Text    = model_results.subject_3.ToString();
                        txtenglish.Text     = model_results.English.ToString();
                        txtgit.Text         = model_results.git.ToString();
                        txttotal.Text       = model_results.total_marks.ToString();
                        txtaverage.Text     = model_results.average_marks.ToString();
                        txtavgstate.Text    = model_results.avg_state;

                        txtsubject1.Enabled = true;
                        txtsubject2.Enabled = true;
                        txtsubject3.Enabled = true;
                        txtenglish.Enabled  = true;
                        txtgit.Enabled      = true;
                        btngenerate.Enabled = true;
                        btnupdate.Enabled   = true;
                        btnclear.Enabled    = true;
                    }
                    else
                    {
                        txtsubject1.Enabled = true;
                        txtsubject2.Enabled = true;
                        txtsubject3.Enabled = true;
                        txtenglish.Enabled = true;
                        txtgit.Enabled = true;
                    }          
                }
            }
            else
            {
                MessageBox.Show("Please try again with correct data!");
                clear();
            }
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            double sub1 = double.Parse(txtsubject1.Text);
            double sub2 = double.Parse(txtsubject2.Text);
            double sub3 = double.Parse(txtsubject3.Text);
            double eng = double.Parse(txtenglish.Text);
            double git = double.Parse(txtgit.Text);
            txttotal.Text = (sub1 + sub2 + sub3).ToString();
            txtaverage.Text = (double.Parse(txttotal.Text) / 3).ToString();

            double goodpass = 64.9;
            double midpass = 44.9;


            if (goodpass < (double.Parse(txtaverage.Text)))
            {
                txtavgstate.Text = "GOOD PASS";
            }
            else if (midpass < (double.Parse(txtaverage.Text)))
            {
                txtavgstate.Text = "MID PASS";
            }
            else if (midpass > (double.Parse(txtaverage.Text)))
            {
                txtavgstate.Text = "FAIL";
            }
        }

        private void message_popup_ok(string messsage)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Caption = "Notification!";
            args.Text = messsage;
            args.Buttons = new DialogResult[] { DialogResult.OK };
            XtraMessageBox.Show(args).ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            decimal sub1 = decimal.Parse(txtsubject1.Text);
            decimal sub2 = decimal.Parse(txtsubject2.Text);
            decimal sub3 = decimal.Parse(txtsubject3.Text);
            decimal  eng = decimal.Parse(txtenglish.Text);
            decimal  git = decimal.Parse(txtgit.Text);
            decimal  tot = decimal.Parse(txttotal.Text);
            decimal  avg = decimal.Parse(txtaverage.Text);

            model_results.subject_1     = sub1;
            model_results.subject_2     = sub2;
            model_results.subject_3     = sub3;
            model_results.English       = eng;
            model_results.git           = git;
            model_results.total_marks   = tot;
            model_results.average_marks = avg;
            model_results.avg_state     = txtavgstate.Text;
            model_results.regid         = txtstudentid.Text;
            model_results.exam          = cmbexam.Text;
            model_results.batch         = txtbatch.Text;


            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                if (cmbexam.Text != null)
                {
                    model_examschedule.exam = cmbexam.Text;
                    model_examschedule = db.basicdate_schedule.Where(x => x.exam == model_examschedule.exam).FirstOrDefault();

                    model_results.exam_date = model_examschedule.start_date;
                }
                else
                {
                    message_popup_ok("Pleae fill all data fields!");
                }                   

                if (db.data_examresults.Where(data => data.regid == txtstudentid.Text && data.exam == cmbexam.Text).Any())//Insert
                    db.Entry(model_results).State = EntityState.Modified;
                else //Update
                    db.data_examresults.Add(model_results);

                db.SaveChangesAsync();
                message_popup_ok("Data Record Saved!");

            }
            populate_all_student_exam_marks_data(); 
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if(txtstudentid.Text != null)
            { 
                dgvStudentResultData.AutoGenerateColumns = false;
                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    model_results.regid = txtstudentid.Text;
                    dgvStudentResultData.DataSource = db.data_examresults.Where(x => x.regid == model_results.regid).ToList<data_examresults>();
                }
            }
            else
            {
                message_popup_ok("Invalid Student ID!");
            }
        }

        private void get_student_exam_vale_list()
        {
            cmbexam.Text = null;
            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                var batch_data = from data in db.basicdate_schedule where data.batch == txtbatch.Text select new { Name = data.id, ID = data.exam };
                cmbexam.DataSource = batch_data.ToList();
                cmbexam.ValueMember = "id";
                cmbexam.DisplayMember = "exam";
                cmbexam.SelectedItem = null;

            }
        }

        private void cmbgenbatch_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbgenexam.Text = null;
            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                var exam = from data in db.basicdate_schedule where data.batch == cmbgenbatch.Text select new { Name = data.id, ID = data.exam };
                cmbgenexam.DataSource = exam.ToList();
                cmbgenexam.ValueMember = "id";
                cmbgenexam.DisplayMember = "exam";
                cmbgenexam.SelectedItem = null;
            }
        }

        private void get_basicdate_for_generate_marks()
        {
            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                var batch = db.basicdata_batch.Select(y => new { y.batchid, y.batch, y.batchstate }).Where(y => y.batchstate == "Active");
                cmbgenbatch.DataSource = batch.ToList();
                cmbgenbatch.DisplayMember = "batch";
                cmbgenbatch.SelectedItem = null;

                cmbmissbatch.DataSource = batch.ToList();
                cmbmissbatch.DisplayMember = "batch";
                cmbmissbatch.SelectedItem = null;
            }
        }

        private void btngenReport_Click(object sender, EventArgs e)
        {
            populated_overall_mark_sheet();
        }

        private void cmbmissbatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                var exam = from data in db.basicdate_schedule where data.batch == cmbmissbatch.Text select new { Name = data.id, ID = data.exam };

                cmbmissexam.DataSource = exam.ToList();
                cmbmissexam.ValueMember = "id";
                cmbmissexam.DisplayMember = "exam";
                cmbmissexam.SelectedItem = null;
            }
        }

        private void btnmissgen_Click(object sender, EventArgs e)
        {
            if (cmbmissbatch.Text != null || cmbmissexam.Text != null)
            {
                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    view_exam_result_summary.exam = cmbmissexam.Text;
                    view_exam_result_summary.batch = cmbmissbatch.Text;
                    dgvMissRecords.DataSource = db.view_exam_results_summary.Where(x => x.batch == cmbmissbatch.Text && x.exam == cmbmissexam.Text && x.average_marks < 1 ).ToList<view_exam_results_summary>();
                }
            }
            else
            {
                message_popup_ok("Invalud Data Query!");
            }
        }
    }
}
