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
    public partial class frmReports : System.Windows.Forms.UserControl
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private static frmReports _instance;

        public static frmReports Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmReports();
                return _instance;
            }
        }

        private void PrintStudentInfrobybatchandschool_Click(object sender, EventArgs e)
        {
            ReportStudentInfoCondition studentReport = new ReportStudentInfoCondition();
            ReportPrintTool printtool = new ReportPrintTool(studentReport);
            printtool.ShowRibbonPreview();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReportStudentInfoByBatch studentReport = new ReportStudentInfoByBatch();
            ReportPrintTool printtool = new ReportPrintTool(studentReport);
            printtool.ShowRibbonPreview();
        }

        private void lblemptystudentlist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReportStudentEmpyReport studentReport = new ReportStudentEmpyReport();
            ReportPrintTool printtool = new ReportPrintTool(studentReport);
            printtool.ShowRibbonPreview();
        }

        private void lblstudentadminon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReportStudentAdmissionForm studentReport = new ReportStudentAdmissionForm();
            ReportPrintTool printtool = new ReportPrintTool(studentReport);
            printtool.ShowRibbonPreview();
        }

        private void lblattandance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReportAttdanceSummary studentReport = new ReportAttdanceSummary();
            ReportPrintTool printtool = new ReportPrintTool(studentReport);
            printtool.ShowRibbonPreview();
        }

        private void lblreportbatch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReportExamResultSummary studentReport = new ReportExamResultSummary();
            ReportPrintTool printtool = new ReportPrintTool(studentReport);
            printtool.ShowRibbonPreview();
        }

        private void lblFileFronpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReportExamMeetingFileCover studentReport = new ReportExamMeetingFileCover();
            ReportPrintTool printtool = new ReportPrintTool(studentReport);
            printtool.ShowRibbonPreview();
        }

        private void lblStudentProgressPageByBatch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReportExamResultPersonalSummary studentReport = new ReportExamResultPersonalSummary();
            ReportPrintTool printtool = new ReportPrintTool(studentReport);
            printtool.ShowRibbonPreview();
        }
    }
}
