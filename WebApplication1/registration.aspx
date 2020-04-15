<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="WebApplication1.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Conestoga International Homes</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="hfStudentID" runat="server" />
            <table>
                <tr>
                    <td>
                        <asp:label Text ="First Name" runat="server" />
                    </td>
                    <td>
                        <asp:textBox ID="txtFirstName" runat="server"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:label Text ="Last Name" runat="server" />
                    </td>
                    <td>
                        <asp:textBox ID="txtLastName" runat="server"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:label Text ="Contact" runat="server" />
                    </td>
                    <td>
                        <asp:textBox ID="txtContact" runat="server"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:label Text ="Gender" runat="server" />
                    </td>
                    <td>
                        <asp:DropDownList ID="DGender" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem>Other</asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
               
                <tr>
                    <td>
                        <asp:label Text ="Address" runat="server" />
                    </td>
                    <td>
                        <asp:textBox ID="txtAddress" runat="server" TextMode="Multiline"/>
                    </td>
                </tr>
                 <tr>
  
                        <td colspan="3">

                        <hr/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:label Text ="UserName" runat="server" />
                     

                    </td>
                    <td>
                        <asp:textBox ID="TextUserName" runat="server"/>
                           <asp:label Text="*" runat="server" ForeColor="Red" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:label Text ="Password" runat="server" />
                    </td>
                    <td>
                        <asp:textBox ID="TextPassword" runat="server" TextMode="Password"/>
                           <asp:label Text="*" runat="server" ForeColor="Red" />
                    </td>
                </tr>
                <tr>
                 <td>
                        <asp:label Text ="Confirm Password" runat="server" />
                    </td>
                    <td>
                        <asp:textBox ID="TextConfirmPassword" runat="server" TextMode="Password"/>
                    </td>
                    </tr>
                <tr>
                    <td></td>
                    <td colspan="2">
                        <asp:Button Text="Submit" ID ="btnsubmit" runat="server" OnClick="btnsubmit_Click"/>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td colspan="2">
                        <asp:label Text="" ID ="lblSuccessMsg" runat="server" ForeColor="Green" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td colspan="2">
                        <asp:label Text="" ID ="lblErrormsg" runat="server" ForeColor="Red" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

