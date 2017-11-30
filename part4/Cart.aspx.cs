using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CartLength"] == null)
        {
            // Error if no items
            setuperror();
        }
        else
        {
            // Show Cart items
            setupitems(Convert.ToInt32(Session["CartLength"]));
        }
    }

    protected void setuperror()
    {
        // Hide information and show Error
        Cart_Label.Text = "Your Cart is empty.";
        checkout_Button.Visible = false;
        cartBox.Visible = false;
        Delete_Checkboxes.Visible = false;
    }

    protected void setupitems(int length)
    {
        // Database Context
        ShopNowDataContext db = new ShopNowDataContext();

        // Cycle through all items
        for (int i = 1; i <= length; i++)
        {
            // Pull string array of items
            string[] cartitems = (string[])Session["CartItem" + i];

            // Pull corresponding row given the selected value
            O OS = db.Os.FirstOrDefault(row => row.ID.Equals(cartitems[0]));
            CPU cPU = db.CPUs.FirstOrDefault(row => row.ID.Equals(cartitems[1]));
            RAM rAM = db.RAMs.FirstOrDefault(row => row.ID.Equals(cartitems[2]));
            HardDrive hardDrive = db.HardDrives.FirstOrDefault(row => row.ID.Equals(cartitems[3]));
            Monitor monitor = db.Monitors.FirstOrDefault(row => row.ID.Equals(cartitems[4]));
            SoundCard soundCard = db.SoundCards.FirstOrDefault(row => row.ID.Equals(cartitems[5]));

            // Format to show use
            cartBox.Items.Add("<br />PC #" + i + "<br />          " +
                OS.Name + "<br />          " +
                cPU.Name + "<br />          " +
                rAM.Name + "<br />          " +
                hardDrive.Name + "<br />          " +
                monitor.Name + "<br />          " +
                soundCard.Name + "<br />          " +
                cartitems[6] + "<br />");
        }
        // Formatting
        cartBox.Attributes.Add("Style", "font-size: x-large; font-weight: strong;");
    }

    protected void checkout_Button_Click(object sender, EventArgs e)
    {
        // Redirect
        Response.Redirect("Checkout.aspx");
    }

    protected void Delete_Checkboxes_Click(object sender, EventArgs e)
    {
        // Initial Index
        int cur_index = 0;

        // Cycle through all of boxes
        for (int i = 0; i < cartBox.Items.Count; i++)
        {
            // Check if selected
            if (cartBox.Items[i].Selected)
            {
                // Check if last item
                if (Convert.ToInt32(Session["CartLength"]) == 1)
                {
                    // Show empty box and clear Session Data
                    Session["CartLength"] = null;
                    setuperror();
                    cartBox.Items.Clear();
                }
                else
                {
                    // Remove Box and lower count
                    Session["CartLength"] = (Convert.ToInt32(Session["CartLength"]) - 1).ToString();
                    cartBox.Items.RemoveAt(i);
                }
            }
            else
            {
                // Next index and reset Seesion Data
                cur_index++;
                Session["CartItem" + cur_index] = (string[])Session["CartItem" + (i + 1)];
            }
        }
        // Redirect
        Response.Redirect("Cart.aspx");
    }
}