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
    public partial class frmCollectPayment : System.Windows.Forms.UserControl
    {
        public frmCollectPayment()
        {
            InitializeComponent();
            txtyear.Text = DateTime.Now.ToString("yyyy");
        }

        basicdata_student   model_student        = new basicdata_student();
        data_feecollection  model_feecollection  = new data_feecollection();
        basicdate_fee       model_fee            = new basicdate_fee();

        string batch = "";
        string amount = "";

        private static frmCollectPayment _instance;

        public static frmCollectPayment Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmCollectPayment();
                return _instance;
            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            if (txtstudentid.Text != null)
            {
                model_student.regid = txtstudentid.Text;
                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    if (db.basicdata_student.Where(data => data.regid == txtstudentid.Text).Any())
                    {
                        model_student = db.basicdata_student.Where(x => x.regid == model_student.regid).FirstOrDefault();
                        batch = model_student.Batch;
                    }
                    else
                    {
                        txtstudentid.Text = null;
                        lblmessage.Text = "Invalid Entry..";
                    }

                    model_fee = db.basicdate_fee.Where(data => data.batch_ == batch).FirstOrDefault();
                    amount = model_fee.amount;
                }

                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    if (db.data_feecollection.Where(data => data.regid == txtstudentid.Text && data.batch == batch && data.feeschedule == txtmonth.Text).Any())//Update attandance
                    {
                        model_feecollection = db.data_feecollection.Where(data => data.regid == txtstudentid.Text && data.batch == batch && data.feeschedule == txtmonth.Text).FirstOrDefault();
                        model_feecollection.payment         = "Paid";
                        model_feecollection.payment_date    = DateTime.Now.ToString();
                        model_feecollection.amount          = amount;

                        db.Entry(model_feecollection).State = EntityState.Modified;
                        db.SaveChanges();

                        lblmessage.Text = "Payment Colleted for : " + model_student.Firstname;
                    }
                    else
                    {
                        lblmessage.Text = "Invalid Entry..";
                    }
                }
                txtstudentid.Text = null;
            }
        }
    }
}
