<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster.master" AutoEventWireup="true" CodeFile="Cart.aspx.cs" Inherits="Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildContentPlaceHolder" Runat="Server">
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <style>
        #maincart{margin-left:200px;
               width:800px;
               margin-top:100px;
              
               height:800px;
               color:red;
        }
        #maincart tr td{text-align:center;}
        .vw{background-color:darkorange;
            color:white;
            border:none;
            width:100px;
            height:50px;
        }
        .vw:hover{border: 2px solid darkorange;
                  color:darkorange;
                  background-color:white;
        }
        #displayItems{
                     
                     border-left:1px solid darkgrey;
                     border-right:1px solid darkgrey;
                      margin-left:200px;
                      margin-bottom:100px;
        }
        #displayItems tr td{width:150px;padding:10px;}
        #displayItems tr td a{color:grey;text-decoration:underline;}
        #le{width:900px ;margin-left:200px;}
        #rt{width:350px;}
        #ma{margin-left:50px;position:relative;}
        .CVC{background-color:lightgrey;
             color:white;
             border:none;
        }
        .secu{border:none;
              height:40px;
              width:190px;
              background-color:orange;
              color:white;
              font-weight:bold;
        }
        .secu:hover{border:2px solid orange;
                    background-color:white;
                    color:orange;
                    
        }
    </style>
    <script>
  $(document).ready(function () {
            $("#hd").click(function () {
                $("#shw").toggle();
            });
        });
    </script>
     <h2  style="text-align:left;font-size:35px;font-weight:bold;margin-left:200px;">CART</h2>
    <table id="maincart" runat="server" >
       

        <tr>
            <td id="le">
                 <asp:DataList runat="server" ID="d1" OnSelectedIndexChanged="d1_SelectedIndexChanged"  >
        <HeaderTemplate>
            <table id="displayItems" >
 <tr style="height:50px;background-color:darkgrey;color:black;font-weight:bold;">
                 <th>ITEM</th>
                 <th></th>
                 <th>SIZE & QUANTITY</th>
                 <th>PRICE</th>
                 <th></th>
            </tr>
        </HeaderTemplate>

        <ItemTemplate>
           
             <tr style="border-bottom:1px solid lightgrey; border-left:1px solid darkgrey;border-right:1px solid darkgrey;">
                 <td>
                     <img  height="100" width="150" src="<%#Eval("prod_image") %>"/>
                 </td>               
                 <td><%#Eval("ProductDescription") %></td>
                 <td>
                     <p> <label>Size  :</label><span>8</span>  </p>
                     <div>
                         <label>Qty   :</label>
                        <asp:DropDownList Width="50" runat="server"   ID="qty" AutoPostBack="True" OnSelectedIndexChanged="qty_SelectedIndexChanged">
                             <asp:ListItem Selected="True">1</asp:ListItem>
                              <asp:ListItem>2</asp:ListItem>
                              <asp:ListItem>3</asp:ListItem>
                              <asp:ListItem>4</asp:ListItem>
                              <asp:ListItem>5</asp:ListItem>
                              <asp:ListItem>6</asp:ListItem>
                              <asp:ListItem>7</asp:ListItem>
                              <asp:ListItem>8</asp:ListItem>
                              <asp:ListItem>9</asp:ListItem>
                              <asp:ListItem>10</asp:ListItem>
                         </asp:DropDownList>
                     </div>
                 </td>
                 <td>R<%#Eval("Price") %></td>
                 <td>
                     <a href="DeleteItem.aspx?id=<%#Eval("ProductId") %>" ><strong>&times;</strong> Remove Item</a>
                 </td>
             </tr>
        </ItemTemplate>

        <FooterTemplate>
            </table>
 </FooterTemplate>
    </asp:DataList>

            </td>
            <td id="rt">
                <div id="ma">
<h1 style="font-weight:bold;">Summary</h1><br />
               <span>____________________________</span><br />
                <asp:Label runat="server" ID="subtot" Visible="false" ></asp:Label><br />
                <span>____________________________</span><br />
                <asp:Label runat="server" ID="delv"  Visible="false" ></asp:Label><br />
                <a href="#">More Options</a><br />
                <span>____________________________</span><br />
                <asp:Label runat="server" ID="tot"  Visible="false" ></asp:Label><br />
                <span>Including all taxes</span><br />
                <span>____________________________</span><br />
                    <p id="hd"> <span style="color:orange;font-size:25px;font-weight:bold;">+</span> Do you have a <a style="color:black;text-decoration:none;font-weight:bold;" href="#">coupon/voucher</a>  code? </p>
                   <div id="shw">
                       <asp:TextBox ID="coupon" BorderColor="Silver" Height="30" runat="server"  placeholder="Coupon/Voucher Code"></asp:TextBox><asp:Button Height="30" CssClass="CVC" runat="server" Text="USE" />
                   </div>
                 <br />  <asp:Button  runat="server" CssClass="secu" Text="SECURE CHECKOUT" /><br /><br />
                    <a href="landing.aspx" style="text-decoration:none;color:black;">Continue Shopping </a>
                </div>
              
            </td>
        </tr>
    </table>
   


   

     
        
</asp:Content>

