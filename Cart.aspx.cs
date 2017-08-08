using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Cart : System.Web.UI.Page
{
    string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    string s;
    string t;
    string[] a = new string[6];
    string ProductName, ProductDescription, Prod_qty, Price, Category, prod_image;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        TEST.Text = "These are your items";
        TEST.Visible = true;
        
       
    }

    protected void view_Click(object sender, EventArgs e)
    {
        
        /*
          DataTable dt2= new DataTable();
          dt2.Columns.AddRange(new DataColumn[6] { new DataColumn("ProductName"), new DataColumn("ProductDescription"), new DataColumn("Prod_qty"), new DataColumn("Price"), new DataColumn("Category"), new DataColumn("prod_image") });

          if(Request.Cookies!=null)
          {
              s = Convert.ToString(Request.Cookies["aa"].Value);
              string[] strArr = s.Split('|');
              for (int i = 0; i <strArr.Length; i++)
              {
                  t = Convert.ToString(strArr[i]);
                  string[] strArr1 = t.Split(',');
                  for (int j = 0; j <strArr1.Length; j++)
                  {
                      a[j] = strArr1[j].ToString();
                  }
              }
          }

          dt2.Rows.Add(a[0].ToString(), a[1].ToString(), a[2].ToString(), a[3].ToString(), a[4].ToString(), a[5].ToString());
          d1.DataSource = dt2;
          d1.DataBind();*/
 string s = Convert.ToString(Request.Cookies["aa"].Value);
        string[] strArr = s.Split(',');
        for (int i = 0; i < strArr.Length; i++)
        {
    viewcart.InnerHtml = strArr[0].ToString()+"  "+strArr[1].ToString() + "  " + strArr[2].ToString() + "  " + strArr[3].ToString() + " <br> " + strArr[4].ToString() + "  " + strArr[5].ToString() ;
           
            
            //Response.Write(strArr[i].ToString());

            // Response.Write("<br>");
        }

    }
    

}