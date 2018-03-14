using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Sarasavi.Model;

namespace Sarasavi.Controller.DBOparation
{
    public class DBLoan
    {
        public Boolean boolSave;
        private SqlConnection con;

        public DBLoan()
        {
            DBConnection db = new DBConnection();
            con = db.getConnection();
        }

        public String Add(Loan loan)
        {
           

            String memberId = loan.getMemberId();
            List<String> bokkIdList = loan.getBookId();
            String retunDate = loan.getReturnDate();
            String borrowDate = loan.getBorowDate();
            int isCanseld = loan.getIsCanceld();

            con.Open();
            String sqlRowCount = "Select count(*) from Loan";
            SqlCommand sqlcmd1 = new SqlCommand(sqlRowCount, con);
            int rowCount = (int)sqlcmd1.ExecuteScalar();
            
            String loanId="L"+rowCount;

            String sqlInsertLoan = "Insert Into Loan Values('" + loanId + "','" + memberId + "','" + borrowDate + "','" + retunDate + "','" + isCanseld + "')";
            SqlCommand sqlcmd2 = new SqlCommand(sqlInsertLoan, con);
           int val1=(int) sqlcmd2.ExecuteNonQuery();

           int val2 = 0;
           foreach (String BookId in bokkIdList)
           {
               if(BookId != null && BookId !=""){
                   String sqlInsertLoanBook = "Insert Into LoanBook Values('" + loanId + "','" + BookId + "')";
                   SqlCommand sqlcmd3 = new SqlCommand(sqlInsertLoanBook, con);
                   val2 = (int)sqlcmd3.ExecuteNonQuery();
               }
          
            }



            if (val1 == 0 && val2==0)
            {
                boolSave = false;
            }
            else if (val1 == 1 && val2 == 1)
            {
                boolSave = true;
            }

            con.Close();
            return loanId;
        }


        public Loan Select(String loanId)
        {
            Loan loan =new Loan();
            con.Open();
            String sqlSelectLoan = "Select * from Loan where LoanId='"+loanId+"'";
            SqlCommand cmd1 = new SqlCommand(sqlSelectLoan, con);
            SqlDataReader reader1=  cmd1.ExecuteReader();

            while (reader1.Read())
            {
                loan.setLoanId(reader1.GetString(0));
                loan.setMemberId(reader1.GetString(1));
                loan.setBorowDate(reader1.GetString(2));
                loan.setReturnDate(reader1.GetString(3));
                loan.setIsCanceld(reader1.GetInt32(4));
            }

            reader1.Close();

            String slqSelectLoanBook = "Select BookId from LoanBook where LoanId='" + loanId + "'";
            SqlCommand cmd2 = new SqlCommand(slqSelectLoanBook,con);
           SqlDataReader reader2= cmd2.ExecuteReader();
           List<String> bookList = new List<string>();
           
           while (reader2.Read())
           {
               bookList.Add(reader2.GetString(0));

            }

            // set Book Id list to Object
           loan.setBookId(bookList);
           reader2.Close();
            con.Close();
            return loan;
        }



        public Boolean Return(int IsCancel, String LoanId)
        {
            Boolean boolVal = false;
           
            String sql = "Update Loan set IsCanceld='"+IsCancel+"' where LoanId='"+LoanId+"'";
            con.Open();

           SqlCommand cmd = new SqlCommand(sql, con);
           int val=(int)cmd.ExecuteNonQuery();
            
            if(val==1){
                boolVal = true;
            }
            
            con.Close();

            return boolVal;
        }

             

    }
}