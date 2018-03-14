using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sarasavi.Model;
using System.Data.SqlClient;
namespace Sarasavi.Controller.DBOparation
{
    public class DBPublisher
    {

          private SqlConnection con;


          public DBPublisher()
        {
            DBConnection db = new DBConnection();
            con = db.getConnection();
        }



        public String Add(Publisher publisher)
        {
            String publisherId="";

            String Name = publisher.getPublisherName();
            String RegID = publisher.getRegNo();

            con.Open();

            String sqlRowCount = "Select Count(*) From Publisher";
            SqlCommand sqlCmd1 = new SqlCommand(sqlRowCount, con);

            int rowCount = (int)sqlCmd1.ExecuteScalar();
            rowCount = rowCount + 1;

            publisherId = "P" + rowCount;

            String sqlInsert = "Insert Into Publisher Values('" + publisherId + "','" + Name + "','"+RegID+"')";
            SqlCommand sqlCmd2 = new SqlCommand(sqlInsert, con);
            sqlCmd2.ExecuteNonQuery();

            con.Close();
            return publisherId;


        }




    }
}