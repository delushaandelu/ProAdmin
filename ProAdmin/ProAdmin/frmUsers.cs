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
    public partial class frmUsers : System.Windows.Forms.UserControl
    {
        basicdata_users model_users = new basicdata_users();
        private static frmUsers _instance;

        public static frmUsers Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmUsers();
                return _instance;
            }
        }

        public frmUsers()
        {
            InitializeComponent();
            populate_users_data_grid_view();
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
            txtfullname.Text = null;
            txtnic.Text = null;
            txtemail.Text = null;
            txtphone.Text = null;
            cmbrole.Text = null;
            cmbstate.Text = null;
            txtusername.Text = null;
            txtpassword.Text = null;
        }

        private void populate_users_data_grid_view()
        {
            using (DBEntity db = new DBEntity())
            {
                dgvUser.DataSource = db.basicdata_users.ToList<basicdata_users>();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtfullname.Text != "" || txtnic.Text != "" || txtemail.Text != "" || txtfullname.Text != "" || txtphone.Text != "" || txtusername.Text != "" || txtpassword.Text != "")
            {
                model_users.fullname = txtfullname.Text;
                model_users.nic = txtnic.Text;
                model_users.email = txtemail.Text;
                model_users.phone = Convert.ToInt32(txtphone.Text);
                model_users.role = cmbrole.SelectedItem.ToString();
                model_users.status = cmbstate.SelectedItem.ToString();
                model_users.username = txtusername.Text;
                model_users.password = txtpassword.Text;
                model_users.log = DateTime.Now.ToString();

                using (DBEntity db = new DBEntity())
                {

                    if (model_users.id == 0)//Insert
                        db.basicdata_users.Add(model_users);
                    else //Update
                        db.Entry(model_users).State = EntityState.Modified;

                    db.SaveChangesAsync();
                    clear_fields();
                    message_popup_ok("Data Record Saved!");
                    populate_users_data_grid_view();

                    //Reset normal after changes done
                    model_users.id = 0;
                    btnSave.Text = "Save";
                }
            }
            else
            {
                message_popup_ok("Empty fields found.");
            }
        }

        private void btnGenPwandUN_Click(object sender, EventArgs e)
        {
            txtpassword.Text = txtnic.Text;
            txtusername.Text = txtemail.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear_fields();
        }

        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}