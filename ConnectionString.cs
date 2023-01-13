using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace DENTAL_SYSTEM_PROTOTYPE
{
    internal class ConnectionString
    {
        public SqlConnection connection() 
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = 
           @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AERON\Documents\DentalDb.mdf;Integrated Security=True;Connect Timeout=30";
            return con; 
        }
    }
}
