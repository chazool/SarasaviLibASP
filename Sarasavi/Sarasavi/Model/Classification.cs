using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sarasavi.Controller;

namespace Sarasavi.Model
{
    public class Classification : ClassificationController
    {

        private String ClassificationId;
        private String Title;
        private String Description;

        public void setClassificationId(String ClassificationId)
        {
            this.ClassificationId = ClassificationId;
        }

        public String getClassificationId()
        {
            return ClassificationId;
        }

        public void setTitle(String Title)
        {
            this.Title = Title;
        }

        public String getTitle()
        {
            return Title;
        }

        public void setDescription(String Description)
        {
            this.Description = Description;
        }

        public String getDescription()
        {
            return Description;
        }

    }
}