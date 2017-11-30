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
        if (Session["OS_Cart"] != null)
        {
            // Database Content
            ShopNowDataContext db = new ShopNowDataContext();

            // Pull corresponding row given the selected value
            O OS = db.Os.FirstOrDefault(row => row.ID.Equals(Session["OS_Cart"].ToString()));
            CPU cPU = db.CPUs.FirstOrDefault(row => row.ID.Equals(Session["CPU_Cart"].ToString()));
            RAM rAM = db.RAMs.FirstOrDefault(row => row.ID.Equals(Session["RAM_Cart"].ToString()));
            HardDrive hardDrive = db.HardDrives.FirstOrDefault(row => row.ID.Equals(Session["HD_Cart"].ToString()));
            Monitor monitor = db.Monitors.FirstOrDefault(row => row.ID.Equals(Session["Display_Cart"].ToString()));
            SoundCard soundCard = db.SoundCards.FirstOrDefault(row => row.ID.Equals(Session["SC_Cart"].ToString()));

            // Check if first cart item
            if (Session["CartLength"] == null)
            {
                // Create first Cart Item
                Session["CartLength"] = "1";
                string[] cartitems = new string[] { Session["OS_Cart"].ToString(), Session["CPU_Cart"].ToString(), Session["RAM_Cart"].ToString(), Session["HD_Cart"].ToString(), Session["Display_Cart"].ToString(), Session["SC_Cart"].ToString(), Session["Cost"].ToString() };
                Session["CartItem1"] = cartitems;
            }
            else
            {
                // Create next Cart item
                Session["CartLength"] = (Convert.ToInt32((string)Session["CartLength"]) + 1).ToString();
                string[] cartitems = new string[] { Session["OS_Cart"].ToString(), Session["CPU_Cart"].ToString(), Session["RAM_Cart"].ToString(), Session["HD_Cart"].ToString(), Session["Display_Cart"].ToString(), Session["SC_Cart"].ToString(), Session["Cost"].ToString() };
                Session["CartItem" + Session["CartLength"].ToString()] = cartitems;
            }

            // Display information that was added to cart
            Confirmation_Label.Text = "You have added a Computer with the following information to the cart:";
            OS_Cart_Label.Text = OS.Name;
            CPU_Cart_Label.Text = cPU.Name;
            RAM_Cart_Label.Text = rAM.Name;
            HD_Cart_Label.Text = hardDrive.Name;
            Display_Cart_Label.Text = monitor.Name;
            SC_Cart_Label.Text = soundCard.Name;
            Cost_Label.Text = (String)Session["Cost"];

            // Null all the info added
            Session["OS_Cart"] = null;
            Session["CPU_Cart"] = null;
            Session["RAM_Cart"] = null;
            Session["HD_Cart"] = null;
            Session["Display_Cart"] = null;
            Session["SC_Cart"] = null;
            Session["Cost"] = null;
        }
        else
        {
            // Error Message
            Confirmation_Label.Text = "Invalid navigation to 'Add Cart Confirmation'";
        }
    }
}