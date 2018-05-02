using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Pubs;Integrated Security=True"))
            {
                string status = string.Empty;
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    //status = "open";
                    string queryString =
                        "select * " + "\r\n" +
                        "  from employee" + "\r\n" +
                        " where emp_id = @parmEmpID";

                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add(new SqlParameter("parmEmpID", "PMA42628M"));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("emp_id\t\tfname\t\tminit\t\tlname\t\tjob_id\t\tjob_lvl\t\tpub_id\t\thire_date\t");
                        while (reader.Read())
                        {
                            Console.WriteLine(string.Format("{0} \t\t | {1} \t\t | {2} \t\t | {3} \t\t | {4} \t\t | {5} \t\t | {6} \t\t | {7}",
                                reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]));
                        }
                    }
                    Console.WriteLine("Data displayed! Now press enter to move to the next section!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    status = "close";
                }

                connection.Close();
                connection.Dispose();
            }
        }
    }
}
