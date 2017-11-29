using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;

public partial class Feedbackform : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void feedback_Button_Click(object sender, EventArgs e)
    {
        // Database Context
        ShopNowDataContext db = new ShopNowDataContext();

        Feedback feedback = new Feedback();
        feedback.User_Feedback = Feedback_Textbox.Text;

        db.Feedbacks.InsertOnSubmit(feedback);

        db.SubmitChanges();

        // Redirect
        Response.Redirect("FeedbackSubmit.aspx");
    }
}