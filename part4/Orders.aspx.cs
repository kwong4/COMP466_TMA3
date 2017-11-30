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

        IQueryable<Order> order_list =  db.Orders.Where(row => row.Username.Equals(Session["Username"].ToString()));

        if (order_list.Any())
        {
            Order_info.Text = "You have the following orders:";

            foreach (Order order in order_list)
            {

                // Pull corresponding row given the selected value
                O OS = db.Os.FirstOrDefault(row => row.ID.Equals(order.OS_ID));
                CPU cPU = db.CPUs.FirstOrDefault(row => row.ID.Equals(order.CPU_ID));
                RAM rAM = db.RAMs.FirstOrDefault(row => row.ID.Equals(order.RAM_ID));
                HardDrive hardDrive = db.HardDrives.FirstOrDefault(row => row.ID.Equals(order.HardDrive_ID));
                Monitor monitor = db.Monitors.FirstOrDefault(row => row.ID.Equals(order.Monitor_ID));
                SoundCard soundCard = db.SoundCards.FirstOrDefault(row => row.ID.Equals(order.SoundCard_ID));

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
            orderBox.Attributes.Add("Style", "font-size: x-large; font-weight: strong;");
        }
        else
        {
            orderBox.Visible = false;
            Delete_Order_Checkboxes.Visible = false;
            Order_info.Text = "Your have no Orders... Yet!";
        }
    }

    protected void Delete_Orders_Click(object sender, EventArgs e)
    {
        // Database Content
        ShopNowDataContext db = new ShopNowDataContext();

        IQueryable<Order> order_list = db.Orders.Where(row => row.Username.Equals(Session["Username"].ToString()));

        if (order_list.Any())
        {
            int cur_index = 0;

            foreach (Order order in order_list)
            {
                if (orderBox.Items[cur_index].Selected)
                {
                    db.Orders.DeleteOnSubmit(order);
                }

                cur_index++;
            }
        }
        else
        {
            orderBox.Visible = false;
            Delete_Order_Checkboxes.Visible = false;
            Order_info.Text = "Your have no Orders to Delete!";
        }

        orderBox.Items.Clear();
        db.SubmitChanges();

        // Redirect
        Response.Redirect("Orders.aspx");
    }
}