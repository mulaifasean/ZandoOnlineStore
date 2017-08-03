using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

public partial class AdminAddItems : System.Web.UI.Page
{
    string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        admin.Text = "Logged in as :" + "   " +Session["email"];
        admin.Visible = true;
      
       
    }

    protected void save_Click(object sender, EventArgs e)
    {

        HttpPostedFile myImage = flImage.PostedFile;
        string fileName = Path.GetFileName(myImage.FileName);
        string fileExtension = Path.GetExtension(fileName);
        int fileSize = myImage.ContentLength;

        bool formValid = true;
        string strError = "";
        byte[] bytes = null;

        if (fileName != "")
        {
            if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".jpeg" || fileExtension.ToLower() == ".png" ||
                fileExtension.ToLower() == ".tiff" || fileExtension.ToLower() == ".gif" || fileExtension.ToLower() == ".bmp")
            {
                Stream stream = myImage.InputStream;
                BinaryReader br = new BinaryReader(stream);
                bytes = br.ReadBytes((int)stream.Length);
               

SqlConnection ObjCon = new SqlConnection(connStr);

        String Qryinsert = "INSERT INTO Items2  VALUES (@ProductName,@ProductDescription,@Prod_qty,@Price,@Category, @Prod_image)";

        SqlCommand cmd = new SqlCommand(Qryinsert, ObjCon);

        cmd.Parameters.Add("@ProductName", System.Data.SqlDbType.VarChar).Value = prodnme.Text;
        cmd.Parameters.Add("@ProductDescription", System.Data.SqlDbType.VarChar).Value = proDesc.Text;
        cmd.Parameters.Add("@Prod_qty", System.Data.SqlDbType.Int).Value = qty.Text;
                cmd.Parameters.Add("@Prod_image", SqlDbType.VarChar).Value ="image/"+ fileName;
        cmd.Parameters.Add("@Price", System.Data.SqlDbType.Int).Value = price.Text;
        cmd.Parameters.Add("@Category", System.Data.SqlDbType.Int).Value = Categ.Text;
        

        ObjCon.Open();
        cmd.CommandText = Qryinsert;
        cmd.ExecuteNonQuery();
        ObjCon.Close();



       Response.Redirect(Request.Url.AbsoluteUri);
                
stat.Text = "Product Successfully Added!!";
                stat.Visible = true;
                stat.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                formValid = false;
                strError += "Invalid file loaded, only (.jpg, .jpeg, .png, .tiff, .gif, .bmp) accepted<br />";
            }
        }
        else
        {
            formValid = false;
            strError += "Please add product image <br />";
        }

        
    }


    protected void adminbtn_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Response.Redirect("RegisterLogin.aspx");
    }
}