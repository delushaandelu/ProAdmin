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
    public partial class frmAttandanceSummary : System.Windows.Forms.UserControl
    {
        public frmAttandanceSummary()
        {
            InitializeComponent();
        }

        private static frmAttandanceSummary _instance;

        public static frmAttandanceSummary Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmAttandanceSummary();
                return _instance;
            }
        }
    }
}
