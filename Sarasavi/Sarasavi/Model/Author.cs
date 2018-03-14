using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sarasavi.Controller;

namespace Sarasavi.Model
{
    public class Author : AuthorController
    {
        
        private String AuhorId;
        private String AuthorName;


        public void setAuthorId(String AuthorId)
        {
            this.AuhorId = AuthorId;
        }

        public String getAuthorId()
        {
            return AuhorId;
        }

        public void setAuthorName(String AuthorName)
        {
            this.AuthorName = AuthorName;
        }

        public String getAuthorName()
        {
            return AuthorName;
        }

    }
}