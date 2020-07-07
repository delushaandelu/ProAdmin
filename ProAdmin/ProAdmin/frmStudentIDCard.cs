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
using System.Drawing.Drawing2D;
using System.Drawing.Text;
namespace ProAdmin
{
    public partial class frmStudentIDCard : System.Windows.Forms.UserControl
    {
        public frmStudentIDCard()
        {
            InitializeComponent();
        }

        basicdata_student model_students = new basicdata_student();
        private static frmStudentIDCard _instance;

        public static frmStudentIDCard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmStudentIDCard();
                return _instance;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmStudentIDCard_Load(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtfind.Text != null)
            {
                groupId.Visible = true;

                model_students.regid = txtfind.Text;

                using (DBEntity db = new DBEntity())
                {
                    if (db.basicdata_student.Where(data=> data.regid == txtfind.Text).Any())
                    {
                        model_students = db.basicdata_student.Where(x => x.regid == model_students.regid).FirstOrDefault();
                        lblname.Text = model_students.Firstname;
                        lblregid.Text = model_students.regid;
                        lbljoiningdate.Text = model_students.JoinDate;
                        lblbatch.Text = model_students.Batch;

                    }
                    else
                    {
                        clear();
                        MessageBox.Show("Invalud Student Registration ID. Please Try Again!");
                    }
                }

                string barCode = model_students.regid;
                try
                {
                    if (barCode != null)
                    {
                        Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                        picbatcode.Image = brCode.Draw(barCode, 60);
                    }

                }
                catch (Exception)
                {

                }


                txtsavefilename.Text = "StudentIDCard_" + model_students.regid;
            }
            else
            {
                MessageBox.Show("Invalud Student Registration ID. Please Try Again!");
                clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            groupId.Visible = false;
            txtfind.Text = null;
            lblname.Text = null;
            lblregid.Text = null;
            lbljoiningdate.Text = null;
            lblbatch.Text = null;
        }
    }
}
