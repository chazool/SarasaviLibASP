<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddClassification.aspx.cs" Inherits="Sarasavi.View.AddClassification" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="FormStyle.css" rel="stylesheet" />
    <link href="MenuBar.css" rel="stylesheet" />
    <title></title>
   
    
</head>
<body>
    <form id="form1" runat="server">

        <table border="0" width="100%">

            <tr>
                <td align="Center">
                    <img src="Sarasavi.jpg" width="50%" /></td>

            </tr>

            <tr>
                <td align="Center">
                    <div class="nav">
                        <ul>
                            <li class="tutorials">
                                <a href="Home.aspx">Home</a></li>
                            <li class="tutorials">
                                <a href="UserRegistration.aspx">Add User</a></li>
                            <li class="about">
                                <a href="BookReg.aspx">Add Book</a></li>
                            <li class="news">
                                <a href="Inquiry.aspx">Inquiry </a></li>
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

                        <tr>
                            <td colspan="2">
                                <div class='panel panel-primary dialog-panel'>

                                    <h5 class='panel-heading'>Add Classification </h5>
                                </div>
                            </td>
                        </tr>

                        <tr>
                            <td align="Right">
                                 <asp:Label ID="Label3" runat="server" Text="ClassificationID:"></asp:Label>
                            </td>
                            <td>

                                <asp:TextBox ID="txtClassificationID" runat="server" CssClass="inputs" placeholder="Classification ID" Font-Bold="True" Font-Size="Large"></asp:TextBox>

                            </td>
                        </tr>

                        <tr>
                            <td align="Right">

                                <asp:Label ID="Label1" runat="server" Text="Title:"></asp:Label>

                            </td>
                            <td>

                                <asp:TextBox ID="txtTitle" runat="server" CssClass="inputs" placeholder="Classification Title"></asp:TextBox>

                            </td>
                        </tr>

                        <tr>
                            <td align="Right">

                                <asp:Label ID="Label2" runat="server" Text="Description:"></asp:Label>

                            </td>
                            <td>

                                <asp:TextBox ID="txtDescription" runat="server" CssClass="inputs" placeholder="Description "></asp:TextBox>

                            </td>
                        </tr>

                        <tr>
                            <td aling="Right">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td align="Right">
                                <asp:Button ID="btnCancel" runat="server" CssClass="CancelButton" Text="Cancel" OnClick="btnCancel_Click" />
                                <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="SaveButton" OnClick="btnAdd_Click" />
                            </td>
                        </tr>

                    </table>
                </td>
            </tr>
        </table>

    </form>
</body>
</html>
