using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WpfApp1
{
    class Data_Rowcs
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Date_From { get; set; }
        public DateTime Date_To { get; set; }

        public void InsertRow()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }



            SqlCommand cmd = new SqlCommand("Proc_InsertData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@price", Price);
            cmd.Parameters.AddWithValue("@date_from", Date_From);
            cmd.Parameters.AddWithValue("@date_to", Date_To);

            cmd.ExecuteNonQuery();



            if (con.State != System.Data.ConnectionState.Closed)
            {
                con.Close();
            }
            

            
        }

    }
}
