<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="DashboardPlaceHolder" Runat="Server">
    <style>
      #CPid{width:800px;    
      }
      #CPid table tr {height:50px;}
      #CPid table{margin-left:100px;}
    </style>
    <div id="CPid">
        <h1 style="font-weight:bold;text-align:center;">MY ACCOUNT  <span style="color:#FF6600;">  Password</span> </h1>
        <table>
            <tr style="height:100px;">
                <td>________________</td>
                <td style="font-weight:bold;">MY CURRENT PASSWORD</td>
                <td>________________</td>

            </tr>
            
            <tr>
                <td style="text-align-last:right;">Current Password</td>
                <td style="text-align:center;">
                    <asp:TextBox runat="server"   ID="Curpass"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align-last:right;">New Password </td>
                <td  style="text-align:center;"> <asp:TextBox runat="server" placeholder="New Password" TextMode="Password" ID="Newpass"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align-last:right;">Confirm New Password</td>
                <td  style="text-align:center;"><asp:TextBox runat="server" placeholder="Confirm New Password" TextMode="Password" ID="CfNewpass"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td style="text-align:center;">
                    <asp:Button runat="server" Text="SAVE" ID="ChangePwrd" Width="70" Height="40" BorderStyle="None" ForeColor="White" BackColor="#FF6600" OnClick="ChangePwrd_Click" />
                </td>
            </tr>
           <tr>
               <td>
                   <asp:Label runat="server" ID="passlbl" Visible="false"></asp:Label>
                  
               </td>
           </tr>
        </table>
    </div>
</asp:Content>

