using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalDB
{
    public partial class Form1 : Form
    {
        string connString = string.Empty;
        SqlConnection sqlConnection = new SqlConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateLocalDB_Click(object sender, EventArgs e)
        {
            //SqlConnection sqlConnection = new SqlConnection();

            sqlConnection = new SqlConnection();
            connString = sqlConnection.ConnectionString;

            //LocalDB.GetLocalDB("Test", false);

            bool blnDelete = chkDeleteDB.Checked;

            sqlConnection = LocalDB.GetLocalDB("Test", blnDelete);
            //sqlConnection = LocalDB.GetLocalDB("Test", false);

            //check exists table
            Boolean blnRtnValue = false;
            blnRtnValue= LocalDB.TableExists(sqlConnection, "Test", "tblPacking");
            if (!blnRtnValue) // not exists
            {
                // create new table 
                string sqlScripts = string.Empty;
                sqlScripts = @"CREATE TABLE [dbo].[tblPacking]("
                            + "	[PackingId] [int] IDENTITY(1001,1) NOT NULL,"
                            + "	[ItemNo] [nvarchar](25) NULL,"
                            + "	[Quantity] [int] NULL,"
                            + "	[PONo] [nvarchar](25) NULL,"
                            + "	[Status] [nvarchar](100) NULL,"
                            + "	[PackingDate] [datetime] NULL,"
                            + "	[HostName] [nvarchar](50) NULL,"
                            + "	[CreateDate] [datetime] NULL,"
                            + "	[ModifyDate] [datetime] NULL,"
                            + " CONSTRAINT [PK_tblPacking] PRIMARY KEY CLUSTERED"
                            + "("
                            + "	[PackingId] ASC"
                            + ")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]"
                            + ") ON [PRIMARY]";

                blnRtnValue = LocalDB.CreateTable(sqlConnection, sqlScripts);


            }

            
            //MessageBox.Show(string.Format("Connection String: {0}" + Environment.NewLine + "Table Exists: {1}", sqlConnection.ToString(), blnRtnValue.ToString()));
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            string sqlCmd = string.Empty;
            string sqlConnectString = sqlConnection.ConnectionString;
            sqlCmd = "SELECT * FROM dbo.tblPacking";
            try
            {
                using (SqlConnection conn = new SqlConnection(sqlConnectString))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlCmd, conn))
                    {
                        SqlCommandBuilder cb = new SqlCommandBuilder(da);

                        DataTable dt = new DataTable();
                        dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
                        da.Fill(dt);
                        bindingSource1.DataSource = dt;
                        dataGridView1.ReadOnly = true;
                        dataGridView1.DataSource = bindingSource1;
                    }
                    //using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
                    //{
                    //    ////cmd.Connection = sqlConnection;
                    //    //cmd.CommandText = sqlCmd;
                    //    //cmd.Connection.Open();
                    //    //conn.Open();
                    //    //SqlDataReader dr = cmd.ExecuteReader();
                    //    //dataGridView1.DataSource = dr;

                    //    //dr.Close();
                    //    //cmd.Connection.Close();

                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }


        }

        private void btnInsertData_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlCmd = string.Empty;
                string sqlConnectString = sqlConnection.ConnectionString;

                //sqlCmd = @"insert into tbl_packing"
                //        + "(ItemNo, Quantity, PONo, Status, PackingDate)"
                //        + "select 'TEST1', 100, 'TESTPO1', 'GOOD', getdate()";
                //        string sql = "INSERT INTO klant(klant_id,naam,voornaam) VALUES(@param1,@param2,@param3)";
                //        SqlCommand cmd = new SqlCommand(sql, connection);
                //        cmd.Parameters.Add("@param1", SqlDbType.Int).value = klantId
                //cmd.Parameters.Add("@param2", SqlDbType.Varchar, 50).value = klantNaam;
                //        cmd.Parameters.Add("@param3", SqlDbType.Varchar, 50).value = klantVoornaam;
                //        cmd.CommandType = CommandType.Text;
                //        cmd.ExecuteNonQuery();
                sqlCmd = @"INSERT INTO TBLPACKING(ItemNo, Quantity, PONo, Status, PackingDate)"
                        + "VALUES (@param1, @param2, @param3, @param4, @param5)";
                using (SqlConnection conn = new SqlConnection(sqlConnectString))
                {

                    using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
                    {
                        cmd.CommandText = sqlCmd;
                        cmd.Parameters.Add("@param1", SqlDbType.NVarChar, 25).Value = "test1234";
                        cmd.Parameters.Add("@param2", SqlDbType.Int).Value = 100;
                        cmd.Parameters.Add("@param3", SqlDbType.NVarChar, 50).Value = "CVE180425-003";
                        cmd.Parameters.Add("@param4", SqlDbType.NVarChar, 50).Value = "GOOD";

                        DateTime dt = DateTime.Now.Date;
                        //cmd.Parameters.AddWithValue("@param5", dt);
                        cmd.Parameters.Add("@param5", SqlDbType.DateTime).Value = dt;
                        //cmd.Parameters.AddWithValue("@param5", DateTime.Now.Date);

                        conn.Open();
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }


        private void btnDeltetDB_Click(object sender, EventArgs e)
        {
            LocalDB.DetachDatabase("Test");
        }
    }
}
