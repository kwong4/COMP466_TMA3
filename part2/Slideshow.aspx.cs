using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Slideshow : System.Web.UI.Page
{

    // Global variables to keep track 
    int counter;
    int max_images;
    int slideshow;
    HttpCookie myCookie;
    static Random random = new Random();
    System.Timers.Timer aTimer;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Resolve counter
        counter = ViewState["counter"] != null ? Convert.ToInt32(ViewState["counter"]) : 0;

        // Resolve Slideshow text
        Slideshow_button.Text = ViewState["play_button"] != null ? ViewState["play_button"].ToString() : "Start";

        string ordering = ViewState["ordering"] != null ? ViewState["ordering"].ToString() : "Sequential";

        // Resolve Playbutton setup
        if (ordering != "Sequential")
        {
            Order_update();
        }

        // Database Context
        SlideshowDataContext db = new SlideshowDataContext();

        // Resolve Max image count
        max_images = db.Images.Count();

        // Update Slideshow image
        Slideshow_image_update();
    }

    protected void Next_button_Click(object sender, EventArgs e)
    {

        // Increase the counter
        counter++;

        // Cycle back to the beginning if past the number of images
        counter = counter % max_images;

        // Update ViewState of counter
        ViewState["counter"] = counter.ToString();

        // Update Slideshow image
        Slideshow_image_update();
    }

    protected void Prev_button_Click(object sender, EventArgs e)
    {
        // Increase the counter
        counter--;

        // Cycle back to the beginning if past the number of images
        counter = (counter + max_images) % max_images;

        // Update ViewState of counter
        ViewState["counter"] = counter.ToString();

        // Update Slideshow image
        Slideshow_image_update();
    }

    protected void Slideshow_image_update()
    {
        // Database Context
        SlideshowDataContext db = new SlideshowDataContext();

        // Get the current image URL
        Image current_image = db.Images.FirstOrDefault(row => row.Image_ID.Equals(counter));

        // Set the caption
        caption_Label.Text = current_image.Image_Caption;

        // Set the image
        Slideshow_Image.ImageUrl = current_image.Image_URL;
    }

    protected void Slideshow_button_Click(Object sender, EventArgs e)
    {
        if (Slideshow_button.Text == "Start")
        {
            // Update Text and save ViewState
            Slideshow_button.Text = "Stop";
            Slideshow_Timer.Enabled = true;
            ViewState["play_button"] = "Stop";
        }
        else
        {
            // Update Text  and save ViewState
            Slideshow_button.Text = "Start";
            Slideshow_Timer.Enabled = false;
            ViewState["play_button"] = "Start";
        }

    }

    protected void Slideshow_transition(Object source, EventArgs e)
    {

        if (Ordering_dropdown.SelectedValue == "Sequential")
        {
            // Increase the counter
            counter++;
        }
        else
        {
            // Random image
            counter = random.Next(1, 20);
        }

        // Cycle back to the beginning if past the number of images
        counter = (counter + max_images) % max_images;

        // Update ViewState of counter
        ViewState["counter"] = counter.ToString();

        // Update Slideshow image
        Slideshow_image_update();
    }

    protected void Ordering_dropdown_SelectedIndexChanged(Object sender, EventArgs e)
    {
        // Update function
        Order_update();
    }

    protected void Order_update()
    {
        if (Ordering_dropdown.SelectedValue == "Sequential")
        {
            // Shows manual controls if sequential
            Next_button.Visible = true;
            Prev_button.Visible = true;
        }
        else
        {
            // Shows manual controls if random
            Next_button.Visible = false;
            Prev_button.Visible = false;
        }

        // Update ViewState of counter
        ViewState["ordering"] = Ordering_dropdown.SelectedValue;
    }
}