<% @Page Title="" Language="C#" MasterPageFile="~/ChildMaster.master" AutoEventWireup="true" CodeFile="ProductDetails.aspx.cs" Inherits="ProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildContentPlaceHolder" Runat="Server">

   <link type="text/css" rel="stylesheet" href="magiczoom.css"/>
<script type="text/javascript" src="magiczoom.js"></script>
   
    <style>
        #PDet{visibility:hidden;}
        #PDet{width:800px;
              margin-left:200px;
        }
        #PDet tr td{width:400px;
                    height:400px;
        }
        #PDet tr td a{width:100%;height:100%;}
    </style>
    
    <script>
     
    </script>
    <div>
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
                </td>
            </tr>
            <tr>
                <td>
                    
                </td>
            </tr>
        </table>
       
    </div>
</asp:Content>

