<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            font-family: Arial;
            font-size: large;
            color: #0000FF;
            margin-top: 50px;
            border: 2px solid black;
            padding:20px
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                Details Page<br />
                <br />
                <br />
                <asp:Label runat="server" class="newStyle1" ID="lblDetails" ></asp:Label>   
                <br /><br /><br />
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem>math</asp:ListItem>
                    <asp:ListItem>eng</asp:ListItem>
                </asp:DropDownList>
                <br /><br /><br />
                <asp:Label runat="server" class="newStyle1" ID="lblAVG" ></asp:Label>   
            </center>
        </div>
    </form>
</body>
</html>
