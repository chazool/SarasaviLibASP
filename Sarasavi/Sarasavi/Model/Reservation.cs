using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sarasavi.Model
{
    public class Reservation
    {
        private String MemberId;
        private String BookId;
        private String ReservationDate;

        public void SetMemberId(String MemberId)
        {
            this.MemberId = MemberId;
        }

        public String getMemberId()
        {
            return MemberId;
        }

        public void setBookId(String BookId)
        {
            this.BookId = BookId;
        }

        public String getBookId()
        {
            return BookId;
        }

        public void setReservationDate(String ReservationDate)
        {
            this.ReservationDate = ReservationDate;
        }

        public String getReservationDate()
        {
            return ReservationDate;
        }

      


    }
}