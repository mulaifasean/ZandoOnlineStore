<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard.master" AutoEventWireup="true" CodeFile="Wishlist.aspx.cs" Inherits="Wishlist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="DashboardPlaceHolder" Runat="Server">
    <style>
      h1{font-weight:bold;text-align:center;}
      h3{text-align:center;}
      Wishl{text-align:center;
           width:800px;
          margin-left:100px;
      }
      #Addwish{background-color:black;color:white;border:none;
               width:200px;
               height:50px;
               
      }
    </style>
    
    <div id="Wishl">
        <h1>MY ACCOUNT  <span style="color:#ff9900;">Wishlist</span></h1>
        <h3><span>___________________</span>  MY WISHLISTS  <span>___________________</span> </h3>
        <table>
            <tr>
                <td style="text-align:right;">
                   <input type="button" id="Addwish" class="glyphicon glyphicon-plus" value="ADD WISHLIST"  />
                </td>
            </tr>

            <tr>
                <td>

                </td>
                <td>

                </td>
            </tr>
        </table>
    </div>
    
</asp:Content>

