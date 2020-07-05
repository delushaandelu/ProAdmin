﻿using System;
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
            populate_student_data_grid_view();
            populate_all_student_data_grid_view();
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
            using (DBEntity db = new DBEntity())
            {
                dgvStudent.DataSource = db.basicdata_student.ToList<basicdata_student>();
            }
        }

        private void populate_all_student_data_grid_view()
        {
            using (DBEntity db = new DBEntity())
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
            txtjoiningdate.Text             = null;
            cmbbatch.SelectedItem           = null;
            cmbscholership.SelectedItem     = null;
            txtfind.Text                    = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtfirstname.Text != null)
            {
                model_students.regid            = DateTime.Now.ToString("yyyMMhhmmss");
                model_students.Firstname        = txtfirstname.Text;
                model_students.Lastname         = txtlastname.Text;
                model_students.Nic              = txtnic.Text;
                model_students.Dob              = dtpdob.Text;
                model_students.home_address     = txthomeaddress.Text;
                model_students.Home_tell        = txthometell.Text;
                model_students.Staying_address  = txtstayingaddress.Text;
                model_students.Stay_home_tell   = txtstayingtell.Text;
                model_students.Father_name      = txtfathername.Text;
                model_students.Parents_contact  = txtparenttell.Text;
                model_students.Ol_School        = cmbalschool.SelectedItem.ToString();
                model_students.Al_school        = cmbalschool.SelectedItem.ToString();
                model_students.Ol_result        = txtolresult.Text;
                model_students.JoinDate         = txtjoiningdate.Text;
                model_students.Batch            = cmbbatch.SelectedItem.ToString();
                model_students.Scholarship      = cmbscholership.SelectedItem.ToString();


                using (DBEntity db = new DBEntity())
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
                }
            }
            else
            {
                message_popup_ok("Empty fields found.");
            }
        }

        private void dgvStudent_DoubleClick(object sender, EventArgs e)
        {
            if (dgvStudent.CurrentRow.Index != -1)
            {
                model_students.Id = Convert.ToInt32(dgvStudent.CurrentRow.Cells["Id"].Value);

                using (DBEntity db = new DBEntity())
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
                    cmbolschool.SelectedItem    = model_students.Ol_School;
                    cmbalschool.SelectedItem    = model_students.Al_school;
                    txtolresult.Text            = model_students.Ol_result;
                    txtjoiningdate.Text         = model_students.JoinDate;
                    cmbbatch.SelectedItem       = model_students.Batch;
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

                using (DBEntity db = new DBEntity())
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
                    cmbolschool.SelectedItem    = model_students.Ol_School;
                    cmbalschool.SelectedItem    = model_students.Al_school;
                    txtolresult.Text            = model_students.Ol_result;
                    txtjoiningdate.Text         = model_students.JoinDate;
                    cmbbatch.SelectedItem       = model_students.Batch;
                    cmbscholership.SelectedItem = model_students.Scholarship;
                }

                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }
    }
}