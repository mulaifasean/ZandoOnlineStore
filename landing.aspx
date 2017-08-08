<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster.master" AutoEventWireup="true" CodeFile="landing.aspx.cs" Inherits="landing" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildContentPlaceHolder" Runat="Server">

    <style>
        #landtbl{max-width:1200px;
              margin-left:200px;   
        }
         #landtbl3{max-width:1200px;
              margin-left:200px;   
        }
         #landtbl4{max-width:1200px;
              margin-left:200px;  
        }
         #landtbl5{max-width:1200px;
              margin-left:200px; 
        }
         #landtbl6{max-width:1200px;
              margin-left:200px;
        }
        #landtbl #tr1 {height:360px;}
        
       #landtbl tr td{padding:10px;}
            #landtbl tr #shop1 {
                background-image: url(http://localhost:49251/landingPics/TL_women.png);
                background-repeat:no-repeat;
              background-size:600px;
                width:600px;
            }
            #landtbl tr #shop2 {
                background-image: url(http://localhost:49251/landingPics/TR_Men.png);
                background-repeat:no-repeat;
               background-size:600px;
                width:600px;
            }
            #landtbl tr .shop{padding:12px;
                              
            }
            #sw{border-style: none;
            background-color:white;
                color:black;
                
                font-weight:bolder;
                font-size:15px;
                opacity:0.4;
                position:absolute;
                margin-left:0px;
            top: 327px;
            left: 200px;
            height:70px;
            width:190px;
        }
            #sw:hover{background-color:black;
                      color:white;
                      opacity:0.8;
            }
            #sm{border-style: none;
            background-color:white;
                color:black;
                
                font-weight:bolder;
                font-size:15px;
                opacity:0.4;
                position:absolute;
                margin-left:0px;
            top: 327px;
            right:200px;
            height:70px;
            width:190px;
            }
            #sm:hover{background-color:black;
                      color:white;
                      opacity:0.8;
            }
            
            #landtbl3 #tr3{height:350px;}
           
                #landtbl3 #tr3 #td31 {
                    background-image: url(http://localhost:49251/landingPics/ML_womensshoes.png);
                    background-repeat: no-repeat;
                    background-size: contain;
                    height: 100%;
                    width: 380px;
                    padding:10px;
                }
                #landtbl3 #tr3 #td32 {
                    background-image: url(http://localhost:49251/landingPics/Get_The_App_Homepage_banner-no_cta.jpg);
                    background-repeat: no-repeat;
                    background-size: contain;
                    height: 100%;
                    width: 380px;
                }
                #landtbl3 #tr3 #td33 {
                    background-image: url(http://localhost:49251/landingPics/MR_mensshoes2.jpg);
                    background-repeat: no-repeat;
                    background-size: contain;
                    height: 100%;
                    width: 380px;
                }
                #landtbl3 #tr3 #td31 input{width:120PX;
                                   height:50px;
                                   background-color:white;
                                   color:black;
                                   font-weight:bolder;
                                   margin-left:30%;
                                   border:none;
                                  position:relative;
                                  bottom:0px;
                                   
                }
                
                 #landtbl3 #tr3 #td32 input{width:120PX;
                                   height:50px;
                                   background-color:white;
                                   color:black;
                                   font-weight:bolder;
                                   margin-left:30%;
                                   border:none;
                                   
                 }
                  #landtbl3 #tr3 #td33 input{width:120PX;
                                   height:50px;
                                   background-color:white;
                                   color:black;
                                   font-weight:bolder;
                                   margin-left:30%;
                                   border:none;
                                  
                  }
                  #landtbl3 #tr3 #td31 input:hover{background-color:black;color:white;}
                  #landtbl3 #tr3 #td32 input:hover{background-color:black;color:white;}
                  #landtbl3 #tr3 #td33 input:hover{background-color:black;color:white;}
                  #tr4{height:400px;}
                  #tr4 .tdmid{width:25%;}
                   #tr4 .tdmid p a{text-decoration:none;
                                   color:black;
                   }
                   #tr4 .tdmid p{border-bottom:1px solid grey;}
                   #tr5{height:50px;}
                   #tr5 td{width:60px;}
                   #landtbl6 tr td{padding:12px;}
                    #landtbl4 tr td{padding:12px;}
                     #landtbl3 tr td{padding:12px;}
                     #words{width:1200px;
                            margin-left:200px;
                     }
                     #words p{height:60px;
                              font-size:14px;
                     }
    </style>

    <table id="landtbl">
        <tr id="tr1">
            <td class="shop" id="shop1">
             <input id="sw" type="button" onclick="window.location('WOMEN.aspx')" value="SHOP WOMEN" />  
            </td>
            <td class="shop" id="shop2" >
               <input id="sm"  type="button" onclick="window.location('MEN.aspx')" value="SHOP MEN" /></td>
        </tr>
       
       
       
        
    </table>
    
                <p style="font-size:30px;margin-left:200px;text-align:center;">STYLE. UNRESTRICTED.</p>
                <p style="font-size:15px;margin-left:200px;text-align:center;">Finding the perfect outfit is just a click away, with Zando you can shop wherever, whenever!</p>
           
    <table id="landtbl3">
         <tr id="tr3">
            <td id="td31">
               <input type="button" value="WOMEN SHOES" />
            </td>
            <td id="td32">
               <input type="button" value="GET THE APP" />
            </td>
            <td id="td33">
                <input type="button" value="MEN SHOES" />
            </td>
        </tr>
    </table>

    <table id="landtbl4">
         <tr id="tr4">
            <td class="tdmid">
                <img src="landingPics/Homepage_Bottom_left_Utopia_14.06.2017.jpg" /></td>
            <td class="tdmid">
                <p style="font-weight:bolder;">SHOP WOMEN</p>
                <p><a href="#">NEW ARRIVALS</a></p>
                 <p> <a href="#">CLOTHING</a></p>
                 <p> <a href="#">SHOES</a></p>
                 <p><a href="#">ACCESSORIES</a></p>
                 <p><a style="color:red;" href="#">SALE</a></p>
                
            </td>
            <td class="tdmid">
                 <p style="font-weight:bolder;">SHOP MEN</p>
                 <p> <a href="#">NEW ARRIVALS</a></p>
                 <p><a href="#">CLOTHING</a></p>
                 <p><a href="#">SHOES</a></p>
                 <p><a href="#">ACCESSORIES</a></p>
                 <p><a href="#" style="color:red;">SALE</a></p>
            </td>
            <td class="tdmid">
                <img src="landingPics/Homepage_Middle_Right_Adidas_090217.jpg" /></td>
        </tr>
    </table>
    
    <table id="landtbl5">
        <tr id="tr5">
            <td><a href="#">
                <img src="landingLabels/utopiarow.jpg" /></a></td>
            <td><a href="#">
                <img src="landingLabels/queenspark.jpg" /></a></td>
            <td><a href="#">
                <img src="landingLabels/zoomrow.jpg" /></a></td>
            <td><a href="#">
                <img src="landingLabels/miss_blackrow.jpg" /></a></td>
            <td><a href="#">
                <img src="landingLabels/Polo_brandlogo_update_80x60_.jpg" /></a></td>
            <td><a href="#">
                <img src="landingLabels/New_Look_brandlogo_update_80x60_.jpg" /></a></td>
            <td><a href="#">
                <img src="landingLabels/Jeep_brandlogo_update_80x60_.jpg" /></a></td>
            <td><a href="#">
                <img src="landingLabels/sovietrow.jpg" /></a></td>
            <td><a href="#">
                <img src="landingLabels/Levi's_brandlogo_update_80x60_.jpg" /></a></td>
            <td><a href="#"></a>
                <img src="landingLabels/adidas.jpg" /></td>
            <td><a href="#">
                <img src="landingLabels/Puma_brandlogo_update_80x60_.jpg" /></a></td>
            <td><a href="#">
                <img src="landingLabels/nikerow.jpg" /></a></td>
        </tr>
    </table>

    <table id="landtbl6">
     <tr>
         <td>
             <img src="landingPics/home_womensdresses_1605.jpg" width="190" height="220" /></td>
         <td>
             <img src="landingPics/home_menstshirts_1605.jpg" width="190" height="220"/></td>
         <td>
             <img src="landingPics/free_delivery_722x482.jpg" width="300" height="220"/></td>
         <td>
             <img src="landingPics/home_kids_1605.jpg" width="190" height="220" /></td>
         <td>
             <img src="landingPics/home_beauty_1605.jpg" width="190" height="220"/></td>
     </tr>
    </table>

    <table>
        </table>
    <div id="words">
        <h2 style="font-size:35px;font-weight:bolder;">Indulge In Online Fashion With Zando!</h2>
        <p>If you’re searching for the latest fashion and accessories for your entire family, then you’ve clicked on the right place! Zando is the ultimate online shopping portal that offers fashion, home and beauty all under one virtual roof. Imagine a store that is open 24 hours a day and 7 days a week, with a multitude of safe payment options and a wide variety of local and international brands to choose from – and all this in the comfort of your home! Shop the best local and international brands and pay with your credit card, or via EFT, cash on delivery, in-store, or using eBucks. If you buy something and it doesn’t fit, no worries because Zando offers free returns within 14 days.</p>
        <p></p>
        <h3>Stay On-Trend With Apparel For Men, Women And Children Online</h3>
        <p>Your every fashion dream comes true with Zando’s trendy clothing for ladies, 
            men and children. Zando takes the latest high fashion runway trends and
            sources the best ready-to-wear interpretations, ensuring that you have the
            latest fashion at your fingertips. Ranging from jackets, jeans, sweatshirts, 
            knitwear, T-shirts, and much more, you have a one-stop online fashion store 
            where all your needs are met. Shop ladies fashion by local designers Chica 
            Loca, Michelle Ludek, as well as international brands Elle Macpherson and many
            more. Men can get all their favourite lifestyle brands like Adidas, Nike, Billabong 
            and more at the click of a button. Have your kiddies decked out in apparel and
            accessories from all their favourite superheroes and cartoon characters like Ben 
            10, Hello Kitty, Minnie Mouse, and Spiderman just to name a few. Browse our Fashion
            Glossary and find trendy clothing items and shoes.</p>
        <p></p>
        <h3>Step Out In Style With Shoes Online At Zando</h3>
        <p>Make sure your shoe-game is up to standard with Zando’s wide selection of shoes. 
            The online shoe store caters for men, women and the littlest members of the family
            too! Ladies are spoilt for choice with the wide assortment of heels on offer.
            From platform heels, to espadrilles, block heels, courts, peep-toes, and boots
            just to name a few, you’re in high heel heaven at Zando. The assortment of ladies 
            shoes also offers trendy sneakers, flats, sandals and slippers.</p>
        <p>They say one can tell a lot about a man from his shoes and now you can let your footwear do all the talking with Zando’s assortment of men’s shoes. Look ultra-suave for any occasion with the selection of men’s shoes on offer. Ranging from casual shoes, to formal, sneakers, sandals, and boots, the men’s shoes take you from work, to play and everything in-between!</p>
        <p>Kiddies are not left out of the fashionable footwear equation! Buy children’s shoes from basic school shoes, to casual sneakers, boots, sandals and more, Zando has not forgotten about the tiniest feet in the family and all your family’s footwear needs are taken care of in a few simple clicks!</p>
        <h3>Dresses – Hit The Right Style Note Every time!</h3>
        <p>The easiest way to get dressed is to throw on a dress and at Zando you have a wide variety of dresses to choose from. The dresses on offer range from skater dresses, to maxi dresses, flared, and bodycon dresses just to name a few. Get the classic little black dress, or contemporary hues and exciting pops of print. With a wide variety of dresses to choose from, Zando has solved the age-old “I have nothing to wear” dilemma for you!</p>
        <h3>Accessorise Excessively With Accessories Online At Zando</h3>
        <p>Add a personal touch to your attire with Zando’s wide assortment of accessories. Accessories are an easy way to instantly transform an outfit and infuse your personal style as well as to have fun with fashion. Buy bags, jewellery, eyewear, belts, gloves and scarves and more small details that make a big difference to your attire!</p>
        <h3>Gear Up In The Best Sportswear And Accessories!</h3>
        <p>Get ready for your workout with women’s and men’s sporting gear online at Zando. The assortment features well-known names in performance apparel. Ranging from sports shoes, to outdoor shoes, sweatshirts, swimwear, sports equipment and accessories, the sportswear on offer consists of basics as well as accessories. Whether you’re a rookie, a seasoned professional or someone who occasionally enjoys a morning jog, Zando has performance apparel and accessories for all fitness levels!</p>
        <h3>Decorate Your Home With The Best Homeware And Décor Accessories Online
        </h3>
        <p>Now you can turn your house into a home with Zando’s home décor items and accessories. 
            The homeware online features décor accessories, kitchen accessories, table linen and 
            blankets, throws and quilts just to name a few. From the bedroom, to the bathroom, 
            outdoors, kitchen, lounge and every other room, you can add special touches to your
            décor that reflect your personal style. Zando has a wide selection of trending home
            décor items and accessories in the season’s hottest hues. Who needs an interior decorator 
            when you can give your house a complete home make-over without leaving the comfort of your home!</p>
        <p></p>
        <h3>Join The Zando Family!</h3>
        <p>Get in on all the fun on our Facebook page, Twitter account, Google Plus, Pinterest and visit our blog regularly for trending fashion news and events. Zando covers the latest trends and brings them to you in the comfort of your home!</p>
    </div>
</asp:Content>

