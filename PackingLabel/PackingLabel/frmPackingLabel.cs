using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;

namespace PackingLabel
{
    public partial class frmPackingLabel : MaterialSkin.Controls.MaterialForm
    {
        public frmPackingLabel()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void frmPackingLabel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lTSolutionsDataSet.tblPacking' table. You can move, or remove it, as needed.
            this.tblPackingTableAdapter.Fill(this.lTSolutionsDataSet.tblPacking);
            Edit(false);

        }
        private void Edit(bool value)
        {
            txtItem.Enabled = value;
            txtQuantity.Enabled = value;
            txtPONo.Enabled = value;
            txtStatus.Enabled = value;
            dtpPackingDate.Enabled = value;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                lTSolutionsDataSet.tblPacking.AddtblPackingRow(lTSolutionsDataSet.tblPacking.NewtblPackingRow());
                tblPackingBindingSource.MoveLast();
                txtItem.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
                lTSolutionsDataSet.tblPacking.RejectChanges();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit(true);
            txtItem.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            tblPackingBindingSource.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                tblPackingBindingSource.EndEdit();
                tblPackingTableAdapter.Update(lTSolutionsDataSet.tblPacking);
                dataGridView1.Refresh();
                txtItem.Focus();

                MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
                lTSolutionsDataSet.tblPacking.RejectChanges();
            }

        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //enter
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    tblPackingBindingSource.RemoveCurrent();
            }
        }
    }
}
