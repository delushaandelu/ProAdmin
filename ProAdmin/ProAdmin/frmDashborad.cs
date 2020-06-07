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
    public partial class frmDashborad : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmDashborad()
        {
            InitializeComponent();
        }

        private void accBasicData_Click(object sender, EventArgs e)
        {
            if(!panelContainer.Controls.Contains(frmManageSubjects.Instance))
            {
                panelContainer.Controls.Add(frmManageSubjects.Instance);
                frmManageSubjects.Instance.Dock = DockStyle.Fill;
                frmManageSubjects.Instance.BringToFront();
            }
            frmManageSubjects.Instance.BringToFront();
        }

        private void accManageStudent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Noifdksad ");
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {

        }

        
    }
}