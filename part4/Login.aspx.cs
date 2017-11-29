using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Login_Submit_Click(object sender, EventArgs e)
    {
        if (Username_Input.Text == "")
        {
            Invalid_Error.Text = "Please fill in a Username";
        }
        else if (Password_Input.Text == "")
        {
            Invalid_Error.Text = "Please fill in a Password";
        }
        else
        {
            // Database Content
            ShopNowDataContext db = new ShopNowDataContext();

            user cur_user = db.users.FirstOrDefault(row => (row.Username.Equals(Username_Input.Text) && row.Password.Equals(Password_Input.Text)));

            if (cur_user == null)
            {
                Invalid_Error.Text = "Invalid Login. Please try again";
            }
            else
            {
                Session["Username"] = cur_user.Username;

                // Redirect
                Response.Redirect("Home.aspx");
            }
        }
    }
}