using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sarasavi.Model;
using Sarasavi.NewException;
using Sarasavi.Controller;
namespace Sarasavi.View
{
    public partial class AddPublisher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Publisher publisher = new Publisher();

            publisher.setPublisherName(txtPublisherName.Text);
            publisher.setRegNo(txtRegistationNo.Text);


            String Message = "";
            try
            {
                PublisherController controle = new PublisherController();

                txtPublisherID.Text = controle.Add(publisher);

            }
            catch (NullPublisherNameException ex)
            {
                Message = "Invalid Publisher Name";
            }

            lblMessage.Text = Message;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtPublisherID.Text = "";
            txtPublisherName.Text = "";
            txtRegistationNo.Text = "";
            lblMessage.Text = "";
        }
    }
}