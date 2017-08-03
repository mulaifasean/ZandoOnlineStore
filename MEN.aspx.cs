using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class MEN : System.Web.UI.Page
{
    string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            SqlConnection objCon = new SqlConnection(connStr);

            SqlDataAdapter da = new SqlDataAdapter("select * from Items ", objCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            name1.InnerText = dt.Rows[0]["ProductName"].ToString();//name
            des1.InnerText = dt.Rows[0]["ProductDescription"].ToString();//desc
            price1.InnerText = dt.Rows[0]["Price"].ToString();//price
            mg1.ImageUrl = dt.Rows[0]["prod_image"].ToString();//image
            A1.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[0]["ProductId"].ToString();

            name2.InnerText = dt.Rows[1]["ProductName"].ToString();//name
            des2.InnerText = dt.Rows[1]["ProductDescription"].ToString();//desc
            price2.InnerText = dt.Rows[1]["Price"].ToString();//price
            mg2.ImageUrl = dt.Rows[1]["prod_image"].ToString();//image
            A2.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[1]["ProductId"].ToString();


            name3.InnerText = dt.Rows[2]["ProductName"].ToString();//name
            des3.InnerText = dt.Rows[2]["ProductDescription"].ToString();//desc
            price3.InnerText = dt.Rows[2]["Price"].ToString();//price
            mg3.ImageUrl = dt.Rows[2]["prod_image"].ToString();//image
            A3.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[2]["ProductId"].ToString();

            name4.InnerText = dt.Rows[4]["ProductName"].ToString();//name
            des4.InnerText = dt.Rows[4]["ProductDescription"].ToString();//desc
            price4.InnerText = dt.Rows[4]["Price"].ToString();//price
            mg4.ImageUrl = dt.Rows[4]["prod_image"].ToString();//image
            A4.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[4]["ProductId"].ToString();

            //Display for the second Row

            name5.InnerText = dt.Rows[5]["ProductName"].ToString();//name
            des5.InnerText = dt.Rows[5]["ProductDescription"].ToString();//desc
            price5.InnerText = dt.Rows[5]["Price"].ToString();//price
            Image5.ImageUrl = dt.Rows[5]["prod_image"].ToString();//image
            A5.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[5]["ProductId"].ToString();

            name6.InnerText = dt.Rows[6]["ProductName"].ToString();//name
            des6.InnerText = dt.Rows[6]["ProductDescription"].ToString();//desc
            price6.InnerText = dt.Rows[6]["Price"].ToString();//price
            Image6.ImageUrl = dt.Rows[6]["prod_image"].ToString();//image
            A6.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[6]["ProductId"].ToString();

            name7.InnerText = dt.Rows[7]["ProductName"].ToString();//name
            des7.InnerText = dt.Rows[7]["ProductDescription"].ToString();//desc
            price7.InnerText = dt.Rows[7]["Price"].ToString();//price
            Image7.ImageUrl = dt.Rows[7]["prod_image"].ToString();//image
            A7.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[7]["ProductId"].ToString();

            name8.InnerText = dt.Rows[8]["ProductName"].ToString();//name
            des8.InnerText = dt.Rows[8]["ProductDescription"].ToString();//desc
            price8.InnerText = dt.Rows[8]["Price"].ToString();//price
            Image8.ImageUrl = dt.Rows[8]["prod_image"].ToString();//image
            A8.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[8]["ProductId"].ToString();

            //For the 3rd Row
            name9.InnerText = dt.Rows[9]["ProductName"].ToString();//name
            des9.InnerText = dt.Rows[9]["ProductDescription"].ToString();//desc
            price9.InnerText = dt.Rows[9]["Price"].ToString();//price
            Image9.ImageUrl = dt.Rows[9]["prod_image"].ToString();//image
            A9.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[9]["ProductId"].ToString();

            name10.InnerText = dt.Rows[10]["ProductName"].ToString();//name
            des10.InnerText = dt.Rows[10]["ProductDescription"].ToString();//desc
            price10.InnerText = dt.Rows[10]["Price"].ToString();//price
            Image10.ImageUrl = dt.Rows[10]["prod_image"].ToString();//image
            A10.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[10]["ProductId"].ToString();

            name11.InnerText = dt.Rows[11]["ProductName"].ToString();//name
            des11.InnerText = dt.Rows[11]["ProductDescription"].ToString();//desc
            price11.InnerText = dt.Rows[11]["Price"].ToString();//price
            Image11.ImageUrl = dt.Rows[11]["prod_image"].ToString();//image
            A11.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[11]["ProductId"].ToString();

            name12.InnerText = dt.Rows[12]["ProductName"].ToString();//name
            des12.InnerText = dt.Rows[12]["ProductDescription"].ToString();//desc
            price12.InnerText = dt.Rows[12]["Price"].ToString();//price
            Image12.ImageUrl = dt.Rows[12]["prod_image"].ToString();//image
            A12.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[12]["ProductId"].ToString();

            //For the 4th Row
            name13.InnerText = dt.Rows[13]["ProductName"].ToString();//name
            des13.InnerText = dt.Rows[13]["ProductDescription"].ToString();//desc
            price13.InnerText = dt.Rows[13]["Price"].ToString();//price
            Image13.ImageUrl = dt.Rows[13]["prod_image"].ToString();//image
            A13.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[13]["ProductId"].ToString();

            name14.InnerText = dt.Rows[14]["ProductName"].ToString();//name
            des14.InnerText = dt.Rows[14]["ProductDescription"].ToString();//desc
            price14.InnerText = dt.Rows[14]["Price"].ToString();//price
            Image14.ImageUrl = dt.Rows[14]["prod_image"].ToString();//image
            A14.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[14]["ProductId"].ToString();

            name15.InnerText = dt.Rows[15]["ProductName"].ToString();//name
            des15.InnerText = dt.Rows[15]["ProductDescription"].ToString();//desc
            price15.InnerText = dt.Rows[15]["Price"].ToString();//price
            Image15.ImageUrl = dt.Rows[15]["prod_image"].ToString();//image
            A15.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[15]["ProductId"].ToString();

            name16.InnerText = dt.Rows[16]["ProductName"].ToString();//name
            des16.InnerText = dt.Rows[16]["ProductDescription"].ToString();//desc
            price16.InnerText = dt.Rows[16]["Price"].ToString();//price
            Image16.ImageUrl = dt.Rows[16]["prod_image"].ToString();//image
            A16.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[16]["ProductId"].ToString();

            //For the 5th Row
            name17.InnerText = dt.Rows[17]["ProductName"].ToString();//name
            des17.InnerText = dt.Rows[17]["ProductDescription"].ToString();//desc
            price17.InnerText = dt.Rows[17]["Price"].ToString();//price
            Image17.ImageUrl = dt.Rows[17]["prod_image"].ToString();//image
            A17.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[17]["ProductId"].ToString();

            name18.InnerText = dt.Rows[18]["ProductName"].ToString();//name
            des18.InnerText = dt.Rows[18]["ProductDescription"].ToString();//desc
            price18.InnerText = dt.Rows[18]["Price"].ToString();//price
            Image18.ImageUrl = dt.Rows[18]["prod_image"].ToString();//image
            A18.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[18]["ProductId"].ToString();

            name19.InnerText = dt.Rows[19]["ProductName"].ToString();//name
            des19.InnerText = dt.Rows[19]["ProductDescription"].ToString();//desc
            price19.InnerText = dt.Rows[19]["Price"].ToString();//price
            Image19.ImageUrl = dt.Rows[19]["prod_image"].ToString();//image
            A19.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[19]["ProductId"].ToString();

            name20.InnerText = dt.Rows[20]["ProductName"].ToString();//name
            des20.InnerText = dt.Rows[20]["ProductDescription"].ToString();//desc
            price20.InnerText = dt.Rows[20]["Price"].ToString();//price
            Image20.ImageUrl = dt.Rows[20]["prod_image"].ToString();//image
            A20.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[20]["ProductId"].ToString();

            //For the 6th Row
            name21.InnerText = dt.Rows[21]["ProductName"].ToString();//name
            des21.InnerText = dt.Rows[21]["ProductDescription"].ToString();//desc
            price21.InnerText = dt.Rows[21]["Price"].ToString();//price
            Image21.ImageUrl = dt.Rows[21]["prod_image"].ToString();//image
            A21.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[21]["ProductId"].ToString();

            name22.InnerText = dt.Rows[22]["ProductName"].ToString();//name
            des22.InnerText = dt.Rows[22]["ProductDescription"].ToString();//desc
            price22.InnerText = dt.Rows[22]["Price"].ToString();//price
            Image22.ImageUrl = dt.Rows[22]["prod_image"].ToString();//image
            A22.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[22]["ProductId"].ToString();

            name23.InnerText = dt.Rows[23]["ProductName"].ToString();//name
            des23.InnerText = dt.Rows[23]["ProductDescription"].ToString();//desc
            price23.InnerText = dt.Rows[23]["Price"].ToString();//price
            Image23.ImageUrl = dt.Rows[23]["prod_image"].ToString();//image
            A23.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[23]["ProductId"].ToString();

            name24.InnerText = dt.Rows[3]["ProductName"].ToString();//name
            des24.InnerText = dt.Rows[3]["ProductDescription"].ToString();//desc
            price24.InnerText = dt.Rows[3]["Price"].ToString();//price
            Image24.ImageUrl = dt.Rows[3]["prod_image"].ToString();//image
            A24.HRef = "ProductDetails2.aspx?Id=" + dt.Rows[3]["ProductId"].ToString();
        }
    }
}