using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LasexWebFormApp
{
    public partial class Administration : System.Web.UI.Page
    {
        private SqlConnection sqlConnection = null;
        protected async void Page_Load(object sender, EventArgs e)
        {
            HttpCookie login = Request.Cookies["login"];
            HttpCookie sign = Request.Cookies["sign"];

            if (login != null && sign != null)
            {
                if (sign.Value == SignGenerator.GetSign(login.Value + "lasex") && login.Value == "admin")
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                    sqlConnection = new SqlConnection(connectionString);
                    await sqlConnection.OpenAsync();
                    return;
                }
            }
            Response.Redirect("~/index.aspx", false);
        }

        protected async void Button1_OnClick(object sender, EventArgs e)
        {
            Dictionary<string, string> db = new Dictionary<string, string>();

            SqlCommand regUser = new SqlCommand("INSERT INTO [Users] (Login, Password, Permission)VALUES(@Login, @Password, @Permission)", sqlConnection);
            regUser.Parameters.AddWithValue("Login", TextBox1.Text);
            regUser.Parameters.AddWithValue("Password", TextBox2.Text);
            regUser.Parameters.AddWithValue("Permission", TextBox3.Text);

            await regUser.ExecuteNonQueryAsync();

            //Response.Redirect("Login.aspx", false);
        }

        protected void Button2_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("~/index.aspx", false);
        }
    }
}