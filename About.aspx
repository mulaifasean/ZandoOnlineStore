<%@ Page Title="" Language="C#" MasterPageFile="~/FirstChild.master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="FirstChildPlaceHolder" Runat="Server">
    <style>
        #mainAbt{width:1200px;
                 height:300px;
                 margin-left:200px;
        }
            #mainAbt img {
                width:1200px;
                height:250px;
                margin-bottom:25px;
                margin-top:25px;
            }
     h2{width:1200px;
        height:100px;
        margin-left:200px;
        padding-top:20px;
        color:black;
        font-weight:bold;
        text-align:center;
     }
     #tbl1{width:1200px;
           height:350px;
           margin-left:200px;
           padding-top:20px;
     }
     #tbl1 tr td{width:300px;text-align:center;}
     #tbl1{border-bottom:2px solid black;}
     #tbl2 {width:1200px;
           height:350px;
           margin-left:200px;
           padding-top:20px;}
     #tbl2 tr td{width:600px;
                 height:150px;
                 text-align:center;
     }
     #tbl2 tr th{height:40px;
                 font-weight:bolder;
                 font-size:20px;
                 text-align:center;
     }
     #VId{width:1200px;
          height:550px;
          margin-left:200px;
          background-color:darkgray;
          margin-bottom:20px;
          
     }
     #VId iframe{margin-left:300px;margin-top:10px;}
     #VId h3,p{text-align:center;}
    </style>
    
    <div id="mainAbt">
        <img src="About%20pics/zandodeals_abouttopimage2.jpg" />
    </div>
    <h2>ABOUT ZANDO DEALS</h2>
    <table id="tbl1">
        <tr>
            <td>
                <img src="About%20pics/1login.png" /></td>
            <td>
                <img src="About%20pics/2discounts.png" /></td>
            <td>
                <img src="About%20pics/3deliveryprice.png" /></td>
            <td>
                <img src="About%20pics/4deliverytime_new.png" /></td>
        </tr>
        <tr style="font-weight:bolder; font-size:20px;">
            <td>Login</td>
            <td>Highest Discount Guaranteed</td>
            <td>Order</td>
            <td>Delivery</td>
        </tr>
        <tr>
            <td>
                Use your Zando Log In or Create a New Account. Don’t forget to subscribe so you never miss a deal.
            </td>
            <td>
                We negotiate the best prices & cut out all the non essential costs so you can get the best deal.
            </td>
            <td>
                Place an order and pay with a credit card. Delivery is only R29, but it’s free if you add a Zando item.
            </td>
            <td>
                After a promotion ends we order your products directly from our suppliers to save on storage costs. This reflects on the price. We deliver to you in 10-15 working days.


            </td>
        </tr>
        

    </table>

    <table id="tbl2">
        <tr>
            <th>What is Zando Deals?</th>
            <th>New Deals Twice A Week</th>
        </tr>
        <tr>
            <td>
                Zando Deals offers you the best Deals you can find on different fashion items 
                and brands. Each of our deals only run for a few days and we 
                have limited quantity, so be quick – our newsletters will keep you updated 
                so you don’t miss any deals.
            </td>
            <td>
                We offer a wide range of well-known, smaller and unknown brands.
                Get inspired by our ever changing deals. Subscribe to our Newsletter
                now and never miss a deal!
            </td>
        </tr>
        <tr>
            <th>What is the Delivery Fee for Zando Deals?</th>
            <th>How do I pay for my Zando Deals Order?</th>
        </tr>
        <tr>
            <td>
                The delivery fee in respect of Zando Deals
                (unless combined with other Zando items and the order is not split) shall be R29.00 
                per order.
            </td>
            <td>
                Unfortunately only credit card payments are accepted in respect of Zando Deals orders. 
                This is because these special offers are available for a limited time only and other
                payment methods takes too long to process and clear. We would not want you to miss out
                on great deals because of payment delays.
            </td>
        </tr>
        <tr>
            <th>The Zando Benefits</th>
            <th>10-15 Working Days Delivery</th>
        </tr>
        <tr>
            <td>As a part of the Zando-family we benefit from good relations with top brands and 
                can therefore pass them onto you. You can also trust the
                reliable Zando Service even though we only accept Credit card payments, 
                but hey – you just got 80% off!</td>
            <td>
                After a promotion ends we order your products directly from
                our suppliers to save on storage costs. This reflects on the price!
                We also cut out all the other bells and whistles to make sure you 
                really get the VERY best price and only pay R29 for each delivery –
                and remember, it’s free if you add a Zando item to your cart!
            </td>
        </tr>
    </table>

    <div id="VId">
        <iframe width="700" height="450" src="https://www.youtube.com/embed/-_iKYZlJCwI"></iframe>
        <h3>How can I become a seller on ZandoDeals?</h3>
        <p>Please email to <u> zandodeals@zando.co.za</u> and tell us a bit more about your brand and product</p>
    </div>
</asp:Content>

