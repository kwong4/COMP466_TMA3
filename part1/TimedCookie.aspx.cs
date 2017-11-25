using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TimedCookie : System.Web.UI.Page
{
    protected void Page_Init(object sender, EventArgs e)
    {
        // Obtain Cookie
        HttpCookie myCookie = Request.Cookies["myCookie"];

        // Number of Visits
        int numVisits;

        // If No cookie found or cookie expired.
        if (myCookie == null)
        {

            // First visit
            FirstVisit();

            // Set visits to 0
            numVisits = 0;
        }
        // Cookie was found
        else
        {
            if (!string.IsNullOrEmpty(myCookie.Values["numVisits"]))
            {
                // Find current number of visits
                numVisits = Convert.ToInt32(myCookie.Values["numVisits"]) + 1;

                // Set numVisits Cookie to numVisits
                myCookie.Values["numVisits"] = numVisits.ToString();
            }
            // Cookie present but is NULL or EMPTY
            else
            {
                // Set numVisits Cookie to 0
                myCookie.Values["numVisits"] = "0";

                // Set visits to 0
                numVisits = 0;
            }

            // Set cookie expiry date-time. Made it to last for a year.
            myCookie.Expires = DateTime.Now.AddYears(1);

            // Write the cookie to client.
            Response.Cookies.Add(myCookie);
        }

        // Display Number of Visits by Client Computer
        visit_Label.Text = numVisits.ToString();

        // Display IP Address of user
        ip_Label.Text = GetIPAddress();
    }

    // Grab IP Address
    protected string GetIPAddress()
    {
        // Find Server Context and Request the HTTP_X_FORWARDED_FOR
        HttpContext context = HttpContext.Current;
        string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

        // If Forwarded
        if (!string.IsNullOrEmpty(ipAddress))
        {
            // Seperate the multiple addresses and get the first one
            string[] addresses = ipAddress.Split(',');
            if (addresses.Length != 0)
            {
                return addresses[0];
            }
        }

        // Return the address if not forwarded
        return context.Request.ServerVariables["REMOTE_ADDR"];
    }

    // Set Cookie for First Visit
    protected void FirstVisit()
    {
        // Create a cookie
        HttpCookie myFirstCookie = new HttpCookie("myCookie");

        // Set numVisits Cookie to 0
        myFirstCookie.Values.Add("numVisits", "0");

        // Set cookie expiry date-time. Made it to last for a year.
        myFirstCookie.Expires = DateTime.Now.AddYears(1);

        // Write the cookie to client.
        Response.Cookies.Add(myFirstCookie);
    }

}