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
        //Declare Object of the Models
        basicdata_batch model_batch = new basicdata_batch();

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
            populate_batch_data_grid_view();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear_fields();
        }

        private void clear_fields()
        {
            txtBatch.Text = null;
        }

        private void message_record_saved()
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Caption = "Success";
            args.Text = "Data record saved successfully.";
            args.Buttons = new DialogResult[] { DialogResult.OK };
            XtraMessageBox.Show(args).ToString();
        }

        private void message_emplty_field_found()
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Caption = "Failed";
            args.Text = "Please fill all the filed to save data.";
            args.Buttons = new DialogResult[] { DialogResult.OK };
            XtraMessageBox.Show(args).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtBatch.Text != "")
            {
                model_batch.batch = txtBatch.Text.Trim();
                model_batch.log = DateTime.Now.ToString();

                using (DBEntity db = new DBEntity())
                {
                    db.basicdata_batch.Add(model_batch);
                    db.SaveChangesAsync();
                    clear_fields();
                    message_record_saved();
                    populate_batch_data_grid_view();
                }
            }
            else
            {
                message_emplty_field_found();
            }
                
        }

        private void populate_batch_data_grid_view()
        {
            using (DBEntity db = new DBEntity())
            {
                dgvBatch.DataSource = db.basicdata_batch.ToList<basicdata_batch>();
            }
        }

        private void dgvBatch_DoubleClick(object sender, EventArgs e)
        {
           
        }
    }
}