using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sarasavi.Model;
using Sarasavi.NewException;


namespace Sarasavi.View
{
    public partial class AuthorRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            String Message = "";
            
            Author author = new Author();
            author.setAuthorName(txtAuthorName.Text);


            try
            {
              txtAuthorID.Text= author.Add(author);

            }
            catch (nullAuthorNameException ex)
            {
                Message = "Invalid Author Name";
            }
            lblMessage.Text = Message;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtAuthorID.Text = "";
            txtAuthorName.Text = "";
            lblMessage.Text = "";
        }
    }
}