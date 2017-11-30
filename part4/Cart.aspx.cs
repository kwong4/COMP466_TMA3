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
            setuperror();
        }
        else
        {
            setupitems(Convert.ToInt32(Session["CartLength"]));
        }
    }

    protected void setuperror()
    {
        Cart_Label.Text = "Your Cart is empty.";
        checkout_Button.Visible = false;
        cartBox.Visible = false;
        Delete_Checkboxes.Visible = false;
    }

    protected void setupitems(int length)
    {
        // Database Context
        ShopNowDataContext db = new ShopNowDataContext();

        for (int i = 1; i <= length; i++)
        {
            string[] cartitems = (string[])Session["CartItem" + i];

            // Pull corresponding row given the selected value
            O OS = db.Os.FirstOrDefault(row => row.ID.Equals(cartitems[0]));
            CPU cPU = db.CPUs.FirstOrDefault(row => row.ID.Equals(cartitems[1]));
            RAM rAM = db.RAMs.FirstOrDefault(row => row.ID.Equals(cartitems[2]));
            HardDrive hardDrive = db.HardDrives.FirstOrDefault(row => row.ID.Equals(cartitems[3]));
            Monitor monitor = db.Monitors.FirstOrDefault(row => row.ID.Equals(cartitems[4]));
            SoundCard soundCard = db.SoundCards.FirstOrDefault(row => row.ID.Equals(cartitems[5]));

            cartBox.Items.Add("<br />PC #" + i + "<br />          " +
                OS.Name + "<br />          " +
                cPU.Name + "<br />          " +
                rAM.Name + "<br />          " +
                hardDrive.Name + "<br />          " +
                monitor.Name + "<br />          " +
                soundCard.Name + "<br />          " +
                cartitems[6] + "<br />");
        }
        cartBox.Attributes.Add("Style", "font-size: x-large; font-weight: strong;");
    }

    protected void checkout_Button_Click(object sender, EventArgs e)
    {
        // Redirect
        Response.Redirect("Checkout.aspx");
    }

    protected void Delete_Checkboxes_Click(object sender, EventArgs e)
    {
        int cur_index = 0;

        for (int i = 0; i < cartBox.Items.Count; i++)
        {
            if (cartBox.Items[i].Selected)
            {
                if (Convert.ToInt32(Session["CartLength"]) == 1)
                {
                    Session["CartLength"] = null;
                    setuperror();
                    cartBox.Items.Clear();
                }
                else
                {
                    Session["CartLength"] = (Convert.ToInt32(Session["CartLength"]) - 1).ToString();
                    cartBox.Items.RemoveAt(i);
                }
            }
            else
            {
                cur_index++;
                Session["CartItem" + cur_index] = (string[])Session["CartItem" + (i + 1)];
            }
        }
        // Redirect
        Response.Redirect("Cart.aspx");
    }
}