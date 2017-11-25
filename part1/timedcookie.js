/*
COMP466 Assignment 3: Part 1 - timedcookie.js
Name: Kevin Wong							
ID: 3339323								
*/

// Load Client Computer's Timezone'
function loadTimeZone() {

    // Find TimeZone Offset
    var timeZoneOffset = new Date().getTimezoneOffset().toString();
    timeZoneOffset = (timeZoneOffset / 60) * -1;

    // Initial time zone string
    var gmt = 'GMT'

    // Find out time zone string
    if (timeZoneOffset !== 0) {
        gmt += timeZoneOffset > 0 ? ' +' : ' ';
        gmt += timeZoneOffset;
    }

    // Set timezone Label
    document.getElementById("zone_Label").innerHTML = gmt;
}

// Initial setup function
function start() {

    // Time zone
    loadTimeZone();
}

// Start after page loads
window.addEventListener("load", start, false);