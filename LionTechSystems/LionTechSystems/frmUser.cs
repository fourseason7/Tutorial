using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

using DevExpress.XtraEditors;

namespace LTSales
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.ConnectionString.ToString());

        public frmUser()
        {
            InitializeComponent();
        }
        public void Edit(bool value)
        {
            txtFirstName.Enabled = value;
            txtLastName.Enabled = value;
            txtUserName.Enabled = value;
            txtPassword.Enabled = value;
            txtEmail.Enabled = value;
            txtContact.Enabled = value;
        }
        public void ResetDetail()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";

            txtFirstName.Focus();
        }
        public void RetrieveData()
        {
            using (SqlCommand cmd = con.CreateCommand())
            {
                string sql =
                        "select * " + "\r\n" +
                        " from tblUserList ";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                gcLists.DataSource = dt;
            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            RetrieveData();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Edit(true);

        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int intRowCount = 0;

            string strFirstName = txtFirstName.Text;
            string strLastName = txtLastName.Text;
            string strUserName = txtUserName.Text;
            string strPassword = txtPassword.Text;
            string strEmail = txtEmail.Text;
            string strContact = txtContact.Text;

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tblUserList where UserName = '" + strUserName + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            intRowCount = Convert.ToInt16(dt.Rows.Count.ToString());
            if (intRowCount == 0)
            {
                try
                {
                    using (SqlCommand insertCommand = con.CreateCommand())
                    {
                        insertCommand.CommandType = CommandType.Text;
                        string sql =
                            "insert into tblUserList" + "\r\n" +
                            "values ('" + strFirstName + "', '" + strLastName + "', '" + strUserName + "', '" + strPassword + "', '" + strEmail + "', '" + strContact + "');";
                        insertCommand.CommandText = sql;
                        insertCommand.ExecuteNonQuery();
                    }
                    XtraMessageBox.Show("User record inserted successfully!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message.ToString(), "Insert Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }
            }
            else
            {
                XtraMessageBox.Show("This username already registered." + Environment.NewLine + "Please, choose another!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ResetDetail();
            RetrieveData();
        }

    }
}