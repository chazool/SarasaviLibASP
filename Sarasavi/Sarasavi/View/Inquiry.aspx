<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inquiry.aspx.cs" Inherits="Sarasavi.View.Inquiry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="FormStyle.css" rel="stylesheet" />
    <link href="MenuBar.css" rel="stylesheet" />
    <title></title>
</head>
<body>

    <table>

        <tr>
            <td align="Center">
                <img src="Sarasavi.jpg" width="50%" /></td>
        </tr>

        <tr>
            <td align="Center">
                <div class="nav">
                    <ul>
                        <li class="home">
                            <a href="Home.aspx">Home</a></li>
                        <li class="tutorials">
                            <a href="UserRegistration.aspx">Add User</a></li>
                        <li class="about">
                            <a href="BookReg.aspx">Add Book</a></li>
                        <li class="news">
                            <a class="active" href="Inquiry.aspx">Inquiry </a></li>
                        <li class="news">
                            <a href="BookReservation.aspx">Reservation </a></li>
                        <li class="news">
                            <a href="BorrowLoan.aspx">Loan</a></li>
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
                    <form id="form1" runat="server">

                        <tr>
                            <td colspan="2">
                                <div class='panel panel-primary dialog-panel'>

                                    <h5 class='panel-heading'>Inquiry Book</h5>
                                </div>
                            </td>
                        </tr>


                        <tr>
                            <td align="Right">
                                <asp:Label ID="Label1" runat="server" Text="BookID:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtBookId" runat="server" CssClass="inputs" placeholder="Book Id"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="Right">
                                <asp:Label ID="lblMessage" runat="server"></asp:Label>
                            </td>
                            <td align="Right">
                                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="CancelButton" />
                                <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="SaveButton" OnClick="btnSearch_Click" />
                            </td>
                        </tr>

                        <tr>
                            <td align="Right">
                                <asp:Label ID="Label2" runat="server" Text="BookName:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtBookName" runat="server" ReadOnly="True" CssClass="inputs" placeholder="Book Name"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="Right">
                                <asp:Label ID="Label3" runat="server" Text="BookTitle:"></asp:Label>
                            </td>
                            <td>

                                <asp:TextBox ID="txtBookTitle" runat="server" ReadOnly="True" CssClass="inputs" placeholder="Book Title"></asp:TextBox>
                            </td>
                        </tr>


                        <tr>
                            <td align="Right">
                                <asp:Label ID="Label8" runat="server" Text="AvailableCopys:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtCopys" runat="server" ReadOnly="True" CssClass="inputs" placeholder="Available Copys"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="Right">
                                <asp:Label ID="Label9" runat="server" Text="BookStatus:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtBookStatus" runat="server" ReadOnly="True" CssClass="inputs" placeholder="Book Status"></asp:TextBox>
                            </td>
                        </tr>
                    </form>
                </table>

            </td>
        </tr>
    </table>


</body>
</html>
