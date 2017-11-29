using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Account_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Login_Submit_Click(object sender, EventArgs e)
    {
        if (Register_Username_Input.Text == "")
        {
            Invalid_Register_Error.Text = "Please fill in a Username";
        }
        else if (Register_Password_Input.Text == "")
        {
            Invalid_Register_Error.Text = "Please fill in a Password";
        }
        else if (RegisterConfirm_Password_Input.Text == "")
        {
            Invalid_Register_Error.Text = "Please fill in a Confirm Password";
        }
        else if (!Register_Password_Input.Text.Equals(RegisterConfirm_Password_Input.Text))
        {
            Invalid_Register_Error.Text = "Please match enter matching Passwords";
        }
        else if (Register_Email_Input.Text == "")
        {
            Invalid_Register_Error.Text = "Please enter in a Email";
        }
        else if (Register_Question_Input.Text == "")
        {
            Invalid_Register_Error.Text = "Please enter a Security Question";
        }
        else if (Register_Answer_Input.Text == "")
        {
            Invalid_Register_Error.Text = "Please enter a Security Answer";
        }
        else
        {
            // Database Content
            ShopNowDataContext db = new ShopNowDataContext();

            user register = db.users.FirstOrDefault(row => (row.Username.Equals(Register_Username_Input.Text)));

            if (register != null)
            {
                Invalid_Register_Error.Text = "Username already registered";
            }
            else
            {
                register = db.users.FirstOrDefault(row => (row.Email.Equals(Register_Password_Input.Text)));

                if (register != null)
                {
                    Invalid_Register_Error.Text = "Email already registered";
                }
                else
                {
                    user new_register = new user();
                    new_register.Username = Register_Username_Input.Text;
                    new_register.Password = Register_Password_Input.Text;
                    new_register.Email = Register_Email_Input.Text;

                    db.users.InsertOnSubmit(new_register);

                    privatesecurity new_security = new privatesecurity();
                    new_security.Email = Register_Email_Input.Text;
                    new_security.SecurityQuestion = Register_Question_Input.Text;
                    new_security.SecurityAnswer = Register_Answer_Input.Text;

                    db.privatesecurities.InsertOnSubmit(new_security);

                    Session["Username"] = Register_Username_Input.Text;

                    db.SubmitChanges();

                    // Redirect
                    Response.Redirect("Home.aspx");
                }
            }
        }
    }
}