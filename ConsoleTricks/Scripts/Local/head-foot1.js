$(document).ready(function (e) {

    var pageTitle = "OPTIONAL HEADER";

    var incomingPageTitle = $(document).find("title").text();

    if (incomingPageTitle === "Bootstrap spacing" || incomingPageTitle === "1099g step 1") {
        pageTitle = "LOGIN";
    } else if ($(document).find("title").text() === "Flex basics") {
        // do nothing
    } else {
        $('body').css("padding", "40px");
        $(document.body).prepend("<div id='header' class='d-flex p-5 justify-content-center text-muted'>" + pageTitle + "</div>");
    }

    $(document.body).append("<div id='indexFooter' class='footer'><a href='https://www.oregon.gov/employ/pages/default.aspx'>Employment Department</a></div>");

});