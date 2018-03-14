using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Sarasavi.Model;
namespace Sarasavi.Controller.DBOparation
{
    public class DBClassification
    {

        private SqlConnection con;

        public DBClassification()
        {
            DBConnection db = new DBConnection();
            con = db.getConnection();
        }


        public String Add(Classification classification)
        {
            String  classificationId="";

            String Title = classification.getTitle();
            string Description = classification.getDescription();

            con.Open();

            String SqlRowCount = "Select count(*) From Classification";
            
            SqlCommand SqlCmd1=new SqlCommand(SqlRowCount,con);

           int RowCount=(int) SqlCmd1.ExecuteScalar();

            RowCount=RowCount+1;
            classificationId = "C" + RowCount;

            String sqlInsert = "Insert Into Classification Values('" + classificationId + "','" + Title + "','" + Description + "')";
            SqlCommand SqlCmd2 = new SqlCommand(sqlInsert, con);

            SqlCmd2.ExecuteNonQuery();

           con.Close();

            return classificationId;
        }



    }
}