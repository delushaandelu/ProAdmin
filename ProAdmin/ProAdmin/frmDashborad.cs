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
            if(!panelContainer.Controls.Contains(frmManageBasicData.Instance))
            {
                panelContainer.Controls.Add(frmManageBasicData.Instance);
                frmManageBasicData.Instance.Dock = DockStyle.Fill;
                frmManageBasicData.Instance.BringToFront();
            }
            frmManageBasicData.Instance.BringToFront();
        }

        private void accManageStudent_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(frmUsers.Instance))
            {
                panelContainer.Controls.Add(frmUsers.Instance);
                frmUsers.Instance.Dock = DockStyle.Fill;
                frmUsers.Instance.BringToFront();
            }
            frmUsers.Instance.BringToFront();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(frmStudentIDCard.Instance))
            {
                panelContainer.Controls.Add(frmStudentIDCard.Instance);
                frmStudentIDCard.Instance.Dock = DockStyle.Fill;
                frmStudentIDCard.Instance.BringToFront();
            }
            frmStudentIDCard.Instance.BringToFront();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(frmStudent.Instance))
            {
                panelContainer.Controls.Add(frmStudent.Instance);
                frmStudent.Instance.Dock = DockStyle.Fill;
                frmStudent.Instance.BringToFront();
            }
            frmStudent.Instance.BringToFront();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(frmSheduleAnExam.Instance))
            {
                panelContainer.Controls.Add(frmSheduleAnExam.Instance);
                frmSheduleAnExam.Instance.Dock = DockStyle.Fill;
                frmSheduleAnExam.Instance.BringToFront();
            }
            frmSheduleAnExam.Instance.BringToFront();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(frmExamResults.Instance))
            {
                panelContainer.Controls.Add(frmExamResults.Instance);
                frmExamResults.Instance.Dock = DockStyle.Fill;
                frmExamResults.Instance.BringToFront();
            }
            frmExamResults.Instance.BringToFront();
        }
    }
}