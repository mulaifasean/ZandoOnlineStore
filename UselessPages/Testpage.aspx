<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Testpage.aspx.cs" Inherits="UselessPages_Testpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #cart2{height:20px;
              width:20px;
              border-radius:10px;
              background-color:lightseagreen;
              color:white;
              text-align:center;           
        }
    </style>
    <script>
        var n=0;
        function inceaseNumber(){
            n=n+1;
            document.getElementById('number2').innerHTML=n;
            zeroNumber();
        }
        function zeroNumber() {
            if (document.getElementById('number2').innerHTML==0){
                document.getElementById('cart2').style.display="none";
            }
            else {
                document.getElementById('cart2').style.display="block";
            }
        }
    </script>
</head>
<body onload="zeroNumber()">
    <form id="form1" runat="server">
    <div>
    <p id="cart2"><span id="number2"></span></p>

        <asp:Button runat="server" Text="try"   OnClick="Unnamed1_Click" />
    </div>
    </form>
</body>
</html>


