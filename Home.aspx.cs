using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Home : System.Web.UI.Page
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
            name1.InnerText = dt.Rows[24]["ProductName"].ToString();//name
            des1.InnerText = dt.Rows[24]["ProductDescription"].ToString();//desc
            price1.InnerText = dt.Rows[24]["Price"].ToString();//price
            mg1.ImageUrl = dt.Rows[24]["prod_image"].ToString();//image
            A1.HRef = "ProductDetails.aspx?Id=" + dt.Rows[24]["ProductId"].ToString();

            name2.InnerText = dt.Rows[25]["ProductName"].ToString();//name
            des2.InnerText = dt.Rows[25]["ProductDescription"].ToString();//desc
            price2.InnerText = dt.Rows[25]["Price"].ToString();//price
            mg2.ImageUrl = dt.Rows[25]["prod_image"].ToString();//image
            A2.HRef = "ProductDetails.aspx?Id=" + dt.Rows[25]["ProductId"].ToString();


            name3.InnerText = dt.Rows[26]["ProductName"].ToString();//name
            des3.InnerText = dt.Rows[26]["ProductDescription"].ToString();//desc
            price3.InnerText = dt.Rows[26]["Price"].ToString();//price
            mg3.ImageUrl = dt.Rows[26]["prod_image"].ToString();//image
            A3.HRef = "ProductDetails.aspx?Id=" + dt.Rows[26]["ProductId"].ToString();

            name4.InnerText = dt.Rows[27]["ProductName"].ToString();//name
            des4.InnerText = dt.Rows[27]["ProductDescription"].ToString();//desc
            price4.InnerText = dt.Rows[27]["Price"].ToString();//price
            mg4.ImageUrl = dt.Rows[27]["prod_image"].ToString();//image
            A4.HRef = "ProductDetails.aspx?Id=" + dt.Rows[27]["ProductId"].ToString();

            //Display for the second Row

            name5.InnerText = dt.Rows[28]["ProductName"].ToString();//name
            des5.InnerText = dt.Rows[28]["ProductDescription"].ToString();//desc
            price5.InnerText = dt.Rows[28]["Price"].ToString();//price
            Image5.ImageUrl = dt.Rows[28]["prod_image"].ToString();//image
            A5.HRef = "ProductDetails.aspx?Id=" + dt.Rows[28]["ProductId"].ToString();

            name6.InnerText = dt.Rows[29]["ProductName"].ToString();//name
            des6.InnerText = dt.Rows[29]["ProductDescription"].ToString();//desc
            price6.InnerText = dt.Rows[29]["Price"].ToString();//price
            Image6.ImageUrl = dt.Rows[29]["prod_image"].ToString();//image
            A6.HRef = "ProductDetails.aspx?Id=" + dt.Rows[29]["ProductId"].ToString();

            name7.InnerText = dt.Rows[30]["ProductName"].ToString();//name
            des7.InnerText = dt.Rows[30]["ProductDescription"].ToString();//desc
            price7.InnerText = dt.Rows[30]["Price"].ToString();//price
            Image7.ImageUrl = dt.Rows[30]["prod_image"].ToString();//image
            A7.HRef = "ProductDetails.aspx?Id=" + dt.Rows[30]["ProductId"].ToString();

            name8.InnerText = dt.Rows[31]["ProductName"].ToString();//name
            des8.InnerText = dt.Rows[31]["ProductDescription"].ToString();//desc
            price8.InnerText = dt.Rows[31]["Price"].ToString();//price
            Image8.ImageUrl = dt.Rows[31]["prod_image"].ToString();//image
            A8.HRef = "ProductDetails.aspx?Id=" + dt.Rows[31]["ProductId"].ToString();

            //For the 3rd Row
            name9.InnerText = dt.Rows[32]["ProductName"].ToString();//name
            des9.InnerText = dt.Rows[32]["ProductDescription"].ToString();//desc
            price9.InnerText = dt.Rows[32]["Price"].ToString();//price
            Image9.ImageUrl = dt.Rows[32]["prod_image"].ToString();//image
            A9.HRef = "ProductDetails.aspx?Id=" + dt.Rows[32]["ProductId"].ToString();

            name10.InnerText = dt.Rows[33]["ProductName"].ToString();//name
            des10.InnerText = dt.Rows[33]["ProductDescription"].ToString();//desc
            price10.InnerText = dt.Rows[33]["Price"].ToString();//price
            Image10.ImageUrl = dt.Rows[33]["prod_image"].ToString();//image
            A10.HRef = "ProductDetails.aspx?Id=" + dt.Rows[33]["ProductId"].ToString();

            name11.InnerText = dt.Rows[34]["ProductName"].ToString();//name
            des11.InnerText = dt.Rows[34]["ProductDescription"].ToString();//desc
            price11.InnerText = dt.Rows[34]["Price"].ToString();//price
            Image11.ImageUrl = dt.Rows[34]["prod_image"].ToString();//image
            A11.HRef = "ProductDetails.aspx?Id=" + dt.Rows[34]["ProductId"].ToString();

            name12.InnerText = dt.Rows[35]["ProductName"].ToString();//name
            des12.InnerText = dt.Rows[35]["ProductDescription"].ToString();//desc
            price12.InnerText = dt.Rows[35]["Price"].ToString();//price
            Image12.ImageUrl = dt.Rows[35]["prod_image"].ToString();//image
            A12.HRef = "ProductDetails.aspx?Id=" + dt.Rows[35]["ProductId"].ToString();

            //For the 4th Row
            name13.InnerText = dt.Rows[36]["ProductName"].ToString();//name
            des13.InnerText = dt.Rows[36]["ProductDescription"].ToString();//desc
            price13.InnerText = dt.Rows[36]["Price"].ToString();//price
            Image13.ImageUrl = dt.Rows[36]["prod_image"].ToString();//image
            A13.HRef = "ProductDetails.aspx?Id=" + dt.Rows[36]["ProductId"].ToString();

            name14.InnerText = dt.Rows[37]["ProductName"].ToString();//name
            des14.InnerText = dt.Rows[37]["ProductDescription"].ToString();//desc
            price14.InnerText = dt.Rows[37]["Price"].ToString();//price
            Image14.ImageUrl = dt.Rows[37]["prod_image"].ToString();//image
            A14.HRef = "ProductDetails.aspx?Id=" + dt.Rows[37]["ProductId"].ToString();

            name15.InnerText = dt.Rows[38]["ProductName"].ToString();//name
            des15.InnerText = dt.Rows[38]["ProductDescription"].ToString();//desc
            price15.InnerText = dt.Rows[38]["Price"].ToString();//price
            Image15.ImageUrl = dt.Rows[38]["prod_image"].ToString();//image
            A15.HRef = "ProductDetails.aspx?Id=" + dt.Rows[38]["ProductId"].ToString();

            name16.InnerText = dt.Rows[39]["ProductName"].ToString();//name
            des16.InnerText = dt.Rows[39]["ProductDescription"].ToString();//desc
            price16.InnerText = dt.Rows[39]["Price"].ToString();//price
            Image16.ImageUrl = dt.Rows[39]["prod_image"].ToString();//image
            A16.HRef = "ProductDetails.aspx?Id=" + dt.Rows[39]["ProductId"].ToString();

            //For the 5th Row
            name17.InnerText = dt.Rows[40]["ProductName"].ToString();//name
            des17.InnerText = dt.Rows[40]["ProductDescription"].ToString();//desc
            price17.InnerText = dt.Rows[40]["Price"].ToString();//price
            Image17.ImageUrl = dt.Rows[40]["prod_image"].ToString();//image
            A17.HRef = "ProductDetails.aspx?Id=" + dt.Rows[40]["ProductId"].ToString();

            name18.InnerText = dt.Rows[41]["ProductName"].ToString();//name
            des18.InnerText = dt.Rows[41]["ProductDescription"].ToString();//desc
            price18.InnerText = dt.Rows[41]["Price"].ToString();//price
            Image18.ImageUrl = dt.Rows[41]["prod_image"].ToString();//image
            A18.HRef = "ProductDetails.aspx?Id=" + dt.Rows[41]["ProductId"].ToString();

            name19.InnerText = dt.Rows[42]["ProductName"].ToString();//name
            des19.InnerText = dt.Rows[42]["ProductDescription"].ToString();//desc
            price19.InnerText = dt.Rows[42]["Price"].ToString();//price
            Image19.ImageUrl = dt.Rows[42]["prod_image"].ToString();//image
            A19.HRef = "ProductDetails.aspx?Id=" + dt.Rows[42]["ProductId"].ToString();

            name20.InnerText = dt.Rows[43]["ProductName"].ToString();//name
            des20.InnerText = dt.Rows[43]["ProductDescription"].ToString();//desc
            price20.InnerText = dt.Rows[43]["Price"].ToString();//price
            Image20.ImageUrl = dt.Rows[43]["prod_image"].ToString();//image
            A20.HRef = "ProductDetails.aspx?Id=" + dt.Rows[43]["ProductId"].ToString();

            //For the 6th Row
            name21.InnerText = dt.Rows[44]["ProductName"].ToString();//name
            des21.InnerText = dt.Rows[44]["ProductDescription"].ToString();//desc
            price21.InnerText = dt.Rows[44]["Price"].ToString();//price
            Image21.ImageUrl = dt.Rows[44]["prod_image"].ToString();//image
            A21.HRef = "ProductDetails.aspx?Id=" + dt.Rows[44]["ProductId"].ToString();

            name22.InnerText = dt.Rows[45]["ProductName"].ToString();//name
            des22.InnerText = dt.Rows[45]["ProductDescription"].ToString();//desc
            price22.InnerText = dt.Rows[45]["Price"].ToString();//price
            Image22.ImageUrl = dt.Rows[45]["prod_image"].ToString();//image
            A22.HRef = "ProductDetails.aspx?Id=" + dt.Rows[45]["ProductId"].ToString();

            name23.InnerText = dt.Rows[46]["ProductName"].ToString();//name
            des23.InnerText = dt.Rows[46]["ProductDescription"].ToString();//desc
            price23.InnerText = dt.Rows[46]["Price"].ToString();//price
            Image23.ImageUrl = dt.Rows[46]["prod_image"].ToString();//image
            A23.HRef = "ProductDetails.aspx?Id=" + dt.Rows[46]["ProductId"].ToString();

            name24.InnerText = dt.Rows[47]["ProductName"].ToString();//name
            des24.InnerText = dt.Rows[47]["ProductDescription"].ToString();//desc
            price24.InnerText = dt.Rows[47]["Price"].ToString();//price
            Image24.ImageUrl = dt.Rows[47]["prod_image"].ToString();//image
            A24.HRef = "ProductDetails.aspx?Id=" + dt.Rows[47]["ProductId"].ToString();


        }
    }
}