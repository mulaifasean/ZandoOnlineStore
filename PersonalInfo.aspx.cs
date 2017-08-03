using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


public partial class PersonalInfo : System.Web.UI.Page
{
    string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
  

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection objCon = new SqlConnection(connStr);

            SqlDataAdapter da = new SqlDataAdapter("select * from Customertbl where email='" + Session["email"] + "'", objCon);
            DataTable dt = new DataTable();
            da.Fill(dt);

            genderUP.Text = dt.Rows[0][1].ToString();
            emailUP.Text = dt.Rows[0][2].ToString();
            fnameUP.Text = dt.Rows[0][3].ToString();
            lnameUP.Text = dt.Rows[0][4].ToString();
            deiUP.Text = dt.Rows[0][5].ToString();
            montUP.Text = dt.Rows[0][5].ToString();
            yeaUP.Text = dt.Rows[0][5].ToString();
           
        }

    }
   
    protected void SaveID_Click(object sender, EventArgs e)
    {

        SqlConnection objCon = new SqlConnection(connStr);
        
        SqlCommand cmd = new SqlCommand("update Customertbl set gender= @gender, fname= @fname, lname= @lname, bday= @bday where email=@email ", objCon);
        objCon.Open();
        
        cmd.Parameters.Add("@gender", System.Data.SqlDbType.VarChar).Value = genderUP.Text;
        cmd.Parameters.Add("@fname", System.Data.SqlDbType.VarChar).Value = fnameUP.Text;
        cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = lnameUP.Text;
        cmd.Parameters.Add("@bday", System.Data.SqlDbType.VarChar).Value = deiUP.Text;
        cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = Session["email"].ToString();

        cmd.ExecuteNonQuery();
        objCon.Close();
       
    }
}