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
    public partial class UserRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.setPassword(txtPassword.Text);
            user.setName(txtFname.Text + " " + txtLname.Text);
            user.setDOB(txtDOB.Text);
            user.setNIC(txtNIC.Text);
            user.setSex(Convert.ToChar(ddlSex.SelectedValue));
            user.setUserRole(ddlUserRole.Text);
            user.setPhone(txtPhone.Text);
            user.setEmail(txtEmail.Text);
            
            String Message="";
           

            try
            {
                 UserController  userController=new UserController();
               txtUserId.Text=  userController.Add(user);
            }
            catch (nullNameException ex)
            {
                Message = "Invalid Name";

            }
            catch (NullDOBException ex)
            {

                Message = "Invalid DOB";
            }
            catch (NullNICException ex)
            {

                Message = "Invalid NIC";
            }
            catch (NullSexException ex)
            {
                Message = "Invalid Sex";

            }
            catch (NullUserRoleException ex)
            {
                Message = "Invalid UserRole";

            }
            catch (NullPasswordException ex)
            {
                Message = "Invalid Password";

            }
            catch (NullPhoneException ex)
            {
                Message = "Invalid Phone";

            }

            lblMessage.Text=Message;
        }

        protected void ddlUserRole0_Load(object sender, EventArgs e)
        {
            
        }
    }
}