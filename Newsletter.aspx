<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard.master" AutoEventWireup="true" CodeFile="Newsletter.aspx.cs" Inherits="Newsletter" %>

<asp:Content ID="Content1" ContentPlaceHolderID="DashboardPlaceHolder" Runat="Server">
    <style>
        #NewL{width:800px;
              margin-left:100px;
              text-align:center;
        }
        p{height:50px;}
        h3{height:70px;}
        h1{font-weight:bold;}
        .Button{background-color:#ff9900;color:white;border:none;
                width:80px;
                height:50px;
        }
        .Button:hover{color:#ff9900;
                      background-color:white;
                      border:2px solid #ff9900;
        }
    </style>
  
    <div id="NewL">
        <h1>MY ACCOUNT  <span style="color:#ff9900;">  Newsletter </span> </h1>
        <h3><span>___________________  </span>  MY SUBSCRIPTION   <span>  ___________________</span> </h3>

        <p>
            <asp:CheckBox  Text="Subscribe me to the daily newsletter." ID="NewslCheck" runat="server"/>
        </p>

        <p>
            <asp:Button  runat="server" ID="NewslUP" CssClass="Button" Text="SAVE" OnClick="NewslUP_Click"  />
        </p>

        <asp:Label runat="server" ID="Newslbl"></asp:Label>
    </div>
</asp:Content>

