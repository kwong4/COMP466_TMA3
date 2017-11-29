using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ComputeDetails_Confirmation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        OS_Cart_Label.Text = (String)Session["OS_Cart"];
        CPU_Cart_Label.Text = (String)Session["CPU_Cart"];
        RAM_Cart_Label.Text = (String)Session["RAM_Cart"];
        HD_Cart_Label.Text = (String)Session["HD_Cart"];
        Display_Cart_Label.Text = (String)Session["Display_Cart"];
        SC_Cart_Label.Text = (String)Session["SC_Cart"];
        Cost_Label.Text = (String)Session["Cost"];
    }
}