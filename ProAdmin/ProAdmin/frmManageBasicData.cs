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
using System.Data.Entity;

namespace ProAdmin
{
    public partial class frmManageBasicData : System.Windows.Forms.UserControl
    {
        //Declare Object of the Models
        basicdata_batch model_batch = new basicdata_batch();

        private static frmManageBasicData _instance;

        public static frmManageBasicData Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmManageBasicData();
                return _instance;
            }
        }

        public frmManageBasicData()
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

        private void message_popup_ok(string messsage)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Caption = "Notification!";
            args.Text = messsage;
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

                    if (model_batch.batchid == 0)//Insert
                        db.basicdata_batch.Add(model_batch);
                    else //Update
                        db.Entry(model_batch).State = EntityState.Modified;

                    db.SaveChangesAsync();
                    clear_fields();
                    message_popup_ok("Data Record Saved!");
                    populate_batch_data_grid_view();

                    //Reset normal after changes done
                    model_batch.batchid = 0;
                    btnSave.Text = "Save";
                }
            }
            else
            {
                message_popup_ok("Empty fields found.");
            }
                
        }

        private void populate_batch_data_grid_view()
        {
            dgvBatchView.AutoGenerateColumns = false;

            using (DBEntity db = new DBEntity())
            {
                dgvBatchView.DataSource = db.basicdata_batch.ToList<basicdata_batch>();
            }
        }


        private void dgvBatchView_DoubleClick(object sender, EventArgs e)
        {
            if(dgvBatchView.CurrentRow.Index != -1)
            {
                model_batch.batchid = Convert.ToInt32(dgvBatchView.CurrentRow.Cells["batchid"].Value);

                using (DBEntity db = new DBEntity())
                {
                    model_batch = db.basicdata_batch.Where(x => x.batchid == model_batch.batchid).FirstOrDefault();
                    txtBatch.Text = model_batch.batch;
                    string now = DateTime.Now.ToString();
                    now = model_batch.log;
                }

                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show("Are you sure to delete the record?","Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DBEntity db = new DBEntity())
                {
                    var entity = db.Entry(model_batch);
                    if (entity.State == EntityState.Detached)
                        db.basicdata_batch.Attach(model_batch);
                    db.basicdata_batch.Remove(model_batch);
                    db.SaveChangesAsync();

                    populate_batch_data_grid_view();
                    clear_fields();
                    btnSave.Text = "Save";

                    message_popup_ok("Data Deleted!");
                }
            }
        }
    }
}