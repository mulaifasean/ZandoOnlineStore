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


    string myId;
    string ProductName, ProductDescription, Prod_qty, Price, Category, prod_image;
    string s;
    string t;
    string[] a = new string[4];

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
                name1.InnerText = reader["Prod_qty"].ToString();//name
                des1.InnerText = reader["ProductDescription"].ToString();//desc
                price1.InnerText ="R"+ reader["Price"].ToString();//price
                mg1.ImageUrl = reader["prod_image"].ToString();//image
                pd1.HRef = reader["prod_image"].ToString();
            }


            objCon.Close();
         
            
        }
    }

    protected void AddCart_Click(object sender, EventArgs e)
    {
        myId = Request.QueryString["Id"].ToString();
        SqlConnection objCon = new SqlConnection(connStr);

        objCon.Open();
        SqlCommand cmd = objCon.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from Items2  where  Items2.ProductId=" + myId + " ";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);

        foreach (DataRow dr in dt.Rows)
        {
            ProductName = dr["ProductName"].ToString();
            ProductDescription = dr["ProductDescription"].ToString();
            Prod_qty = dr["Prod_qty"].ToString();
            Price = dr["Price"].ToString();
            Category = dr["Category"].ToString();
            prod_image = dr["prod_image"].ToString();
        }

        objCon.Close();

        if (Request.Cookies["aa"] == null)
        {
            Response.Cookies["aa"].Value = Prod_qty.ToString() + "," + ProductDescription.ToString() + "," + Price.ToString() + "," + prod_image.ToString();
            Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);


            //ScriptManager.RegisterClientScriptBlock(this,GetType(), "mykey", "IncreaseNumber()", true);
        }
        else
        {
            Response.Cookies["aa"].Value = Request.Cookies["aa"].Value + " |" + Prod_qty.ToString() + "," + ProductDescription.ToString() + "," + Price.ToString() + "," + prod_image.ToString();
            Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
        }


        Response.Redirect("Cart.aspx");

    }
}