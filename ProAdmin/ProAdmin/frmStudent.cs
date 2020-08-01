using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using DevExpress.XtraReports.UI;

namespace ProAdmin
{
    public partial class frmStudent : System.Windows.Forms.UserControl
    {
        basicdata_student model_students = new basicdata_student();
        private static frmStudent _instance;

        public static frmStudent Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmStudent();
                return _instance;
            }
        }

        public frmStudent()
        {
            InitializeComponent();
            txtjoiningdate.Text = DateTime.Now.ToString();
            txtnewjoiningdate.Text = DateTime.Now.ToString();
            populate_student_data_grid_view();
            populate_all_student_data_grid_view();
            get_combo_vale_list();
            clear_fields();
        }

        bool TestForNullOrEmpty(string s)
        {
            bool result;
            result = s == null || s == string.Empty;
            return result;
        }

        private void get_combo_vale_list()
        {
            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                var school = db.basicdata_school.Select(x => new { x.schid, x.schoolname });
                cmbalschool.DataSource = school.ToList();
                cmbalschool.ValueMember = "schid";
                cmbalschool.DisplayMember = "schoolname";
                cmbalschool.SelectedItem = null;


                cmbolschool.DataSource = school.ToList();
                cmbolschool.DisplayMember = "schoolname";
                cmbolschool.SelectedItem = null;

                cmbnewalschool.DataSource = school.ToList();
                cmbnewalschool.ValueMember = "schid";
                cmbnewalschool.DisplayMember = "schoolname";
                cmbnewalschool.SelectedItem = null;


                cmbnewolschool.DataSource = school.ToList();
                cmbnewolschool.DisplayMember = "schoolname";
                cmbnewolschool.SelectedItem = null;



                var batch = db.basicdata_batch.Select(y => new { y.batchid, y.batch, y.batchstate }).Where(y => y.batchstate == "Active");
                cmbbatch.DataSource = batch.ToList();
                cmbbatch.DisplayMember = "batch";
                cmbbatch.SelectedItem = null;

                cmbnewbatch.DataSource = batch.ToList();
                cmbnewbatch.DisplayMember = "batch";
                cmbnewbatch.SelectedItem = null;

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

        private void populate_student_data_grid_view()
        {
            dgvStudent.AutoGenerateColumns = false;
            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                dgvStudent.DataSource = db.basicdata_student.ToList<basicdata_student>();
            }
        }

        private void populate_all_student_data_grid_view()
        {
            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                dgvAllStudent.DataSource = db.basicdata_student.ToList<basicdata_student>();
            }
        }

        private void clear_fields()
        {
            txtfirstname.Text               = null;
            txtlastname.Text                = null;
            txtnic.Text                     = null;
            dtpdob.Text                     = null;
            txthomeaddress.Text             = null;
            txthometell.Text                = null;
            txtstayingaddress.Text          = null;
            txtstayingtell.Text             = null;
            txtfathername.Text              = null;
            txtparenttell.Text              = null;
            cmbolschool.SelectedItem        = null;
            cmbalschool.SelectedItem        = null;
            txtolresult.Text                = null;
            cmbbatch.SelectedItem           = null;
            cmbscholership.SelectedItem     = null;
            txtfind.Text                    = null;
            cmbgender.Text                  = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int seq_val = 0;
            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                var seq = db.GetNextSequenceValue();
                int? nextSequenceValue = seq.Single();
                seq_val = nextSequenceValue.Value;
            }

            if (txtfirstname.Text == "" ||
                txtlastname.Text == "" ||
                cmbgender.Text == "" ||
                txtnic.Text == "" ||
                dtpdob.Text == "" ||
                cmbbatch.Text == "" ||
                txtfathername.Text == "" ||
                txthomeaddress.Text == "" ||
                txthometell.Text == "" ||
                txtstayingaddress.Text == "" ||
                txtstayingtell.Text == "" ||
                txtparenttell.Text == "" ||
                cmbolschool.Text == "" ||
                txtolresult.Text == "" ||
                cmbalschool.Text == "" ||
                txtjoiningdate.Text == "" ||
                cmbscholership.Text == "")
            {
                message_popup_ok("Empty fields found.");
            }
            else
            {
                model_students.Firstname = txtfirstname.Text;
                model_students.Lastname = txtlastname.Text;
                model_students.Nic = txtnic.Text;
                model_students.Dob = dtpdob.Text;
                model_students.home_address = txthomeaddress.Text;
                model_students.Home_tell = txthometell.Text;
                model_students.Staying_address = txtstayingaddress.Text;
                model_students.Stay_home_tell = txtstayingtell.Text;
                model_students.Father_name = txtfathername.Text;
                model_students.Parents_contact = txtparenttell.Text;
                model_students.Ol_School = cmbalschool.Text;
                model_students.Al_school = cmbalschool.Text;
                model_students.Ol_result = txtolresult.Text;
                model_students.JoinDate = txtjoiningdate.Text;
                model_students.Batch = cmbbatch.Text;
                model_students.Gender = cmbgender.Text;
                model_students.Scholarship = cmbscholership.SelectedItem.ToString();


                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {

                    if (model_students.Id == 0)//Insert
                    {
                        model_students.regid = cmbbatch.Text + "01" + seq_val;
                        db.basicdata_student.Add(model_students);
                    }
                    else //Update
                        db.Entry(model_students).State = EntityState.Modified;

                    db.SaveChangesAsync();
                    clear_fields();
                    message_popup_ok("Data Record Saved!");
                    populate_student_data_grid_view();

                    //Reset normal after changes done
                    model_students.Id = 0;
                    btnSave.Text = "Save";
                }
            }
        }

        private void dgvStudent_DoubleClick(object sender, EventArgs e)
        {
            if (dgvStudent.CurrentRow.Index != -1)
            {
                model_students.Id = Convert.ToInt32(dgvStudent.CurrentRow.Cells["Id"].Value);

                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    model_students = db.basicdata_student.Where(x => x.Id == model_students.Id).FirstOrDefault();
                    txtfirstname.Text           = model_students.Firstname;
                    txtlastname.Text            = model_students.Lastname;
                    txtnic.Text                 = model_students.Nic;
                    dtpdob.Text                 = model_students.Dob;
                    txthomeaddress.Text         = model_students.home_address;
                    txthometell.Text            = model_students.Home_tell;
                    txtstayingaddress.Text      = model_students.Staying_address;
                    txtstayingtell.Text         = model_students.Stay_home_tell;
                    txtfathername.Text          = model_students.Father_name;
                    txtparenttell.Text          = model_students.Parents_contact;
                    cmbolschool.Text            = model_students.Ol_School;
                    cmbalschool.Text            = model_students.Al_school;
                    txtolresult.Text            = model_students.Ol_result;
                    txtjoiningdate.Text         = model_students.JoinDate;
                    cmbbatch.Text               = model_students.Batch;
                    cmbgender.Text              = model_students.Gender;
                    cmbscholership.SelectedItem = model_students.Scholarship;
                }

                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear_fields();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text != null)
            {
                model_students.regid = txtfind.Text;

                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    model_students              = db.basicdata_student.Where(x => x.regid == model_students.regid).FirstOrDefault();
                    txtfirstname.Text           = model_students.Firstname;
                    txtlastname.Text            = model_students.Lastname;
                    txtnic.Text                 = model_students.Nic;
                    dtpdob.Text                 = model_students.Dob;
                    txthomeaddress.Text         = model_students.home_address;
                    txthometell.Text            = model_students.Home_tell;
                    txtstayingaddress.Text      = model_students.Staying_address;
                    txtstayingtell.Text         = model_students.Stay_home_tell;
                    txtfathername.Text          = model_students.Father_name;
                    txtparenttell.Text          = model_students.Parents_contact;
                    cmbolschool.Text            = model_students.Ol_School;
                    cmbalschool.Text            = model_students.Al_school;
                    txtolresult.Text            = model_students.Ol_result;
                    txtjoiningdate.Text         = model_students.JoinDate;
                    cmbbatch.Text               = model_students.Batch;
                    cmbgender.Text              = model_students.Gender;
                    cmbscholership.SelectedItem = model_students.Scholarship;
                }

                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtjoiningdate.Text = DateTime.Now.ToString();
            txtnewjoiningdate.Text = DateTime.Now.ToString();
            populate_student_data_grid_view();
            populate_all_student_data_grid_view();
            get_combo_vale_list();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure to delete the record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    var entity = db.Entry(model_students);
                    if (entity.State == EntityState.Detached)
                        db.basicdata_student.Attach(model_students);
                    db.basicdata_student.Remove(model_students);
                    db.SaveChangesAsync();

                    populate_student_data_grid_view();
                    populate_all_student_data_grid_view();
                    clear_fields();
                    btnSave.Text = "Save";

                    message_popup_ok("Data Deleted!");
                }
            }
        }

        private void btnnewsave_Click(object sender, EventArgs e)
        {
            int seq_val = 0;
            using (proadmin_v1Entities db = new proadmin_v1Entities())
            {
                var seq = db.GetNextSequenceValue();
                int? nextSequenceValue = seq.Single();
                seq_val = nextSequenceValue.Value;
            }

            if (txtnewfullname.Text == "" || txtnewlastname.Text == "" || txtnewnic.Text == "" || dtpnewdob.Text == "" || txtnewhomwaddress.Text == "" || 
                txtnewhometell.Text == "" || txtnewfathername.Text == "" || txtnewparentsname.Text == "" || cmbnewolschool.Text == "" || cmbnewalschool.Text == "" ||
                cmbnewbatch.Text == "" || cmbnewscol.Text == "" || cmbnewgender.Text == "" || txtnewstaytell.Text =="" || txtnewstayaddress.Text =="")
            {
                message_popup_ok("Empty fields found.");
            }
            else
            {
                string regid = cmbnewbatch.Text + "01" + seq_val;
                model_students.regid = regid;
                model_students.Firstname = txtnewfullname.Text;
                model_students.Lastname = txtnewlastname.Text;
                model_students.Nic = txtnewnic.Text;
                model_students.Dob = dtpnewdob.Text;
                model_students.home_address = txtnewhomwaddress.Text;
                model_students.Home_tell = txtnewhometell.Text;
                model_students.Staying_address = txtnewstayaddress.Text;
                model_students.Stay_home_tell = txtnewstaytell.Text;
                model_students.Father_name = txtnewfathername.Text;
                model_students.Parents_contact = txtnewparentsname.Text;
                model_students.Ol_School = cmbnewolschool.Text;
                model_students.Al_school = cmbnewalschool.Text;
                model_students.Ol_result = txtnewolresult.Text;
                model_students.JoinDate = txtnewjoiningdate.Text;
                model_students.Batch = cmbnewbatch.Text;
                model_students.Gender = cmbnewgender.Text;
                model_students.Scholarship = cmbnewscol.SelectedItem.ToString();


                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {

                    if (model_students.Id == 0)//Insert
                        db.basicdata_student.Add(model_students);
                    else //Update
                        db.Entry(model_students).State = EntityState.Modified;

                    db.SaveChangesAsync();
                    clear_fields();
                    message_popup_ok("Data Record Saved!");
                    populate_student_data_grid_view();

                    //Reset normal after changes done
                    model_students.Id = 0;
                    btnSave.Text = "Save";
                    txtmessage.Text = "New Student Reg ID : '" + regid + "'";
                    txtmessagbarcode.Text = regid;


                }
            }
        }

        private void btnregresh2_Click(object sender, EventArgs e)
        {
            txtjoiningdate.Text = DateTime.Now.ToString();
            txtnewjoiningdate.Text = DateTime.Now.ToString();
            populate_student_data_grid_view();
            populate_all_student_data_grid_view();
            get_combo_vale_list();
        }

        private void btnnewrefresh_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGenID_Click(object sender, EventArgs e)
        {
            groupId.Visible = true;

            lblname.Text = txtnewfullname.Text;
            lblregid.Text = txtmessagbarcode.Text;
            lblbatch.Text = cmbnewbatch.Text;
            lbljoiningdate.Text = txtnewjoiningdate.Text;

            string barCode = txtmessagbarcode.Text;
            try
            {
                if (txtmessagbarcode != null)
                {
                    Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                    picbatcode.Image = brCode.Draw(barCode, 60);
                }
                
            }
            catch (Exception)
            {

            }
            txtsavefilename.Text = "StudentIDCard_" + txtmessagbarcode.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtnewfullname.Text         = null;
            txtnewlastname.Text         = null;
            txtnewnic.Text              = null;
            dtpnewdob.Text              = null;
            txtnewhomwaddress.Text      = null;
            txtnewhometell.Text         = null;
            txtnewstayaddress.Text      = null;
            txtnewstaytell.Text         = null;
            txtnewfathername.Text       = null;
            txtnewparentsname.Text      = null;
            cmbnewolschool.Text         = null;
            cmbnewalschool.Text         = null;
            txtnewolresult.Text         = null;
            cmbnewbatch.Text            = null;
            cmbnewscol.SelectedItem     = null;
            cmbgender.Text              = null;

            lblbatch.Text               = null;
            lbljoiningdate.Text         = null;
            lblname.Text                = null;
            lblregid.Text               = null;
            txtmessagbarcode.Text       = null;
            txtmessage.Text             = null;

            txtjoiningdate.Text         = DateTime.Now.ToString();
            txtnewjoiningdate.Text      = DateTime.Now.ToString();
            populate_student_data_grid_view();
            populate_all_student_data_grid_view();
            get_combo_vale_list();
            txtmessage.Text             = null;
            groupId.Visible             = false;
            //txtsavefilename.Text = null;

            picbatcode.InitialImage = null;
        }

        private void cmbOpenSnip_Click(object sender, EventArgs e)
        {
            string invalidRegStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", @"%windir%\system32\SnippingTool.exe");

            System.Diagnostics.Process.Start(invalidRegStr);
        }

        private void lblstudentadminon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReportStudentAdmissionForm studentReport = new ReportStudentAdmissionForm();
            ReportPrintTool printtool = new ReportPrintTool(studentReport);
            printtool.ShowRibbonPreview();
        }
    }
}
