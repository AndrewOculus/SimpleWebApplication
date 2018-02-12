using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LasexWebFormApp
{
    public partial class JournalOfEquipmentOperationPolishingMachine : System.Web.UI.Page
    {
        private SqlConnection sqlConnection = null;
        protected async void Page_Load(object sender, EventArgs e)
        {
            HttpCookie login = Request.Cookies["login"];
            HttpCookie sign = Request.Cookies["sign"];

            if (login != null && sign != null)
            {
                if (sign.Value == SignGenerator.GetSign(login.Value + "bytepp"))
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                    sqlConnection = new SqlConnection(connectionString);
                    await sqlConnection.OpenAsync();
                    return;
                }
            }
            Response.Redirect("Login.aspx", false);


        }


        protected async void Button1_OnClick(object sender, EventArgs e)
        {
            Dictionary<string, string> db = new Dictionary<string, string>();

            SqlCommand regUser = new SqlCommand("INSERT INTO [PSP-2SH] (FullName, Phone, EMail, Time, Temperature, Pressure, Humidity, BlockNumber," +
                                                " PolishingSuspension, PolishingClothMaterial, StartPH, TemperatureOfPolishingSuspension, SpindleSpeed, SweepFrequency," +
                                                " CargoMass, PolishingCycleTime, FinalPH, ShortCheck)VALUES(@FullName, @Phone, @EMail, @Time, @Temperature, @Pressure, @Humidity, @BlockNumber," +
                                                " @PolishingSuspension, @PolishingClothMaterial, @StartPH, @TemperatureOfPolishingSuspension, @SpindleSpeed, @SweepFrequency, @CargoMass, @PolishingCycleTime," +
                                                "@FinalPH, @ShortCheck)", sqlConnection);
            regUser.Parameters.AddWithValue("FullName", TextBox1.Text);
            regUser.Parameters.AddWithValue("Phone", TextBox2.Text);
            regUser.Parameters.AddWithValue("EMail", TextBox3.Text);
            regUser.Parameters.AddWithValue("Time", TextBox4.Text);
            regUser.Parameters.AddWithValue("Temperature", TextBox5.Text);
            regUser.Parameters.AddWithValue("Pressure", TextBox6.Text);
            regUser.Parameters.AddWithValue("Humidity", TextBox7.Text);
            regUser.Parameters.AddWithValue("BlockNumber", TextBox8.Text);
            regUser.Parameters.AddWithValue("PolishingSuspension", TextBox9.Text);
            regUser.Parameters.AddWithValue("PolishingClothMaterial", TextBox10.Text);
            regUser.Parameters.AddWithValue("StartPH", TextBox11.Text);
            regUser.Parameters.AddWithValue("TemperatureOfPolishingSuspension", TextBox12.Text);
            regUser.Parameters.AddWithValue("SpindleSpeed", TextBox13.Text);
            regUser.Parameters.AddWithValue("SweepFrequency", TextBox14.Text);
            regUser.Parameters.AddWithValue("CargoMass", TextBox15.Text);
            regUser.Parameters.AddWithValue("PolishingCycleTime", TextBox16.Text);
            regUser.Parameters.AddWithValue("FinalPH", TextBox17.Text);
            regUser.Parameters.AddWithValue("ShortCheck", TextBox18.Text);

            await regUser.ExecuteNonQueryAsync();

            string script = "alert('Форма отправлена!')";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "MessageBox", script, true);
            //Response.Redirect("Login.aspx", false);

        }
        protected void Page_Unload(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }

        protected void Button2_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx", false);
        }
    }
}
