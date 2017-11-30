using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RecoverPasswordQuestion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["RecoverEmail"] == null)
        {
            // Hide Information
            Recover_Password_SecurityQuestion.Visible = false;
            Recover_Password_UserInput.Visible = false;
            Submit_SecurityQuestion.Visible = false;

            // Error Message
            Recover_Password_Security.Text = "Please go through proper steps to recover password";
        }
        else
        {
            // Check if email is valid

            // Else post that it is not valid
            Recover_Password_Security.Text = "No Account associated with email entered. Please try again.";
            Recover_Password_SecurityQuestion.Visible = false;
            Recover_Password_UserInput.Visible = false;
            Submit_SecurityQuestion.Visible = false;
        }
    }

    protected void Submit_SecurityQuestion_Click(object sender, EventArgs e)
    {
        // Session
        Session["RecoverAnswer"] = Recover_Password_UserInput.Text;

        // Redirect
        Response.Redirect("RecoverPasswordSolution.aspx");
    }
}