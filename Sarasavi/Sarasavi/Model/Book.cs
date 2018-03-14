using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sarasavi.Model
{
    public class Book
    {
        private String BookId;
        private String BookName;
        private String BookTitle;
        private String ClasificationID;
        private String PublisherId;
        private String ISBM;
        private String BookStatus;
        private int NoOfCopys;
        private List<String> Author;

        public void SetBookId(String BookId)
        {
            this.BookId = BookId;
        }

        public String getBookId()
        {
            return BookId;
        }

        public void setBookName(String BookName)
        {
            this.BookName = BookName;
        }

        public String getBookName()
        {
            return BookName;
        }

        public void setBookTitle(String BookTitle)
        {
            this.BookTitle = BookTitle;
        }

        public String getBookTitle()
        {
            return BookTitle;
        }

        public void SetClasificationID(String ClasificationID)
        {
            this.ClasificationID = ClasificationID;
        }

        public String getClasificationID()
        {
            return ClasificationID;
        }

        public void SetPublisherId(String PublisherId)
        {
            this.PublisherId = PublisherId;
        }

        public String getPublisherId()
        {
            return PublisherId;
        }

        public void setISBM(String ISBM)
        {
            this.ISBM = ISBM;
        }

        public String getISBM()
        {
            return ISBM;
        }

        public void setBookStatus(String BookStatus)
        {
            this.BookStatus = BookStatus;
        }

        public String getBookStatus()
        {
            return BookStatus;
        }

        public void setAuthor(List<String> Author)
        {
            this.Author = Author;
        }

        public List<String> getAuthor()
        {
            return Author;
        }

        public void setNoOfCopys(int NoOfCopys)
        {
            this.NoOfCopys = NoOfCopys;
        }

        public int getNoOfCopys()
        {
            return NoOfCopys;
        }


    }
}