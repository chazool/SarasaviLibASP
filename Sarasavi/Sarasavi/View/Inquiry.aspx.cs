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
    public partial class Inquiry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            String Message = "";


            try
            {
                BookController controller = new BookController();
            Book book=controller.Search(txtBookId.Text);
            // Set Book Data
            txtBookName.Text = book.getBookName();
            txtBookStatus.Text = book.getBookStatus();
            txtBookTitle.Text = book.getBookTitle();
            txtCopys.Text = book.getNoOfCopys().ToString();
            }
            catch (nullIDException Ex)
            {

                Message = "Invalid Book Id";
            }

            lblMessage.Text = Message;
        }
    }
}