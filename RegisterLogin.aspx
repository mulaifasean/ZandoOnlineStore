<%@ Page Title="" Language="C#" MasterPageFile="~/ChildMaster.master" AutoEventWireup="true" CodeFile="RegisterLogin.aspx.cs" Inherits="RegisterLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildContentPlaceHolder" Runat="Server">
    <style dir="ltr">
        *{margin:0px;
          padding:0px;
        }
        #Big{width:100%;
             height:900px;
        }
       .Left{width:50%;float:left;height:100%;}
       .Right{width:50%;float:right;height:100%}
       .Left table{margin:0 auto;margin-top:100px;}
        .Right table{margin:0 auto;margin-top:100px;}
        .Left table tr td{padding:15px;}
         .Right table tr td{padding:10px;}
         .Left table tr th{font-size:24px;border-bottom:2px solid;border-bottom-color:black;width:50%;}
         .Right table tr th{font-size:24px;border-bottom:2px solid;border-bottom-color:black;}
        #Signlog{background-color:black;color:white;border:none;width:100px;height:40px;font-weight:bolder;}
        #Signlog:hover{background-color:white;color:black;
                       border:2px solid black;
        }
        #fblog{background-color:#CCC;color:white;border:none;font-weight:bolder;}
        #fblog:hover{background-color:#0094ff;color:white;}
        #Reg{background-color:black;color:white;border:none;width:170px;height:40px;font-weight:bolder;}
        #Reg:hover{background-color:white;color:black;
                       border:2px solid black;}
        .auto-style1 {
            height: 72px;
        }
        #label1{background-color:green;color:white;
                width:100%;
                font-size:20px;
        }
        #fblog{background-color:grey;
               color:white;
        }
        #fblog:hover{background-color:blue;
                     color:white;
        }
        .signlog{background-color:black;color:white;border:none;width:100px;height:70px;
                 font-weight:bold;
        }
        .signlog:hover{background-color:white;color:black;border:2px solid black;}
         .reg{background-color:black;color:white;border:none;width:100px;height:70px;
                 font-weight:bold;
        }
        .reg:hover{background-color:white;color:black;border:2px solid black;}
    </style>
   

    <div id="Big">
        <asp:Label runat="server" ID="labellog" BorderWidth="2" BackColor="Red" ForeColor="Black" Font-Bold="true"   Visible="false"></asp:Label>
 <asp:Label runat="server" ID="labelreg" BorderWidth="2" BackColor="Green" ForeColor="White" Font-Bold="true"   Visible="false"></asp:Label>

        <div class="Left">
           
           <table>
               <tr>
                   <th>LOGIN</th>
               </tr>
       <tr><td>Email Address
           </td>
           <td>
               <asp:TextBox runat="server" TextMode="Email" ID="emailog"  placeholder="Email"></asp:TextBox>
           </td>
       </tr>
       <tr><td>Password
           </td>
           <td>
               <asp:TextBox runat="server" TextMode="Password"  ID="paslog"  placeholder="password"></asp:TextBox>
           </td>
       </tr>
     <tr>
         <td></td>
         <td><asp:CheckBox runat="server"  ID="CheckMe" Text="Remember Me"  /></td>
     </tr>
               <tr>
                   <td></td>
                   <td><a href="#">Forgot your Password?</a></td>
               </tr>
       <tr><td class="auto-style1"></td>
           <td class="auto-style1">
               <asp:Button runat="server" ID="Signlog" Cssclass="signlog"   Text="SIGN IN" OnClick="Signlog_Click"  />
           </td>
       </tr>
               <tr>
                   <td></td>
            <td>
                <input type="button"  id="fblog" value="f LOGIN WITH FACEBOOK" onclick="window.location='https://www.facebook.com/login/'" />
            </td>      
               </tr>
   </table> 
            
           
        </div>
        <div class=" Right">
            <table style="background-color:#CCC;">
               
                <tr>
                   
                    <th>CREATE NEW CUSTOMER ACCOUNT</th>
                   
                </tr>
                <tr>
                    <td>Gender</td>
                    <td><asp:DropDownList runat="server" ID="gender">
                        <asp:ListItem>Please select your gender</asp:ListItem>
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>

                    </td>
                </tr>
                <tr>
                    <td>E-mail</td>
                    <td><asp:TextBox runat="server" name="email" ID="emailreg" ></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>Firstname</td>
                    <td><asp:TextBox runat="server" ID="fname" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Lastname</td>
                    <td><asp:TextBox runat="server" ID="lname"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>Birthday</td>
                    <td><asp:TextBox runat="server" placeholder="dd" Width="50" Height="30" ID="dei" ></asp:TextBox>
                        <asp:TextBox runat="server" placeholder="mm" Width="50" Height="30" ID="mont"></asp:TextBox>
                        <asp:TextBox runat="server" placeholder="yyyy" Width="50" Height="30" ID="yea"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>I want to receive promotional emails from:</td>
                    
                </tr>
                <tr>
                    <td></td>
                    <td><asp:CheckBox runat="server" Text="Zando" ID="zandoProm" /></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:CheckBox runat="server" Text="Zando Blog"  ID="zandoBlog"/></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:CheckBox runat="server" Text="Zando deals" ID="zandoDeals" /></td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td><asp:TextBox runat="server" TextMode="Password" ID="pass2"></asp:TextBox>
                     
                    </td>
                </tr>
                <tr>
                    <td>Confirm Password</td>
                    <td><asp:TextBox runat="server" TextMode="Password" ID="pass2Con"></asp:TextBox>
                       
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button runat="server" ID="Reg" Text="Register" OnClick="Reg_Click"  Cssclass="reg" /></td>
                </tr>
            </table>
           
        </div>
    </div>
   
</asp:Content>
