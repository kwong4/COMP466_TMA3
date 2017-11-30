using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Computer_Details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            // Session
            Computer_Detail_Label.Text = Session["Title"] != null ? (String)Session["Title"] : "Custom Computer";
            OSDropDownList.SelectedIndex = Session["OS"] != null ? Convert.ToInt32(Session["OS"]) : 0;
            CPUDropDownList.SelectedIndex = Session["CPU"] != null ? Convert.ToInt32(Session["CPU"]) : 0;
            RAMDropDownList.SelectedIndex = Session["RAM"] != null ? Convert.ToInt32(Session["RAM"]) : 0;
            HardDriveDropDownList.SelectedIndex = Session["HD"] != null ? Convert.ToInt32(Session["HD"]) : 0;
            DisplayDropDownList.SelectedIndex = Session["Display"] != null ? Convert.ToInt32(Session["Display"]) : 0;
            SoundCardDropDownList.SelectedIndex = Session["SC"] != null ? Convert.ToInt32(Session["SC"]) : 0;
        }
        
        // Calculate Total
        double total = 0;
        total += Convert.ToDouble(OSDropDownList.SelectedValue);
        total += Convert.ToDouble(CPUDropDownList.SelectedValue);
        total += Convert.ToDouble(RAMDropDownList.SelectedValue);
        total += Convert.ToDouble(HardDriveDropDownList.SelectedValue);
        total += Convert.ToDouble(DisplayDropDownList.SelectedValue);
        total += Convert.ToDouble(SoundCardDropDownList.SelectedValue);

        // Result to user
        Computer_Cost_Label.Text = "$ " + total.ToString();
    }

    protected void SelectedIndexChanged(object sender, EventArgs e)
    {
        // Calculate Total
        double total = 0;
        total += Convert.ToDouble(OSDropDownList.SelectedValue);
        total += Convert.ToDouble(CPUDropDownList.SelectedValue);
        total += Convert.ToDouble(RAMDropDownList.SelectedValue);
        total += Convert.ToDouble(HardDriveDropDownList.SelectedValue);
        total += Convert.ToDouble(DisplayDropDownList.SelectedValue);
        total += Convert.ToDouble(SoundCardDropDownList.SelectedValue);

        // Result to user
        Computer_Cost_Label.Text = "$ " + total.ToString();
    }

    protected void Detail_Add_to_Cart_Click(object sender, EventArgs e)
    {
        // Session
        Session["OS_Cart"] = OSDropDownList.SelectedItem.Text;
        Session["CPU_Cart"] = CPUDropDownList.SelectedItem.Text;
        Session["RAM_Cart"] = RAMDropDownList.SelectedItem.Text;
        Session["HD_Cart"] = HardDriveDropDownList.SelectedItem.Text;
        Session["Display_Cart"] = DisplayDropDownList.SelectedItem.Text;
        Session["SC_Cart"] = SoundCardDropDownList.SelectedItem.Text;
        Session["Cost"] = Computer_Cost_Label.Text;

        // Redirect
        Response.Redirect("ComputerDetails_Confirmation.aspx");
    }
}