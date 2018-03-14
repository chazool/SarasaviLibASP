using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace Sarasavi.Controller
{
    public class DBConnection
    {
        private SqlConnection con;

        public DBConnection()
        {


            con = new SqlConnection("Data Source=DESKTOP-U8QF8JC;Initial Catalog=SarasaviLibraryDB;Integrated Security=True");

        }


        public SqlConnection getConnection()
        {

            return con;
        }
        
    }
}