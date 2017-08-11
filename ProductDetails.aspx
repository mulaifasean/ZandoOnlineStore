<% @Page Title="" Language="C#" MasterPageFile="~/ChildMaster.master" AutoEventWireup="true" CodeFile="ProductDetails.aspx.cs" Inherits="ProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildContentPlaceHolder" Runat="Server">

   <link type="text/css" rel="stylesheet" href="magiczoom.css"/>
<script type="text/javascript" src="magiczoom.js"></script>
   
    <style>
        #PDet2{width:1000px;
                         
              margin-top:200px;
              margin-left:200px;
        }
        #PDet tr td{width:500px;
                    height:500px;
                    padding:30px;
        }
        #PDet tr td a{width:100%;height:100%;}
        
        .AddC{width:300PX;
              height:70PX;
              border:none;
              background-color:darkorange;
              color:white;
              font-weight:bold;
        }
        .AddC:hover{border:2px solid darkorange;
                color:darkorange;
                background-color:white;
        }
    </style>
    
    <script>
     
    </script>
    <div id="PDet2">
        <table id="PDet" runat="server" >
            <tr>
                <td>
                    
                    <a id="pd1"  runat="server" data-options="zoomWidth:300px; zoomHeight:300px" class="MagicZoom">
<asp:Image runat="server" ID="mg1" Width="400" Height="400" />
                    </a>
      
                </td>
                <td>
              
                     <h3 id="name1" runat="server"></h3>
                     <h4 id="des1" runat="server"></h4>
                     <p id="price1" runat="server"></p>
                    <asp:Button runat="server" ID="AddCart" Cssclass="AddC"    Text="ADD TO CART" OnClick="AddCart_Click"   /><br />
                </td>
            </tr>
            <tr>
                <td>
                    
                </td>
            </tr>
        </table>
       
    </div>
</asp:Content>

