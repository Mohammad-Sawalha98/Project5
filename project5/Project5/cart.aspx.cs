﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5
{
    public partial class cart1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["userID"].ToString() != null)
                {
                    login.Visible = false;
                    register.Visible = false;
                }



            }
            catch (Exception)
            {

                logout.Visible = false;
                profile.Visible = false;

            }
        }

        protected void checkOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("checkOut.aspx");

        }
    }
}