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
    public partial class frmMarkAttandance : System.Windows.Forms.UserControl
    {
        public frmMarkAttandance()
        {
            InitializeComponent();
        }

        private static frmMarkAttandance _instance;

        public static frmMarkAttandance Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmMarkAttandance();
                return _instance;
            }
        }
    }
}
