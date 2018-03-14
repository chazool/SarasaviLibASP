<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BorrowLoan.aspx.cs" Inherits="Sarasavi.View.BorrowLoan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="FormStyle.css" rel="stylesheet" />
    <link href="MenuBar.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <table border="0">
            <tr>
                <td align="Center">
                    <img src="Sarasavi.jpg" width="50%" /></td>
            </tr>

            <tr>
                <td align="Center">
                    <div class="nav">
                        <ul>
                          <li class="tutorials">
                                <a href="UserRegistration.aspx">Add User</a></li>
                             <li class="tutorials">
                                <a href="Home.aspx">Home</a></li>
                            <li class="about">
                                <a href="BookReg.aspx">Add Book</a></li>
                            <li class="news">
                                <a href="Inquiry.aspx">Inquiry </a></li>
                            <li class="news">
                                <a href="BookReservation.aspx">Reservation </a></li>
                            <li class="news">
                                <a class="active" href="BorrowLoan.aspx">Loan</a></li>
                            <li class="news">
                                <a href="Return.aspx">Retun</a></li>
                            <li class="contact">
                                <a href="Login.aspx">LogOut</a></li>
                        </ul>
                    </div>
                </td>
            </tr>


            <tr>
                <td>

        <table border="0" width="25%" align="Center" class='panel-body'>
                    
                        <tr>
                            <td colspan="2">
                                <div class='panel panel-primary dialog-panel'>

                                    <h5 class='panel-heading'>Borrow Loan</h5>
                                </div>
                            </td>
                        </tr>
            <tr>
                <td align="Right">
                    <asp:Label ID="Label1" runat="server" Text="Loan ID:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtLoanId" runat="server" ReadOnly="True" CssClass="inputs" placeholder="Loan ID"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td align="Right">
                    <asp:Label ID="Label2" runat="server" Text="MemberID:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMemberId" runat="server" CssClass="inputs" placeholder="Member ID"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td align="Right" valign="Top">
                    <asp:Label ID="Label4" runat="server" Text="BookID:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBook1" runat="server" CssClass="inputs" placeholder="Book ID 1"></asp:TextBox>
                     
                </td>
            </tr>
            <Tr>
                <td></td>
                 <td> <asp:TextBox ID="txtBook2" runat="server" CssClass="inputs" placeholder="Book ID 2" ></asp:TextBox></td>
            </Tr>

             <Tr>
                <td></td>
                 <td> <asp:TextBox ID="txtBook3" runat="server" CssClass="inputs" placeholder="Book ID 3"></asp:TextBox></td>
            </Tr>

             <Tr>
                <td></td>
                 <td> <asp:TextBox ID="txtBook4" runat="server" CssClass="inputs" placeholder="Book ID 4" ></asp:TextBox></td>
            </Tr>

             <Tr>
                <td></td>
                 <td> <asp:TextBox ID="txtBook5" runat="server" CssClass="inputs" placeholder="Book ID 5" ></asp:TextBox></td>
            </Tr>


            <tr>
                <td align="Right">
                    <asp:Label ID="Label5" runat="server" Text="ReturnDate:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtReturnDate" runat="server" CssClass="inputs" placeholder="Return Date"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td align="Right">
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td align="Right">
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="CancelButton" OnClick="btnCancel_Click"/>
                    <asp:Button ID="btnAdd" runat="server" Text="Borrow" CssClass="SaveButton" OnClick="btnAdd_Click" />
                </td>
            </tr>
            </table>
                    </td>
            </tr>
        </table>
    </form>
</body>
</html>
