using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Mail;
using System.Net.Mail;


public partial class RegisterLogin : System.Web.UI.Page
   

{
    protected void Page_Load(object sender, EventArgs e)
    {

       if(Request.Cookies["authcookie"]!=null)
        {
            if(Request.Cookies["authcookie"]["email"]==emailog.Text && Request.Cookies["authcookie"]["password"]==paslog.Text)
            {
                Response.Redirect("PersonalInfo.aspx");
            }
        }

    }
    

    string zandoP;
    string zandoB;
    string zandoD;
 string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;



    protected void Signlog_Click(object sender, EventArgs e)
    {
        SqlConnection objCon = new SqlConnection(connStr);
        objCon.Open();
        string QryLogin = "select count(*) from Customertbl where email='" + emailog.Text + "'";
        SqlCommand cmd = new SqlCommand(QryLogin, objCon);
        int Customerpar = Convert.ToInt32(cmd.ExecuteScalar().ToString());
        objCon.Close();

        if (emailog.Text=="Admin@zando.com")
        {
            Session["email"] = emailog.Text;
            Response.Redirect("AdminAddItems.aspx");
        }
        else
        {
            if (Customerpar == 1)
            {

                objCon.Open();
                string QrypassCheck = "select password from Customertbl where email='" + emailog.Text + "'";
                SqlCommand passcmd = new SqlCommand(QrypassCheck, objCon);
                string password = passcmd.ExecuteScalar().ToString().Replace(" ", "");
                if (password == paslog.Text)
                {

                    Session["email"] = emailog.Text;

                    if (CheckMe.Checked)
                    {
                        Response.Cookies["authcookie"]["email"] = emailog.Text;
                        Response.Cookies["authcookie"]["password"] = paslog.Text;
                        Response.Cookies["authcookie"].Expires = DateTime.Now.AddDays(2);
                    }
                    string adminPar = "Admin@zando.com";
                    if(Session["email"].ToString()==adminPar.ToString())
                    {
                        Response.Redirect("AdmiAddItems.aspx");
                    }
                    {
                      Response.Redirect("PersonalInfo.aspx");
                    }
                   
                }
                else
                {

                    labellog.Text = "Password is Incorrect" + "<span class='glyphicon glyphicon-remove'></span>";
                    labellog.Visible = true;
                    labellog.Width = 800;
                    labellog.Height = 100;

                }
            }
            else
            {

                labellog.Text = "Customer is not Registered!" + "<span class='glyphicon glyphicon-remove'></span>";
                labellog.Visible = true;
                labellog.Width = 800;
                labellog.Height = 100;
            }




        }
    }
    protected void Reg_Click(object sender, EventArgs e)
    {


        SqlConnection objCon = new SqlConnection(connStr);

        String Qryinsert = "INSERT INTO Customertbl  VALUES (@gender,@email,@fname,@lname,@bday,@zandoProm,@zandoBlog,@zandoDeals,@password)";

        SqlCommand cmd = new SqlCommand(Qryinsert,objCon);
        
        if(zandoProm.Checked==true)
        {
            zandoP = "Subscribed";
        }
        else if(zandoProm.Checked==false)
        {
            zandoP = "Unsubscribed";
        }
        if(zandoBlog.Checked==true)
        {
            zandoB = "Blogged";
        }
        else if(zandoBlog.Checked==false)
        {
            zandoB = "Not Blogged";
        }
        if(zandoDeals.Checked==true)
        {
            zandoD = "Dealed";
        }
        else if(zandoDeals.Checked==false)
        {
            zandoD = "No Deal";
        }

        cmd.Parameters.Add("@gender", System.Data.SqlDbType.VarChar).Value = gender.Text;
        cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = emailreg.Text;
        cmd.Parameters.Add("@fname", System.Data.SqlDbType.VarChar).Value = fname.Text;
        cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname.Text;
        cmd.Parameters.Add("@bday", System.Data.SqlDbType.VarChar).Value =dei.Text+"/"+mont.Text+"/"+yea.Text;
        cmd.Parameters.Add("@zandoProm", System.Data.SqlDbType.VarChar).Value = zandoP;
        cmd.Parameters.Add("@zandoBlog", System.Data.SqlDbType.VarChar).Value = zandoB;
        cmd.Parameters.Add("@zandoDeals", System.Data.SqlDbType.VarChar).Value = zandoD;
        cmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = pass2.Text;

        //Sending Confirmation Email to the customer
        
        string myUrl = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority).ToString();
        System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
        SmtpClient SmtpServer = new SmtpClient("smtp.scdev.co.za");
        mail.From = new MailAddress("no-reply@zando.co.za");
        mail.To.Add(emailreg.Text.ToString()); // Send mail to Employee                   
        mail.Subject = "Zando-Online-Store Registration";
        mail.Body = "<h3> Welcome to Zando-Online-Store, <br/>Your email address was registered at our site<br>" +
            "To begin shopping please click <a href='" + myUrl + "'>here</a> <br />" +
            "<br/><br/><br/> Kind Regards,<br/>Zando-Online-Store Team<br/> <img src='MainPics/Zandomain.jpg' /> ";
        mail.IsBodyHtml = true;
        SmtpServer.Port = 587;
        SmtpServer.EnableSsl = false;
        SmtpServer.Credentials = new System.Net.NetworkCredential("outgoing@scdev.co.za","SCmtp@2015" );

        SmtpServer.Send(mail);

        try
        {
           
        }
        catch (Exception)
        {

        }
        
       

        objCon.Open();
        cmd.CommandText = Qryinsert;
        cmd.ExecuteNonQuery();
        objCon.Close();

        

        Response.Redirect(Request.Url.AbsoluteUri);
        labelreg.Text = "You are successfully registered"+ "<span class='glyphicon glyphicon-ok'></span>"+"<span class='close'>&times;</span>";
        labelreg.Visible = true;
        labelreg.Width = 800;
        labelreg.Height = 100;
    }

}