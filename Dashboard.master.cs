using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dashboard : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string t = LatestO.InnerHtml;
        string b = OrderH.InnerHtml;
        string c = Returns.InnerHtml;
       // PageID.InnerHtml = t;
        
        if(OrderH.HRef.Contains("OrderHistory.aspx"))
        {
            PageID.InnerHtml = b;
        }
        else if(Returns.Name=="Returns.aspx")
        {
            PageID.InnerHtml = c;
        }
        //LogSta.Text = "<p  style='background-color:green;width:100%;height:30px;font-size:14px;'>" + "You have successfully Logged In</p>"+
         //   "<button type='button' class='close' data-dismiss='p'>&times;</button>";
       // LogSta.Visible = true;
        Label1.Text = "Logged in as :" + "   " + Session["email"];
        Label1.Visible = true;
    }

    protected void LogOutbtn_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Response.Redirect("RegisterLogin.aspx");
       
    }
}
