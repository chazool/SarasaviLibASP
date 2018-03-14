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
    public partial class BookReg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtBookId.Text = "";
            txtBookName.Text = "";
            txtBookStatus.Text = "";
            txtBookTitle.Text = "";
            txtCopys.Text = "";
            txtISBM.Text = "";
            ddlAuthor1.SelectedIndex = 0;
            ddlAuthor2.SelectedIndex = 0;
            ddlAuthor3.SelectedIndex = 0;
            ddlAuthor4.SelectedIndex = 0;
            ddlAuthor5.SelectedIndex = 0;
            ddlClassification.SelectedIndex = 0;
            ddlPublisher.SelectedIndex = 0;

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book();

            // Start Create Author List
            List<String> list = new List<string>();
            list.Add(ddlAuthor1.SelectedValue);
            list.Add(ddlAuthor2.SelectedValue);
            list.Add(ddlAuthor3.SelectedValue);
            list.Add(ddlAuthor4.SelectedValue);
            list.Add(ddlAuthor5.SelectedValue);
            // End Get Author List

            // Set Book Data to Book Object 

            book.SetBookId(txtBookId.Text);
            book.setBookName(txtBookName.Text);
            book.setBookTitle(txtBookTitle.Text);
            book.setAuthor(list);
            book.SetClasificationID(ddlClassification.SelectedValue);
            book.SetPublisherId(ddlPublisher.SelectedValue);
            book.setISBM(txtISBM.Text);
            book.setNoOfCopys(Convert.ToInt16(txtCopys.Text));
            book.setBookStatus(txtBookStatus.Text);

            BookController bookController = new BookController();

            String Message = "";

            // Save Book Data And Get Exception 
            try
            {
             txtBookId.Text=   bookController.Add(book);
            }
            catch(nullAuthorException ex){
                Message = "Invalid Author";
            }
            catch (NullBookStatusException ex)
            {
                Message = "Invalid Book Book Status";
            }
            catch (NullNoOFCopyException ex)
            {
                Message = "Invalid No Of Copys";
            }
            catch (NullISBMException ex)
            {
                Message = "Invalid ISBM";
            }
            catch (nullPublisherIdException ex)
            {
                Message = "Invalid Author";
            }
            catch (NullClasificationIDException ex)
            {
                Message = "Invalid ClasificationID";
            }
            catch (nullBookTitileException ex)
            {
                Message = "Invalid Book Title";
            }
            catch (nullBookNameException ex)
            {
                Message = "Invalid Book Name";
            }


            // Set Message (Exception Error Message)
            lblMessage.Text = Message;

        }
    }
}