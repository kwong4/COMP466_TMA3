using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Orders : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Database Content
        ShopNowDataContext db = new ShopNowDataContext();

        // Find all orders corresponding with name
        IQueryable<Order> order_list =  db.Orders.Where(row => row.Username.Equals(Session["Username"].ToString()));

        // If any exists
        if (order_list.Any())
        {
            // Display
            Order_info.Text = "You have the following orders:";

            // Cycle through each order
            foreach (Order order in order_list)
            {

                // Pull corresponding row given the selected value
                O OS = db.Os.FirstOrDefault(row => row.ID.Equals(order.OS_ID));
                CPU cPU = db.CPUs.FirstOrDefault(row => row.ID.Equals(order.CPU_ID));
                RAM rAM = db.RAMs.FirstOrDefault(row => row.ID.Equals(order.RAM_ID));
                HardDrive hardDrive = db.HardDrives.FirstOrDefault(row => row.ID.Equals(order.HardDrive_ID));
                Monitor monitor = db.Monitors.FirstOrDefault(row => row.ID.Equals(order.Monitor_ID));
                SoundCard soundCard = db.SoundCards.FirstOrDefault(row => row.ID.Equals(order.SoundCard_ID));

                // Formatting
                orderBox.Items.Add("<br />Order #" + order.Order_ID + "<br />          PC #" +
                    order.InternalComp_ID + "<br />-------------------------------------------------------<br />           " +
                    OS.Name + "<br />          " +
                    cPU.Name + "<br />          " +
                    rAM.Name + "<br />          " +
                    hardDrive.Name + "<br />          " +
                    monitor.Name + "<br />          " +
                    soundCard.Name + "<br />          $ " +
                    order.Cost + "<br />");
            }

            // CSS Formatting
            orderBox.Attributes.Add("Style", "font-size: x-large; font-weight: strong;");
        }
        else
        {
            // Error message
            orderBox.Visible = false;
            Delete_Order_Checkboxes.Visible = false;
            Order_info.Text = "Your have no Orders... Yet!";
        }
    }

    protected void Delete_Orders_Click(object sender, EventArgs e)
    {
        // Database Content
        ShopNowDataContext db = new ShopNowDataContext();

        // Find all orders corresponding to user
        IQueryable<Order> order_list = db.Orders.Where(row => row.Username.Equals(Session["Username"].ToString()));

        // Check if any orders present
        if (order_list.Any())
        {
            // Initial Index
            int cur_index = 0;

            // Cycle through each order
            foreach (Order order in order_list)
            {
                // Check if current one is selected, if so delete
                if (orderBox.Items[cur_index].Selected)
                {
                    db.Orders.DeleteOnSubmit(order);
                }

                // Increment to next index
                cur_index++;
            }
        }
        else
        {
            // Hide information and Error message
            orderBox.Visible = false;
            Delete_Order_Checkboxes.Visible = false;
            Order_info.Text = "Your have no Orders to Delete!";
        }

        // Clear boxes and finalize database changes
        orderBox.Items.Clear();
        db.SubmitChanges();

        // Redirect
        Response.Redirect("Orders.aspx");
    }
}