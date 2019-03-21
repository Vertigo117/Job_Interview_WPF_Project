using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WpfApp1
{
    class UserInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool CheckUserInfo()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Database1ConnectionString);
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }



            SqlCommand cmd = new SqlCommand("Proc_CheckUserInfo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", UserName);
            cmd.Parameters.AddWithValue("@password", Password);

            SqlParameter outputParameter = new SqlParameter();
            outputParameter.ParameterName = "@counter";
            outputParameter.SqlDbType = SqlDbType.Int;
            outputParameter.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputParameter);

            cmd.ExecuteNonQuery();



            int counter = 0;
            counter = Convert.ToInt32(outputParameter.Value);
            con.Close();

            if (counter > 1)
                return true;
            else
                return false;
        }
    }
}
