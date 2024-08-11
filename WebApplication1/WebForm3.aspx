<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>

    <meta name="viewport" content="width=device-width" height="device-height" />

      <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <style type="text/css">
       

                    #form1
                    {
             height: 2950px;
             width: 1510px;
      
                }
         
          
      
         body{
             background-color:rgb(6, 1, 13);
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
    width: 142px;
    height: 72px;
    position:absolute;
    left: 1324px;
    top: 34px;
}

           


.auto-style16 {
    position: absolute;
    left: 7px;
    top: 132px;
    width: 1497px;
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

        }
        .buttss:hover
         {
             opacity:0.7;
             cursor:pointer;
             transform:scale(0.9);
             
            
            
         }

         

       



        .auto-style17 {
            position: absolute;
            left: 10px;
            top: 169px;
            width: 1501px;
            height: 553px;
        }

       



        .auto-style18 {
            margin-left: 30px;
            margin-right:30px;
            margin-top:10px;
            margin-bottom:10px;
            border-radius:30px;
            border-style:solid;
            border-color:white;
            border-width:6px;

        }

       



        .auto-style19 {
            position: absolute;
            left: 46px;
            top: 145px;
            width: 506px;
            height: 340px;
        }

       
        .abc{
            color:white;
            font-size:45px;
            font-family:'Bell MT';
            font-style:normal;
            font-weight:bold;
        }


        .auto-style20 {
            position: absolute;
            left: 275px;
            top: 44px;
            width: 1137px;
            height: 83px;
        }


        .auto-style21 {
            position: absolute;
            left: 18px;
            top: 737px;
            width: 1497px;
            height: 481px;
        }
        .auto-style22 {
            height: 1227px;
        }


        .auto-style23 {
            position: absolute;
            left: 30px;
            top: 9px;
            width: 616px;
            height: 453px;
        }


        .auto-style24 {
            position: absolute;
            left: 819px;
            top: 124px;
            width: 630px;
            height: 284px;
        }


        .img3{
            border-style:solid;
            border-width:medium;
            border-color:white;
            height:250px;
            width:550px;
        }

        

        .auto-style25 {
            position: absolute;
            left: 16px;
            top: 1230px;
            width: 1495px;
            height: 1365px;
        }
        .auto-style26 {
            width: 100%;
            height: 561px;
        }

        .cimg{
            height:350px;
            width:320px;
            margin-left:15px;
            margin-right:15px;
            border-style:solid;
            border-width:thick;
            border-color:white;
            border-radius:10px;
        }

        .cimg:hover{
            box-shadow:rgba(44,40,42,8) 10px 10px ;
            cursor:pointer;

        }



        .cname{
            font-size:x-large;
            color:white;
            text-align:center;
            height:40px;

        }

        .auto-style27 {
            border: thick groove white;
            position: absolute;
            left: 10px;
            top: 2623px;
            width: 1485px;
            height: 320px;
            background-color: #301934;
            border-top-left-radius:100px;
            border-bottom-right-radius:100px;
            }
        

        .auto-style28 {
            position: absolute;
            left: 953px;
            top: 21px;
            width: 470px;
            height: 266px;
        }
        

        .auto-style29 {
            width: 100%;
            height: 98px;
        }
        .auto-style30 {
            width: 140px;
            font-size:larger;
            color:white;
            text-align:right;

        }
        

        
        

        .buttss2{
            margin-left:170px;
    height:50px;
    width:120px;
    background-color:transparent;
    color:white;
    font-size:20px;
    text-align:center;
    border:solid;
    border-radius:30px;
    border-color:white;
    box-shadow:purple 3px 3px;

}
.buttss2:hover
 {
     opacity:0.7;
     cursor:pointer;
     transform:scale(0.9);
    
    
 }

        .auto-style31 {
            position: absolute;
            left: 31px;
            top: 46px;
            width: 488px;
            height: 230px;
        }



                .fa {
  padding: 10px;
  font-size: 30px;
  width: 30px;
  text-align: center;
  text-decoration: none;
  border-radius: 50%;
}

        .fa:hover {
  opacity: 0.7;
}


.fa-facebook {
  background: #3B5998;
  color: white;
}
.fa-twitter {
  background: #55ACEE;
  color: white;
}
.fa-google {
  background: #dd4b39;
  color: white;
}

.fa-linkedin {
  background: #007bb5;
  color: white;
}

.fa-youtube {
  background: #bb0000;
  color: white;
}

