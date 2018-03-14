using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sarasavi.Model;
using Sarasavi.NewException;
using Sarasavi.Controller.DBOparation;


namespace Sarasavi.Controller
{
    public class PublisherController
    {

        private Boolean Check(Publisher publisher)
        {
            Boolean boolVal = true;

            if (publisher.getPublisherName() == null || publisher.getPublisherName() == "")
            {
                boolVal = false;
                throw new NullPublisherNameException();
            }
            return boolVal;
        }

        public String Add(Publisher publisher)
        {
            String publisherId = "";

            if (Check(publisher))
            {
                DBPublisher db = new DBPublisher();
                publisherId = db.Add(publisher);
            }
            return publisherId;
        }


    }
}