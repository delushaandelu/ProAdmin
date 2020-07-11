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
        }

        basicdata_student model_students = new basicdata_student();
        basicdate_schedule model_examschedule = new basicdate_schedule();
        data_examresults model_results = new data_examresults();

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

        public void populate_all_student_exam_marks_data()
        {
            
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
            txtsubject1.Text        = null;
            txtsubject2.Text        = null;
            txtsubject3.Text        = null;
            txtenglish.Text         = null;
            txtgit.Text             = null;
            txttotal.Text           = null;
            txtaverage.Text         = null;
            txtavgstate.Text        = null;

        }

        private void btnstudentsearch_Click(object sender, EventArgs e)
        {
            if (txtstudentid.Text != null)
            {
                model_students.regid = txtstudentid.Text;
                using (DBEntity db = new DBEntity())
                {
                    if (db.basicdata_student.Where(data => data.regid == txtstudentid.Text).Any())
                    {
                        model_students          = db.basicdata_student.Where(x => x.regid == model_students.regid).FirstOrDefault();
                        txtstudentname.Text     = model_students.Lastname;
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
        }

        private void get_student_exam_vale_list()
        {        
            using (DBEntity db = new DBEntity())
            {
                var batch_data = from data in db.basicdate_schedule  where data.batch == txtbatch.Text select new { Name = data.id, ID = data.exam };
                cmbexam.DataSource = batch_data.ToList();
                cmbexam.ValueMember = "id";
                cmbexam.DisplayMember = "exam";
                cmbexam.SelectedItem = null;

            }
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

                using (DBEntity db = new DBEntity())
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
            model_results.batch = txtbatch.Text;


            using (DBEntity db = new DBEntity())
            {

                if (db.data_examresults.Where(data => data.regid == txtstudentid.Text && data.exam == cmbexam.Text).Any())//Insert
                    db.Entry(model_results).State = EntityState.Modified;
                else //Update
                    db.data_examresults.Add(model_results);

                db.SaveChangesAsync();
                clear();
                message_popup_ok("Data Record Saved!");

            }
        }
    }
}
