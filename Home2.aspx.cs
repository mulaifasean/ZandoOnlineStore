using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Home2 : System.Web.UI.Page
{
    string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            SqlConnection objCon = new SqlConnection(connStr);

            SqlDataAdapter da = new SqlDataAdapter("select * from Items2 ", objCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            name1.InnerText = dt.Rows[48]["ProductName"].ToString();//name
            des1.InnerText = dt.Rows[48]["ProductDescription"].ToString();//desc
            price1.InnerText = dt.Rows[48]["Price"].ToString();//price
            mg1.ImageUrl = dt.Rows[48]["prod_image"].ToString();//image
            A1.HRef = "ProductDetails.aspx?Id=" + dt.Rows[48]["ProductId"].ToString();

            name2.InnerText = dt.Rows[49]["ProductName"].ToString();//name
            des2.InnerText = dt.Rows[49]["ProductDescription"].ToString();//desc
            price2.InnerText = dt.Rows[49]["Price"].ToString();//price
            mg2.ImageUrl = dt.Rows[49]["prod_image"].ToString();//image
            A2.HRef = "ProductDetails.aspx?Id=" + dt.Rows[49]["ProductId"].ToString();


            name3.InnerText = dt.Rows[50]["ProductName"].ToString();//name
            des3.InnerText = dt.Rows[50]["ProductDescription"].ToString();//desc
            price3.InnerText = dt.Rows[50]["Price"].ToString();//price
            mg3.ImageUrl = dt.Rows[50]["prod_image"].ToString();//image
            A3.HRef = "ProductDetails.aspx?Id=" + dt.Rows[50]["ProductId"].ToString();

            name4.InnerText = dt.Rows[51]["ProductName"].ToString();//name
            des4.InnerText = dt.Rows[51]["ProductDescription"].ToString();//desc
            price4.InnerText = dt.Rows[51]["Price"].ToString();//price
            mg4.ImageUrl = dt.Rows[51]["prod_image"].ToString();//image
            A4.HRef = "ProductDetails.aspx?Id=" + dt.Rows[51]["ProductId"].ToString();

            //Display for the second Row

            name5.InnerText = dt.Rows[52]["ProductName"].ToString();//name
            des5.InnerText = dt.Rows[52]["ProductDescription"].ToString();//desc
            price5.InnerText = dt.Rows[52]["Price"].ToString();//price
            Image5.ImageUrl = dt.Rows[52]["prod_image"].ToString();//image
            A5.HRef = "ProductDetails.aspx?Id=" + dt.Rows[52]["ProductId"].ToString();

            name6.InnerText = dt.Rows[53]["ProductName"].ToString();//name
            des6.InnerText = dt.Rows[53]["ProductDescription"].ToString();//desc
            price6.InnerText = dt.Rows[53]["Price"].ToString();//price
            Image6.ImageUrl = dt.Rows[53]["prod_image"].ToString();//image
            A6.HRef = "ProductDetails.aspx?Id=" + dt.Rows[53]["ProductId"].ToString();

            name7.InnerText = dt.Rows[54]["ProductName"].ToString();//name
            des7.InnerText = dt.Rows[54]["ProductDescription"].ToString();//desc
            price7.InnerText = dt.Rows[54]["Price"].ToString();//price
            Image7.ImageUrl = dt.Rows[54]["prod_image"].ToString();//image
            A7.HRef = "ProductDetails.aspx?Id=" + dt.Rows[54]["ProductId"].ToString();

            name8.InnerText = dt.Rows[55]["ProductName"].ToString();//name
            des8.InnerText = dt.Rows[55]["ProductDescription"].ToString();//desc
            price8.InnerText = dt.Rows[55]["Price"].ToString();//price
            Image8.ImageUrl = dt.Rows[55]["prod_image"].ToString();//image
            A8.HRef = "ProductDetails.aspx?Id=" + dt.Rows[55]["ProductId"].ToString();

            //For the 3rd Row
            name9.InnerText = dt.Rows[56]["ProductName"].ToString();//name
            des9.InnerText = dt.Rows[56]["ProductDescription"].ToString();//desc
            price9.InnerText = dt.Rows[56]["Price"].ToString();//price
            Image9.ImageUrl = dt.Rows[56]["prod_image"].ToString();//image
            A9.HRef = "ProductDetails.aspx?Id=" + dt.Rows[56]["ProductId"].ToString();

            name10.InnerText = dt.Rows[57]["ProductName"].ToString();//name
            des10.InnerText = dt.Rows[57]["ProductDescription"].ToString();//desc
            price10.InnerText = dt.Rows[57]["Price"].ToString();//price
            Image10.ImageUrl = dt.Rows[57]["prod_image"].ToString();//image
            A10.HRef = "ProductDetails.aspx?Id=" + dt.Rows[57]["ProductId"].ToString();

            name11.InnerText = dt.Rows[58]["ProductName"].ToString();//name
            des11.InnerText = dt.Rows[58]["ProductDescription"].ToString();//desc
            price11.InnerText = dt.Rows[58]["Price"].ToString();//price
            Image11.ImageUrl = dt.Rows[58]["prod_image"].ToString();//image
            A11.HRef = "ProductDetails.aspx?Id=" + dt.Rows[58]["ProductId"].ToString();

            name12.InnerText = dt.Rows[59]["ProductName"].ToString();//name
            des12.InnerText = dt.Rows[59]["ProductDescription"].ToString();//desc
            price12.InnerText = dt.Rows[59]["Price"].ToString();//price
            Image12.ImageUrl = dt.Rows[59]["prod_image"].ToString();//image
            A12.HRef = "ProductDetails.aspx?Id=" + dt.Rows[59]["ProductId"].ToString();

            //For the 4th Row
            name13.InnerText = dt.Rows[60]["ProductName"].ToString();//name
            des13.InnerText = dt.Rows[60]["ProductDescription"].ToString();//desc
            price13.InnerText = dt.Rows[60]["Price"].ToString();//price
            Image13.ImageUrl = dt.Rows[60]["prod_image"].ToString();//image
            A13.HRef = "ProductDetails.aspx?Id=" + dt.Rows[60]["ProductId"].ToString();

            name14.InnerText = dt.Rows[61]["ProductName"].ToString();//name
            des14.InnerText = dt.Rows[61]["ProductDescription"].ToString();//desc
            price14.InnerText = dt.Rows[61]["Price"].ToString();//price
            Image14.ImageUrl = dt.Rows[61]["prod_image"].ToString();//image
            A14.HRef = "ProductDetails.aspx?Id=" + dt.Rows[61]["ProductId"].ToString();

            name15.InnerText = dt.Rows[62]["ProductName"].ToString();//name
            des15.InnerText = dt.Rows[62]["ProductDescription"].ToString();//desc
            price15.InnerText = dt.Rows[62]["Price"].ToString();//price
            Image15.ImageUrl = dt.Rows[62]["prod_image"].ToString();//image
            A15.HRef = "ProductDetails.aspx?Id=" + dt.Rows[62]["ProductId"].ToString();

            name16.InnerText = dt.Rows[63]["ProductName"].ToString();//name
            des16.InnerText = dt.Rows[63]["ProductDescription"].ToString();//desc
            price16.InnerText = dt.Rows[63]["Price"].ToString();//price
            Image16.ImageUrl = dt.Rows[63]["prod_image"].ToString();//image
            A16.HRef = "ProductDetails.aspx?Id=" + dt.Rows[63]["ProductId"].ToString();

            //For the 5th Row
            name17.InnerText = dt.Rows[64]["ProductName"].ToString();//name
            des17.InnerText = dt.Rows[64]["ProductDescription"].ToString();//desc
            price17.InnerText = dt.Rows[64]["Price"].ToString();//price
            Image17.ImageUrl = dt.Rows[64]["prod_image"].ToString();//image
            A17.HRef = "ProductDetails.aspx?Id=" + dt.Rows[64]["ProductId"].ToString();

            name18.InnerText = dt.Rows[65]["ProductName"].ToString();//name
            des18.InnerText = dt.Rows[65]["ProductDescription"].ToString();//desc
            price18.InnerText = dt.Rows[65]["Price"].ToString();//price
            Image18.ImageUrl = dt.Rows[65]["prod_image"].ToString();//image
            A18.HRef = "ProductDetails.aspx?Id=" + dt.Rows[65]["ProductId"].ToString();

            name19.InnerText = dt.Rows[66]["ProductName"].ToString();//name
            des19.InnerText = dt.Rows[66]["ProductDescription"].ToString();//desc
            price19.InnerText = dt.Rows[66]["Price"].ToString();//price
            Image19.ImageUrl = dt.Rows[66]["prod_image"].ToString();//image
            A19.HRef = "ProductDetails.aspx?Id=" + dt.Rows[66]["ProductId"].ToString();

            name20.InnerText = dt.Rows[67]["ProductName"].ToString();//name
            des20.InnerText = dt.Rows[67]["ProductDescription"].ToString();//desc
            price20.InnerText = dt.Rows[67]["Price"].ToString();//price
            Image20.ImageUrl = dt.Rows[67]["prod_image"].ToString();//image
            A20.HRef = "ProductDetails.aspx?Id=" + dt.Rows[67]["ProductId"].ToString();

            //For the 6th Row
            name21.InnerText = dt.Rows[68]["ProductName"].ToString();//name
            des21.InnerText = dt.Rows[68]["ProductDescription"].ToString();//desc
            price21.InnerText = dt.Rows[68]["Price"].ToString();//price
            Image21.ImageUrl = dt.Rows[68]["prod_image"].ToString();//image
            A21.HRef = "ProductDetails.aspx?Id=" + dt.Rows[68]["ProductId"].ToString();

            name22.InnerText = dt.Rows[69]["ProductName"].ToString();//name
            des22.InnerText = dt.Rows[69]["ProductDescription"].ToString();//desc
            price22.InnerText = dt.Rows[69]["Price"].ToString();//price
            Image22.ImageUrl = dt.Rows[69]["prod_image"].ToString();//image
            A22.HRef = "ProductDetails.aspx?Id=" + dt.Rows[69]["ProductId"].ToString();

            name23.InnerText = dt.Rows[70]["ProductName"].ToString();//name
            des23.InnerText = dt.Rows[70]["ProductDescription"].ToString();//desc
            price23.InnerText = dt.Rows[70]["Price"].ToString();//price
            Image23.ImageUrl = dt.Rows[70]["prod_image"].ToString();//image
            A23.HRef = "ProductDetails.aspx?Id=" + dt.Rows[70]["ProductId"].ToString();

            name24.InnerText = dt.Rows[71]["ProductName"].ToString();//name
            des24.InnerText = dt.Rows[71]["ProductDescription"].ToString();//desc
            price24.InnerText = dt.Rows[71]["Price"].ToString();//price
            Image24.ImageUrl = dt.Rows[71]["prod_image"].ToString();//image
            A24.HRef = "ProductDetails.aspx?Id=" + dt.Rows[71]["ProductId"].ToString();


        }
    }
}