using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Computer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Database Context
        ShopNowDataContext db = new ShopNowDataContext();

        // PreBuild 1
        PreMade preMade = db.PreMades.FirstOrDefault(row => row.Premade_ID.Equals("0"));

        // Pull corresponding row given the selected value
        O OS = db.Os.FirstOrDefault(row => row.ID.Equals(preMade.OS_ID));
        CPU cPU = db.CPUs.FirstOrDefault(row => row.ID.Equals(preMade.CPU_ID));
        RAM rAM = db.RAMs.FirstOrDefault(row => row.ID.Equals(preMade.RAM_ID));
        HardDrive hardDrive = db.HardDrives.FirstOrDefault(row => row.ID.Equals(preMade.HardDrive_ID));
        Monitor monitor = db.Monitors.FirstOrDefault(row => row.ID.Equals(preMade.Monitor_ID));
        SoundCard soundCard = db.SoundCards.FirstOrDefault(row => row.ID.Equals(preMade.SoundCard_ID));

        // Set Corresponding Comp names
        OS_Label1.Text = OS.Name;
        CPU_Label1.Text = cPU.Name;
        RAM_Label1.Text = rAM.Name;
        HD_Label1.Text = hardDrive.Name;
        Display_Label1.Text = monitor.Name;
        SC_Label1.Text = soundCard.Name;
        PreMade1_Label.Text = preMade.Name;
        PreMadeCost1_Label.Text = preMade.Cost;

        // PreBuild 2
        preMade = db.PreMades.FirstOrDefault(row => row.Premade_ID.Equals("1"));

        // Pull corresponding row given the selected value
        OS = db.Os.FirstOrDefault(row => row.ID.Equals(preMade.OS_ID));
        cPU = db.CPUs.FirstOrDefault(row => row.ID.Equals(preMade.CPU_ID));
        rAM = db.RAMs.FirstOrDefault(row => row.ID.Equals(preMade.RAM_ID));
        hardDrive = db.HardDrives.FirstOrDefault(row => row.ID.Equals(preMade.HardDrive_ID));
        monitor = db.Monitors.FirstOrDefault(row => row.ID.Equals(preMade.Monitor_ID));
        soundCard = db.SoundCards.FirstOrDefault(row => row.ID.Equals(preMade.SoundCard_ID));

        // Set Corresponding Comp names
        OS_Label2.Text = OS.Name;
        CPU_Label2.Text = cPU.Name;
        RAM_Label2.Text = rAM.Name;
        HD_Label2.Text = hardDrive.Name;
        Display_Label2.Text = monitor.Name;
        SC_Label2.Text = soundCard.Name;
        PreMade2_Label.Text = preMade.Name;
        PreMadeCost2_Label.Text = preMade.Cost;

        // PreBuild 3
        preMade = db.PreMades.FirstOrDefault(row => row.Premade_ID.Equals("2"));

        // Pull corresponding row given the selected value
        OS = db.Os.FirstOrDefault(row => row.ID.Equals(preMade.OS_ID));
        cPU = db.CPUs.FirstOrDefault(row => row.ID.Equals(preMade.CPU_ID));
        rAM = db.RAMs.FirstOrDefault(row => row.ID.Equals(preMade.RAM_ID));
        hardDrive = db.HardDrives.FirstOrDefault(row => row.ID.Equals(preMade.HardDrive_ID));
        monitor = db.Monitors.FirstOrDefault(row => row.ID.Equals(preMade.Monitor_ID));
        soundCard = db.SoundCards.FirstOrDefault(row => row.ID.Equals(preMade.SoundCard_ID));

        // Set Corresponding Comp names
        OS_Label3.Text = OS.Name;
        CPU_Label3.Text = cPU.Name;
        RAM_Label3.Text = rAM.Name;
        HD_Label3.Text = hardDrive.Name;
        Display_Label3.Text = monitor.Name;
        SC_Label3.Text = soundCard.Name;
        PreMade3_Label.Text = preMade.Name;
        PreMadeCost3_Label.Text = preMade.Cost;
    }

    protected void View_Details_1_Click(object sender, EventArgs e)
    {
        // Create a Session Info
        Session["Title"] = "Custom Computer";

        // Redirect
        Response.Redirect("Computer_Details.aspx");
    }

    protected void View_Details_2_Click(object sender, EventArgs e)
    {
        // Database Context
        ShopNowDataContext db = new ShopNowDataContext();

        // PreBuild 1
        PreMade preMade = db.PreMades.FirstOrDefault(row => row.Premade_ID.Equals("0"));

        // Pull corresponding row given the selected value
        O OS = db.Os.FirstOrDefault(row => row.ID.Equals(preMade.OS_ID));
        CPU cPU = db.CPUs.FirstOrDefault(row => row.ID.Equals(preMade.CPU_ID));
        RAM rAM = db.RAMs.FirstOrDefault(row => row.ID.Equals(preMade.RAM_ID));
        HardDrive hardDrive = db.HardDrives.FirstOrDefault(row => row.ID.Equals(preMade.HardDrive_ID));
        Monitor monitor = db.Monitors.FirstOrDefault(row => row.ID.Equals(preMade.Monitor_ID));
        SoundCard soundCard = db.SoundCards.FirstOrDefault(row => row.ID.Equals(preMade.SoundCard_ID));

        // Create a Session Info
        Session["Title"] = preMade.Name;
        Session["Total"] = preMade.Cost;
        Session["OS"] = OS.ID.ToString();
        Session["CPU"] = cPU.ID.ToString();
        Session["RAM"] = rAM.ID.ToString();
        Session["HD"] = hardDrive.ID.ToString();
        Session["Display"] = monitor.ID.ToString();
        Session["SC"] = soundCard.ID.ToString();

        // Redirect
        Response.Redirect("Computer_Details.aspx");
    }

    protected void View_Details_3_Click(object sender, EventArgs e)
    {
        // Database Context
        ShopNowDataContext db = new ShopNowDataContext();

        // PreBuild 1
        PreMade preMade = db.PreMades.FirstOrDefault(row => row.Premade_ID.Equals("1"));

        // Pull corresponding row given the selected value
        O OS = db.Os.FirstOrDefault(row => row.ID.Equals(preMade.OS_ID));
        CPU cPU = db.CPUs.FirstOrDefault(row => row.ID.Equals(preMade.CPU_ID));
        RAM rAM = db.RAMs.FirstOrDefault(row => row.ID.Equals(preMade.RAM_ID));
        HardDrive hardDrive = db.HardDrives.FirstOrDefault(row => row.ID.Equals(preMade.HardDrive_ID));
        Monitor monitor = db.Monitors.FirstOrDefault(row => row.ID.Equals(preMade.Monitor_ID));
        SoundCard soundCard = db.SoundCards.FirstOrDefault(row => row.ID.Equals(preMade.SoundCard_ID));

        // Create a Session Info
        Session["Title"] = preMade.Name;
        Session["Total"] = preMade.Cost;
        Session["OS"] = OS.ID.ToString();
        Session["CPU"] = cPU.ID.ToString();
        Session["RAM"] = rAM.ID.ToString();
        Session["HD"] = hardDrive.ID.ToString();
        Session["Display"] = monitor.ID.ToString();
        Session["SC"] = soundCard.ID.ToString();

        // Redirect
        Response.Redirect("Computer_Details.aspx");
    }

    protected void View_Details_4_Click(object sender, EventArgs e)
    {
        // Database Context
        ShopNowDataContext db = new ShopNowDataContext();

        // PreBuild 1
        PreMade preMade = db.PreMades.FirstOrDefault(row => row.Premade_ID.Equals("2"));

        // Pull corresponding row given the selected value
        O OS = db.Os.FirstOrDefault(row => row.ID.Equals(preMade.OS_ID));
        CPU cPU = db.CPUs.FirstOrDefault(row => row.ID.Equals(preMade.CPU_ID));
        RAM rAM = db.RAMs.FirstOrDefault(row => row.ID.Equals(preMade.RAM_ID));
        HardDrive hardDrive = db.HardDrives.FirstOrDefault(row => row.ID.Equals(preMade.HardDrive_ID));
        Monitor monitor = db.Monitors.FirstOrDefault(row => row.ID.Equals(preMade.Monitor_ID));
        SoundCard soundCard = db.SoundCards.FirstOrDefault(row => row.ID.Equals(preMade.SoundCard_ID));

        // Create a Session Info
        Session["Title"] = preMade.Name;
        Session["Total"] = preMade.Cost;
        Session["OS"] = OS.ID.ToString();
        Session["CPU"] = cPU.ID.ToString();
        Session["RAM"] = rAM.ID.ToString();
        Session["HD"] = hardDrive.ID.ToString();
        Session["Display"] = monitor.ID.ToString();
        Session["SC"] = soundCard.ID.ToString();

        // Redirect
        Response.Redirect("Computer_Details.aspx");
    }


    protected void Add_to_Cart_2_Click(object sender, EventArgs e)
    {
        // Database Context
        ShopNowDataContext db = new ShopNowDataContext();

        // PreBuild 0
        PreMade preMade = db.PreMades.FirstOrDefault(row => row.Premade_ID.Equals("0"));

        // Pull corresponding row given the selected value
        O OS = db.Os.FirstOrDefault(row => row.ID.Equals(preMade.OS_ID));
        CPU cPU = db.CPUs.FirstOrDefault(row => row.ID.Equals(preMade.CPU_ID));
        RAM rAM = db.RAMs.FirstOrDefault(row => row.ID.Equals(preMade.RAM_ID));
        HardDrive hardDrive = db.HardDrives.FirstOrDefault(row => row.ID.Equals(preMade.HardDrive_ID));
        Monitor monitor = db.Monitors.FirstOrDefault(row => row.ID.Equals(preMade.Monitor_ID));
        SoundCard soundCard = db.SoundCards.FirstOrDefault(row => row.ID.Equals(preMade.SoundCard_ID));

        // Session
        Session["OS_Cart"] = OS.ID.ToString();
        Session["CPU_Cart"] = cPU.ID.ToString();
        Session["RAM_Cart"] = rAM.ID.ToString();
        Session["HD_Cart"] = hardDrive.ID.ToString();
        Session["Display_Cart"] = monitor.ID.ToString();
        Session["SC_Cart"] = soundCard.ID.ToString();
        Session["Cost"] = "$ " + preMade.Cost;

        // Redirect
        Response.Redirect("ComputerDetails_Confirmation.aspx");
    }

    protected void Add_to_Cart_3_Click(object sender, EventArgs e)
    {
        // Database Context
        ShopNowDataContext db = new ShopNowDataContext();

        // PreBuild 1
        PreMade preMade = db.PreMades.FirstOrDefault(row => row.Premade_ID.Equals("1"));

        // Pull corresponding row given the selected value
        O OS = db.Os.FirstOrDefault(row => row.ID.Equals(preMade.OS_ID));
        CPU cPU = db.CPUs.FirstOrDefault(row => row.ID.Equals(preMade.CPU_ID));
        RAM rAM = db.RAMs.FirstOrDefault(row => row.ID.Equals(preMade.RAM_ID));
        HardDrive hardDrive = db.HardDrives.FirstOrDefault(row => row.ID.Equals(preMade.HardDrive_ID));
        Monitor monitor = db.Monitors.FirstOrDefault(row => row.ID.Equals(preMade.Monitor_ID));
        SoundCard soundCard = db.SoundCards.FirstOrDefault(row => row.ID.Equals(preMade.SoundCard_ID));

        // Session
        Session["OS_Cart"] = OS.ID.ToString();
        Session["CPU_Cart"] = cPU.ID.ToString();
        Session["RAM_Cart"] = rAM.ID.ToString();
        Session["HD_Cart"] = hardDrive.ID.ToString();
        Session["Display_Cart"] = monitor.ID.ToString();
        Session["SC_Cart"] = soundCard.ID.ToString();
        Session["Cost"] = "$ " + preMade.Cost;

        // Redirect
        Response.Redirect("ComputerDetails_Confirmation.aspx");
    }

    protected void Add_to_Cart_4_Click(object sender, EventArgs e)
    {
        // Database Context
        ShopNowDataContext db = new ShopNowDataContext();

        // PreBuild 2
        PreMade preMade = db.PreMades.FirstOrDefault(row => row.Premade_ID.Equals("2"));

        // Pull corresponding row given the selected value
        O OS = db.Os.FirstOrDefault(row => row.ID.Equals(preMade.OS_ID));
        CPU cPU = db.CPUs.FirstOrDefault(row => row.ID.Equals(preMade.CPU_ID));
        RAM rAM = db.RAMs.FirstOrDefault(row => row.ID.Equals(preMade.RAM_ID));
        HardDrive hardDrive = db.HardDrives.FirstOrDefault(row => row.ID.Equals(preMade.HardDrive_ID));
        Monitor monitor = db.Monitors.FirstOrDefault(row => row.ID.Equals(preMade.Monitor_ID));
        SoundCard soundCard = db.SoundCards.FirstOrDefault(row => row.ID.Equals(preMade.SoundCard_ID));

        // Session
        Session["OS_Cart"] = OS.ID.ToString();
        Session["CPU_Cart"] = cPU.ID.ToString();
        Session["RAM_Cart"] = rAM.ID.ToString();
        Session["HD_Cart"] = hardDrive.ID.ToString();
        Session["Display_Cart"] = monitor.ID.ToString();
        Session["SC_Cart"] = soundCard.ID.ToString();
        Session["Cost"] = "$ " + preMade.Cost;

        // Redirect
        Response.Redirect("ComputerDetails_Confirmation.aspx");
    }
}