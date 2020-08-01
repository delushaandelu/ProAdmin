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

            if (!panelContainer.Controls.Contains(frmMainPage.Instance))
            {
                panelContainer.Controls.Add(frmMainPage.Instance);
                frmMainPage.Instance.Dock = DockStyle.Fill;
                frmMainPage.Instance.BringToFront();
            }
            frmManageBasicData.Instance.BringToFront();
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

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(frmExamResultCharts.Instance))
            {
                panelContainer.Controls.Add(frmExamResultCharts.Instance);
                frmExamResultCharts.Instance.Dock = DockStyle.Fill;
                frmExamResultCharts.Instance.BringToFront();
            }
            frmExamResultCharts.Instance.BringToFront();
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(frmScheduleClass.Instance))
            {
                panelContainer.Controls.Add(frmScheduleClass.Instance);
                frmScheduleClass.Instance.Dock = DockStyle.Fill;
                frmScheduleClass.Instance.BringToFront();
            }
            frmScheduleClass.Instance.BringToFront();
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(frmMarkAttandance.Instance))
            {
                panelContainer.Controls.Add(frmMarkAttandance.Instance);
                frmMarkAttandance.Instance.Dock = DockStyle.Fill;
                frmMarkAttandance.Instance.BringToFront();
            }
            frmMarkAttandance.Instance.BringToFront();
        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(frmAttandanceSummary.Instance))
            {
                panelContainer.Controls.Add(frmAttandanceSummary.Instance);
                frmAttandanceSummary.Instance.Dock = DockStyle.Fill;
                frmAttandanceSummary.Instance.BringToFront();
            }
            frmAttandanceSummary.Instance.BringToFront();
        }

        private void accordionControlElement14_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(frmSchedulePayment.Instance))
            {
                panelContainer.Controls.Add(frmSchedulePayment.Instance);
                frmSchedulePayment.Instance.Dock = DockStyle.Fill;
                frmSchedulePayment.Instance.BringToFront();
            }
            frmSchedulePayment.Instance.BringToFront();
        }

        private void accordionControlElement15_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(frmCollectPayment.Instance))
            {
                panelContainer.Controls.Add(frmCollectPayment.Instance);
                frmCollectPayment.Instance.Dock = DockStyle.Fill;
                frmCollectPayment.Instance.BringToFront();
            }
            frmCollectPayment.Instance.BringToFront();
        }

        private void accordionControlElement16_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(frmPaymentSummary.Instance))
            {
                panelContainer.Controls.Add(frmPaymentSummary.Instance);
                frmPaymentSummary.Instance.Dock = DockStyle.Fill;
                frmPaymentSummary.Instance.BringToFront();
            }
            frmPaymentSummary.Instance.BringToFront();
        }

        private void accordionControlElement18_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(frmReports.Instance))
            {
                panelContainer.Controls.Add(frmReports.Instance);
                frmReports.Instance.Dock = DockStyle.Fill;
                frmReports.Instance.BringToFront();
            }
            frmReports.Instance.BringToFront();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void accordionControlElement13_Click_1(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(frmMainPage.Instance))
            {
                panelContainer.Controls.Add(frmMainPage.Instance);
                frmMainPage.Instance.Dock = DockStyle.Fill;
                frmMainPage.Instance.BringToFront();
            }
            frmMainPage.Instance.BringToFront();
        }
    }
}