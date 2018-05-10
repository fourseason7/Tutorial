using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using DevExpress.XtraEditors;


namespace InotechWireless
{
    public partial class frmLogin : XtraForm
    {

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=InoTechSSD;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int intRowCount = 0;
            string strLoginID = string.Empty;
            string strPassword = string.Empty;

            strLoginID = txtLoginID.Text;
            strPassword = txtPassword.Text;

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tblUserList where UserName = '" + strLoginID + "' and Password = '" + strPassword + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            intRowCount = Convert.ToInt16(dt.Rows.Count.ToString());
            if (intRowCount == 0)
            {
                MessageBox.Show("This Username and password does not match!", "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLoginID.Focus();
            }
            else
            {
                this.Hide();
                frmMain fm = new frmMain();
                fm.Show();
            }
        }

        private void txtLoginID_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (string.IsNullOrEmpty(txtLoginID.Text))
                    {
                        txtLoginID.Focus();
                    }
                    else
                    {
                        txtPassword.Focus();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (string.IsNullOrEmpty(txtPassword.Text))
                    {
                        txtPassword.Focus();
                    }
                    else
                    {
                        //btnLogin.Focus();
                        btnLogin.PerformClick();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
