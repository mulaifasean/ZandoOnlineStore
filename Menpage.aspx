<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster.master" AutoEventWireup="true" CodeFile="Menpage.aspx.cs" Inherits="Menpage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildContentPlaceHolder" Runat="Server">
    <style>
      #Picmen{width:800px;
              margin-left:200px;
      }
      #Picmen tr {height:250px;}
      #Picmen tr td{width:180px;padding:20px;}
      #Picmen tr td a:hover{color:orange;}
      #Picmen tr td a{text-decoration:none;
                      color:black;
      }
    </style>
    <div>

        <table id="Picmen">
            <tr>
                 <td>
               
                     <a id="A1" runat="server" href="ProductDetails.aspx">
                     <asp:Image runat="server" ID="mg1" />
                     <h3 id="name1" runat="server"></h3></a>
                     <h4 id="des1" runat="server"></h4>
                     R<p id="price1" runat="server"></p>
                     
                 </td>
                 <td>
                     <a href="#">
                         <asp:Image runat="server" ID="mg2" />
                         <h3 id="name2" runat="server"></h3></a>
                 
                     <h4 id="des2" runat="server"></h4>
                     R<p id="price2" runat="server"></p> 
                 </td>
                 <td>
                     <a href="#">
                         <asp:Image runat="server" ID="mg3" />
                         <h3 id="name3" runat="server"></h3></a>
                   
                     <h4 id="des3" runat="server"></h4>
                    R <p id="price3" runat="server"></p>  
                 </td>
                 <td>
                     <a href="#">
                    <asp:Image runat="server" ID="mg4" />
                    <h3 id="name4" runat="server"></h3></a>
                   
                     <h4 id="des4" runat="server"></h4>
                    R <p id="price4" runat="server"></p>
                 </td>
            </tr>
        </table>
    </div>
</asp:Content>

