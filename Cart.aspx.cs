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
   
    int totale = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        
       if(!IsPostBack)
        {

           
            delv.Text = "<strong>Standard Delivery</strong>" +"  " +"<strong>FREE</strong>";
           
            delv.Visible = true;
            
            

            //DISPLAY ITEMS  IN THE CART

            DataTable dt2 = new DataTable();
        dt2.Columns.AddRange(new DataColumn[5] { new DataColumn("Prod_qty"), new DataColumn("ProductDescription"), new DataColumn("Price"), new DataColumn("prod_image"), new DataColumn("ProductId") });

        if (Request.Cookies["aa"] != null)
        {
            s = Convert.ToString(Request.Cookies["aa"].Value);

            string[] strArr = s.Split('|');

            for (int i = 0; i < strArr.Length; i++)
            {
                t = Convert.ToString(strArr[i].ToString());

                string[] strArr1 = t.Split(',');
                for (int j = 0; j < strArr1.Length; j++)
                {
                    a[j] = strArr1[j].ToString();
                }
                dt2.Rows.Add(a[0].ToString(), a[1].ToString(), a[2].ToString(), a[3].ToString(),i.ToString());
                    //int qty = 1;
                 totale = totale + (Convert.ToInt32(a[0].ToString()) * Convert.ToInt32(a[2].ToString()) );
                    subtot.Text ="<strong>Subtotal</strong>"+"  "+"R"+ totale.ToString();
                    tot.Text = "<strong>TOTAL</strong>" +"   "+"R"+totale.ToString();
                  subtot.Visible = true;
                    tot.Visible = true;


                  
            }
        }

        d1.DataSource = dt2;
        d1.DataBind();
        d1.Visible = true;




        }
       
    }



    /*
    protected void qty_SelectedIndexChanged(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Request.QueryString["Id"].ToString());
        SqlConnection objCon = new SqlConnection(connStr);

        SqlCommand cmd = objCon.CreateCommand();
        cmd.CommandType = CommandType.Text;
         cmd.CommandText=   ("update Items set Prod_qty= @Prod_qty-"+ qty.Text);
        objCon.Open();
        cmd.ExecuteNonQuery();
        objCon.Close();
        Response.Redirect("Cart.aspx?Id"+id);
    }
    */

    protected void d1_SelectedIndexChanged(object sender, EventArgs e)
    {

        
    }



    protected void qty_SelectedIndexChanged(object sender, EventArgs e)
    {

        int id = Convert.ToInt32(Request.QueryString["Id"].ToString());
        SqlConnection objCon = new SqlConnection(connStr);

        SqlCommand cmd = objCon.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = ("update Items set Prod_qty= @Prod_qty-");
        objCon.Open();
        cmd.ExecuteNonQuery();
        objCon.Close();
        Response.Redirect("Cart.aspx?Id" + id);

    }

  
}