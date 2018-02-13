using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LasexWebFormApp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie login = Request.Cookies["login"];
            HttpCookie sign = Request.Cookies["sign"];
            HttpCookie permission = Request.Cookies["permission"];



            if (login != null && sign != null)
            {
                if (sign.Value == SignGenerator.GetSign(login.Value + "lasex"))
                {

                    if (login.Value != "admin")
                        Button7.Enabled = false;

                    try
                    {
                        string str = permission.Value;
                        int count = 0;
                        foreach (char ch in str)
                        {
                            string s = ch.ToString();

                            switch (count)
                            {
                                case 0:
                                    if (int.Parse(s) == 0)
                                        Button1.Enabled = false;
                                    break;

                                case 1:
                                    if (int.Parse(s) == 0)
                                        Button2.Enabled = false;
                                    break;

                                case 2:
                                    if (int.Parse(s) == 0)
                                        Button3.Enabled = false;
                                    break;

                                case 3:
                                    if (int.Parse(s) == 0)
                                        Button4.Enabled = false;
                                    break;

                                case 4:
                                    if (int.Parse(s) == 0)
                                        Button5.Enabled = false;
                                    break;
                            }

                            ++count;

                        }
                    }
                    catch 
                    {

                    }



                    Label1.Text = "Ваш логин: " + login.Value;
                    return;
                }
            }
            Response.Redirect("Login.aspx");
        }

        protected void Button1_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("JournalOfEquipmentOperationPolishingMachine.aspx");
            throw new NotImplementedException();
        }

        protected void Button2_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("EquipmentOperationLog.aspx");

            throw new NotImplementedException();
        }

        protected void Button3_OnClick(object sender, EventArgs e)
        {

            Response.Redirect("LogOfEquipmentOperationInterferometer.aspx");

        }

        protected void Button4_OnClick(object sender, EventArgs e)
        {

            Response.Redirect("TheEquipmentOperationLogProfilometer.aspx");

        }

        protected void Button5_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("JournalOfTheOperationOfEquipmentMicroscope.aspx");

        }

        protected void Button6_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("Logout.aspx");
        }

        protected void Button7_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Administration.aspx");
        }
    }
}