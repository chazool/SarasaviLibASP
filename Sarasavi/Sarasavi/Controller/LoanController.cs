using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sarasavi.Model;
using Sarasavi.NewException;
using Sarasavi.Controller.DBOparation;
namespace Sarasavi.Controller
{
    public class LoanController
    {
        public Boolean boolSave;
        public Boolean Check(Loan loan)
        {
            Boolean boolval = true;


            if (loan.getMemberId() == null || loan.getMemberId() == "")
            {
                boolval = false;
                throw new nullIDException();
            }


            if (loan.getReturnDate() == null || loan.getReturnDate() == "")
            {
                boolval = false;
                throw new nullReturnDateException();
            }

            // Check Book Id
            Boolean boolValBookId = false;
            foreach (String bookId in loan.getBookId())
            {

                if (bookId == null || bookId == "")
                {
                    boolValBookId = false;
                }
                else
                {
                    boolValBookId = true;
                    break;
                }
            }

            if (boolValBookId == false)
            {
                throw new nullBookNameException();
            }
            // End Check Book Id


            return boolval;
        }

        public String Add(Loan loan)
        {
            String LoanID = "";

            if (Check(loan))
            {
                DBLoan db = new DBLoan();
                LoanID = db.Add(loan);
                boolSave = db.boolSave;
            }


            return LoanID;
        }


        public Loan Select(String loanId)
        {
            Loan loan=new Loan() ;

            Boolean CheckBool;

            // Check Loan Id
            if (loanId == null || loanId == "")
            {
                CheckBool = false;
                throw new nullIDException();
            }
            else
            {
                CheckBool = true;
            }

            // End Check Loan ID


            if (CheckBool)
            {
                DBLoan db = new DBLoan();

                loan = db.Select(loanId);
            }
           

            
            return loan;
        }


        public Boolean ReturnLoan(int isCancel,String LoanId)
        {
            
            DBLoan db = new DBLoan();
          Boolean boolVal=  db.Return(isCancel, LoanId);
            
          return boolVal;
        }



    }




}