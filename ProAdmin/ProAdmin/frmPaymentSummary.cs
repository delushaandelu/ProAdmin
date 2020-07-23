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

            }
        }
    }
}
