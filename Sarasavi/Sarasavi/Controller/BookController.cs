using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sarasavi.Model;
using Sarasavi.NewException;
using Sarasavi.Controller.DBOparation;
namespace Sarasavi.Controller
{
    public class BookController
    {

        private Boolean Check(Book book)
        {
            Boolean booleanVal = true;
            if (book.getBookName() == null || book.getBookName() == "")
            {
                booleanVal = false;
                throw new nullBookNameException();
            }

            if (book.getBookTitle() == null || book.getBookTitle() == "")
            {
                booleanVal = false;
                throw new nullBookTitileException();
            }

            if (book.getClasificationID() == null || book.getClasificationID() == "")
            {
                booleanVal = false;
                throw new NullClasificationIDException();
            }

            if (book.getPublisherId() == null || book.getPublisherId() == "")
            {
                booleanVal = false;
                throw new nullPublisherIdException();
            }

            if (book.getISBM() == null || book.getISBM() == "")
            {
                booleanVal = false;
                throw new NullISBMException();
            }

            if (book.getNoOfCopys() == 0)
            {
                booleanVal = false;
                throw new NullNoOFCopyException();
            }

            if (book.getBookStatus() == null || book.getBookStatus() == "")
            {
                booleanVal = false;
                throw new NullBookStatusException();
            }

            // Check Book Author
            foreach (var author in book.getAuthor())
            {
                if (author == null || author == "")
                {
                    booleanVal = false;
                    throw new nullAuthorException();
                }
            }


            return booleanVal;
        }


        public String Add(Book book)
        {
            String BookRegistationNo = "";
            if (this.Check(book))
            {
                DBBook db = new DBBook();
                BookRegistationNo = db.Add(book);
            }


            return BookRegistationNo;
        }



        public Book Search(String BookId)
        {
            Book book = null;

            if (BookId == null || BookId == "")
            {
                throw new nullIDException();
            }
            else
            {
                DBBook db = new DBBook();
                book = db.Search(BookId);
            }

            return book;
        }


       

    }
}