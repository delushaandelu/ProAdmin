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

        basicdate_schedule  model_examschedule = new basicdate_schedule();
        basicdata_student   model_student = new basicdata_student();
        data_examresults    model_results = new data_examresults();

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

                cmbsearchbybatch.DataSource = school.ToList();
                cmbsearchbybatch.ValueMember = "batchid";
                cmbsearchbybatch.DisplayMember = "batch";
                cmbsearchbybatch.SelectedItem = null;

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
            if (txtexam.Text != null || dtpenddate.Text != null || dtpenddate.Text != null || cmbstate.Text != null || cmbexamtype.Text != null)
            {
                string exam = txtexam.Text + '_' + cmbexamtype.Text;

                model_examschedule.exam         = exam;
                model_examschedule.start_date   = dtpstartdate.Text;
                model_examschedule.end_date     = dtpenddate.Text;
                model_examschedule.state        = cmbstate.Text;
                model_examschedule.exam_type    = cmbexamtype.Text;
                model_examschedule.batch        = cmbbatch.Text;

                using (DBEntity db = new DBEntity())
                {
                    if (model_examschedule.id == 0)//Insert
                    {
                        db.basicdate_schedule.Add(model_examschedule);

                        if (XtraMessageBox.Show("If you created this record, there will be students marks list also generated at the same time. Are you sure you want to shedule an exam?", "Authentication Required!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            generate_marks_list(cmbbatch.Text, exam);
                        }
                    }
                    else //Update
                    {
                        db.Entry(model_examschedule).State = EntityState.Modified;
                    } 

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

        private void generate_marks_list(string batch, string exam)
        {
            using (DBEntity db = new DBEntity())
            {
                var selectedStudents = db.basicdata_student.Where(i => i.Batch == batch).ToList();

                foreach (basicdata_student student in selectedStudents)
                {
                    model_results.subject_1     = 0;
                    model_results.subject_2     = 0;
                    model_results.subject_3     = 0;
                    model_results.English       = 0;
                    model_results.git           = 0;
                    model_results.total_marks   = 0;
                    model_results.average_marks = 0;
                    model_results.avg_state     = "";
                    model_results.regid         = student.regid;
                    model_results.exam          = exam;
                    model_results.batch         = batch;
                    model_results.exam_date     = dtpstartdate.Text;

                    db.data_examresults.Add(model_results);
                    db.SaveChanges();
                }
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
                    
                    btnsubsave.Text = "Save";

                    if (XtraMessageBox.Show("Do you want to delete all the Marks for this exam shedule too?", "Authentication Required!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var data = db.data_examresults.Where(rec => rec.exam == txtexam.Text && rec.batch == cmbbatch.Text);
                        db.data_examresults.RemoveRange(data);
                        db.SaveChanges();
                    }
                    clear_fields();

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

        private void cmbsearchbybatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvExamSchedule.AutoGenerateColumns = false;
            using (DBEntity db = new DBEntity())
            {
                model_examschedule.batch = cmbsearchbybatch.Text;

                dgvExamSchedule.DataSource = db.basicdate_schedule.Where(x => x.batch == model_examschedule.batch).ToList<basicdate_schedule>();
            }
        }
    }
}
