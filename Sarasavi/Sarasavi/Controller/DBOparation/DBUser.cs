using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sarasavi.Model;
using System.Data.SqlClient;
using Sarasavi.Controller.DBOparation;
namespace Sarasavi.Controller.DBOparation
{
    public class DBUser
    {

        private SqlConnection con;

        public DBUser()
        {
            DBConnection db = new DBConnection();
            con = db.getConnection();
        }


        public String Add(User user)
        {
            String UserName = "";


            String Name = user.getName();
            String DOB = user.getDOB();
            String NIC = user.getNIC();
            char Sex = user.getSex();
            String UserRole = user.getUserRole();
            String Password = user.getPassword();
            String Phone = user.getPhone();
            String Email = user.getEmail();


            con.Open();

            String sqlRowCount = "Select Count(*) From  [SarasaviLibraryDB].[dbo].[User]";
            SqlCommand sqlCmd = new SqlCommand(sqlRowCount, con);

            int RowCount = (int)sqlCmd.ExecuteScalar();
            RowCount = RowCount + 1;
            UserName = "U" + UserRole.Substring(0, 1) + RowCount;

            String sqlInsert = "INSERT INTO [dbo].[User] ([UserName] ,[Password] ,[Name],[DOB],[NIC],[Sex],[UserRole],[Phone],[Email]) VALUES('" + UserName + "','" + Password + "','" + Name + "','" + DOB + "','" + NIC + "','" + Sex + "','" + UserRole + "','" + Phone + "','" + Email + "')";
            SqlCommand sqlCmd2 = new SqlCommand(sqlInsert, con);
            sqlCmd2.ExecuteNonQuery();

            con.Close();
            return UserName;
        }


        public String Login(String UserId)
        {
            String Password = "";

            String SqlSelect = "Select Password from [SarasaviLibraryDB].[dbo].[User] where UserName='" + UserId + "'";

            con.Open();

            SqlCommand cmd = new SqlCommand(SqlSelect, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {

                    Password = reader.GetString(0);
                }
            }

            con.Close();


            return Password;
        }


    }
}