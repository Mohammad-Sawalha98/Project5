﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Reflection.Emit;

namespace Project5

{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("data source = DESKTOP-EJ4EJ89\\SQLEXPRESS; database=MobileZone;integrated security=SSPI");
            SqlCommand command = new SqlCommand("select email,password,id from Users ", connection);
            connection.Open();
            SqlDataReader sdr = command.ExecuteReader();
            
            while (sdr.Read())
            {
                if (Email.Value == "haitham@gmail.com" && Password1.Value == "123456789")
                {
                    Session["userid"] = sdr[2];
                    Response.Redirect("Admin.aspx");

                    break;
                }

                if (Email.Value == sdr[0].ToString() && Password1.Value == sdr[1].ToString())
                {
                    Session["userid"] = sdr[2];
                    Response.Redirect("Home.aspx");
                    break;


                }




            }
            Label1.Text = ("Email Or Password Incorrect");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}