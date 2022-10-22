using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace cashdro
{
    static class funciones
    {
        // public static string cnLocal = @"Data Source=.\SQLEXPRESS;Initial Catalog=SensorTest;Integrated Security = True";
        public static string cnLocal = @"Data Source=.\ss01;Initial Catalog=GestionCashdro;User Id=userCashdro;password=userCashdro";
        public static string cnRemota = @"";

        //static public DataSet LeerCasdro()
        //{
        //    DataSet ds;
        //    using (SqlConnection connection = new SqlConnection(cnLocal))
        //    {
        //        // int employeeID = findEmployeeID();
        //        try
        //        {

        //            connection.Open();
        //            SqlCommand command = new SqlCommand("getCasdro", connection);
        //            command.CommandType = CommandType.StoredProcedure;
        //            // command.Parameters.Add(new SqlParameter("@EmployeeID", employeeID));
        //            command.CommandTimeout = 5;

        //            using (SqlDataReader dr = command.ExecuteReader())
        //            {
        //                if (dr.HasRows)
        //                {
        //                    while (dr.Read())
        //                    {
        //                        //ip = dr["ip"].ToString();
        //                        //alias = dr["alias"].ToString();

        //                    }
        //                }

        //            }
        //            return ds;
        //        }
        //        catch (Exception)
        //        {
        //            if (connection.State == System.Data.ConnectionState.Open) connection.Close();
        //        //    return ds;
        //        }

        //    }

        //}




        static public DataSet GetDataSet(string ConnectionString, string SQL)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = SQL;
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            conn.Open();
            da.Fill(ds);
            conn.Close();

            return ds;
        }
        


    }
}
