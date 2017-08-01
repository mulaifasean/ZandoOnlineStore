using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class KidsSub : System.Web.UI.Page
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
            name1.InnerText = dt.Rows[72]["ProductName"].ToString();//name
            des1.InnerText = dt.Rows[72]["ProductDescription"].ToString();//desc
            price1.InnerText ="R"+ dt.Rows[72]["Price"].ToString();//price
            mg1.ImageUrl = dt.Rows[72]["prod_image"].ToString();//image
            A1.HRef = "ProductDetails.aspx?Id=" + dt.Rows[72]["ProductId"].ToString();

            name2.InnerText = dt.Rows[73]["ProductName"].ToString();//name
            des2.InnerText = dt.Rows[73]["ProductDescription"].ToString();//desc
            price2.InnerText = "R" + dt.Rows[73]["Price"].ToString();//price
            mg2.ImageUrl = dt.Rows[73]["prod_image"].ToString();//image
            A2.HRef = "ProductDetails.aspx?Id=" + dt.Rows[73]["ProductId"].ToString();


            name3.InnerText = dt.Rows[74]["ProductName"].ToString();//name
            des3.InnerText = dt.Rows[74]["ProductDescription"].ToString();//desc
            price3.InnerText = "R" + dt.Rows[74]["Price"].ToString();//price
            mg3.ImageUrl = dt.Rows[74]["prod_image"].ToString();//image
            A3.HRef = "ProductDetails.aspx?Id=" + dt.Rows[74]["ProductId"].ToString();

            name4.InnerText = dt.Rows[75]["ProductName"].ToString();//name
            des4.InnerText = dt.Rows[75]["ProductDescription"].ToString();//desc
            price4.InnerText = "R" + dt.Rows[75]["Price"].ToString();//price
            mg4.ImageUrl = dt.Rows[75]["prod_image"].ToString();//image
            A4.HRef = "ProductDetails.aspx?Id=" + dt.Rows[75]["ProductId"].ToString();

            //Display for the second Row

            name5.InnerText = dt.Rows[76]["ProductName"].ToString();//name
            des5.InnerText = dt.Rows[76]["ProductDescription"].ToString();//desc
            price5.InnerText = "R" + dt.Rows[76]["Price"].ToString();//price
            Image5.ImageUrl = dt.Rows[76]["prod_image"].ToString();//image
            A5.HRef = "ProductDetails.aspx?Id=" + dt.Rows[76]["ProductId"].ToString();

            name6.InnerText = dt.Rows[77]["ProductName"].ToString();//name
            des6.InnerText = dt.Rows[77]["ProductDescription"].ToString();//desc
            price6.InnerText = "R" + dt.Rows[77]["Price"].ToString();//price
            Image6.ImageUrl = dt.Rows[77]["prod_image"].ToString();//image
            A6.HRef = "ProductDetails.aspx?Id=" + dt.Rows[77]["ProductId"].ToString();

            name7.InnerText = dt.Rows[78]["ProductName"].ToString();//name
            des7.InnerText = dt.Rows[78]["ProductDescription"].ToString();//desc
            price7.InnerText = "R" + dt.Rows[78]["Price"].ToString();//price
            Image7.ImageUrl = dt.Rows[78]["prod_image"].ToString();//image
            A7.HRef = "ProductDetails.aspx?Id=" + dt.Rows[78]["ProductId"].ToString();

            name8.InnerText = dt.Rows[79]["ProductName"].ToString();//name
            des8.InnerText = dt.Rows[79]["ProductDescription"].ToString();//desc
            price8.InnerText = "R" + dt.Rows[79]["Price"].ToString();//price
            Image8.ImageUrl = dt.Rows[79]["prod_image"].ToString();//image
            A8.HRef = "ProductDetails.aspx?Id=" + dt.Rows[79]["ProductId"].ToString();

            //For the 3rd Row
            name9.InnerText = dt.Rows[80]["ProductName"].ToString();//name
            des9.InnerText = dt.Rows[80]["ProductDescription"].ToString();//desc
            price9.InnerText = "R" + dt.Rows[80]["Price"].ToString();//price
            Image9.ImageUrl = dt.Rows[80]["prod_image"].ToString();//image
            A9.HRef = "ProductDetails.aspx?Id=" + dt.Rows[80]["ProductId"].ToString();

            name10.InnerText = dt.Rows[81]["ProductName"].ToString();//name
            des10.InnerText = dt.Rows[81]["ProductDescription"].ToString();//desc
            price10.InnerText = "R" + dt.Rows[81]["Price"].ToString();//price
            Image10.ImageUrl = dt.Rows[81]["prod_image"].ToString();//image
            A10.HRef = "ProductDetails.aspx?Id=" + dt.Rows[81]["ProductId"].ToString();

            name11.InnerText = dt.Rows[82]["ProductName"].ToString();//name
            des11.InnerText = dt.Rows[82]["ProductDescription"].ToString();//desc
            price11.InnerText = "R" + dt.Rows[82]["Price"].ToString();//price
            Image11.ImageUrl = dt.Rows[82]["prod_image"].ToString();//image
            A11.HRef = "ProductDetails.aspx?Id=" + dt.Rows[82]["ProductId"].ToString();

            name12.InnerText = dt.Rows[83]["ProductName"].ToString();//name
            des12.InnerText = dt.Rows[83]["ProductDescription"].ToString();//desc
            price12.InnerText = "R" + dt.Rows[83]["Price"].ToString();//price
            Image12.ImageUrl = dt.Rows[83]["prod_image"].ToString();//image
            A12.HRef = "ProductDetails.aspx?Id=" + dt.Rows[83]["ProductId"].ToString();

            //For the 4th Row
            name13.InnerText = dt.Rows[84]["ProductName"].ToString();//name
            des13.InnerText = dt.Rows[84]["ProductDescription"].ToString();//desc
            price13.InnerText = "R" + dt.Rows[84]["Price"].ToString();//price
            Image13.ImageUrl = dt.Rows[84]["prod_image"].ToString();//image
            A13.HRef = "ProductDetails.aspx?Id=" + dt.Rows[84]["ProductId"].ToString();

            name14.InnerText = dt.Rows[85]["ProductName"].ToString();//name
            des14.InnerText = dt.Rows[85]["ProductDescription"].ToString();//desc
            price14.InnerText = "R" + dt.Rows[85]["Price"].ToString();//price
            Image14.ImageUrl = dt.Rows[85]["prod_image"].ToString();//image
            A14.HRef = "ProductDetails.aspx?Id=" + dt.Rows[85]["ProductId"].ToString();

            name15.InnerText = dt.Rows[86]["ProductName"].ToString();//name
            des15.InnerText = dt.Rows[86]["ProductDescription"].ToString();//desc
            price15.InnerText = "R" + dt.Rows[86]["Price"].ToString();//price
            Image15.ImageUrl = dt.Rows[86]["prod_image"].ToString();//image
            A15.HRef = "ProductDetails.aspx?Id=" + dt.Rows[86]["ProductId"].ToString();

            name16.InnerText = dt.Rows[87]["ProductName"].ToString();//name
            des16.InnerText = dt.Rows[87]["ProductDescription"].ToString();//desc
            price16.InnerText = "R" + dt.Rows[87]["Price"].ToString();//price
            Image16.ImageUrl = dt.Rows[87]["prod_image"].ToString();//image
            A16.HRef = "ProductDetails.aspx?Id=" + dt.Rows[87]["ProductId"].ToString();

            //For the 5th Row
            name17.InnerText = dt.Rows[88]["ProductName"].ToString();//name
            des17.InnerText = dt.Rows[88]["ProductDescription"].ToString();//desc
            price17.InnerText = "R" + dt.Rows[88]["Price"].ToString();//price
            Image17.ImageUrl = dt.Rows[88]["prod_image"].ToString();//image
            A17.HRef = "ProductDetails.aspx?Id=" + dt.Rows[88]["ProductId"].ToString();

            name18.InnerText = dt.Rows[89]["ProductName"].ToString();//name
            des18.InnerText = dt.Rows[89]["ProductDescription"].ToString();//desc
            price18.InnerText = "R" + dt.Rows[89]["Price"].ToString();//price
            Image18.ImageUrl = dt.Rows[89]["prod_image"].ToString();//image
            A18.HRef = "ProductDetails.aspx?Id=" + dt.Rows[89]["ProductId"].ToString();

            name19.InnerText = dt.Rows[90]["ProductName"].ToString();//name
            des19.InnerText = dt.Rows[90]["ProductDescription"].ToString();//desc
            price19.InnerText = "R" + dt.Rows[90]["Price"].ToString();//price
            Image19.ImageUrl = dt.Rows[90]["prod_image"].ToString();//image
            A19.HRef = "ProductDetails.aspx?Id=" + dt.Rows[90]["ProductId"].ToString();

            name20.InnerText = dt.Rows[91]["ProductName"].ToString();//name
            des20.InnerText = dt.Rows[91]["ProductDescription"].ToString();//desc
            price20.InnerText = "R" + dt.Rows[91]["Price"].ToString();//price
            Image20.ImageUrl = dt.Rows[91]["prod_image"].ToString();//image
            A20.HRef = "ProductDetails.aspx?Id=" + dt.Rows[91]["ProductId"].ToString();

            //For the 6th Row
            name21.InnerText = dt.Rows[92]["ProductName"].ToString();//name
            des21.InnerText = dt.Rows[92]["ProductDescription"].ToString();//desc
            price21.InnerText = "R" + dt.Rows[92]["Price"].ToString();//price
            Image21.ImageUrl = dt.Rows[92]["prod_image"].ToString();//image
            A21.HRef = "ProductDetails.aspx?Id=" + dt.Rows[92]["ProductId"].ToString();

            name22.InnerText = dt.Rows[93]["ProductName"].ToString();//name
            des22.InnerText = dt.Rows[93]["ProductDescription"].ToString();//desc
            price22.InnerText = "R" + dt.Rows[93]["Price"].ToString();//price
            Image22.ImageUrl = dt.Rows[93]["prod_image"].ToString();//image
            A22.HRef = "ProductDetails.aspx?Id=" + dt.Rows[93]["ProductId"].ToString();

            name23.InnerText = dt.Rows[94]["ProductName"].ToString();//name
            des23.InnerText = dt.Rows[94]["ProductDescription"].ToString();//desc
            price23.InnerText = "R" + dt.Rows[94]["Price"].ToString();//price
            Image23.ImageUrl = dt.Rows[94]["prod_image"].ToString();//image
            A23.HRef = "ProductDetails.aspx?Id=" + dt.Rows[94]["ProductId"].ToString();

            name24.InnerText = dt.Rows[95]["ProductName"].ToString();//name
            des24.InnerText = dt.Rows[95]["ProductDescription"].ToString();//desc
            price24.InnerText = "R" + dt.Rows[95]["Price"].ToString();//price
            Image24.ImageUrl = dt.Rows[95]["prod_image"].ToString();//image
            A24.HRef = "ProductDetails.aspx?Id=" + dt.Rows[95]["ProductId"].ToString();


        }
    }
}