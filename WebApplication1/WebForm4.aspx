<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication1.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
        .h
        {
            border:5px solid black;

        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" download runat="server" CssClass="h">HyperLink</asp:HyperLink>
            <br />
            <br />
            <br />
            <br />
            name
            <asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="221px"></asp:TextBox>

            <br />
            <br />
            email
            <asp:TextBox ID="TextBox2" runat="server" Height="25px" TextMode="Email" Width="221px"></asp:TextBox>
            <br />
            <br />
            message
            <asp:TextBox ID="TextBox3" runat="server" Height="25px" TextMode="MultiLine" Width="221px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />

        </div>
    </form>
</body>
</html>
