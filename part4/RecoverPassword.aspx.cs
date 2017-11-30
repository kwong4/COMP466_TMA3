using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RecoverPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Recover_Password_Button_Click(object sender, EventArgs e)
    {
        // Database Content
        ShopNowDataContext db = new ShopNowDataContext();

        // Lookup Email
        privatesecurity security = db.privatesecurities.FirstOrDefault(row => (row.Email.Equals(Recover_Password_Email.Text)));

        // Check if one present
        if (security == null)
        {
            // Error message
            Invalid_Recover_Error.Text = "Non-Registered Email. Please try again.";
        }
        else
        {
            // Session
            Session["RecoverEmail"] = Recover_Password_Email.Text;

            // Redirect
            Response.Redirect("RecoverPasswordQuestion.aspx");
        }
    }
}