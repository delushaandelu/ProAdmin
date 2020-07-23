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
    public partial class frmSchedulePayment : System.Windows.Forms.UserControl
    {
        public frmSchedulePayment()
        {
            InitializeComponent();
            populate_batch();
            txtyear.Text = DateTime.Now.ToString("yyyy");
        }

        basicdata_batch         model_batch         = new basicdata_batch();
        basicdate_feeschedule   model_feeschedule   = new basicdate_feeschedule();
        data_feecollection      model_feedata       = new data_feecollection();

        private static frmSchedulePayment _instance;

        public static frmSchedulePayment Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmSchedulePayment();
                return _instance;
            }
        }

        private void populate_batch()
        {
            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                var batch = db.basicdata_batch.Select(y => new { y.batchid, y.batch, y.batchstate }).Where(y => y.batchstate == "Active");
                cmbbatch.DataSource = batch.ToList();
                cmbbatch.DisplayMember = "batch";
                cmbbatch.SelectedItem = null;

                cmbsearchbybatch.DataSource = batch.ToList();
                cmbsearchbybatch.DisplayMember = "batch";
                cmbsearchbybatch.SelectedItem = null;
            }
        }

        private void cmbbatch_SelectedValueChanged(object sender, EventArgs e)
        {
            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                dgvpaymentschedule.DataSource = db.basicdate_feeschedule.Where(data => data.batch == cmbbatch.Text).ToList<basicdate_feeschedule>();
            }
        }

        private void cmbsearchbybatch_SelectedValueChanged(object sender, EventArgs e)
        {
            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                dgvpaymentschedule.DataSource = db.basicdate_feeschedule.Where(data => data.batch == cmbsearchbybatch.Text).ToList<basicdate_feeschedule>();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtmonth.Text != null && txtyear.Text != null && cmbbatch.Text != null)
            {
                model_feeschedule.batch     = cmbbatch.Text;
                model_feeschedule.feemonth  = txtmonth.Text;
                model_feeschedule.year      = txtyear.Text;
                model_feeschedule.state     = "Active";

                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {

                    db.basicdate_feeschedule.Add(model_feeschedule);

                    db.SaveChangesAsync();

                    //student payment empty records creating
                    generate_payment_records();

                    MessageBox.Show("Data Record Saved!");
                    dgvpaymentschedule.DataSource = db.basicdate_feeschedule.Where(data => data.batch == cmbbatch.Text).ToList<basicdate_feeschedule>();
                }
            }
            else
            {
                MessageBox.Show("Please fill all the feilds..");
            }
            clear_feild();
        }

        private void generate_payment_records()
        {
            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                var selectedStudents = db.basicdata_student.Where(i => i.Batch == cmbbatch.Text && i.Scholarship == "NO").ToList();

                foreach (basicdata_student student in selectedStudents)
                {
                    model_feedata.amount        = "0";
                    model_feedata.batch         = cmbbatch.Text;
                    model_feedata.feeschedule   = txtmonth.Text;
                    model_feedata.payment       = "Not Paid";
                    model_feedata.payment_date  = "";
                    model_feedata.regid         = student.regid;
                    model_feedata.year          = txtyear.Text;

                    db.data_feecollection.Add(model_feedata);
                    db.SaveChanges();
                }
            }
        }

        private void clear_feild()
        {
            cmbbatch.Text = null;
            txtmonth.Text = null;
        }
    }
}
