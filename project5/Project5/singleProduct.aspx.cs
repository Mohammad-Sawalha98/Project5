﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Project5
{
    public partial class singleProduct : System.Web.UI.Page
    {
        string productID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
            productID = Request.QueryString["pid"];
            SqlConnection con = new SqlConnection("data source=DESKTOP-EJ4EJ89\\SQLEXPRESS ; database=MobileZone ; integrated security = SSPI");
            con.Open();
            SqlCommand com = new SqlCommand($"select * from Product where product_id={productID}", con);
            SqlDataReader sdr = com.ExecuteReader();
            sdr.Read();
            
                productTitle.InnerHtml = sdr[1].ToString();
                price.InnerHtml += sdr[6].ToString();
                description.InnerHtml = sdr[2].ToString();

            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            productID = Request.QueryString["pid"];

            SqlConnection con = new SqlConnection("data source=DESKTOP-EJ4EJ89\\SQLEXPRESS ; database=MobileZone ; integrated security = SSPI");
                con.Open();
                SqlCommand com = new SqlCommand($"select * from Product where product_id={productID}", con);
                SqlDataReader sdr = com.ExecuteReader();
                sdr.Read();
                Response.Write(sdr[0] + " " + sdr[1] + "  " + sdr[3] + " " + sdr[6]);

                int quantity = Convert.ToInt32(ProductQtn.SelectedValue);
                Response.Write(quantity);
                int userID = Convert.ToInt32(Session["userID"]);
                double price = Convert.ToDouble(sdr[6]);
                string query = $"insert into Cart values({userID} , {sdr[0]} ,{quantity}, {price} , {price * quantity} , '{sdr[1]}' , '{sdr[3]}' )";
                con.Close();
                con.Open();
                SqlCommand addToCart = new SqlCommand(query, con);
                addToCart.ExecuteNonQuery();

            
        }
    }
}