.fa-instagram {
  background: #125688;
  color: white;
}

        .auto-style32 {
            width: 452px;
            height: 55px;
        }

        .auto-style33 {
            position: absolute;
            top: 135px;
            left: 5px;
            width: 458px;
            height: 61px;
        }

        .customer{
            font-family:'Bell MT';
            font-size:xx-large;
            color:white;
            font-weight:bolder;
            text-align:center;
        }

        .auto-style34 {
            height: 50px;
        }
        .auto-style35 {
            width: 468px;
            height: 59px;
        }

        .auto-style36 {
            position: absolute;
            left: 594px;
            top: 47px;
            width: 257px;
            height: 219px;
        }
        .auto-style37 {
            width: 100%;
            height: 209px;
        }

        .some{
            font-size:xx-large;
            font-family:'Bell MT';
            color:white;
            font-weight:bold;
        }

        .someli{
            font-size:x-large;
            color:white;
            font-family:'Bell MT';
        }

        </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style22">
       <div class="auto-style12">

      <div class="auto-style13">

          <asp:Image ID="Image1" runat="server" Height="139px" ImageUrl="~/Scripts/WebForms/bookbg.png" Width="136px" />

      </div>

       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      
      <div class="auto-style14">

           E-BOOKS STORE

      </div>

     

      <div class="auto-style15">
          

          <asp:Button ID="Button1" runat="server" Text="Login" CssClass="buttss" OnClick="Button1_Click"/>
          

      </div>

       <div class="auto-style16">
        <hr />
      </div>

  </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        
        <br />

        <div class="auto-style17">

            <asp:Image ID="Image2" runat="server" Height="523px" ImageUrl="~/Scripts/WebForms/img.png" Width="1436px" CssClass="auto-style18" />


            <div class="auto-style20">
                <h1 style="font-family: 'Bell MT'; font-size: 50px; font-weight: bolder; font-style: normal; color: #FFFFFF">
                    LOTS OF E-BOOKS. 100% FREE DOWNLOAD
                </h1>
            </div>

            <div class="auto-style19">
                <h1 style="color: #FFFFFF; font-family: 'bell MT'; font-size: 50px; font-weight: bold; font-style: italic;">Top Books Categories</h1>
                
                <span class="abc"></span>
            </div>

                    <script src="https://unpkg.com/typed.js@2.1.0/dist/typed.umd.js"></script>

        <script type="text/javascript">
            var typed = new Typed(".abc", {
                strings: ["Mystery", "Science Fiction","Thriller", "Romance", "Adventure", "Horror", "Historical Fiction", "Literary Function", "Crime", "Biography","Young Adult","Business","Comics","Children's","Religion","History","Fantasy","Dystopian"],
                typeSpeed: 70,
                backSpeed: 70,
                lopped :true
            })
        </script>

        </div>

         <div class="auto-style21">
             <div class="auto-style23" style="text-align: justify">
                 <h1 style="font-family: 'times New Roman', Times, serif; font-size: 45px; font-weight: bold; color: #FFFFFF; text-decoration: underline;">E-BOOKS STORE</h1>

                 <p style="color: #FFFFFF; font-size: x-large">
                     E-Books Store is a remarkable eBook libary to free download the books of your choice. Among the top free eBook sites available you can access on the 
                     internet, you should undoubtedly try out E-Books Store. The site is one of the most extensive online book libaries with countless eBooks in various 
                     categories. You can choose from mystery, horror, thriller, adventure and much more. Using a free sign-up on the website, you can download eBooks in PDF 
                     and other supported formats on E-Books Store easily.
                 </p>
             </div>

             <div class="auto-style24">

                 <asp:Image ID="Image3" runat="server" CssClass="img3" ImageUrl="~/Scripts/WebForms/img2.jpeg" />

             </div>
             +
         </div>

        <div class="auto-style25">

            <table class="auto-style26">
                <tr>
                    <td>
                        <asp:Image ID="Image4" runat="server"  CssClass="cimg" ImageUrl="~/Scripts/WebForms/r.jpg" />
                    </td>
                    <td>
                        <asp:Image ID="Image5" runat="server"  CssClass="cimg" ImageUrl="~/Scripts/WebForms/aa.jpg" />
                    </td>
                    <td>
                        <asp:Image ID="Image6" runat="server"  CssClass="cimg" ImageUrl="~/Scripts/WebForms/mt.jpg" />
                    </td>
                    <td>
                        <asp:Image ID="Image7" runat="server"  CssClass="cimg" ImageUrl="~/Scripts/WebForms/bh.jpg" />
                    </td>
                </tr>
                <tr>
                    <td class="cname">ROMANCE</td>
                    <td class="cname">ACTION &amp; ADVENTURE</td>
                    <td class="cname">MYSTERY &amp; THRILLER</td>
                    <td class="cname">BIOGRAPHY &amp; HISTORY</td>
                </tr>
                <tr>
                    <td class="cname">&nbsp;</td>
                    <td class="cname">&nbsp;</td>
                    <td class="cname">&nbsp;</td>
                    <td class="cname">&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Image ID="Image8" runat="server"  CssClass="cimg" ImageUrl="~/Scripts/WebForms/c.jpeg" />
                    </td>
                    <td>
                        <asp:Image ID="Image9" runat="server"  CssClass="cimg" ImageUrl="~/Scripts/WebForms/ya.jpg" />
                    </td>
                    <td>
                        <asp:Image ID="Image10" runat="server"  CssClass="cimg" ImageUrl="~/Scripts/WebForms/f.jpeg" />
                    </td>
                    <td>
                        <asp:Image ID="Image11" runat="server"  CssClass="cimg" ImageUrl="~/Scripts/WebForms/hf.jpg" />
                    </td>
                </tr>
                <tr>
                    <td class="cname">
                        CHILDREN&#39;S</td>
                    <td class="cname">
                        YOUNG ADULT</td>
                    <td class="cname">
                        FANTASY</td>
                    <td class="cname">
                        HISTORICAL FICTION</td>
                </tr>
                <tr>
                    <td class="cname">
                        &nbsp;</td>
                    <td class="cname">
                        &nbsp;</td>
                    <td class="cname">
                        &nbsp;</td>
                    <td class="cname">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Image ID="Image12" runat="server"  CssClass="cimg" ImageUrl="~/Scripts/WebForms/ho.jpeg" />
                    </td>
                    <td>
                        <asp:Image ID="Image13" runat="server"  CssClass="cimg" ImageUrl="~/Scripts/WebForms/lf.jpeg" />
                    </td>
                    <td>
                        <asp:Image ID="Image14" runat="server"  CssClass="cimg" ImageUrl="~/Scripts/WebForms/nf.jpeg" />
                    </td>
                    <td>
                        <asp:Image ID="Image15" runat="server"  CssClass="cimg" ImageUrl="~/Scripts/WebForms/sf.jpg" />
                    </td>
                </tr>
                <tr>
                    <td class="cname">
                        HORROR</td>
                    <td class="cname">
                        LITERARY FICTION</td>
                    <td class="cname">
                        NON-FICTION</td>
                    <td class="cname">
                        SCIENCE FICTION</td>
                </tr>
                <tr>
                    <td class="cname">
                        &nbsp;</td>
                    <td class="cname">
                        &nbsp;</td>
                    <td class="cname">
                        &nbsp;</td>
                    <td class="cname">
                        &nbsp;</td>
                </tr>
            </table>

        </div>

        <br />
        <br />

        
            <div class="auto-style27">


                <div class="auto-style31">

                    <div style="font-family: 'Bell MT'; font-size: x-large; color: #FFFFFF; font-weight: bolder; text-align: center;" class="auto-style33">
                        <table class="auto-style32">
        <tr class="style29">
            <td class="style30">
               <a href="#" class="fa fa-facebook"></a></td>
            <td class="style30">
                <a href="#" class="fa fa-google"></a></td>
            <td class="style30">
                <a href="#" class="fa fa-linkedin"></a></td>
            <td class="style30">
               <a href="#" class="fa fa-instagram"></a></td>
            <td class="style30">
                <a href="#" class="fa fa-youtube"></a></td>
            <td class="style30">
                <a href="#" class="fa fa-twitter"></a></td>
        </tr>
        </table>
        <br />
                    </div>

                    <br />
                    <table class="auto-style35">
                        <tr class="customer">
                            <td>CUSTOMER CARE</td>
                        </tr>
                        <tr class="customer">
                            <td class="auto-style34">9865741023, 7418520963</td>
                        </tr>
                    </table>

                </div>



                <div class="auto-style36">



                    <table class="auto-style37">
                        <tr class="some">
                            <td>SOME LINKS</td>
                        </tr>
                        <tr class="someli">
                            <td>F.A.Q</td>
                        </tr>
                        <tr class="someli">
                            <td>Cookies Policy</td>
                        </tr>
                        <tr class="someli">
                            <td>Terms of Service</td>
                        </tr>
                        <tr class="someli">
                            <td>Support</td>
                        </tr>
                    </table>



                </div>



                <div class="auto-style28">
                    <h1 style="font-family: 'Bell MT'; font-weight: bold; color: #FFFFFF; text-align: center">SUGGESTION</h1>

                    <table class="auto-style29">
                        <tr>
                            <td class="auto-style30">E-MAIL :-</td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" Height="26px" Width="285px" placeholder="Enter your email"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style30">COMMENT :-</td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server" Height="26px" Width="285px" placeholder="Enter your message max 50 words"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                    <br />


                    <asp:Button ID="Button2" runat="server" Text="Submit" CssClass="buttss2" OnClick="Button2_Click"/>

                </div>

            </div>


        
        

    </form>
</body>
</html>
