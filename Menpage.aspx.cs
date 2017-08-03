using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Menpage : System.Web.UI.Page
{

    string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {

      SqlConnection objCon = new SqlConnection(connStr);

        SqlDataAdapter da = new SqlDataAdapter("select * from Items ", objCon);
        DataTable dt = new DataTable();
        da.Fill(dt);
        name1.InnerText = dt.Rows[7]["ProductName"].ToString();//name
        des1.InnerText= dt.Rows[7]["ProductDescription"].ToString();//desc
        price1.InnerText = dt.Rows[7]["Price"].ToString();//price
        mg1.ImageUrl = dt.Rows[7]["prod_image"].ToString();//image

        name2.InnerText = dt.Rows[4]["ProductName"].ToString();//name
        des2.InnerText = dt.Rows[4]["ProductDescription"].ToString();//desc
        price2.InnerText = dt.Rows[4]["Price"].ToString();//price
        mg2.ImageUrl = dt.Rows[4]["prod_image"].ToString();//image

        name3.InnerText = dt.Rows[5]["ProductName"].ToString();//name
        des3.InnerText = dt.Rows[5]["ProductDescription"].ToString();//desc
        price3.InnerText = dt.Rows[5]["Price"].ToString();//price
        mg3.ImageUrl = dt.Rows[5]["prod_image"].ToString();//image

        name4.InnerText = dt.Rows[8]["ProductName"].ToString();//name
        des4.InnerText = dt.Rows[8]["ProductDescription"].ToString();//desc
        price4.InnerText = dt.Rows[8]["Price"].ToString();//price
        mg4.ImageUrl = dt.Rows[8]["prod_image"].ToString();//image

            

        }
        

    }
}