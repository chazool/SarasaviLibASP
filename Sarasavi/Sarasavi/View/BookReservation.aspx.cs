using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sarasavi.Controller;
using Sarasavi.Model;
using Sarasavi.NewException;

namespace Sarasavi.View
{
    public partial class BookReservation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtBookResevationDate.Text = DateTime.Today.ToString("dd.MM.yyyy");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.setBookId(txtBookid.Text);
            reservation.SetMemberId(txtMemberId.Text);
            reservation.setReservationDate(txtBookResevationDate.Text);

            String Message = "";
            try
            {
                ReservationController controller = new ReservationController();
                controller.Add(reservation);
                if (controller.SeccessBool)
                {
                    Message = "Save Success";
                    Cancel();
                }
                else
                {
                    Message = "Unsuccess";

                }
            }
            catch (nullIDException ex)
            {
                Message = "Invalid Book ID";

            }
            catch (nullUserIdException ex)
            {
                Message = "Invalid Member IDs";

            }

            lblMessage.Text = Message;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }


        private void Cancel()
        {
            txtBookid.Text = "";
            txtBookResevationDate.Text = "";
            txtMemberId.Text = "";
        }
    }
}