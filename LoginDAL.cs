using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLibrary
{
    public class LoginDAL
    {

        public bool VerifyData(Passenger p)
        {
            bool loginStatus = false;
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Airline"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from Passenger where Email = '" + p.Email + "'and Pwd = '" + p.Pwd + "'", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                cn.Close();
                loginStatus = true;
            }
            else
            {
                cn.Close();
                loginStatus = false;
            }

            return loginStatus;
        }
    }
}
