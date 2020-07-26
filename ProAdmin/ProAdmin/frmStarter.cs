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
    public partial class frmStarter : DevExpress.XtraEditors.XtraForm
    {
        public frmStarter()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep(); // or progressBar1.Value++;
            if (progressBar1.Value == 150)  // check with the value
            {
                new frmLogin().Show();
                timer1.Stop();
                this.Hide();
            }
        }

        private void frmStarter_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 150;
            progressBar1.Minimum = 0;
            progressBar1.Step = 2;
            timer1.Start();  // start the timer
        }
    }
}