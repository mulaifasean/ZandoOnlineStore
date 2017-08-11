using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Manager : System.Web.UI.MasterPage
{

    string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
    string s;
    string t;
    string[] a = new string[6];
    int totitems = 0;
    int total = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["aa"] != null)
        {
            s = Convert.ToString(Request.Cookies["aa"].Value);

            string[] strArr = s.Split('|');

            for (int i = 0; i < strArr.Length; i++)
            {
                t = Convert.ToString(strArr[i].ToString());

                string[] strArr1 = t.Split(',');
                for (int j = 0; j < strArr1.Length; j++)
                {
                    a[j] = strArr1[j].ToString();
                }

                totitems = totitems + 1;
                ItemsNo.Text = totitems.ToString();
                ItemsNo.Visible = true;

            }
        }
    }
}
