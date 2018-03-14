<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserRegistration.aspx.cs" Inherits="Sarasavi.View.UserRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="FormStyle.css" rel="stylesheet" />
    <link href="MenuBar.css" rel="stylesheet" />
    <title>User Registration</title>
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
                             <li class="tutorials">
                                <a href="Home.aspx">Home</a></li>
                            <li class="tutorials">
                                <a  class="active" href="UserRegistration.aspx">Add User</a></li>
                            <li class="about">
                                <a  href="BookReg.aspx">Add Book</a></li>
                            <li class="news">
                                <a href="Inquiry.aspx">Inquiry </a></li>
                            <li class="news">
                                <a href="BookReservation.aspx">Reservation </a></li>
                            <li class="news">
                                <a href="BorrowLoan.aspx">Loan</a></li>
                            <li class="news">
                                <a  href="Return.aspx">Retun</a></li>
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

                                    <h5 class='panel-heading'>User Registration</h5>
                                </div>
                            </td>
                        </tr>

            <tr >
                <td align="Right">
                    <asp:Label ID="Label1" runat="server" Text="UserID:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUserId" runat="server" ReadOnly="True" CssClass="inputs" placeholder="User Id"></asp:TextBox>
                </td>
            </tr>

             <tr>
                <td align="Right">   
                    <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>
                 </td>
                <td>   
                    <asp:TextBox ID="txtFname" runat="server" CssClass="inputs" placeholder="First Name"></asp:TextBox>
                    <asp:TextBox ID="txtLname" runat="server" CssClass="inputs" placeholder="Last Name"></asp:TextBox>
                 </td>
            </tr>
              <tr>
                <td align="Right">   
                    <asp:Label ID="Label3" runat="server" Text="DOB:"></asp:Label>
                 </td>
                <td >
                    <asp:TextBox ID="txtDOB" runat="server"  CssClass="inputs" placeholder="DOB (DD.MM.YYYY)"></asp:TextBox>
                  </td>
            </tr>
              <tr>
                <td align="Right">   
                    <asp:Label ID="Label4" runat="server" Text="NIC:"></asp:Label>
                 </td>
                <td>   
                    <asp:TextBox ID="txtNIC" runat="server" CssClass="inputs" placeholder="NIC"></asp:TextBox>
                 </td>
            </tr>
              <tr>
                <td align="Right">   
                    <asp:Label ID="Label5" runat="server" Text="Sex:"></asp:Label>
                 </td>
                <td>   
                    <asp:DropDownList ID="ddlSex" runat="server" CssClass="inputs" >
                        <asp:ListItem Value=" ">Sex</asp:ListItem>
                        <asp:ListItem Value="M">Male</asp:ListItem>
                        <asp:ListItem Value="F">Female</asp:ListItem>
                    </asp:DropDownList>
                 </td>
            </tr>
              <tr>
                <td align="Right">   
                    <asp:Label ID="Label6" runat="server" Text="UserRole:"></asp:Label>
                 </td>
                <td>   
                    <asp:DropDownList ID="ddlUserRole" runat="server" CssClass="inputs" >
                        <asp:ListItem Value=" ">UserRole</asp:ListItem>
                        <asp:ListItem>Visitors</asp:ListItem>
                        <asp:ListItem>Registered </asp:ListItem>
                        <asp:ListItem>Librarian</asp:ListItem>
                    </asp:DropDownList>
                 </td>
            </tr>
              <tr>
                <td align="Right">   
                    <asp:Label ID="Label7" runat="server" Text="Password:"></asp:Label>
                 </td>
                <td>   
                    <asp:TextBox ID="txtPassword" runat="server" SkinID="*" TextMode="Password" CssClass="inputs" placeholder="Password"></asp:TextBox>
                 </td>
            </tr>
              <tr>
                <td align="Right">   
                    <asp:Label ID="Label8" runat="server" Text="Contact:"></asp:Label>
                 </td>
                <td>   
                 <asp:TextBox ID="txtPhone" runat="server" CssClass="inputs" placeholder="Phone Number"></asp:TextBox> <br />
                 <asp:TextBox ID="txtEmail" runat="server" CssClass="inputs" placeholder="Email Address"></asp:TextBox>
                 </td>
            </tr>            

             <tr>
                 <td align="Right">
                     <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                 </td>
                <td align="Right">   
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel"  CssClass="CancelButton" />
                    <asp:Button ID="btnAdd" runat="server" Text="Register "  CssClass="SaveButton" OnClick="btnAdd_Click" />
                 </td>
            </tr>
    </table>
                 </td> </tr>  </table>
    </form>
</body>
</html>
