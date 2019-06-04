<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LOING PAGE</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <p><b><u>Login Page</u></b></p>
                ID: <asp:TextBox runat="server" ID="txtID"></asp:TextBox><br /><br />
                Name: <asp:TextBox runat="server" ID="txtName"></asp:TextBox><br /><br />
                <asp:Button runat="server" ID="btnLogin" Text="Log In" OnClick="btnLogin_Click" /><br />
                <asp:Label runat="server" ID="lblRes" ForeColor="Red"></asp:Label>
            </center>
        </div>
    </form>
</body>
</html>
