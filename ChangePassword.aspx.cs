using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class ChangePassword : System.Web.UI.Page
{

    string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        
       if(!IsPostBack)
        {
            SqlConnection objCon = new SqlConnection(connStr);

            SqlDataAdapter da = new SqlDataAdapter("select * from Customertbl where email='" + Session["email"] + "'", objCon);
        DataTable dt = new DataTable();
        da.Fill(dt);
        Curpass.Text = dt.Rows[0][9].ToString();

        }

    }

    protected void ChangePwrd_Click(object sender, EventArgs e)
    {


        SqlConnection objCon = new SqlConnection(connStr);
       
        SqlCommand cmd = new SqlCommand("update Customertbl set password=  @password where email='"+Session["email"]+"'", objCon);

        if(Newpass.Text==CfNewpass.Text)
        {

 objCon.Open();

        cmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = CfNewpass.Text;
        cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = Session["email"].ToString();
       
       
        cmd.ExecuteNonQuery();
        objCon.Close();
            passlbl.Text = "Password Successfully changed!!!";
            passlbl.Visible = true;
            passlbl.ForeColor = System.Drawing.Color.Green;
        }
       else
        {
            passlbl.Text = "Password Do not match";
            passlbl.Visible = true;
            passlbl.ForeColor = System.Drawing.Color.Red;
        }

    }
        
       

       
        
        
    
}