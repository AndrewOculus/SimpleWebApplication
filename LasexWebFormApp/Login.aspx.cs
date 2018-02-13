using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            Dictionary<string, string> db = new Dictionary<string, string>();

            SqlCommand getUsersCredCmd = new SqlCommand("SELECT [Login], [Password] FROM [Users]", sqlConnection);

            SqlDataReader sqlReader = null;

            try
            {
                sqlReader = await getUsersCredCmd.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    db.Add(Convert.ToString(sqlReader["Login"].ToString()), Convert.ToString(sqlReader["Password"].ToString()));
                }
            }
            catch
            {
            }
            finally
            {
                sqlReader?.Close();
            }

            if (TextBox2.Text == db[TextBox1.Text])
            {
                HttpCookie login = new HttpCookie("login" , TextBox1.Text);
                HttpCookie sign = new HttpCookie("sign", SignGenerator.GetSign(TextBox1.Text+"lasex"));
                Response.Cookies.Add(login);
                Response.Cookies.Add(sign);

                Response.Redirect("index.aspx", false);
            }

        }

    }
}