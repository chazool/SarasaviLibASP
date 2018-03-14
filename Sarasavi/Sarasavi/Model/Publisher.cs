using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sarasavi.Model
{
    public class Publisher
    {
        private String PublisherId;
        private String PublisherName;
        private String RegNo;

        public void setPublisherId(String PublisherId)
        {
            this.PublisherId = PublisherId;
        }

        public String getPublisherId()
        {
            return PublisherId;
        }

        public void setPublisherName(String PublisherName)
        {
            this.PublisherName = PublisherName;
        }

        public String getPublisherName()
        {
            return PublisherName;
        }

        public void setRegNo(String RegNo)
        {
            this.RegNo = RegNo;
        }

        public String getRegNo()
        {
            return RegNo;
        }
    }
}