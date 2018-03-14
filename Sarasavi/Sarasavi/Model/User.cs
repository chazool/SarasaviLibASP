using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sarasavi.Model
{
    public class User
    {
        private String UserName;
        private String Password;
        private String Name;
        private String DOB;
        private String NIC;
        private char Sex;
        private String UserRole;
        private String Phone;
        private String Email;


        public void setUserName(String UserName)
        {
            this.UserName = UserName;
        }

        public String getUserName()
        {
            return UserName;
        }

        public void setPassword(String Password)
        {
            this.Password = Password;
        }

        public String getPassword()
        {
            return Password;
        }

        public void setName(String Name)
        {
            this.Name = Name;
        }

        public String getName()
        {
            return Name;
        }

        public void setDOB(String DOB)
        {
            this.DOB = DOB;
        }

        public String getDOB()
        {
            return DOB;
        }

        public void setNIC(String NIC)
        {
            this.NIC = NIC;
        }

        public String getNIC()
        {
            return NIC;
        }

        public void setSex(Char Sex)
        {
            this.Sex = Sex;
        }

        public Char getSex()
        {
            return Sex;
        }

        public void setUserRole(String UserRole)
        {
            this.UserRole = UserRole;
        }

        public String getUserRole()
        {
            return UserRole;
        }

        public void setPhone(String Phone)
        {
            this.Phone = Phone;
        }

        public String getPhone()
        {
            return Phone;
        }

        public void setEmail(String Email)
        {
            this.Email = Email;
        }

        public String getEmail()
        {
            return Email;
        }
    }
}