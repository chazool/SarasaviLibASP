using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sarasavi.Model;
using Sarasavi.Controller;
using System.Data.SqlClient;
namespace Sarasavi.Controller.DBOparation
{
    public class DBBook
    {

        private SqlConnection con;

        public DBBook()
        {

            DBConnection DB = new DBConnection();
            con = DB.getConnection();
        }

        public String Add(Book book)
        {

            String BookRegistationNo = "";
            //Opent DConnection 
            con.Open();

            // Create SQl  
            String BookName = book.getBookName();
            String BookTitle = book.getBookTitle();
            String ClassificationID = book.getClasificationID();
            String Publisher = book.getPublisherId();
            String ISBM = book.getISBM();
            String BookStatus = book.getBookStatus();
            int NoofCopys = book.getNoOfCopys();
            String sqlGetRowCout = "Select count(*) FROM Book";
            SqlCommand sqlCom = new SqlCommand(sqlGetRowCout, con);

            int reader = (int)sqlCom.ExecuteScalar();

            BookRegistationNo = "B" + reader;

            String sqlInsertBook = "Insert Into Book values ('" + BookRegistationNo + "','" + BookName + "','" + BookTitle + "','" + ClassificationID + "','" + Publisher + "','" + ISBM + "','" + BookStatus + "')";

            //Sql Insert Book          
            SqlCommand cmd = new SqlCommand(sqlInsertBook, con);
            cmd.ExecuteNonQuery();

            //Sql Insert Book Authors
            String AuthorId = "";
            List<String> AuthorList = book.getAuthor();
            foreach (var value in AuthorList)
            {
                AuthorId = value;
                if (AuthorId != "0")
                {
                    String SqlInsetrBookAuthors = "Insert Into BookAuthor Values ('" + BookRegistationNo + "','" + AuthorId + "')";
                    SqlCommand cmd2 = new SqlCommand(SqlInsetrBookAuthors, con);
                    cmd2.ExecuteNonQuery();
                }
            }
            // Sql Insert Book No Of Copys
            String sqlInsertBookNoOfCopy = "Insert into BookCopy Values ('" + BookRegistationNo + "','" + NoofCopys + "','" + NoofCopys + "')";
            SqlCommand cmd3 = new SqlCommand(sqlInsertBookNoOfCopy, con);
            cmd3.ExecuteNonQuery();
            con.Close();

            return BookRegistationNo;
        }


        public Book Search(String BookId)
        {
            Book book =new  Book();

            con.Open();
            String SqlSearch = "Select * from Book where BookID='" + BookId + "'";
            SqlCommand cmd = new SqlCommand(SqlSearch, con);
            SqlDataReader reader = cmd.ExecuteReader();


            String id = "";
            String  BookName = "";
            String BookTitle = "";
            String BookClassification = "";
            String BookPublisher = "";
            String BOOkISBM = "";
            String BookStatus = "";

            int NoofCopy = 0;
            if (reader.HasRows)
            {

                while (reader.Read())
                {

                    id = reader.GetString(0);
                    BookName = reader.GetString(1);
                    BookTitle = reader.GetString(2);
                    BookClassification = reader.GetString(3);
                    BookPublisher = reader.GetString(4);
                    BOOkISBM = reader.GetString(5);
                    BookStatus = reader.GetString(6);
                }
            }

            reader.Close();

            String sqlSearchAvalblleCopy = "Select Availble from [SarasaviLibraryDB].[dbo].[BookCopy] where BookID='" + BookId + "'";
            SqlCommand cmd2 = new SqlCommand(sqlSearchAvalblleCopy,con);
            SqlDataReader reader2 = cmd2.ExecuteReader();

            if (reader2.HasRows)
            {

                while (reader2.Read())
                {
                    NoofCopy = reader2.GetInt32(0);
                }
            }

            reader.Close();
            
            book.setBookName(id);
            book.setBookName(BookName);
            book.setBookTitle(BookTitle);
            book.SetClasificationID(BookClassification);
            book.SetPublisherId(BookPublisher);
            book.setISBM(BOOkISBM);
            book.setBookStatus(BookStatus);

            // set Avalble Copy
            book.setNoOfCopys(NoofCopy);

            con.Close();
            return book;
        }


    }
}