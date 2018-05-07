using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace YEZONEUSA
{
    static class Global
    {
        private static string _conString = "";
        public static string ConString
        {
            get { return _conString; }
            set { _conString = value; }
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmPacking());

            string connString = string.Empty;
            if (PreCheckDatabase())
            {

                Global.ConString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmPacking());
            }
            else
            {
                return;
            }
        }
        public static Boolean PreCheckDatabase()
        {
            //string connString = string.Empty;
            SqlConnection sqlConnection = new SqlConnection();
            string retMessage = string.Empty;

            try
            {
                sqlConnection = new SqlConnection();
                sqlConnection = LocalDB.GetLocalDB("YEZONEUSA", false, retMessage);

                if (sqlConnection == null)
                {
                    MessageBox.Show(retMessage, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                Global.ConString = sqlConnection.ConnectionString;

                Boolean blnRtnValue = false;
                blnRtnValue = LocalDB.TableExists(sqlConnection, "YEZONEUSA", "tblPacking", retMessage);
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

                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

    }
}
