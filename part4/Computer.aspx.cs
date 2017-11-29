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
        // Session
        Session["OS_Cart"] = "Windows 10 Home (64 bit) - 139.99";
        Session["CPU_Cart"] = "Core i5-8600K Processor, 3.5GHz w/ 9MB Cache - 334.99";
        Session["RAM_Cart"] = "HyperX Fury Series 16GB PC4-19200 DDR4 Kit (2x 8GB), Black - 219.99";
        Session["HD_Cart"] = "850 EVO Series Solid State Drive, 250GB - 109.99";
        Session["Display_Cart"] = "GC2870H 28in FHD Widescreen VA LED LCD - 239.99";
        Session["SC_Cart"] = "Xonar DGX PCI-E 5.1 Gaming Audio Card w/ Headphone Amp - 64.99";
        Session["Cost"] = "$ 1109.94";

        // Redirect
        Response.Redirect("ComputerDetails_Confirmation.aspx");
    }

    protected void Add_to_Cart_3_Click(object sender, EventArgs e)
    {
        // Session
        Session["OS_Cart"] = "Windows 10 Pro (64 bit) - 219.99";
        Session["CPU_Cart"] = "Core i7-7700K Processor, 4.20GHz w/ 8MB Cache - 499.99";
        Session["RAM_Cart"] = "Vengeance LPX 16GB DDR4 2400MHz CL14 Dual Channel Kit (2 x 8GB), Black - 249.99";
        Session["HD_Cart"] = "850 EVO Series Solid State Drive, 500GB - 179.99";
        Session["Display_Cart"] = "Optix G24C 23.6in FHD Widescreen Curved VA LED LCD w/ AMD FreeSync, 144Hz - 329.99";
        Session["SC_Cart"] = "Sound Blaster Z PCI-E 5.1 Sound Card w/ Beamforming Microphone - 129.99";
        Session["Cost"] = "$ 1529.94";

        // Redirect
        Response.Redirect("ComputerDetails_Confirmation.aspx");
    }

    protected void Add_to_Cart_4_Click(object sender, EventArgs e)
    {
        // Session
        Session["OS_Cart"] = "Windows 7 Professional (64 bit) - 209.99";
        Session["CPU_Cart"] = "Core i5-7600K Processor, 3.80GHz w/ 6MB Cache - 259.99";
        Session["RAM_Cart"] = "Vengeance LPX 8GB DDR4 2400MHz CL14 DIMM (1 x 8GB), Black - 124.99";
        Session["HD_Cart"] = "4TB BarraCuda HDD, SATA III w/ 256MB Cache - 139.99";
        Session["Display_Cart"] = "GW2270 21.5in Widescreen VA LED LCD - 99.99";
        Session["SC_Cart"] = "USB Stereo Audio Adaptor - 14.99";
        Session["Cost"] = "$ 849.94";

        // Redirect
        Response.Redirect("ComputerDetails_Confirmation.aspx");
    }
}