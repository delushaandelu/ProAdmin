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

            chartEconomics.Series["Average"].XValueMember = "exam";
            chartEconomics.Series["Average"].YValueMembers = "subject_1";
            chartEconomics.DataSource = dgvStudentResultData.DataSource;
            chartEconomics.DataBind();

            chartAccounting.Series["Average"].XValueMember = "exam";
            chartAccounting.Series["Average"].YValueMembers = "subject_3";
            chartAccounting.DataSource = dgvStudentResultData.DataSource;
            chartAccounting.DataBind();

            chartBusiness.Series["Average"].XValueMember = "exam";
            chartBusiness.Series["Average"].YValueMembers = "subject_2";
            chartBusiness.DataSource = dgvStudentResultData.DataSource;
            chartBusiness.DataBind();
        }

        public void populate_all_student_exam_marks_data()
        {
            dgvStudentResultData.AutoGenerateColumns = false;
            using (DBEntity db = new DBEntity())
            {
                model_results.regid = txtstudentid.Text;
                dgvStudentResultData.DataSource = db.data_examresults.Where(x => x.regid == model_results.regid).ToList<data_examresults>();
            }
        }
    }
}
