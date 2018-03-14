using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Sarasavi.Model;
namespace Sarasavi.Controller.DBOparation
{
    public class DBAuthor
    {

        private SqlConnection con;


        public DBAuthor()
        {
            DBConnection db = new DBConnection();
            con = db.getConnection();
        }


        public String Add(Author author)
        {
            String AuthorId = "";

            String AuthorName = author.getAuthorName();

            con.Open();

            String sqlRowCount = "Select Count(*) From Author";
            SqlCommand sqlCmd1 = new SqlCommand(sqlRowCount, con);

            int rowCount = (int)sqlCmd1.ExecuteScalar();
            rowCount = rowCount + 1;

            AuthorId="A"+rowCount;

            String sqlInsert = "Insert Into Author Values('"+AuthorId+"','"+AuthorName+"')";
             SqlCommand sqlCmd2 = new SqlCommand(sqlInsert, con);
             sqlCmd2.ExecuteNonQuery();

            con.Close();
            return AuthorId;
        }


    }
}