using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sarasavi.Model;
using Sarasavi.NewException;
using Sarasavi.Controller.DBOparation;
namespace Sarasavi.Controller
{
    public class AuthorController
    {

        private Boolean check(Author author)
        {
            Boolean boolVal = true;
            if (author.getAuthorName()== null || author.getAuthorName() == "")
            {
                boolVal = false;
                throw new nullAuthorNameException();
            }

            return boolVal;
        }



        public String Add(Author author)
        {
            String authorId = "";

            if (check(author))
            {
                DBAuthor db=new DBAuthor();
                authorId = db.Add(author);
            }

            return authorId;
        }
    }
}