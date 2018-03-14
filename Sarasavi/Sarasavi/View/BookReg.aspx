<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookReg.aspx.cs" Inherits="Sarasavi.View.BookReg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="FormStyle.css" rel="stylesheet" />
    <link href="MenuBar.css" rel="stylesheet" />
    <title>Book Registration</title>
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
                        <li class="tutorials">
                            <a  href="UserRegistration.aspx">Add User</a></li>
                         <li class="tutorials">
                                <a href="Home.aspx">Home</a></li>
                        <li class="about">
                            <a class="active" href="BookReg.aspx">Add Book</a></li>
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
                    <form id="form1" runat="server">

                        <tr>
                            <td colspan="2">
                                <div class='panel panel-primary dialog-panel'>

                                    <h5 class='panel-heading'>Book Registation</h5>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td align="Right">
                                <asp:Label ID="Label1" runat="server" Text="Book ID :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtBookId" runat="server" ReadOnly="True" CssClass="inputs" placeholder="Book ID"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td align="Right">
                                <asp:Label ID="Label2" runat="server" Text="Book Name :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtBookName" runat="server" CssClass="inputs" placeholder="Book Name"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="Right">
                                <asp:Label ID="Label3" runat="server" Text="Book Title :"></asp:Label>
                            </td>
                            <td aria-autocomplete="none" aria-checked="undefined" aria-dropeffect="none">



                                <asp:TextBox ID="txtBookTitle" runat="server" CssClass="inputs" placeholder="Book Title"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="Right" valign="Top">
                                <asp:Label ID="Label4" runat="server" Text="Author ID :"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlAuthor1" runat="server" CssClass="inputs" DataSourceID="SqlDataSource2" DataTextField="AuthorName" DataValueField="AuthorId">
                                   
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:SarasaviLibraryDBConnectionString %>" SelectCommand="SELECT [AuthorId], [AuthorName] FROM [Author]"></asp:SqlDataSource>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SarasaviLibraryDBConnectionString %>" SelectCommand="SELECT * FROM [BookAuthor]"></asp:SqlDataSource>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>
                                <asp:DropDownList ID="ddlAuthor2" runat="server" CssClass="inputs" DataSourceID="SqlDataSource2" DataTextField="AuthorName" DataValueField="AuthorId">
                                   
                                </asp:DropDownList>
                                <br />
                            </td>
                        </tr>

                        <tr>
                            <td></td>
                            <td>
                                <asp:DropDownList ID="ddlAuthor3" runat="server" CssClass="inputs" DataSourceID="SqlDataSource2" DataTextField="AuthorName" DataValueField="AuthorId">
                                   
                                </asp:DropDownList>
                                <br />
                            </td>
                        </tr>

                        <tr>
                            <td></td>
                            <td>
                                <asp:DropDownList ID="ddlAuthor4" runat="server" CssClass="inputs" DataSourceID="SqlDataSource2" DataTextField="AuthorName" DataValueField="AuthorId">
                                   
                                </asp:DropDownList>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>
                                <asp:DropDownList ID="ddlAuthor5" runat="server" CssClass="inputs" DataSourceID="SqlDataSource2" DataTextField="AuthorName" DataValueField="AuthorId">
                                   
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td align="Right">
                                <asp:Label ID="Label5" runat="server" Text="Classification ID :"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlClassification" runat="server" CssClass="inputs" DataSourceID="SqlDataSource3" DataTextField="Title" DataValueField="ClassificationId">
                                   
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:SarasaviLibraryDBConnectionString %>" SelectCommand="SELECT [ClassificationId], [Title] FROM [Classification]"></asp:SqlDataSource>
                            </td>
                        </tr>

                        <tr>
                            <td align="Right">
                                <asp:Label ID="Label6" runat="server" Text="Publisher ID :"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlPublisher" runat="server" CssClass="inputs" DataSourceID="Publisher" DataTextField="PublisherName" DataValueField="PublisherId">
                                    <asp:ListItem Value="0" CssClass="inputs">Publisher Id </asp:ListItem>
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="Publisher" runat="server" ConnectionString="<%$ ConnectionStrings:SarasaviLibraryDBConnectionString %>" SelectCommand="SELECT [PublisherId], [PublisherName] FROM [Publisher]"></asp:SqlDataSource>
                            </td>
                        </tr>

                        <tr>
                            <td align="Right">
                                <asp:Label ID="Label7" runat="server" Text="ISBM :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtISBM" runat="server" CssClass="inputs" placeholder="ISBM"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td align="Right">
                                <asp:Label ID="Label8" runat="server" Text="No Of Copys :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtCopys" runat="server" CssClass="inputs" placeholder="No Of Copy"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="Right">
                                <asp:Label ID="Label9" runat="server" Text="Book Status :"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtBookStatus" runat="server" CssClass="inputs" placeholder="Book Status"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td align="Right">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="Red" Font-Bold="True"></asp:Label>
                            </td>
                            <td align="Right">
                                <asp:Button ID="btnCancel" runat="server" CssClass="CancelButton" Text="Cancel" OnClick="btnCancel_Click" />
                                <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="SaveButton" OnClick="btnAdd_Click" />
                            </td>
                        </tr>
                    </form>
                </table>
            </td>
        </tr>
    </table>



</body>
</html>
