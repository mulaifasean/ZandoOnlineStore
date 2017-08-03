using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class Newsletter : System.Web.UI.Page
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
            if(dt.Rows[0][6].ToString()=="Subscribed")
                {
                NewslCheck.Checked = true;
                }
            else
            {
                NewslCheck.Checked = false;
            }
            

        }
    }

    protected void NewslUP_Click(object sender, EventArgs e)
    {

        SqlConnection objCon = new SqlConnection(connStr);

        SqlCommand cmd = new SqlCommand("update Customertbl set zandoProm=  @zandoProm where email='" + Session["email"] + "'", objCon);

        if (NewslCheck.Checked==true)
        {
            string zandoSub = "Subscribed";
            objCon.Open();

            cmd.Parameters.Add("@zandoProm", System.Data.SqlDbType.VarChar).Value = zandoSub; 
            cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = Session["email"].ToString();


            cmd.ExecuteNonQuery();
            objCon.Close();
            Newslbl.Text = "Subscription Status Successfully changed!!!";
            Newslbl.Visible = true;
            Newslbl.ForeColor = System.Drawing.Color.Green;
        }
        else if(NewslCheck.Checked==false)
        {
            
            Newslbl.Text = "Subscription Status is still the same";
            Newslbl.Visible = true;
            Newslbl.ForeColor = System.Drawing.Color.Red;
        }

    }
}