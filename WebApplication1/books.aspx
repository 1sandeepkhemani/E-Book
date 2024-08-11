<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="books.aspx.cs" Inherits="WebApplication1.books" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Material+Symbols+Outlined:opsz,wght,FILL,GRAD@48,400,0,0" />

    <style type="text/css">
          
       

                    #form1
                    {
             height: 3900px;
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

         

       
        

         

       
        

         .sesslab{
            font-size: 30px;
            font-weight: bold;
            color: white;
            vertical-align: middle;
        }

       
        .auto-style19 {
            position: absolute;
            left: 13px;
            top: 166px;
            width: 1501px;
            height: 360px;
        }
         
         .style20{
             font-size:40px;
             font-style:oblique;
            color:white;
            background-color: #301934;
            height:50px;
            }

       

       
        .auto-style22 {
            position: absolute;
            left: 500px;
            top: 80px;
            width: 603px;
            height: 60px;
            
            font-size:60px;
            font-style:oblique;
            color:white;
            text-decoration:underline;
            text-decoration-style:solid;

        }

       
        .auto-style23 {
            position: absolute;
            left: 0px;
            top: 164px;
            width: 1500px;
            height: 186px;
        }

       .linkb{
           font-size:35px;
           border:solid 3px;
           border-color:white;
           color:white;
           padding:2px;
           box-shadow:purple 3px 3px;
           text-decoration:none;
           border-radius:30px;

       }

        .linkb:hover{

            text-decoration:underline;
            
            cursor:pointer;
           
            text-decoration-color:white;
             background-color:#a42cb9;
        }
        .auto-style24 {
            width: 100%;
            height: 175px;
            text-align:center;
        }

   
        
        .auto-style26 {
            position: absolute;
            left: 14px;
            top: 529px;
            width: 1500px;
            height: 3284px;
        }

        .lable2{
            font-size:50px;
            color:white;
            font-weight:bold;
            text-decoration:underline;
            text-decoration-color:white;

        }
   
        .auto-style27 {
            position: absolute;
            left: 27px;
            top: 100px;
            width: 630px;
            height: 320px;
        }

         .img3{
     border-style:solid;
     border-width:thick;
     border-color:white;
     height:280px;
     width:600px;
 }
   
        .auto-style28 {
            position: absolute;
            left: 779px;
            top: 112px;
            width: 648px;
            height: 292px;
            text-align:justify;
        }
        
        .lable3{
            font-size:25px;
            color:white;
            font-family:'Bell MT';
            

        }

      

        .auto-style29 {
            position: absolute;
            left: 5px;
            top: 513px;
            width: 1492px;
            height: 528px;
        }

      

        .auto-style30 {
            position: absolute;
            left: 53px;
            top: 25px;
            width: 375px;
            height: 475px;
        }
        
        .bookimg{
            border-style:solid;
            border-width:3px;
            border-color:white;
            border-radius:20px;
            box-shadow:rgba(44,40,42,8) 8px 8px ;
            cursor:pointer;
        }

       

        .auto-style31 {
            position: absolute;
            left: 446px;
            top: 156px;
            width: 439px;
            height: 230px;
            color: #FFFFFF;
            font-family: "Bell MT";
            font-size: x-large;
        }



        .namelabel{
            font-size: 45px;
            font-family: 'Bell MT';
            color: white;
            text-align: left;
        }

        .linkbutton{
           
            background-color: transparent;
            color: white;
            font-size: xx-large;
            text-align: center;
            border: solid;
            padding:2px;
            border-radius: 30px;
            border-color: rebeccapurple;
            box-shadow: purple 3px 3px;
            text-decoration:none;
        }

                .linkbutton:hover{

            cursor:pointer;
             background-color:#a42cb9;
             border-color:white;

        }

        .auto-style32 {
            position: absolute;
            left: 932px;
            top: 27px;
            width: 515px;
            height: 478px;
            text-align: justify;
        }

        .auto-style33 {
            position: absolute;
            left: 5px;
            top: 1048px;
            width: 1492px;
            height: 528px;
        }

        .auto-style34 {
            position: absolute;
            left: 5px;
            top: 1584px;
            width: 1492px;
            height: 528px;
        }

        .auto-style35 {
            position: absolute;
            left: 5px;
            top: 2121px;
            width: 1492px;
            height: 528px;
        }
        .auto-style36 {
            position: absolute;
            left: 5px;
            top: 2657px;
            width: 1492px;
            height: 528px;
        }

        .auto-style37 {
            width: 48px;
            height: 48px;
        }

        .auto-style38 {
            position: absolute;
            left: 256px;
            top: 0px;
            width: 52px;
            height: 52px;
        }
        .changebut{
            text-align: center;
            color: white;
            font-size: x-large;
            vertical-align: super;
        }
        .auto-style39 {
            position: absolute;
            left: 1225px;
            top: 0px;
            width: 274px;
            height: 52px;
            top: 0px;
            vertical-align: middle;
        }
        .auto-style40 {
            width: 48px;
            height: 48px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">

             <div class="auto-style12">

    <div class="auto-style13">

        <asp:Image ID="Image1" runat="server" Height="139px" ImageUrl="~/Scripts/WebForms/bookbg.png" Width="136px" />

    </div>

     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    <div class="auto-style14">

         E-BOOKS STORE

    </div>

   

    <div class="auto-style15">
        

        <asp:Button ID="Button1" runat="server" Text="Logout" CssClass="buttss" OnClick="Button1_Click"/>
        

    </div>

     <div class="auto-style16">
      <hr />
    </div>

                
    </div>

        <br />
        <br />


        <div class="auto-style19">
            
            <div class="style20">
                WELCOME TO&nbsp;
                <div class="auto-style38"><img src="data:image/png;base64,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" class="auto-style37">
                </div>
                 &nbsp;&nbsp;&nbsp;
                 <asp:Label ID="Label1" runat="server" CssClass="sesslab"></asp:Label>

                

            
                <div class="auto-style39">
                <img src="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAADAAAAAwCAYAAABXAvmHAAAACXBIWXMAAAsTAAALEwEAmpwYAAADTklEQVR4nO2YXU8TQRSGe0G4URN/hIkJslP5AVKK3nvlH/CCP+Bn9AJjIol4IQnUpDNFEkrVEEIQkSCKGBSItqYYykdKKgYxiAiiIB/CmddsC7LbAlW7s1TTN5mk6Z6deZ+eczq743DklFNOlkrzQmOCqjRBEY3TYnwIiujfMR8KHdmqgkbkM0EeJoiYkNhuaJzWGadqPdaRTSpoRL4mqGsn4ykggrqyCkLjdMtsklqcAiWsHvv04fTBrXFqNcVwqnZkS83HS+OXOVzcMVbgsrGcnBxHHHuteHMafvl08ZqgB4b4m/a43M0Qp6FNQ4VeuNLFM45SQy9E7HG5myFBC5uGCmqwP138YR8OGDKw4NhrGRtT5T3KlAPYa/0TGXCVI08TOM8EhRin1Z12WOM9BQKHNEFvf3d3ZonNbVVfQ19LX9M685y60y3uFESdMXgfRuFtGYX3dBv6/8i8SB70zBIIjeNCusWO1kqcfSzxdBzojAHtUeD2AFDszwRAQs9ExgDxstmY8HofMPwJGJkBBqeBgSkg9AF4OQn0TgA972CCuD8KNA0D9wYl/G8k6sIS/LWE55VEVb9EZa/EtR6JK90Sl55InHkkcbLRVFLBzAEMNT82C8TmgOhnhRAd5p6wIANbE07MA+Nf1EMwK/+ljJNNfoMtEEwVwNQCbIFgqgCmF2ELBFMFMLMEWyCYKoC5ZdgCwVQBzK/AFgimCuDrCkwQrVHAHZAoDUg0j5gh7kQAV4NEiV83ZoaoCQLH6mV83OhLhVAGsLAKE8TxwNY1/bMxE+6GrWtuvzRlwviIUVwvUzKhDGDxB0wQyQDGckoGMJaTKwmgPamclAEsrcEE0RFLQJwISLSNmXuiaSQBUdogcXfI3BO+cALCVS/hCaX2hDKAlTWkQKhobKYKYHUdtkAwVQBrBFsgmEoAOyCYKoD1DQDVEEwVAEnYAsFUAtgBwSwFMLxS6mZVQ/S/h8WvlJyCmxN6w1AKEf4IXH0Oa1/qEwdaf380cqo58YhhhKh4IVFUa9OxiqscefohUyYQlX3wzC+jbHYZZTPfUVbko5W05jl1W3s6p2dCL6ddjha3HxRy1uGgcT6NU4UmaC0lVp+bU1DjOGeZ+Zxy+s/1E9qpmAG7gy62AAAAAElFTkSuQmCC" class="auto-style40"><asp:LinkButton ID="LinkButton11" runat="server" CssClass="changebut" OnClick="LinkButton11_Click">Change Password</asp:LinkButton>
                    </div>
                

                

            </div>
            <hr />

            <br />
           

            <div class="auto-style22">
                BOOKS CATEGORIES
            </div>

            <div class="auto-style23">
                
                    
                <table class="auto-style24">
                    <tr>
                        <td >
                            
                            <asp:LinkButton ID="LinkButton1" runat="server" CssClass="linkb" OnClick="LinkButton1_Click1" Height="50px" Width="250px">Mystery</asp:LinkButton>
                        </td>
                        <td >
                            <asp:LinkButton ID="LinkButton2" runat="server" CssClass="linkb" Height="50px" Width="250px" OnClick="LinkButton2_Click">Thriller</asp:LinkButton>
                        </td>
                        <td>
                            <asp:LinkButton ID="LinkButton3" runat="server" CssClass="linkb" Height="50px" Width="250px" OnClick="LinkButton3_Click">Science Fiction</asp:LinkButton>
                        </td>
                        <td>
                            <asp:LinkButton ID="LinkButton4" runat="server" CssClass="linkb" Height="50px" Width="250px" OnClick="LinkButton4_Click">Romance</asp:LinkButton>
                        </td>
                        <td >
                            <asp:LinkButton ID="LinkButton5" runat="server" CssClass="linkb" Height="50px" Width="250px" OnClick="LinkButton5_Click">Adventure</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td >
                            <asp:LinkButton ID="LinkButton6" runat="server" CssClass="linkb" Height="50px" Width="250px" OnClick="LinkButton6_Click">Crime</asp:LinkButton>
                        </td>
                        <td >
                            <asp:LinkButton ID="LinkButton7" runat="server" CssClass="linkb" Height="50px" Width="250px" OnClick="LinkButton7_Click">Horror</asp:LinkButton>
                        </td>
                        <td >
                            <asp:LinkButton ID="LinkButton8" runat="server" CssClass="linkb" Height="50px" Width="250px" OnClick="LinkButton8_Click">Biography</asp:LinkButton>
                        </td>
                        <td >
                            <asp:LinkButton ID="LinkButton9" runat="server" CssClass="linkb" Height="50px" Width="250px" OnClick="LinkButton9_Click">Action</asp:LinkButton>
                        </td>
                        <td >
                            <asp:LinkButton ID="LinkButton10" runat="server" CssClass="linkb" Height="50px" Width="250px" OnClick="LinkButton10_Click">Children's</asp:LinkButton>
                        </td>
                    </tr>
                </table>
                <hr />
                </div>
            
        </div>




        <div class="auto-style26">
            
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" CssClass="lable2"></asp:Label>
            
            <br />
            <br />
            <div class="auto-style27">

                <asp:Image ID="Image2" runat="server" CssClass="img3" />

            </div>

            <div class="auto-style28">

                <asp:Label ID="Label3" runat="server" CssClass="lable3"></asp:Label>

            </div>




            <div class="auto-style33">

                <div class="auto-style30">

                    <asp:Image ID="Image3" runat="server" Height="450px" Width="350px" CssClass="bookimg" />

                </div>

                <div class="auto-style31">



                    <asp:Label ID="Label4" runat="server" CssClass="namelabel"></asp:Label>



                    <br />
                    <br />
                    &nbsp;Author By :-
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                    <br />



                    <br />
                    &nbsp;<asp:HyperLink ID="HyperLink1" runat="server" CssClass="linkbutton" Height="40px" Width="150px" Target="_blank">Read</asp:HyperLink>
                    &nbsp;
                    <asp:HyperLink ID="HyperLink2" download runat="server" CssClass="linkbutton" Height="40px" Width="200px">Download</asp:HyperLink>



                </div>


                <div class="auto-style32">


                <asp:Label ID="Label6" runat="server" CssClass="lable3"></asp:Label>


                </div>

                </div>



            <div class="auto-style29">

                 <div class="auto-style30">

                     <asp:Image ID="Image4" runat="server" Height="450px" Width="350px" CssClass="bookimg" />

                </div>

                <div class="auto-style31">



                     <asp:Label ID="Label7" runat="server" CssClass="namelabel"></asp:Label>



                     <br />
                    <br />
                    &nbsp;Author By :-
                    <asp:Label ID="Label8" runat="server"></asp:Label>
                    <br />



                     <br />
                     &nbsp;<asp:HyperLink ID="HyperLink3" runat="server" CssClass="linkbutton" Height="40px" Width="150px" Target="_blank">Read</asp:HyperLink>
                     &nbsp;
                     <asp:HyperLink ID="HyperLink4" download runat="server" CssClass="linkbutton" Height="40px" Width="200px">Download</asp:HyperLink>



                 </div>


                 <div class="auto-style32">


                    <asp:Label ID="Label9" runat="server" CssClass="lable3"></asp:Label>


                 </div>

           </div>




           <div class="auto-style35">

            <div class="auto-style30">

                 <asp:Image ID="Image5" runat="server" Height="450px" Width="350px" CssClass="bookimg" />

            </div>

             <div class="auto-style31">



                 <asp:Label ID="Label10" runat="server" CssClass="namelabel"></asp:Label>



                <br />
                <br />
                 &nbsp;Author By :-
                <asp:Label ID="Label11" runat="server"></asp:Label>
                <br />



                <br />
                &nbsp;<asp:HyperLink ID="HyperLink5" runat="server" CssClass="linkbutton" Height="40px" Width="150px" Target="_blank">Read</asp:HyperLink>
                &nbsp;
                <asp:HyperLink ID="HyperLink6" download runat="server" CssClass="linkbutton" Height="40px" Width="200px">Download</asp:HyperLink>



              </div>


                <div class="auto-style32">


                     <asp:Label ID="Label12" runat="server" CssClass="lable3"></asp:Label>


                </div>

            </div>
            

            <div class="auto-style34">

                    <div class="auto-style30">

                         <asp:Image ID="Image6" runat="server" Height="450px" Width="350px" CssClass="bookimg" />

                    </div>

                <div class="auto-style31">



                 <asp:Label ID="Label13" runat="server" CssClass="namelabel"></asp:Label>



                     <br />
                     <br />
                     &nbsp;Author By :-
                    <asp:Label ID="Label14" runat="server"></asp:Label>
                    <br />



                 <br />
                 &nbsp;<asp:HyperLink ID="HyperLink7" runat="server" CssClass="linkbutton" Height="40px" Width="150px" Target="_blank">Read</asp:HyperLink>
                 &nbsp;
                <asp:HyperLink ID="HyperLink8" download runat="server" CssClass="linkbutton" Height="40px" Width="200px">Download</asp:HyperLink>



                </div>


                <div class="auto-style32">


                  <asp:Label ID="Label15" runat="server" CssClass="lable3"></asp:Label>


              </div>

        </div>


         <div class="auto-style36">

                 <div class="auto-style30">

            <asp:Image ID="Image7" runat="server" Height="450px" Width="350px" CssClass="bookimg" />

           </div>

           <div class="auto-style31">



             <asp:Label ID="Label16" runat="server" CssClass="namelabel"></asp:Label>



                 <br />
                <br />
                 &nbsp;Author By :-
               <asp:Label ID="Label17" runat="server"></asp:Label>
               <br />



                 <br />
                 &nbsp;<asp:HyperLink ID="HyperLink9" runat="server" CssClass="linkbutton" Height="40px" Width="150px" Target="_blank">Read</asp:HyperLink>
                 &nbsp;
                 <asp:HyperLink ID="HyperLink10" download runat="server" CssClass="linkbutton" Height="40px" Width="200px">Download</asp:HyperLink>



            </div>


                   <div class="auto-style32">


                         <asp:Label ID="Label18" runat="server" CssClass="lable3"></asp:Label>


                    </div>

            </div>




        </div>
       
    </form>
</body>
</html>
