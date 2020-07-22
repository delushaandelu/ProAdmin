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
    public partial class frmMarkAttandance : System.Windows.Forms.UserControl
    {
        public frmMarkAttandance()
        {
            InitializeComponent();

            txttoday.Text = DateTime.Now.ToString(("M/dd/yyyy"));
        }

        basicdata_class model_class = new basicdata_class();
        basicdata_student model_student = new basicdata_student();
        data_attandance model_attandance = new data_attandance();

        private static frmMarkAttandance _instance;

        public static frmMarkAttandance Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmMarkAttandance();
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
                        txtbatch.Text = model_student.Batch;
                    }
                    else
                    {
                        clear();
                        lblmessage.Text = "Invalid Class Entry..";
                    }
                }

                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    model_attandance.intime = DateTime.Now.ToString();
                    model_attandance.attandance = "1";

                    if (db.data_attandance.Where(data => data.regid == txtstudentid.Text && data.batch == txtbatch.Text && data.classdate == txttoday.Text).Any())//Update attandance
                    {
                        model_attandance = db.data_attandance.Where(x => x.regid == txtstudentid.Text && x.batch == txtbatch.Text && x.classdate == txttoday.Text).FirstOrDefault();
                        model_attandance.intime = DateTime.Now.ToString();
                        model_attandance.attandance = "1";

                        db.Entry(model_attandance).State = EntityState.Modified;
                        db.SaveChanges();

                        lblmessage.Text = "Welcome : " + model_student.Firstname;
                    }
                    else
                    {
                        lblmessage.Text = "Invalid Class Entry..";
                    }
                }
                txtstudentid.Text = null;
                txtbatch.Text = null;
            }
        }

        private void clear()
        {
            txtbatch.Text = null;
            txtstudentid.Text = null;
        }
    }
}
