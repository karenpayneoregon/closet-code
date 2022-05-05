$(document).ready(function (e) {
    $(document.body).append("<div id='indexFooter' class='footer'><a href='https://www.oregon.gov/employ/pages/default.aspx'>Employment Department</a></div>");
    var normalColor = $('a:link').css('color');
    $('a').click(function () {
        $('a:visited').css('color', normalColor);
    });    
});
