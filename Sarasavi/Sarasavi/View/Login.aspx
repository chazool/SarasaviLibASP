<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Sarasavi.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="FormStyle.css" rel="stylesheet" />
    <link href="MenuBar.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <table>

            <tr>
                <td align="Center">
                    <img src="Sarasavi.jpg" width="50%" /></td>
            </tr>

            <tr>
                <td align="Center">
                    <div class="nav">
                        <ul>
                            <li class="tutorials">Add User</li>
                            <li class="about">Add Book</li>
                            <li class="news">Inquiry </li>
                            <li class="news">Reservation</li>
                            <li class="news">Loan</li>
                            <li class="news">Retun</li>
                            <li class="contact">
                                <a class="active" href="Login.aspx">Login</a></li>
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

                                    <h5 class='panel-heading'>User Login</h5>
                                </div>
                            </td>
                        </tr>

                        <tr>
                            <td align="Right">
                                <asp:Label ID="Label1" runat="server" Text="UserID:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtUserId" runat="server" MaxLength="8" CssClass="inputs" placeholder="User ID" required></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td align="Right">
                                <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtPassword" type="Password" runat="server" TextMode="Password" CssClass="inputs" placeholder="Password"></asp:TextBox>

                            </td>
                        </tr>

                        <tr>
                            <td align="Right">
                                <asp:Label ID="lblMessage" runat="server"></asp:Label>
                            </td>
                            <td align="Right">
                                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="CancelButton" />
                                <asp:Button ID="btlLogin" runat="server" Text="Login" CssClass="SaveButton" OnClick="btlLogin_Click" />
                            </td>
                        </tr>

                    </table>

                </td>
            </tr>
        </table>
    </form>

    </body>
</html>
