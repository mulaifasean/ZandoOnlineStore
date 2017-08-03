<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster.master" AutoEventWireup="true" CodeFile="AdminAddItems.aspx.cs" Inherits="AdminAddItems" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildContentPlaceHolder" Runat="Server">
    <style>

        .auto-style1 {
            height: 20px;
        }
        
        #admintbl tr td{width:100px;padding:20PX;}
        h3{background-color:aqua;color:red;text-align:center;font-weight:bold;font-size:30px;}
        #admintbl{margin-left:400px;
background-image:linear-gradient(to Bottom,#00ff90 30%,#0026ff 70%);
color:purple; 
text-align:center;
width:700px;
        }
        .Aditem{background-color:orange;color:white;border:none;
                width:200px;
                height:80px;
                font-weight:bold;
        }
        .Aditem:hover{background-color:white;color:orange;
                      border:2px solid orange;
        }
        .btn{background-color:black;color:white;
             border:none;
             width:150px;
             height:60px;
        }
        .btn:hover{background-color:white;color:black;
                   border:2px solid black;
        }
    </style>
    <div>
        <h3>ADD PRODUCTS IN THE FOLLOWING FIELDS:</h3>
        <table id="admintbl">
            <asp:Label Visible="false" runat="server" ID="stat" ></asp:Label>
            <tr>
                <td colspan="2">
                    <asp:Label runat="server" ID="admin" Visible="false" ></asp:Label>
                    <asp:Button class="navbar navbar-right" runat="server" Text="Log Out" ID="adminbtn" CssClass="btn" OnClick="adminbtn_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1"><span style="font-weight:bold;" >PRODUCT NAME:</span></td>
                <td class="auto-style1">
                    <asp:TextBox runat="server" ID="prodnme"></asp:TextBox>
                </td>
            </tr>

             <tr>
                <td><span style="font-weight:bold;" >PRODUCT DESCRIPTION:</span></td>
                <td>
                    <asp:TextBox runat="server" ID="proDesc" Height="100" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td><span style="font-weight:bold;" >PRODUCT QUANTITY:</span></td>
                <td>
                    <asp:DropDownList ID="qty" runat="server">
                         <asp:ListItem>Please select quantity</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>50</asp:ListItem>
                        <asp:ListItem>200</asp:ListItem>
                        <asp:ListItem>400</asp:ListItem>
                        <asp:ListItem>5000</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
             <tr>
                <td><span style="font-weight:bold;">PRICE:</span></td>
                <td>
                    <asp:TextBox runat="server" ID="price" ></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td><span style="font-weight:bold;" >CATEGORY:</span></td>
                <td>
                    <asp:DropDownList runat="server" ID="Categ">
                        <asp:ListItem>Please select category</asp:ListItem>
                         <asp:ListItem>501</asp:ListItem>
                         <asp:ListItem>502</asp:ListItem>
                         <asp:ListItem>503</asp:ListItem>
                         <asp:ListItem>504</asp:ListItem>
                         <asp:ListItem>505</asp:ListItem>
                         <asp:ListItem>506</asp:ListItem>
                         <asp:ListItem>507</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
             <tr>
                <td><span style="font-weight:bold;" >IMAGE</span></td>
                <td>
                    <input type ="file" id ="flImage" name ="image" runat="server"/>
                </td>
            </tr>
             <tr>
                <td></td>
                <td>
                    <asp:Button runat="server" ID="save" CssClass="Aditem" Text="ADD ITEMS" OnClick="save_Click"  />
                </td>
            </tr>
        </table>

       
       
    </div>

</asp:Content>

