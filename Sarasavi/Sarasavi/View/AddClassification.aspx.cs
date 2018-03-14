using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sarasavi.Model;
using Sarasavi.Controller;
using Sarasavi.NewException;

namespace Sarasavi.View
{
    public partial class AddClassification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtClassificationID.Text = "";
            txtDescription.Text = "";
            txtTitle.Text = "";
            lblMessage.Text = "";

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            String Message="";
            Classification classification = new Classification();

            classification.setTitle (txtTitle.Text);
            classification.setDescription(txtDescription.Text);

            try
            {
                txtClassificationID.Text = classification.Add(classification);
            }
            catch (nullTitleException ex)
            {
                Message = "Invalid Title";
            }
           

            lblMessage.Text = Message;
           
        }
    }
}