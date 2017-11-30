using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Checkout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CartLength"] == null)
        {
            // Error message
            setuperror();
        }
        else
        {
            // Database Context
            ShopNowDataContext db = new ShopNowDataContext();

            // Initial variables
            Checkout_info.Text = "";
            double total = 0;
            Guid guid = Guid.NewGuid();

            // Cycle through whole cart
            for (int i = 1; i <= Convert.ToInt32(Session["CartLength"]); i++)
            {

                // Get current cart items
                string[] cartitems = (string[])Session["CartItem" + i];

                // Pull corresponding row given the selected value
                O OS = db.Os.FirstOrDefault(row => row.ID.Equals(cartitems[0]));
                CPU cPU = db.CPUs.FirstOrDefault(row => row.ID.Equals(cartitems[1]));
                RAM rAM = db.RAMs.FirstOrDefault(row => row.ID.Equals(cartitems[2]));
                HardDrive hardDrive = db.HardDrives.FirstOrDefault(row => row.ID.Equals(cartitems[3]));
                Monitor monitor = db.Monitors.FirstOrDefault(row => row.ID.Equals(cartitems[4]));
                SoundCard soundCard = db.SoundCards.FirstOrDefault(row => row.ID.Equals(cartitems[5]));

                // Format correctly
                Checkout_info.Text += "<br />PC #" + i + "<br />          " +
                    OS.Name + "<br />          " +
                    cPU.Name + "<br />          " +
                    rAM.Name + "<br />          " +
                    hardDrive.Name + "<br />          " +
                    monitor.Name + "<br />          " +
                    soundCard.Name + "<br />          " +
                    cartitems[6] + "<br />";

                // Find total
                total += Convert.ToDouble(cartitems[6].Substring(2, cartitems[6].Length - 2));

                // Create order item for the info to be inserted
                Guid internal_guid = Guid.NewGuid();
                Order order = new Order();
                order.Order_ID = guid;
                order.InternalComp_ID = internal_guid;
                order.OS_ID = OS.ID;
                order.CPU_ID = cPU.ID;
                order.RAM_ID = rAM.ID;
                order.HardDrive_ID = hardDrive.ID;
                order.Monitor_ID = monitor.ID;
                order.SoundCard_ID = soundCard.ID;
                order.Cost = cartitems[6].Substring(2, cartitems[6].Length - 2);
                
                // Check if Guest or logged in
                if (Session["Username"] == null)
                {
                    order.Username = "";
                }
                else
                {
                    order.Username = Session["Username"].ToString();
                }

                // Insert row
                db.Orders.InsertOnSubmit(order);
            }
            // Formatting
            Checkout_info.Text += "<br />";
            Checkout_info.Text += "Total: " + total;
            Checkout_Label.Text = "Thank you for your purchase!";

            // Reset Session data and submit database changes
            Session["CartLength"] = null;
            db.SubmitChanges();
        }
    }

    protected void setuperror()
    {
        // Hide info and Error message
        Checkout_Label.Text = "Please go through the proper channels to obtain this page";
        Checkout_info.Visible = false;
    }
}