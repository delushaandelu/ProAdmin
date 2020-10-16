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

namespace ProAdmin
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
            txtusername.Text = null; 
            txtpassword.Text = null;
            cmbuser.Text = null;
        }

        basicdata_users model_user = new basicdata_users();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text != null || txtpassword.Text != null || cmbuser.Text != null)
            {
                model_user.username = txtusername.Text;
                model_user.password = txtpassword.Text;
                model_user.role = cmbuser.Text;

                using (proadmin_v1Entities db = new proadmin_v1Entities())
                {
                    if (db.basicdata_users.Where(data => data.username == txtusername.Text && data.password == txtpassword.Text && data.role == cmbuser.Text).Any())
                    {
                        
                        frmDashborad dashborad = new frmDashborad();
                        dashborad.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User login, Please try again.");
                        txtusername.Text = null;
                        txtpassword.Text = null;
                        cmbuser.Text = null;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields.");
            }
        }
    }
}