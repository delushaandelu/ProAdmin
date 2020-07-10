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
            
        }
    }
}
