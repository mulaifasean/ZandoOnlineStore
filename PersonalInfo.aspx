<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard.master" AutoEventWireup="true" CodeFile="PersonalInfo.aspx.cs" Inherits="PersonalInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="DashboardPlaceHolder" Runat="Server">
    <style>
        #PInfo{width:800px;
               margin-left:150px;
        }
        table tr{height:50px;}
        h1{font-size:25px;
           font-weight:bolder;
           text-align:center;
        }
    </style>
    <div id="PInfo">
        <h1>MY ACCOUNT <span style="color:#ff6600;">Personal Information</span> </h1>
        <table>
            <tr>
                <td>____________________</td>
                <td>ACCOUNT INFORMATION</td>
                <td>____________________</td>
            </tr>
            <tr>
                <td style="text-align-last:right;">First name</td>
                <td><asp:TextBox runat="server" ID="fnameUP"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align-last:right;">Last name </td>
                <td><asp:TextBox runat="server" ID="lnameUP"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align-last:right;">Gender </td>
                <td><asp:DropDownList runat="server" ID="genderUP" >
                    <asp:ListItem>Please select your gender</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            
            <tr>
                <td style="text-align-last:right;">Email </td>
                <td><asp:TextBox runat="server" ID="emailUP" Enabled="false" ></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align-last:right;">Birthday </td>
                <td>
                    <asp:TextBox runat="server" ID="deiUP" Width="50"></asp:TextBox>
                    <asp:TextBox runat="server" ID="montUP" Width="50"></asp:TextBox>
                    <asp:TextBox runat="server" ID="yeaUP" Width="50"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>____________________</td>
                <td>CONTACT INFORMATION</td>
                <td>____________________</td>
            </tr>
            <tr>
                <td style="text-align-last:right;">Cell Number </td>
                <td><asp:TextBox runat="server"  ID="CellNoUP"></asp:TextBox></td>
            </tr>
            
            <tr>
                <td></td>
                <td><asp:Button runat="server" BackColor="#ff6600" ForeColor="White" Font-Size="Large" BorderStyle="None"  Text="Save" ID="SaveID" OnClick="SaveID_Click" /></td>
            </tr>
        </table>
    </div>
</asp:Content>

