using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sarasavi.Model;
using Sarasavi.NewException;
using Sarasavi.Controller.DBOparation;
namespace Sarasavi.Controller
{
    public class ReservationController
    {

        public Boolean SeccessBool;

        public Boolean Check(Reservation reervation)
        {
            Boolean boolval = true;
            if (reervation.getBookId() == null || reervation.getBookId() == "")
            {
                boolval = false;
                throw new nullIDException();
                
            }

            if (reervation.getMemberId() == null || reervation.getMemberId() == "")
            {
                boolval = false;
                throw new nullUserIdException();

            }


            return boolval;
        }

        public void Add(Reservation reservation)
        {
            if(Check(reservation)){

                DBReservation db = new DBReservation();
                db.Add(reservation);
               this.SeccessBool= db.SeccessBool;
            }


        }
    }
}