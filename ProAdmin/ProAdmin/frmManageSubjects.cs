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

namespace ProAdmin
{
    public partial class frmManageSubjects : System.Windows.Forms.UserControl
    {
        private static frmManageSubjects _instance;

        public static frmManageSubjects Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmManageSubjects();
                return _instance;
            }
        }

        public frmManageSubjects()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
        }

        private void windowsUIButtonPanelMain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Noifdksad ");
        }
    }
}