using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProAdmin
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            DefaultHideMenuPanel();
        }

        private void DefaultHideMenuPanel()
        {
            panelOption1.Visible = false;
            panelOption2.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelOption1.Visible == true)
                panelOption1.Visible = false;
            if (panelOption2.Visible == true)
                panelOption2.Visible = false;
        }

        private void ShowSubMenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btnMenu1_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelOption1);
        }

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelOption2);
        }

        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            if(activeForm != null)
            
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageBatch());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManagerUser());
        }
    }
}
