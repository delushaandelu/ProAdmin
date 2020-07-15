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
    public partial class frmExamResultCharts : System.Windows.Forms.UserControl
    {
        public frmExamResultCharts()
        {
            InitializeComponent();
        }

        private static frmExamResultCharts _instance;

        public static frmExamResultCharts Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmExamResultCharts();
                return _instance;
            }
        }
    }
}
