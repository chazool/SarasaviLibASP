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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btlLogin_Click(object sender, EventArgs e)
        {
            String Message = "";
            try
            {
                UserController controller = new UserController();
                User user = new User();
                user.setUserName(txtUserId.Text);
                user.setPassword(txtPassword.Text);

                if (controller.Login(user))
                {
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    Message = "Invalid Input";
                }

            }
            catch (NullPasswordException Ex)
            {

                Message = "Invalid Password";

            }
            catch (nullUserIdException ex)
            {

                Message = "Invalid User Id";
            }
            lblMessage.Text = Message;
        }
    }


}
