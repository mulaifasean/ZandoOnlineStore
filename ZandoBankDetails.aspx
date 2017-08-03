<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard.master" AutoEventWireup="true" CodeFile="ZandoBankDetails.aspx.cs" Inherits="ZandoBankDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="DashboardPlaceHolder" Runat="Server">

    <style>
       #ZBD{text-align:center;
            margin-left:20px;
       }
       #p1{height:60px;
           background-color:pink;
           color:palevioletred;
           border:1px solid palevioletred;
       }
       #p1 span{font-weight:bold;}
      .Zbd1{background-color:#CCC;color:black;height:80px;width:500px;}
      table tr td{margin-bottom:30px;}
    </style>

    <div id="ZBD">
        <h1>PAYMENT<span style="color:#ff6a00;">Bank Details</span></h1>

        <p>Please make sure to only use your order number as your reference. </p>

        <p id="p1"><span>Please Note:</span>  The bank details below are only to be used for orders where EFT is the selected payment method.
            Please contact our Customer Loyalty Team for assistance with our other payment options.</p>
       
        <table style="text-align:start;margin-left:100px;">
            <tr style="height:80px;">
                <td style="width:60px">____________________</td>
                <th style="width:40px;">NEDBANK</th>
                <td style="width:100px;">____________________</td>
            </tr>
             <tr class="Zbd1">
                <td>
                    <p style="font-weight:bold;">BANK:</p>
                    <p style="font-weight:bold;">BRANCH CODE:</p>
                    <p style="font-weight:bold;">ACCOUNT HOLDER:</p>
                    <p style="font-weight:bold;">ACCOUNT NUMBER:</p>
                    <p style="font-weight:bold;">PAYMENT REFERENCE:</p>
                </td>
                <td colspan="2">
                    <p>NEDBANK</p>
                    <p>198765</p>
                    <p>JADE E-SERVICES SOUTH AFRICA PTY LTD</p>
                    <p>1047836629</p>
                    <p>{YOUR 200XXXXXX ORDER NUMBER}</p>
                </td>
                
            </tr>
             <tr style="height:80px;">
                <td style="width:60px">____________________</td>
                <th>FIRST NATIONAL BANK</th>
                <td style="width:100px;">____________________</td>
            </tr>
             <tr class="Zbd1">
                <td>
                     <p style="font-weight:bold;">BANK:</p>
                    <p style="font-weight:bold;">BRANCH CODE:</p>
                    <p style="font-weight:bold;">ACCOUNT HOLDER:</p>
                    <p style="font-weight:bold;">ACCOUNT NUMBER:</p>
                    <p style="font-weight:bold;">PAYMENT REFERENCE:</p>
                </td>
                <td colspan="2">
                    <p>FIRST NATIONAL BANK</p>
                    <p>250655</p>
                    <p>JADE E SERVICES SA</p>
                    <p>62502702906</p>
                    <p>{YOUR 200XXXXXX ORDER NUMBER}</p>
                </td>
                
            </tr>
             <tr style="height:80px;">
                <td style="width:60px">____________________</td>
                <th>ABSA</th>
                <td style="width:100px;">____________________</td>
            </tr>
             <tr class="Zbd1">
                <td>
                    <p style="font-weight:bold;">BANK:</p>
                    <p style="font-weight:bold;">BRANCH CODE:</p>
                    <p style="font-weight:bold;">ACCOUNT HOLDER:</p>
                    <p style="font-weight:bold;">ACCOUNT NUMBER:</p>
                    <p style="font-weight:bold;">PAYMENT REFERENCE:</p>
                </td>
                <td colspan="2">
                    <p>ABSA</p>
                    <p>632005</p>
                    <p>JADE E-SERVICES SA PTY LTD</p>
                    <p>4084683606</p>
                    <p>{YOUR 200XXXXXX ORDER NUMBER}</p>
                </td>
              
            </tr>
             <tr style="height:80px;">
                <td style="width:60px">____________________</td>
                <th>STANDARD BANK</th>
                <td style="width:100px;">____________________</td>
            </tr>
             <tr class="Zbd1">
                <td>
                    <p style="font-weight:bold;">BANK:</p>
                    <p style="font-weight:bold;">BRANCH CODE:</p>
                    <p style="font-weight:bold;">ACCOUNT HOLDER:</p>
                    <p style="font-weight:bold;">ACCOUNT NUMBER:</p>
                    <p style="font-weight:bold;">PAYMENT REFERENCE:</p>
                </td>
                <td colspan="2">
                    <p>STANDARD BANK</p>
                    <p>051001</p>
                    <p>JADE E-SERVICES SA PTY LTD</p>
                    <p>	070256969</p>
                    <p>{YOUR 200XXXXXX ORDER NUMBER}</p>
                </td>
                
            </tr>
            <tr style="height:100px;"><td>

                </td>

            </tr>
        </table>

    </div>

</asp:Content>

