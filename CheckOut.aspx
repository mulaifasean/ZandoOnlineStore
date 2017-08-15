<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster.master" AutoEventWireup="true" CodeFile="CheckOut.aspx.cs" Inherits="CheckOut" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildContentPlaceHolder" Runat="Server">
    <style>
    #checkout{width:1200px;
              margin-left:200px;
            
    }
    #LoR{width:400px;
         
    }
    #PayM{width:350px;
      
    }
    #CO{width:400px;
        
    }
    h1{font-size:15px;
       font-weight:bold;
    }
    h1 span{height:20px;
            width:20px;
            border-radius:14px;
            border:2px solid orange;
            text-align:center;
    }
    h1 span i{color:orange;}
    header{
        height:40px;
       background-color:lightgrey;
    }
   #div2 a{font-size:15px;color:black;margin-left:5px;}
    #div2 a:hover{color:black;}
    #Credit{border-bottom:2px solid lightgrey;
            border-right:2px solid lightgrey;
            border-left:2px solid lightgrey;
            height:300px;
            
    }

    
    #EFT{height:200px;}
   #EFT a{font-size:15px;color:black;margin-left:5px;}
    #EFT a:hover{color:black;}
    #EFT11{border-bottom:2px solid lightgrey;
            border-right:2px solid lightgrey;
            border-left:2px solid lightgrey;
            height:300px;
            
    }

     #COD{}
   #COD a{font-size:15px;color:black;margin-left:5px;}
    #COD a:hover{color:black;}
    #COD11{border-bottom:2px solid lightgrey;
            border-right:2px solid lightgrey;
            border-left:2px solid lightgrey;
            
            
    }
    .txt{width:200px;margin-left:30px;}
    label{font-weight:normal;}
    .containa{margin-top:20px;}
    </style>
    <script>
        
   $(document).ready(function () {
            $("#div21").click(function () {
                $("#Credit").toggle();
            });
        });
      //For the 2nd row
      
        $(document).ready(function () {
            $("#EFT1").click(function () {
                $("#EFT11").toggle();
            });
        });

        $(document).ready(function () {
            $("#COD1").click(function () {
                $("#COD11").toggle();
            });
        });
    </script>
    <table id="checkout">
        <tr>
            <td id="LoR">qa</td>


            <td id="PayM">
                <h1><span> <i>2</i></span>Choose a payment method</h1>

                <table id="Innertbl">
                    <tr>
                        <td>
                            <div class="containa">
             <div id="div2"><header><a id="div21">Credit/Cheque Card</a></header> 
                    <div id="Credit">
                        <br />
                     <label style="margin-left:30px;">Card Number</label><img src="CheckOut%20Pics/visa-new.png" height="30" width="40" />
                        <img src="CheckOut%20Pics/mastercard.png" height="20" width="30" />
                        <img src="CheckOut%20Pics/amex-new.png" height="20" width="30" />
                        <br />
                        <asp:TextBox runat="server" CssClass="txt"></asp:TextBox><br />
                       <label style="margin-left:30px;">Card Holder Name</label><br />
                        <asp:TextBox runat="server" CssClass="txt"></asp:TextBox><br />
                        <label style="margin-left:30px;">Expiry Month</label><br />
                        <asp:DropDownList runat="server" CssClass="txt">
                             <asp:ListItem>01-January</asp:ListItem>
                             <asp:ListItem>02-February</asp:ListItem>
                             <asp:ListItem>03-March</asp:ListItem>
                             <asp:ListItem>04-April</asp:ListItem>
                             <asp:ListItem>05-May</asp:ListItem>
                             <asp:ListItem>06-June</asp:ListItem>
                             <asp:ListItem>07-July</asp:ListItem>
                             <asp:ListItem>08-August</asp:ListItem>
                             <asp:ListItem>09-September</asp:ListItem>
                             <asp:ListItem>10-October</asp:ListItem>
                             <asp:ListItem>11-November</asp:ListItem>
                             <asp:ListItem>12-December</asp:ListItem>
                        </asp:DropDownList><br />
                        <label style="margin-left:30px;">Expiry Year</label><br />
                        <asp:DropDownList runat="server" CssClass="txt">
                             <asp:ListItem>2017</asp:ListItem>
                             <asp:ListItem>2018</asp:ListItem>
                             <asp:ListItem>2019</asp:ListItem>
                             <asp:ListItem>2020</asp:ListItem>
                             <asp:ListItem>2021</asp:ListItem>
                             <asp:ListItem>2022</asp:ListItem>
                             <asp:ListItem>2023</asp:ListItem>
                             <asp:ListItem>2024</asp:ListItem>
                             <asp:ListItem>2025</asp:ListItem>
                             <asp:ListItem>2026</asp:ListItem>
                             <asp:ListItem>2027</asp:ListItem>
                             <asp:ListItem>2028</asp:ListItem>
                            <asp:ListItem>2029</asp:ListItem>
                            <asp:ListItem>2030</asp:ListItem>
                            <asp:ListItem>2031</asp:ListItem>
                            <asp:ListItem>2032</asp:ListItem>
                        </asp:DropDownList><br />
                        <label style="margin-left:30px;">Verification Code</label><br />
                        <asp:TextBox CssClass="txt" runat="server" Width="100"></asp:TextBox><br />
                        <asp:CheckBox CssClass="txt" ID="chckCred"  runat="server" Text="Save my card information"/>
                    </div>
                    </div>
                                </div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class="containa">
                            <div id="EFT">
                                <header><a id="EFT1">EFT Bank Deposit</a></header>                      
                        <div id="EFT11">
                            <label style="margin-left:30px;" >Please choose your bank from the list below</label><br />
                    <br />
                            <asp:DropDownList runat="server" CssClass="txt">
                                <asp:ListItem>-</asp:ListItem>
                                <asp:ListItem  Text="Available Banks"></asp:ListItem>
                                <asp:ListItem>ABSA</asp:ListItem>
                                <asp:ListItem>First National Bank</asp:ListItem>
                                <asp:ListItem>Nedbank</asp:ListItem>
                                <asp:ListItem>Standard Bank</asp:ListItem>
                                <asp:ListItem >Other Banks</asp:ListItem>
                                <asp:ListItem>Other</asp:ListItem>
                            </asp:DropDownList><br />
                            <p style="margin-left:30px;">
                                <strong>Please note:</strong> Orders are processed once the correct funds reflect in our 
                                bank account. All bank deposits will require proof of payment, which can be emailed to 
                               service@zando.co.za
                            </p>

                        </div>
                    </div>
                                </div>
                        </td>
                    </tr>

                    <tr>
                        <td>
                    
                            <div style="margin-top:20px;" >
                             <div id="COD">
                                 <header> <a id="COD1">Cash On Delivery</a></header>                      
                        <div id="COD11">
                            <p>Pay cash at the door when receiving your order.

                               You will be charged an additional R10 cash handling fee.

                               Important:</p>
                        </div>
                    </div>
                                </div>
                        </td>
                    </tr>
                </table>

             
                    
                   


                   


                    

                   

                    
               
            </td>
            <td id="CO">da</td>
        </tr>
    </table>

</asp:Content>

