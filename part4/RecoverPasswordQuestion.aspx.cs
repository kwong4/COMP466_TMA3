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
        // Check if got here properly
        if (Session["RecoverEmail"] == null)
        {
            // Hide Information
            Recover_Password_SecurityQuestion.Visible = false;
            Recover_Password_UserInput.Visible = false;
            Submit_SecurityQuestion.Visible = false;

            // Error message
            Recover_Password_Security.Text = "Please go through proper steps to recover password";
        }
        else
        {
            // Database Content
            ShopNowDataContext db = new ShopNowDataContext();

            // Lookup Email
            privatesecurity security = db.privatesecurities.FirstOrDefault(row => (row.Email.Equals(Session["RecoverEmail"].ToString())));

            // Instructions
            Recover_Password_Security.Text = "Please Answer the following Security Question to recover your password.";

            // Security Question
            Recover_Password_SecurityQuestion.Text = security.SecurityQuestion;
        }
    }

    protected void Submit_SecurityQuestion_Click(object sender, EventArgs e)
    {
        // Check if question answered
        if (Recover_Password_UserInput.Text == "")
        {
            // Error message
            Invalid_RecoverQuestion_Error.Text = "Please enter an Answer.";
        }
        else
        {
            // Database Content
            ShopNowDataContext db = new ShopNowDataContext();

            // Lookup Email
            privatesecurity security = db.privatesecurities.FirstOrDefault(row => (row.Email.Equals(Session["RecoverEmail"].ToString())));

            // Check if answer is correct
            if (security.SecurityAnswer.Equals(Recover_Password_UserInput.Text))
            {
                // Session
                Session["RecoveredAnswer"] = security.SecurityAnswer;

                // Redirect
                Response.Redirect("RecoverPasswordSolution.aspx");
            }
            else
            {
                // Error message
                Invalid_RecoverQuestion_Error.Text = "Invalid Answer. Please try again.";
            }
        }
    }
}