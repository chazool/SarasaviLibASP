using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sarasavi.Model;
using Sarasavi.NewException;
using Sarasavi.Controller.DBOparation;
namespace Sarasavi.Controller
{
    public class UserController
    {
        /***
         * User Data Check Point 
         * */
        private Boolean Check(User user)
        {
            Boolean boolVal = true;
            if (user.getName() == null || user.getName() == "")
            {
                boolVal = false;
                throw new nullNameException();
            }

            if (user.getDOB() == null)
            {
                boolVal = false;
                throw new NullDOBException();
            }

            if (user.getNIC() == null || user.getNIC() == "" || user.getNIC().Length != 10)
            {
                boolVal = false;
                throw new NullNICException();
            }

            if (user.getSex() == null || user.getSex().ToString().Length != 1)
            {
                boolVal = false;
                throw new NullSexException();
            }

            if (user.getUserRole() == null || user.getUserRole() == "")
            {
                boolVal = false;
                throw new NullUserRoleException();
            }

            if (user.getPassword() == null || user.getPassword() == "" || user.getPassword().Length < 5)
            {
                boolVal = false;
                throw new NullPasswordException();
            }

            if (user.getPhone() == null || user.getPhone() == "" || user.getPhone().Length != 10)
            {
                boolVal = false;
                throw new NullPhoneException();
            }


            return boolVal;
        }


        public String Add(User user)
        {
            String UserName = "";

            if (Check(user))
            {
                DBUser db = new DBUser();
                UserName = db.Add(user);
            }

            return UserName;
        }



        public Boolean Login(User User)
        {
            Boolean boolval = false;

            String Password = "";


            if (User.getUserName() != null || User.getUserName() != "")
            {

                DBUser db = new DBUser();
                Password = db.Login(User.getUserName());

                if (Password == User.getPassword())
                {
                    boolval = true;
                }

                if (Password == null || Password == "")
                {
                    throw new NullPasswordException();
                }
                else
                {
                    if (Password == User.getPassword())
                    {
                        boolval = true;
                    }
                    else
                    {
                        boolval = false;
                    }
                }
            }
            else
            {
                throw new nullUserIdException();
            }

            return boolval;
        }



    }
}
