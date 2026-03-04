using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsDataAccessStockHistory
    {

        public static DataTable GetDataFromStockHistory()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string Query = "SELECT * FROM StockHistory;";

                using (SqlCommand cmd = new SqlCommand(Query,con))
                {
                    con.Open();

                    SqlDataReader Read = cmd.ExecuteReader();
                    dt.Load(Read);
                }
            }

            return dt;
        }


    }
}
