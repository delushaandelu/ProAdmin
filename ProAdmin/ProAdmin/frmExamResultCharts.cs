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
    public partial class frmExamResultCharts : System.Windows.Forms.UserControl
    {
        public frmExamResultCharts()
        {
            InitializeComponent();
        }

        data_examresults model_results = new data_examresults();
        basicdata_student model_students = new basicdata_student();

        private static frmExamResultCharts _instance;

        public static frmExamResultCharts Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmExamResultCharts();
                return _instance;
            }
        }

        private void btnstudentsearch_Click(object sender, EventArgs e)
        {
            populate_all_student_exam_marks_data();
            
            chartAvg.Series["Average"].XValueMember = "exam";
            chartAvg.Series["Average"].YValueMembers = "average_marks";
            chartAvg.DataSource = dgvStudentResultData.DataSource;
            chartAvg.DataBind();

            charAvgBar.Series["Average"].XValueMember = "exam";
            charAvgBar.Series["Average"].YValueMembers = "average_marks";
            charAvgBar.DataSource = dgvStudentResultData.DataSource;
            charAvgBar.DataBind();

            chartEconomics.Series["Economics"].XValueMember = "exam";
            chartEconomics.Series["Economics"].YValueMembers = "subject_1";
            chartEconomics.DataSource = dgvStudentResultData.DataSource;
            chartEconomics.DataBind();

            chartAccounting.Series["Accounting"].XValueMember = "exam";
            chartAccounting.Series["Accounting"].YValueMembers = "subject_3";
            chartAccounting.DataSource = dgvStudentResultData.DataSource;
            chartAccounting.DataBind();

            chartBusiness.Series["BusinessStudies"].XValueMember = "exam";
            chartBusiness.Series["BusinessStudies"].YValueMembers = "subject_2";
            chartBusiness.DataSource = dgvStudentResultData.DataSource;
            chartBusiness.DataBind();

            try
            {
                model_students.regid = txtstudentid.Text;
                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    if (db.basicdata_student.Where(data => data.regid == txtstudentid.Text).Any())
                    {
                        model_students = db.basicdata_student.Where(x => x.regid == model_students.regid).FirstOrDefault();
                        txtfirstname.Text = model_students.Firstname;
                        txtlastname.Text = model_students.Lastname;
                        txtbatch.Text = model_students.Batch;
                        txtschool.Text = model_students.Al_school;

                    }
                    else
                    {
                        MessageBox.Show("Invalud Student Registration ID. Please Try Again!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Please Contact IT Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void populate_all_student_exam_marks_data()
        {
            try
            {
                dgvStudentResultData.AutoGenerateColumns = false;
                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    model_results.regid = txtstudentid.Text;
                    dgvStudentResultData.DataSource = db.data_examresults.Where(x => x.regid == model_results.regid).ToList<data_examresults>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Please Contact IT Support", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
