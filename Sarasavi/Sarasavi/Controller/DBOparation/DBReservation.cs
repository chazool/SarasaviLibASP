using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sarasavi.Model;
using System.Data.SqlClient;

namespace Sarasavi.Controller.DBOparation
{
    public class DBReservation
    {

        SqlConnection con;
        public Boolean SeccessBool;
        public DBReservation()
        {
            DBConnection db = new DBConnection();
            con= db.getConnection();

        }

        public void Add(Reservation reservation)
        {

            String BookId = reservation.getBookId();
            String MemberId = reservation.getMemberId();
            String rDate = reservation.getReservationDate();

            String SqlInsert = "Insert into Reservation Values ('"+MemberId+"','"+BookId+"','"+rDate+"')";

            con.Open();

            SqlCommand cmd = new SqlCommand(SqlInsert,con);

          int val=  cmd.ExecuteNonQuery();

           if(val==1){
               this.SeccessBool = true;
           }
           else if(val==0){
               this.SeccessBool = false;

           }

            
        }
    }
}