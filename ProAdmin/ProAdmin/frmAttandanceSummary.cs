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
    public partial class frmAttandanceSummary : System.Windows.Forms.UserControl
    {
        public frmAttandanceSummary()
        {
            InitializeComponent();
        }

        basicdata_class model_class = new basicdata_class();
        view_attandance_summary view_attandance = new view_attandance_summary();

        private static frmAttandanceSummary _instance;

        public static frmAttandanceSummary Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmAttandanceSummary();
                return _instance;
            }
        }

        private void txtdate_SelectionChanged(object sender, EventArgs e)
        {
            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                var batch_data = from data in db.basicdata_class where data.classdate == txtdate.Text select new { Name = data.id, ID = data.batch };
                cmbbatch.DataSource = batch_data.ToList();
                cmbbatch.ValueMember = "id";
                cmbbatch.DisplayMember = "batch";
                cmbbatch.SelectedItem = null;

            }
        }

        private void btnprocess_Click(object sender, EventArgs e)
        {
            if (txtdate.Text != null && cmbbatch.Text != null)
            {
                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    dgvattendees.DataSource = db.view_attandance_summary.Where(x => x.batch == cmbbatch.Text && x.classdate == txtdate.Text && x.attandance == "Attend").ToList<view_attandance_summary>();
                    dgvabsentee.DataSource = db.view_attandance_summary.Where(x => x.batch == cmbbatch.Text && x.classdate == txtdate.Text && x.attandance == "Not Attend").ToList<view_attandance_summary>();

                    txtattend.Text = db.view_attandance_summary.Where(x => x.batch == cmbbatch.Text && x.classdate == txtdate.Text && x.attandance == "Attend").Count().ToString();
                    txtnotattend.Text = db.view_attandance_summary.Where(x => x.batch == cmbbatch.Text && x.classdate == txtdate.Text && x.attandance == "Not Attend").Count().ToString();
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields..");
            }
        }

        private void lblattandance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReportAttdanceSummary studentReport = new ReportAttdanceSummary();
            ReportPrintTool printtool = new ReportPrintTool(studentReport);
            printtool.ShowRibbonPreview();
        }
    }
}
