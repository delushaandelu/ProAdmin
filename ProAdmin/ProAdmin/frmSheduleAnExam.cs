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
    public partial class frmSheduleAnExam : System.Windows.Forms.UserControl
    {
        public frmSheduleAnExam()
        {
            InitializeComponent();
            populate_examschedule_data_grid_view();
            get_combo_vale_list();
            populate_all_examschedule_rich_data_grid_view();
        }

        basicdate_schedule model_examschedule = new basicdate_schedule();

        private static frmSheduleAnExam _instance;
        public static frmSheduleAnExam Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmSheduleAnExam();
                return _instance;
            }
        }

        private void get_combo_vale_list()
        {
            using (DBEntity db = new DBEntity())
            {
                var school = db.basicdata_batch.Select(x => new { x.batchid, x.batch });
                cmbbatch.DataSource = school.ToList();
                cmbbatch.ValueMember = "batchid";
                cmbbatch.DisplayMember = "batch";
                cmbbatch.SelectedItem = null;

            }
        }

        private void message_popup_ok(string messsage)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Caption = "Notification!";
            args.Text = messsage;
            args.Buttons = new DialogResult[] { DialogResult.OK };
            XtraMessageBox.Show(args).ToString();
        }

        private void clear_fields()
        {
            txtexam.Text        = null;
            dtpstartdate.Text   = null;
            dtpenddate.Text     = null;
            cmbstate.Text       = null;
            cmbexamtype.Text    = null;
        }

        private void populate_examschedule_data_grid_view()
        {
            dgvExamSchedule.AutoGenerateColumns = false;
            using (DBEntity db = new DBEntity())
            {
                dgvExamSchedule.DataSource = db.basicdate_schedule.ToList<basicdate_schedule>();
            }
        }

        private void populate_all_examschedule_rich_data_grid_view()
        {
            using (DBEntity db = new DBEntity())
            {
                dgvAllExam.DataSource = db.basicdate_schedule.ToList<basicdate_schedule>();
            }
        }


        private void btnsubsave_Click(object sender, EventArgs e)
        {
            if(txtexam.Text != null || dtpenddate.Text != null || dtpenddate.Text != null || cmbstate.Text != null || cmbexamtype.Text != null)
            {
                model_examschedule.exam         = txtexam.Text;
                model_examschedule.start_date   = dtpstartdate.Text;
                model_examschedule.end_date     = dtpenddate.Text;
                model_examschedule.state        = cmbstate.Text;
                model_examschedule.exam_type    = cmbexamtype.Text;
                model_examschedule.batch        = cmbbatch.Text;

                using (DBEntity db = new DBEntity())
                {
                    if (model_examschedule.id == 0)//Insert
                        db.basicdate_schedule.Add(model_examschedule);
                    else //Update
                        db.Entry(model_examschedule).State = EntityState.Modified;

                    db.SaveChangesAsync();
                    clear_fields();
                    message_popup_ok("Data Record Saved!");
                    populate_examschedule_data_grid_view();
                    populate_all_examschedule_rich_data_grid_view();

                    //Reset normal after changes done
                    model_examschedule.id = 0;
                    btnsubsave.Text = "Save";
                }
            }
            else
            {
                message_popup_ok("Empty fields found.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear_fields();
        }

        private void btnsubdelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure to delete the record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DBEntity db = new DBEntity())
                {
                    var entity = db.Entry(model_examschedule);
                    if (entity.State == EntityState.Detached)
                        db.basicdate_schedule.Attach(model_examschedule);
                    db.basicdate_schedule.Remove(model_examschedule);
                    db.SaveChangesAsync();

                    populate_examschedule_data_grid_view();
                    populate_all_examschedule_rich_data_grid_view();
                    clear_fields();
                    btnsubsave.Text = "Save";

                    message_popup_ok("Data Deleted!");
                }
            }
        }

        private void dgvExamSchedule_DoubleClick(object sender, EventArgs e)
        {
            if (dgvExamSchedule.CurrentRow.Index != -1)
            {
                model_examschedule.id = Convert.ToInt32(dgvExamSchedule.CurrentRow.Cells["id"].Value);

                using (DBEntity db = new DBEntity())
                {
                    model_examschedule  = db.basicdate_schedule.Where(x => x.id == model_examschedule.id).FirstOrDefault();
                    txtexam.Text        = model_examschedule.exam;
                    dtpstartdate.Text   = model_examschedule.start_date;
                    dtpenddate.Text     = model_examschedule.end_date;
                    cmbstate.Text       = model_examschedule.state;
                    cmbexamtype.Text    = model_examschedule.exam_type;
                    cmbbatch.Text       = model_examschedule.batch;
                }

                btnsubsave.Text = "Update";
                btnsubdelete.Enabled = true;
            }
        }
    }
}
