﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RecoverPasswordSolution : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Check if got here properly
        if (Session["RecoveredAnswer"] == null)
        {
            // Error message
            RecoverPassword_Answer.Text = "Please go through proper steps to recover password";
        }
        else
        {
            // Display recovered password and reset steps
            RecoverPassword_Answer.Text = "Your recovered password is: " + Session["RecoveredAnswer"];
            Session["RecoveredAnswer"] = null;
        }
    }
}