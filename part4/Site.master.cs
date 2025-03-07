﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Site : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Check if user is logged in
        if (Session["Username"] != null)
        {
            // Show information
            Register_Button.Visible = false;
            Login_Button.Visible = false;
            SignOut_Button.Visible = true;
            Orders_Button.Visible = true;
        }
    }

    protected void Register_Button_Click(object sender, EventArgs e)
    {
        // Redirect
        Response.Redirect("Register.aspx");
    }

    protected void Login_Button_Click(object sender, EventArgs e)
    {
        // Redirect
        Response.Redirect("Login.aspx");
    }

    protected void SignOut_Button_Click(object sender, EventArgs e)
    {
        // Reset Session Data
        Session["Username"] = null;

        // Redirect
        Response.Redirect("Home.aspx");
    }

    protected void Orders_Button_Click1(object sender, EventArgs e)
    {
        // Redirect
        Response.Redirect("Orders.aspx");
    }
}
