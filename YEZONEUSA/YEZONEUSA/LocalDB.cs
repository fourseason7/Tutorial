using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace YEZONEUSA
{
    static class LocalDB
    {
        public const string DB_DIRECTORY = "Data";

        public static SqlConnection GetLocalDB(string dbName, bool deleteIfExists = false, string retMessage = "")
        {
            try
            {
                string outputFolder = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), DB_DIRECTORY);
                string mdfFilename = dbName + ".mdf";
                string dbFileName = Path.Combine(outputFolder, mdfFilename);
                string logFileName = Path.Combine(outputFolder, String.Format("{0}_log.ldf", dbName));
                // Create Data Directory If It Doesn't Already Exist.
                if (!Directory.Exists(outputFolder))
                {
                    Directory.CreateDirectory(outputFolder);
                }

                // If the file exists, and we want to delete old data, remove it here and create a new database.
                if (File.Exists(dbFileName) && deleteIfExists)
                {
                    if (File.Exists(logFileName)) File.Delete(logFileName);
                    File.Delete(dbFileName);
                    CreateDatabase(dbName, dbFileName);
                }
                // If the database does not already exist, create it.
                else if (!File.Exists(dbFileName))
                {
                    CreateDatabase(dbName, dbFileName);
                }

                // Open newly created, or old database.
                //Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =| DataDirectory |\LTSolutions.mdf; Integrated Security = True
                //string connectionString = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFileName={1};Initial Catalog={0};Integrated Security=True;", dbName, dbFileName);
                string connectionString = String.Format(@"Data Source=(LocalDB)\v11.0;AttachDBFileName={1};Initial Catalog={0};Integrated Security=True;", dbName, dbFileName);
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (SqlException ex)
            {
                retMessage = ex.Message.ToString();
                //MessageBox.Show(ex.Message, "Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                retMessage = ex.Message.ToString();
                return null;
                //MessageBox.Show(ex.Message, "Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
        }

        public static bool CreateDatabase(string dbName, string dbFileName, string retMessage = "")
        {
            try
            {
                string connectionString = String.Format(@"Data Source=(LocalDB)\v11.0;Initial Catalog=master;Integrated Security=True");
                //string connectionString = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True");
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();


                    DetachDatabase(dbName);

                    cmd.CommandText = String.Format("CREATE DATABASE {0} ON (NAME = N'{0}', FILENAME = '{1}')", dbName, dbFileName);
                    cmd.ExecuteNonQuery();
                }

                if (File.Exists(dbFileName)) return true;
                else return false;
            }
            catch (SqlException ex)
            {
                retMessage = ex.Message;
                //MessageBox.Show(ex.Message, "Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                retMessage = ex.Message;
                //MessageBox.Show(ex.Message, "Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool DetachDatabase(string dbName, string retMessage = "")
        {
            try
            {
                string connectionString = String.Format(@"Data Source=(LocalDB)\v11.0;Initial Catalog=master;Integrated Security=True");
                //string connectionString = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True");
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = String.Format("exec sp_detach_db '{0}'", dbName);
                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (SqlException ex)
            {
                retMessage = ex.Message;
                //MessageBox.Show(ex.Message, "Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                retMessage = ex.Message;
                //MessageBox.Show(ex.Message, "Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool TableExists(SqlConnection conn, string database, string name, string retMessage = "")
        {
            string strCmd = null;
            SqlCommand sqlCmd = null;

            try
            {
                strCmd = "select case when exists((select '['+SCHEMA_NAME(schema_id)+'].['+name+']' As name FROM [" + database + "].sys.tables WHERE name = '" + name + "')) then 1 else 0 end";
                sqlCmd = new SqlCommand(strCmd, conn);

                return (int)sqlCmd.ExecuteScalar() == 1;
            }
            catch (SqlException ex)
            {
                retMessage = ex.Message;
                //MessageBox.Show(ex.Message, "Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                retMessage = ex.Message;
                //MessageBox.Show(ex.Message, "Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool CreateTable(SqlConnection conn, string name, string retMessage = "")
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = name;
                    command.Connection = conn;
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (SqlException ex)
            {
                retMessage = ex.Message;
                //MessageBox.Show(ex.Message, "Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                retMessage = ex.Message;
                //MessageBox.Show(ex.Message, "Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
