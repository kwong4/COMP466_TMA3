using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RecoverPasswordSolution : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["RecoverAnswer"] == null)
        {
            RecoverPassword_Answer.Text = "Please go through proper steps to recover password";
        }
        else
        {
            // Check if answer is valid

            // Else post that it is not valid
            RecoverPassword_Answer.Text = "Invalid Security Answer. Please try again.";
        }
    }
}