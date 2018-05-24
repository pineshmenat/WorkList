using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkList
{
    class DBUtility
    {
        public static SqlDataReader reader;
        public static SqlCommand cmd;
        public static SqlConnection con;

        public static void connectDB()
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLOCALDB;Initial Catalog=Pomodoro;Integrated Security=True");
            con.Open();
        }

        public static void disconnectDB()
        {
            con.Close();
        }
        
    }
}
