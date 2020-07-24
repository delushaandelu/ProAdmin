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
using DevExpress.XtraReports.UI;

namespace ProAdmin
{
    public partial class frmReportStudentDetails : System.Windows.Forms.UserControl
    {
        public frmReportStudentDetails()
        {
            InitializeComponent();
        }

        private static frmReportStudentDetails _instance;

        public static frmReportStudentDetails Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmReportStudentDetails();
                return _instance;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ReportStudentInfoCondition studentReport = new ReportStudentInfoCondition();
            ReportPrintTool printtool = new ReportPrintTool(studentReport);
            printtool.ShowPreview();
        }
    }
}
