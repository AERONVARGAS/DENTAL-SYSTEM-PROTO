using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Serialization.Configuration;
using System.Data;

namespace DENTAL_SYSTEM_PROTOTYPE
{
    internal class MYPatient
    {
        public void AddPatient(string query)
        {
            ConnectionString MyConnection= new ConnectionString();
            SqlConnection con = MyConnection.connection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= con;    
            con.Open();
            cmd.CommandText= query;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeletePatient(string query)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection con = MyConnection.connection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void UpdatePatient(string query)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection con = MyConnection.connection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

        }


        public DataSet ShowPatient(string query)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection con = MyConnection.connection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= con;
            cmd.CommandText= query;
            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlData.Fill(ds);
            return ds;
        }
    }
}
