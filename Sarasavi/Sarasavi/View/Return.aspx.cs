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
    public partial class Return : System.Web.UI.Page
    {
        private LoanController controlle = new LoanController();
        private String LoanId;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            String Message = "";
            if (controlle.ReturnLoan(1, txtLoanId.Text))
            {
                Cancel();
                Message = "Success";
            }
            else
            {
                Message = "Unsuccess";

            }

            lblMessage.Text = Message;
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {

            String Message = "";
            try
            {
               // LoanController controlle = new LoanController();
                Loan loan; loan = controlle.Select(txtLoanId.Text);
                txtMemberId.Text = loan.getMemberId();
                txtReturnDate.Text = loan.getReturnDate();


                // set Loan Id Globle PM
                this.LoanId = txtLoanId.Text;
                // End set 
                List<String> bookList = loan.getBookId();

                // Set Book Id
                int listCount = 0;
               
                foreach (String value in bookList)
                {
                    listCount = listCount + 1;
                    if(listCount==1){
                        txtBook1.Text = value;
                    }
                    else if (listCount == 2)
                    {
                        txtBook2.Text = value;
                    }
                    else if (listCount == 3)
                    {
                        txtBook3.Text = value;
                    }
                    else if (listCount == 4)
                    {
                        txtBook4.Text = value;
                    }
                    else if (listCount == 5)
                    {
                        txtBook5.Text = value;
                    }
                } 
                
            }
            catch (nullIDException Ex)
            {
                Message = "Invalid LoanId";
            }

            lblMessage.Text = Message;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtLoanId.Text = "";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }


        private void Cancel()
        {
            txtLoanId.Text="";
            txtMemberId.Text="";
            txtReturnDate.Text="";
            txtBook1.Text = "";
            txtBook2.Text = "";
            txtBook3.Text = "";
            txtBook4.Text = "";
            txtBook5.Text = "";
        }

    }
}