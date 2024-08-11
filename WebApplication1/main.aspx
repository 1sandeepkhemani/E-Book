<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <style>
        #a{
            height:300px;
            width:300px;
        }
    </style>
    
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            email
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            pass&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"  TextMode="Password"></asp:TextBox>
            <br />
            <table border="1" auto-style1">
                <tr>
                    <td>name</td>
                    <td>class</td>
                    <td>fees</td>
                </tr>
                <tr>
                    <td>meet</td>
                    <td>mca a sec</td>
                    <td>55000</td>
                </tr>
                <tr>
                    <td>shivam</td>
                    <td>mca b sec</td>
                    <td>55000</td>
                </tr>
            </table>
            <br />
            <br />
        &nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
            <br />
            <asp:Button ID="Button4" runat="server" PostBackUrl="~/login.aspx" Text="Button" />
            <br />
            <br />
            <br />
            <br />
            <br />
            #9370DB
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="email" DataSourceID="SqlDataSource3">
                <Columns>
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="email" HeaderText="email" ReadOnly="True" SortExpression="email" />
                    <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [user]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [user]"></asp:SqlDataSource>
        </div>
        <p>
            &nbsp;</p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="email" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="email" HeaderText="email" ReadOnly="True" SortExpression="email" />
                <asp:BoundField DataField="pass" HeaderText="pass" SortExpression="pass" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        login
        <br />
        <br />
        email
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        pass<asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [sonu]"></asp:SqlDataSource>
   
        
    <div>
        <h1>I'M <span class="abc">
           
                </span></h1>

        <script src="https://unpkg.com/typed.js@2.1.0/dist/typed.umd.js"></script>
        <script type="text/javascript">
            var typed = new Typed(".abc", {
                strings: ["sandeep", "sonu"],
                typeSpeed: 50,
                backSpeed: 50,
                lopped :true
            })
        </script>
    </div>

 


        <asp:Button ID="Button1" runat="server" Text="Button" CssClass="bi-x-circle-fill"/>

        
        
       <i class="bi bi-3-circle-fill" style="width:200px; height:150px"></i>

        <svg xmlns="http://www.w3.org/2000/svg" fill="currentColor" class="bi bi-0-circle-fill" viewBox="0 0 16 16" style="width: 114px; height: 48px">
  <path d="M8 4.951c-1.008 0-1.629 1.09-1.629 2.895v.31c0 1.81.627 2.895 1.629 2.895s1.623-1.09 1.623-2.895v-.31c0-1.8-.621-2.895-1.623-2.895"/>
  <path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0m-8.012 4.158c1.858 0 2.96-1.582 2.96-3.99V7.84c0-2.426-1.079-3.996-2.936-3.996-1.864 0-2.965 1.588-2.965 3.996v.328c0 2.42 1.09 3.99 2.941 3.99"/>
</svg>
        <a href="Scripts/WebForms/hf.jpg" download >download</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>


        <a href="Scripts/ass.iwp.pdf">Scripts/ass.iwp.pdf</a>
    </form>
</body>
</html>
