using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sarasavi.Model
{
    public class Loan
    {
        private String LoanId;
        private String MemberId;
        private String BorowDate;
        private String ReturnDate;
        private List<String> BookId;
        private int IsCanceld;

        public void setLoanId(String LoanId)
        {
            this.LoanId = LoanId;
        }

        public String getLoanId()
        {
            return LoanId;
        }

        public void setMemberId(String MemberId)
        {
            this.MemberId = MemberId;
        }

        public String getMemberId()
        {
            return MemberId;
        }

        public void setBorowDate(String BorowDate)
        {
            this.BorowDate = BorowDate;
        }

        public String getBorowDate()
        {
            return BorowDate;
        }

        public void setReturnDate(String ReturnDate)
        {
            this.ReturnDate = ReturnDate;
        }

        public String getReturnDate()
        {
            return ReturnDate;
        }

        public void setBookId(List<String> BookId)
        {
            this.BookId = BookId;
        }

        public List<String> getBookId()
        {
            return BookId;
        }

        public void setIsCanceld(int IsCanceld)
        {
            this.IsCanceld = IsCanceld;
        }

        public int getIsCanceld()
        {
            return IsCanceld;
        }
    }
}