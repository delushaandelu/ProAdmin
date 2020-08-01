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
    public partial class frmMainPage : System.Windows.Forms.UserControl
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        private static frmMainPage _instance;

        public static frmMainPage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmMainPage();
                return _instance;
            }
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
