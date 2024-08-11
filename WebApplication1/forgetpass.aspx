<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgetpass.aspx.cs" Inherits="WebApplication1.forgetpass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <meta name="viewport" content="width=device-width" />
    <title></title>
        <style type="text/css">
           
        
              #form1
  {
      height: 750px;
      width: 1510px;
        
  }
           
            
        
           body{
               background-color:#121212;
           }
            
            .auto-style1 {
                position: absolute;
                left: 200px;
                top: 180px;
                width: 1110px;
                height: 500px;
                border-bottom-right-radius:40px;
                 border-top-right-radius:40px;
                 border-bottom-left-radius:150px;
                 border-top-left-radius:40px;
                 box-shadow:rgb(44, 43, 43, 0.80) 12px 12px;
                  background:linear-gradient(to left,rebeccapurple,purple);
                
            }
           
            
        
           
            
            .auto-style3 {
                position: absolute;
                left: 0px;
                top: 0px;
                height: 500px;
                width: 550px;
             
            }
           
            
        
           
            
            .auto-style2 {
                position: absolute;
                left: 611px;
                top: 32px;
                height: 435px;
                width: 450px;
                border-radius:60px 0;
                background-color:white;
            }
           
            
        
           
            
            .auto-style4 {
                position: absolute;
                left: 51px;
                top: 14px;
                width: 376px;
                height: 66px;
            }
           
            
            .signin{
                font-size:50px;
                font-family:'Bell MT';
                font-weight:bold;
                color:black;

            }
           
            
            .auto-style5 {
                position: absolute;
                left: 20px;
                top: 100px;
                width: 420px;
                height: 210px;
            }
            .auto-style6 {
                width: 100%;
                height: 199px;
            }

            .label{
                font-family:'Times New Roman';
                font-size:18px;
                color:black;
                font-weight:bold;
                font-style:normal;
                
            }

            .text{
                height:30px;
                width:370px;
                font-size:18px;
                background-color:#E5E4E2;
                border:hidden;
                border-radius:5px;
            }
           
            
            .auto-style7 {
                position: absolute;
                left: 135px;
                top: 372px;
                width: 173px;
                height: 54px;
                right: 142px;
            }

            .but{
                height:50px;
                width:150px;
                font-size:15px;
                color:white;
                background-color:purple;
                border-radius:10px;
                border:hidden;
            }

            .but:hover{
                cursor:pointer;
                border:groove;
     
                box-shadow:0 5px #666;
              
                   
                
            }
           
            
            .auto-style8 {
                width: 401px;
            }
           
            
            .auto-style9 {
                position: absolute;
                left: 51px;
                top: 141px;
                width: 475px;
                height: 98px;
            }
           .labelside{
               font-family:'Bell MT';
               font-size:70px;
               color:#fff;
               text-shadow:2px;
                animation: glow 1s ease-in-out infinite alternate;
           }

           @-webkit-keyframes glow {
  from {
    text-shadow: 0 0 10px #fff, 0 0 20px #fff, 0 0 30px #e60073, 0 0 40px #e60073, 0 0 50px #e60073, 0 0 60px #e60073, 0 0 70px #e60073;
  }
  
  to {
    text-shadow: 0 0 20px #fff, 0 0 30px #ff4da6, 0 0 40px #ff4da6, 0 0 50px #ff4da6, 0 0 60px #ff4da6, 0 0 70px #ff4da6, 0 0 80px #ff4da6;
  }
} 

         
            
            .auto-style10 {
                position: absolute;
                left: 59px;
                top: 253px;
                width: 455px;
                height: 71px;
                 font-family:'Bell MT';
                font-size:28px;
                color:white;
                text-align:center;
            }

           
         
            
                             .buts{
                     height:50px;
                     width:150px;
                     font-size:15px;
                     color:white;
                     background-color:purple;
                     border:ridge;
                     border-radius:10px;
                    
                     border-color:white;
                     

                 }

                     .buts:hover{
                     cursor:pointer;
                     border:groove;
     
                     box-shadow:2px 7px #666;
        
     
                 }

           
         
            
            .auto-style12 {
                position: absolute;
                left: 10px;
                top: 15px;
                height: 148px;
                width: 1498px;
            }

           
         
            
            .auto-style13 {
                position: absolute;
                left: 6px;
                top: 1px;
                width: 149px;
                height: 142px;
            }

           
         
            
            .auto-style14 {
                position: absolute;
                left: 141px;
                top: 42px;
                width: 468px;
                height: 44px;
                font-family:'Times New Roman';
                font-size:45px;
                background:linear-gradient(to left,white,#10edc5);
                -webkit-background-clip:text;
                color:transparent;
                font-style:italic;
                font-weight:bold;
                
                
            }

           
         
            
            .auto-style15 {
                    height: 72px;
                position:absolute;
                left: 1324px;
                top: 34px;
}
            



    .buttss{
    height:60px;
    width:130px;
    background-color:transparent;
    color:white;
    font-size:20px;
    text-align:center;
    border:solid;
    border-radius:30px;
    border-color:rebeccapurple;
    box-shadow:purple 3px 3px;

}.buttss:hover
 {
     opacity:0.7;
     cursor:pointer;
     transform:scale(0.9);
    
    
 }

           
            .link{
                color:black;
                font-size:x-large;
                
                
            }
            
              .imgbut{
              height:90px;
              width:140px;
                 }
            
                .imgbut:hover{
                    opacity:0.8;
                    transform:scale(1.1);
                    
                    
                }

                 .auto-style16 {
     position: absolute;
     left: 7px;
     top: 132px;
     width: 1497px;
 }
            
            
            .auto-style17 {
                position: absolute;
                left: 152px;
                top: 333px;
                width: 145px;
                height: 35px;
            }
            
            
            .auto-style18 {
                position: absolute;
                left: 23px;
                top: 308px;
                width: 242px;
            }
            
            
        </style>
</head>
<body>
    <form id="form1" runat="server"  enctype="multipart/form-data">

        <div class="auto-style12">

            <div class="auto-style13">

                <asp:Image ID="Image1" runat="server" Height="139px" ImageUrl="~/Scripts/WebForms/bookbg.png" Width="136px" />

            &nbsp;</div>

             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            <div class="auto-style14">

                 E-BOOKS STORE

            </div>


            <div class="auto-style15">
     

                <asp:Button ID="Button3" runat="server" Text="Back" CssClass="buttss" PostBackUrl="~/login.aspx" />
     

            </div>

             <div class="auto-style16">
                          <hr />
            </div>

        </div>
        
        <div class="auto-style1">

            <div class="auto-style2">
                <div class="auto-style4">

                    <asp:Label ID="Label1" runat="server" CssClass="signin"  Text="Forget Password"></asp:Label>

                </div>

                <div class="auto-style5">

                    <table class="auto-style6">
                        <tr>
                            <td class="auto-style8">
                                <asp:Label ID="Label2" CssClass="label" runat="server" Text="Name"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:TextBox ID="TextBox1" CssClass="text" runat="server" placeholder=" Enter Name"></asp:TextBox>
                            &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:Label ID="Label3" CssClass="label" runat="server" Text="Email"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:TextBox ID="TextBox2" CssClass="text" runat="server" placeholder=" Enter Email" TextMode="Email"></asp:TextBox>
                            &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:Label ID="Label5" CssClass="label" runat="server" Text="OTP"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:TextBox ID="TextBox3" CssClass="text" runat="server" placeholder=" Enter OTP" TextMode="singleline"></asp:TextBox>
                            </td>
                        </tr>
                        </table>

                </div>

                <div class="auto-style18">

                    <asp:Label ID="Label6" runat="server" Font-Size="Large" ForeColor="Red"></asp:Label>

                </div>

                <div class="auto-style17">

                    <asp:LinkButton ID="LinkButton1" runat="server" Font-Size="X-Large" OnClick="LinkButton1_Click">Send OTP</asp:LinkButton>
                    <br />

                </div>

                <div class="auto-style7">

                    <asp:Button ID="Button1" runat="server" CssClass="but" Text="SIGN UP" OnClick="Button1_Click"  />

                </div>

            </div>

            <div class="auto-style3">

                <div class="auto-style9">
                    <asp:Label ID="Label4" runat="server" Text="Welcome Back!" CssClass="labelside"></asp:Label>
                </div>

                <div class="auto-style10">


                    Enter your personal details to recover your password</div>

            </div>

        </div>

    </form>
</body>
</html>


