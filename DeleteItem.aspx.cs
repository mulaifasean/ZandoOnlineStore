using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class DeleteItem : System.Web.UI.Page
{
    int count = 0;
    string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    string s;
    string t;
    string[] a = new string[5];
    int id;
    string ProductName, ProductDescription, Prod_qty, Price, Category, prod_image;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            id = Convert.ToInt32(Request.QueryString["Id"].ToString());

            DataTable dt2 = new DataTable();
            dt2.Rows.Clear();
            dt2.Columns.AddRange(new DataColumn[5] { new DataColumn("ProductName"), new DataColumn("ProductDescription"), new DataColumn("Price"), new DataColumn("prod_image"), new DataColumn("ProductId") });

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
                    dt2.Rows.Add(a[0].ToString(), a[1].ToString(), a[2].ToString(), a[3].ToString(), i.ToString());

                }
            }
            dt2.Rows.RemoveAt(id);
            Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);
            foreach (DataRow dr in dt2.Rows)
            {
                ProductName = dr["ProductName"].ToString();
                ProductDescription = dr["ProductDescription"].ToString();
                Price = dr["Price"].ToString();
                prod_image = dr["prod_image"].ToString();

                count = count + 1;

                if (count == 1)
                {
                    Response.Cookies["aa"].Value = ProductName.ToString() + "," + ProductDescription.ToString() + "," + Price.ToString() + "," + prod_image.ToString();
                    Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
                }
                else
                {
                    Response.Cookies["aa"].Value = Request.Cookies["aa"].Value + " |" + ProductName.ToString() + "," + ProductDescription.ToString() + "," + Price.ToString() + "," + prod_image.ToString();
                    Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
                }

            }


            Response.Redirect("Cart.aspx");

        }
        
    }
}