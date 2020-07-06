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
using System.Drawing.Drawing2D;
using System.Drawing.Text;
namespace ProAdmin
{
    public partial class frmStudentIDCard : System.Windows.Forms.UserControl
    {
        public frmStudentIDCard()
        {
            InitializeComponent();
        }

        basicdata_student model_students = new basicdata_student();
        private static frmStudentIDCard _instance;

        public static frmStudentIDCard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmStudentIDCard();
                return _instance;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmStudentIDCard_Load(object sender, EventArgs e)
        {

        }
    }
}
