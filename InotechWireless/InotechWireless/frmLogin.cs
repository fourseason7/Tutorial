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

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SSD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            }
            else
            {
                this.Hide();
                frmMain fm = new frmMain();
                fm.Show();
            }
        }
    }
}
