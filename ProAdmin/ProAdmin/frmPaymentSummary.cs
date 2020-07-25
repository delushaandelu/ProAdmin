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
    public partial class frmPaymentSummary : DevExpress.XtraEditors.XtraUserControl
    {
        public frmPaymentSummary()
        {
            InitializeComponent();
            populate_batchs();
            txtyear.Text = DateTime.Now.ToString("yyyy");
        }

        view_payment_summary view_fee_summary = new view_payment_summary();
        view_schoarshipstd_summary view_scol_summary = new view_schoarshipstd_summary();

        private static frmPaymentSummary _instance;

        public static frmPaymentSummary Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmPaymentSummary();
                return _instance;
            }
        }

        private void populate_batchs()
        {
            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                var batch = db.basicdata_batch.Select(y => new { y.batchid, y.batch, y.batchstate }).Where(y => y.batchstate == "Active");
                cmbbatch.DataSource = batch.ToList();
                cmbbatch.DisplayMember = "batch";
                cmbbatch.SelectedItem = null;

            }
        }

        private void btnprocess_Click(object sender, EventArgs e)
        {
            if(txtmonth.Text != null && txtyear.Text != null && cmbbatch.Text != null)
            {
                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    dgvpadi.DataSource = db.view_payment_summary.Where(x => x.batch == cmbbatch.Text && x.feeschedule == txtmonth.Text && x.year == txtyear.Text && x.payment == "Paid").ToList<view_payment_summary>();
                    dgvnotpadi.DataSource = db.view_payment_summary.Where(x => x.batch == cmbbatch.Text && x.feeschedule == txtmonth.Text && x.year == txtyear.Text && x.payment == "Not Paid").ToList<view_payment_summary>();
                    dgvsolview.DataSource = db.view_schoarshipstd_summary.Where(x => x.Scholarship == "YES" && x.Batch == cmbbatch.Text).ToList<view_schoarshipstd_summary>();

                    txtspaid.Text = db.view_payment_summary.Where(x => x.batch == cmbbatch.Text && x.feeschedule == txtmonth.Text && x.year == txtyear.Text && x.payment == "Paid").Count().ToString();
                    txtsnotpaid.Text = db.view_payment_summary.Where(x => x.batch == cmbbatch.Text && x.feeschedule == txtmonth.Text && x.year == txtyear.Text && x.payment == "Not Paid").Count().ToString();
                    txtsscol.Text = db.view_schoarshipstd_summary.Where(x => x.Scholarship == "YES" && x.Batch == cmbbatch.Text).Count<view_schoarshipstd_summary>().ToString();
                }
            }
        }
    }
}
