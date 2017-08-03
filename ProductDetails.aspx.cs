using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class ProductDetails : System.Web.UI.Page
{
    string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {

            string myId = Request.QueryString["Id"].ToString();

            SqlConnection objCon = new SqlConnection(connStr);

            SqlCommand da = new SqlCommand("select * from Items2  where  Items2.ProductId=@Id ", objCon);
            da.Parameters.AddWithValue("Id", myId);
            objCon.Open();
            SqlDataReader reader = da.ExecuteReader();
            PDet.Visible = true;
            if (reader.Read())
            {
                name1.InnerText = reader["ProductName"].ToString();//name
                des1.InnerText = reader["ProductDescription"].ToString();//desc
                price1.InnerText = reader["Price"].ToString();//price
                mg1.ImageUrl = reader["prod_image"].ToString();//image
                pd1.HRef = reader["prod_image"].ToString();
            }


            objCon.Close();
         
            
        }
    }
}