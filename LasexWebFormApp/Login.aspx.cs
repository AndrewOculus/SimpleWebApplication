using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using LasexWebFormApp.Models;

namespace LasexWebFormApp
{
    public partial class Login : System.Web.UI.Page
    {
        private SqlConnection sqlConnection = null;

        protected async void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            System.Diagnostics.Debug.WriteLine(connectionString);
        }

        protected async void OnClick(object sender, EventArgs e)
        {
            Dictionary<string, User> db = new Dictionary<string, User>();

            SqlCommand getUsersCredCmd = new SqlCommand("SELECT [Login], [Password], [Permission] FROM [Users]", sqlConnection);

            SqlDataReader sqlReader = null;

            try
            {
                sqlReader = await getUsersCredCmd.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    db.Add(Convert.ToString(sqlReader["Login"].ToString()),new User(Convert.ToString(sqlReader["Password"].ToString()) , Convert.ToString(sqlReader["Permission"].ToString())));
                }
            }
            catch
            {
            }
            finally
            {
                sqlReader?.Close();
            }

            if (TextBox2.Text == db[TextBox1.Text].password)
            {
                HttpCookie login = new HttpCookie("login" , TextBox1.Text);
                HttpCookie sign = new HttpCookie("sign", SignGenerator.GetSign(TextBox1.Text+"lasex"));
                HttpCookie permission = new HttpCookie("permission", db[TextBox1.Text].permission);
                Response.Cookies.Add(login);
                Response.Cookies.Add(sign);
                Response.Cookies.Add(permission);

                Response.Redirect("index.aspx", false);
            }

        }

    }
}