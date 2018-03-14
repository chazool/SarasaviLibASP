using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sarasavi.Model;
using Sarasavi.NewException;
using Sarasavi.Controller.DBOparation;
namespace Sarasavi.Controller

{
    public class ClassificationController
    {

        private Boolean Check(Classification classification)
        {
            Boolean boolVal = true;

            if (classification.getTitle() == null || classification.getTitle() == "")
            {
                boolVal = false;
                throw new nullTitleException();

            }

           

            return boolVal;
 }


        public String Add(Classification classification)
        {
            String classificationId = "";
            if(Check(classification)){
                DBClassification db = new DBClassification();
                classificationId= db.Add(classification);
            }


            return classificationId;
        }

    }
}