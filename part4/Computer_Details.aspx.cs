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
            OSDropDownList.SelectedValue = Session["OS"] != null ? (String)Session["OS"] : "0";
            CPUDropDownList.SelectedValue = Session["CPU"] != null ? (String)Session["CPU"] : "0";
            RAMDropDownList.SelectedValue = Session["RAM"] != null ? (String)Session["RAM"] : "0";
            HardDriveDropDownList.SelectedValue = Session["HD"] != null ? (String)Session["HD"] : "0";
            DisplayDropDownList.SelectedValue = Session["Display"] != null ? (String)Session["Display"] : "0";
            SoundCardDropDownList.SelectedValue = Session["SC"] != null ? (String)Session["SC"] : "0";
        }
        
        int OS_value = OSDropDownList.SelectedValue == "" ? 0 : Convert.ToInt32(OSDropDownList.SelectedValue);
        int cPU_value = CPUDropDownList.SelectedValue == "" ? 0 : Convert.ToInt32(CPUDropDownList.SelectedValue);
        int rAM_value = RAMDropDownList.SelectedValue == "" ? 0 : Convert.ToInt32(RAMDropDownList.SelectedValue);
        int hardDrive_value = HardDriveDropDownList.SelectedValue == "" ? 0 : Convert.ToInt32(HardDriveDropDownList.SelectedValue);
        int monitor_value = DisplayDropDownList.SelectedValue == "" ? 0 : Convert.ToInt32(DisplayDropDownList.SelectedValue);
        int soundCard_value = SoundCardDropDownList.SelectedValue == "" ? 0 : Convert.ToInt32(SoundCardDropDownList.SelectedValue);

        // Database Content
        ShopNowDataContext db = new ShopNowDataContext();

        // Pull corresponding row given the selected value
        O OS = db.Os.FirstOrDefault(row => row.ID.Equals(OS_value));
        CPU cPU = db.CPUs.FirstOrDefault(row => row.ID.Equals(cPU_value));
        RAM rAM = db.RAMs.FirstOrDefault(row => row.ID.Equals(rAM_value));
        HardDrive hardDrive = db.HardDrives.FirstOrDefault(row => row.ID.Equals(hardDrive_value));
        Monitor monitor = db.Monitors.FirstOrDefault(row => row.ID.Equals(monitor_value));
        SoundCard soundCard = db.SoundCards.FirstOrDefault(row => row.ID.Equals(soundCard_value));

        // Calculate Total
        double total = 0;
        total += Convert.ToDouble(OS.Cost);
        total += Convert.ToDouble(cPU.Cost);
        total += Convert.ToDouble(rAM.Cost);
        total += Convert.ToDouble(hardDrive.Cost);
        total += Convert.ToDouble(monitor.Cost);
        total += Convert.ToDouble(soundCard.Cost);
       
        if (Session["Total"] != null)
        {
            Computer_Cost_Label.Text = "$ " + (String)Session["Total"];
            Session["Total"] = null;
        }
        else
        {
            Computer_Cost_Label.Text = "$ " + total.ToString();
        }
        
    }

    protected void SelectedIndexChanged(object sender, EventArgs e)
    {
        // Database Content
        ShopNowDataContext db = new ShopNowDataContext();

        // Pull corresponding row given the selected value
        O OS = db.Os.FirstOrDefault(row => row.ID.Equals(OSDropDownList.SelectedValue));
        CPU cPU = db.CPUs.FirstOrDefault(row => row.ID.Equals(CPUDropDownList.SelectedValue));
        RAM rAM = db.RAMs.FirstOrDefault(row => row.ID.Equals(RAMDropDownList.SelectedValue));
        HardDrive hardDrive = db.HardDrives.FirstOrDefault(row => row.ID.Equals(HardDriveDropDownList.SelectedValue));
        Monitor monitor = db.Monitors.FirstOrDefault(row => row.ID.Equals(DisplayDropDownList.SelectedValue));
        SoundCard soundCard = db.SoundCards.FirstOrDefault(row => row.ID.Equals(SoundCardDropDownList.SelectedValue));

        // Calculate Total
        double total = 0;
        total += Convert.ToDouble(OS.Cost);
        total += Convert.ToDouble(cPU.Cost);
        total += Convert.ToDouble(rAM.Cost);
        total += Convert.ToDouble(hardDrive.Cost);
        total += Convert.ToDouble(monitor.Cost);
        total += Convert.ToDouble(soundCard.Cost);

        Computer_Cost_Label.Text = "$ " + total.ToString();
    }

    protected void Detail_Add_to_Cart_Click(object sender, EventArgs e)
    {
        // Session
        Session["OS_Cart"] = OSDropDownList.SelectedValue;
        Session["CPU_Cart"] = CPUDropDownList.SelectedValue;
        Session["RAM_Cart"] = RAMDropDownList.SelectedValue;
        Session["HD_Cart"] = HardDriveDropDownList.SelectedValue;
        Session["Display_Cart"] = DisplayDropDownList.SelectedValue;
        Session["SC_Cart"] = SoundCardDropDownList.SelectedValue;
        Session["Cost"] = Computer_Cost_Label.Text;

        // Redirect
        Response.Redirect("ComputerDetails_Confirmation.aspx");
    }
}