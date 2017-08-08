<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster.master" AutoEventWireup="true" CodeFile="Cart.aspx.cs" Inherits="Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildContentPlaceHolder" Runat="Server">
    <style>
        #wanga{margin-left:200px;
               width:800px;
               margin-top:100px;
              
               height:800px;
               color:red;
        }
        #wanga tr td{text-align:center;}
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
    </style>
    <table id="wanga" runat="server">
        <tr>
            <td>
                <h3>CART PAGE</h3>
                <asp:Label ID="TEST" runat="server" Visible="false" ></asp:Label>
  <asp:Button runat="server" ID="view" Text="View Cart" CssClass="vw" OnClick="view_Click" />
            </td>
            
        </tr>
        
        <tr>
            <td  runat="server" id="viewcart">
                

            </td>
        </tr>
    </table>
   

  
</asp:Content>

