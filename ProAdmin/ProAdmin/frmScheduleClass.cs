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
    public partial class frmScheduleClass : System.Windows.Forms.UserControl
    {
        public frmScheduleClass()
        {
            InitializeComponent();
        }

        private static frmScheduleClass _instance;

        public static frmScheduleClass Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmScheduleClass();
                return _instance;
            }
        }
    }
}
