using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class ProductDetails2 : System.Web.UI.Page
{
    string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

    string myId;
    string ProductName, ProductDescription, Prod_qty, Price, Category, prod_image;
    string s;
    string t;
    string[] a = new string[6];
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           

            myId = Request.QueryString["Id"].ToString();

            SqlConnection objCon = new SqlConnection(connStr);

            SqlCommand da = new SqlCommand("select * from Items  where  Items.ProductId=@Id ", objCon);
            da.Parameters.AddWithValue("Id", myId);
            objCon.Open();
            SqlDataReader reader = da.ExecuteReader();
            PDet.Visible = true;
            if (reader.Read())
            {
                name1.InnerText = reader["ProductName"].ToString();//name
                des1.InnerText = reader["ProductDescription"].ToString();//desc
                price1.InnerText ="R"+ reader["Price"].ToString();//price
                mg1.ImageUrl = reader["prod_image"].ToString();//image
                pd1.HRef = reader["prod_image"].ToString();
            }


            objCon.Close();

    
        
        
    }}

    protected void AddCart_Click(object sender, EventArgs e)
    {
       
        myId = Request.QueryString["Id"].ToString();
        SqlConnection objCon = new SqlConnection(connStr);
        /*
        SqlCommand da = new SqlCommand("select * from Items  where  Items.ProductId=@Id ", objCon);
        da.Parameters.AddWithValue("Id", myId);
        objCon.Open();
        SqlDataReader reader = da.ExecuteReader();
        PDet.Visible = true;
        if (reader.Read())
        {
            name1.InnerText = reader["ProductName"].ToString();//name
            des1.InnerText = reader["ProductDescription"].ToString();//desc
            price1.InnerText = "R" + reader["Price"].ToString();//price
            mg1.ImageUrl = reader["prod_image"].ToString();//image
            pd1.HRef = reader["prod_image"].ToString();
        }
        */
        objCon.Open();
        SqlCommand cmd = objCon.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from Items  where  Items.ProductId="+myId+" ";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);

        foreach(DataRow dr in dt.Rows)
        {
            ProductName = dr["ProductName"].ToString();
            ProductDescription = dr["ProductDescription"].ToString();
            Prod_qty = dr["Prod_qty"].ToString();
            Price = dr["Price"].ToString();
            Category = dr["Category"].ToString();
          prod_image = dr["prod_image"].ToString();
        }

        objCon.Close();

        if(Request.Cookies["aa"]==null)
        {
            Response.Cookies["aa"].Value = ProductName.ToString() + "," + ProductDescription.ToString() + "," + Price.ToString() + "," + prod_image.ToString();
            Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
        }
        else
        {
            Response.Cookies["aa"].Value =Request.Cookies["aa"].Value+" |"+ ProductName.ToString() + "," + ProductDescription.ToString() + "," + Price.ToString() + "," + prod_image.ToString();
            Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
        }
        Response.Redirect("Cart.aspx");
        /*
        string s = Convert.ToString(Request.Cookies["aa"].Value);
        string[] strArr = s.Split(',');
        for (int i = 0; i <strArr.Length; i++)
        {
            Response.Write(strArr[i].ToString());
            Response.Write("<br>");
        }
       */
    }

    protected void vwct_Click(object sender, EventArgs e)
    {
      
        string s = Convert.ToString(Request.Cookies["aa"].Value);
        string[] strArr = s.Split(',');
        for (int i = 0; i < strArr.Length; i++)
        {   
            Response.Write(strArr[i].ToString());
            Response.Write("<br>");
        }
     
        
        /*
          myId = Request.QueryString["Id"].ToString();
          SqlConnection objCon = new SqlConnection(connStr);
          objCon.Open();
          SqlCommand cmd = objCon.CreateCommand();
          cmd.CommandType = CommandType.Text;
          cmd.CommandText = "select * from Items  where  Items.ProductId=" + myId + " ";
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
          //until here wait 



        //  DataTable dt2 = new DataTable();
         // dt2.Columns.AddRange(new DataColumn[6] { new DataColumn("ProductName"), new DataColumn("ProductDescription"), new DataColumn("Prod_qty"), new DataColumn("Price"), new DataColumn("Category"), new DataColumn("prod_image") });

          if (Request.Cookies["aa"] != null)
          {
              s = Convert.ToString(Request.Cookies["aa"].Value);
              string[] strArr = s.Split('|');
              for (int i = 0; i<strArr.Length; i++)
              {
                  t = Convert.ToString(strArr[i]);
                  string[] strArr1 = t.Split(',');
                  for (int j = 0; j<strArr1.Length; j++)
                  {
                      a[j] = strArr1[j].ToString();
                  }
                dt.Rows.Add(a[0].ToString(), a[1].ToString(), a[2].ToString(), a[3].ToString(), a[4].ToString(), a[5].ToString());

              }
          }


          d1.DataSource = dt;
          d1.DataBind();
          d1.Visible = true;

      */

    }
}