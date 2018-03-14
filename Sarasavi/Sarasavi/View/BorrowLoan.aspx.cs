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
    public partial class BorrowLoan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            Loan loan = new Loan();

            // Start List Book Id
            List<String> BookList = new List<string>();
            BookList.Add(txtBook1.Text);
            BookList.Add(txtBook2.Text);
            BookList.Add(txtBook3.Text);
            BookList.Add(txtBook4.Text);
            BookList.Add(txtBook5.Text);
            // End List Book Id

           // loan.setLoanId(txtLoanId.Text);
            loan.setMemberId(txtMemberId.Text);
            loan.setReturnDate(txtReturnDate.Text);
            loan.setBookId(BookList);
            loan.setBorowDate(DateTime.Today.ToString("dd.MM.yyyy"));
            loan.setIsCanceld(0);

            String Message = "";
            try
            {
                LoanController controller=new LoanController();
                txtLoanId.Text = controller.Add(loan);

                if(controller.boolSave){
                    Message = "Save Success";
                    Cancel();
                }
                else{
                    Message = " Save Unsuccess";
                }
            }
            catch(nullBookNameException ex){
                Message = "Please set Book Id";
            }
            catch (nullIDException ex)
            {
                Message = "Invalid MemberID";
            }
            catch (nullReturnDateException ex)
            {
                Message = "Invalid Return Date";
            }


            lblMessage.Text = Message;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtLoanId.Text = "";
            Cancel();
        }

        private void Cancel()
        {
            
            txtMemberId.Text = "";
            txtReturnDate.Text = "";
            txtBook1.Text = "";
            txtBook2.Text = "";
            txtBook3.Text = "";
            txtBook4.Text = "";
            txtBook5.Text = "";
        }

    }
}