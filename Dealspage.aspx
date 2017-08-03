<%@ Page Title="" Language="C#" MasterPageFile="~/FirstChild.master" AutoEventWireup="true" CodeFile="Dealspage.aspx.cs" Inherits="Dealspage" %>

<%-- Add content controls here --%>

<asp:Content ContentID="Content2"   ContentPlaceHolderID="FirstChildPlaceHolder" runat="server" >
    <style>
        #main{width:1400px;
             text-align:center;
             margin-left:100px;
            
        }
        #maintbl{width:1280px;
                 
                 margin-left:4%;
                 margin-right:30%;
                 background-color:white;
                 color:black;
                 
                 
        }
        .tdl{width:320px;}
        .tdl h3{font-size:14px;font-weight:bolder;}
        table tr #Alinks a{text-decoration:none;color:black;
                           font-size:18px;
                           padding:5px;
        }
        table tr #Alinks a:hover{color:#ff6a00;}
       #maintbl2 tr .pic{width:640px;height:300px;}

       #maintbl2 tr td{padding:20px;}

        .text_container{
            
            position:relative;
        }
       
        .text_div{
            display:none;
            opacity:0.8;
            background:#000;
            width:570px;
            position:absolute;
            bottom:0px;
            padding:5px;
            
            text-align:center;
            color:white;
        }
      .text_div  a{background-color:white;
               color:black;
               width:100px;
               height:70px;
               font-weight:bolder;
               text-decoration:none;
        }
      .text_div  a:hover{
            background-color:#000000;
            color:white;
            text-decoration:none;
        }
      .text_container #try{
            position:absolute;
        
            left:0%;
            right:0%;
            background-color:black;
            color:red;
            padding:1%;
            max-width:100%;
            opacity:0.8;
            
        }
        
    </style>
   
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script>
        $(document).ready(function () {

            $('.text_container').hover(function () {
                $('.text_div').slideToggle('slow');
            },
                function () {
                    $('.text_div').slideToggle('slow');

                });
        });
    </script>
    <div id="main">
       <img src="RealDeals/homepagebanner_top_autumn_0603.jpg" width="1400" height="300"  />
        <table  id="maintbl">
            <tr style="width:1280px; height:100px;margin-top:0px;">
                <td  class="tdl">
                    <h3>What is Zando Deals? </h3>
                    <p>Zando Deals offers you the best fashion <br/> deals in South Africa.</p>
                    <p>Our deals only run for a few days and have<br/> limited quantity, so be quick.</p>
                </td>
                <td class="tdl">
                    <h3>New Deals Twice a Week</h3>
                    <p>We offer a wide range of well-known and<br /> smaller brands. Get inspired by our ever<br /> changing deals.</p>
                    <p style="color:white;">We offer a wide range of well-known and</p>
                </td>
                <td class="tdl">
                    <h3>The Zando Deals Benefit</h3>
                    <p>You still get the top brands but now at a<br /> great discount.</p>
                    <p>We only accept Debit & Credit card<br /> payment, but hey – you just got 80% off.</p>
                </td>
                <td class="tdl">
                    <h3>10 - 15 Business Days Delivery</h3>
                    <p>We cut out all the frills and order directly<br /> from our suppliers , cutting storage costs<br />, ensuring you get the VERY best price and<br /> only pay R29 per delivery – remember, it’s<br /> free if you add a Zando item to your cart!</p>
                </td>
            </tr>
            
           <tr>
                <td colspan="2" id="Alinks">
                    <a href="#" style="font-weight:bold;">ALL DEALS</a> |
                    <a href="#">WOMEN</a>     |
                    <a href="#">MEN</a>       |
                    <a href="#">KIDS</a>
                </td>
            </tr>
            
        </table>
        <table id="maintbl2">
            <tr>
                <td  class="pic">
                    
    <div  id="wrapper">
  <div class="text_container">
      <img src="MakeDeals/burano_homepage.jpg" />
      <div class="text_div">

          <h2>Burano</h2>
          
          <a href="#">SHOP NOW</a>
      </div>
  </div>
    </div>
                </td>

                <td class="pic">
                      <div id="wrapper2"> 
  <div class="text_container">
      <img src="MakeDeals/greygardens_homepage_copy.jpg" />
      <div class="text_div">

          <h2>grey gardens</h2>
          
          <a href="#">SHOP NOW</a>
      </div>
      <div id="try">
          <h2>12 hours</h2>
<p>Up to 30% OFF</p>
      </div>
      
  </div>
        </div>            
                </td>
            </tr>

            <tr>
                <td>
            <div class="text_container">
          <img src="MakeDeals/cover_girl_homepage.jpg" />
      <div class="text_div">

          <h2>Cover Girl</h2>
          
          <a href="#">SHOP NOW</a>
      </div>
  </div>
                </td>
                <td>
<div class="text_container">
    <img src="MakeDeals/blackChilli_banner.jpg" />
      <div class="text_div">

          <h2>BlackChilli</h2>
          
          <a href="#">SHOP NOW</a>
      </div>
  </div>
                </td>
            </tr>

            <tr style="border-bottom:2px solid black;">
                <td>


           <div class="text_container">
    <img src="MakeDeals/iamtrend_banner.jpg" />
          <div class="text_div">
         
          <h2>I AM TREND</h2>
          
          <a href="#">SHOP NOW</a>
      </div>
  </div>

                </td>

                <td>

             <div class="text_container">
          <img src="MakeDeals/blackcherry_homepage.jpg" />
      <div class="text_div">

          <h2>BlackCherry</h2>
          
          <a href="#">SHOP NOW</a>
      </div>
  </div>

                </td>
            </tr>

            <tr >
                <td></td>
            </tr>

        </table>

    </div>
    

</asp:Content>
