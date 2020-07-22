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
    public partial class frmScheduleClass : System.Windows.Forms.UserControl
    {
        public frmScheduleClass()
        {
            InitializeComponent();
            get_combo_vale_list();
            populate_shedule();
        }

        basicdata_class model_class      = new basicdata_class();
        data_attandance model_attandance = new data_attandance();
        basicdata_student model_student  = new basicdata_student();

        private static frmScheduleClass _instance;

        public static frmScheduleClass Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmScheduleClass();
                return _instance;
            }
        }

        private void get_combo_vale_list()
        {
            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                var batch = db.basicdata_batch.Select(y => new { y.batchid, y.batch });
                cmbbatch.DataSource = batch.ToList();
                cmbbatch.DisplayMember = "batch";
                cmbbatch.SelectedItem = null;
            }
        }

        private void populate_shedule()
        {
            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                dgvclassshedule.DataSource = db.basicdata_class.ToList<basicdata_class>();
            }
        }

        private void claclass_Click(object sender, EventArgs e)
        {
            txtdate.Text = claclass.SelectedRanges.Start.ToShortDateString();

            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                dgvclassshedule.DataSource = db.basicdata_class.Where(x => x.classdate == txtdate.Text).ToList<basicdata_class>();
            }
        }

        private void clear_feild()
        {
            txtdate.Text = null;
            cmbbatch.Text = null;
        }

        private void message_popup_ok(string messsage)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Caption = "Notification!";
            args.Text = messsage;
            args.Buttons = new DialogResult[] { DialogResult.OK };
            XtraMessageBox.Show(args).ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtdate.Text != "" && cmbbatch.Text != "")
            {
                model_class.batch       = cmbbatch.Text;
                model_class.classdate   = txtdate.Text;
                model_class.state       = "Active";

                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {

                    db.basicdata_class.Add(model_class);

                    db.SaveChangesAsync();

                    //student attdance empty records creating
                    generate_attandance_records();

                    message_popup_ok("Data Record Saved!");
                    dgvclassshedule.DataSource = db.basicdata_class.Where(x => x.classdate == txtdate.Text).ToList<basicdata_class>();
                    clear_feild();
                }
            }
            else
            {
                message_popup_ok("Please fill all the fields!");
            }
        }

        private void generate_attandance_records()
        {
            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                var selectedStudents = db.basicdata_student.Where(i => i.Batch == cmbbatch.Text).ToList();

                foreach (basicdata_student student in selectedStudents)
                {
                    model_attandance.classdate  = txtdate.Text;
                    model_attandance.attandance = "0";
                    model_attandance.batch      = cmbbatch.Text;
                    model_attandance.intime     = "0";
                    model_attandance.regid      = student.regid;

                    db.data_attandance.Add(model_attandance);
                    db.SaveChanges();
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure to delete the record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    var entity = db.Entry(model_class);
                    if (entity.State == EntityState.Detached)
                        db.basicdata_class.Attach(model_class);
                    db.basicdata_class.Remove(model_class);
                    db.SaveChangesAsync();

                    btndelete.Enabled = false;

                    if (XtraMessageBox.Show("Do you want to delete all the addtendance for this class shedule too?", "Authentication Required!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var data = db.data_attandance.Where(rec => rec.batch == cmbbatch.Text && rec.classdate == txtdate.Text);
                        db.data_attandance.RemoveRange(data);
                        db.SaveChanges();
                    }

                    clear_feild();

                    message_popup_ok("Data Deleted!");
                }
            }
        }

        private void dgvclassshedule_DoubleClick_1(object sender, EventArgs e)
        {
            if (dgvclassshedule.CurrentRow.Index != -1)
            {
                model_class.id = Convert.ToInt32(dgvclassshedule.CurrentRow.Cells["id"].Value);
                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    model_class = db.basicdata_class.Where(x => x.id == model_class.id).FirstOrDefault();
                    txtdate.Text  = model_class.classdate;
                    cmbbatch.Text = model_class.batch;
                    dgvclassshedule.DataSource = db.basicdata_class.Where(x => x.classdate == model_class.classdate).ToList<basicdata_class>();
                }
                btndelete.Enabled = true;
                
            }
        }
    }
}
