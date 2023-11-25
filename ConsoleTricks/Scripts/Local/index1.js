document.addEventListener("DOMContentLoaded", () => {

    document.getElementById("btnNotifications").addEventListener("click", function () {

        var value = parseInt(document.getElementById('lblIncrement').innerText);
        var newValue = value + 1;
        document.getElementById('lblIncrement').innerText = newValue;

    });

    document.getElementById("btnGetNotificationCount").addEventListener("click", function () {

        var value = parseInt(document.getElementById('lblIncrement').innerText);

        if (value === 0) {
            kendoConsole.log('No notifications');
        } else {
            kendoConsole.log(`Notification count ${value}`);
        }
    });

    document.getElementById("btnShowCurrentTime").addEventListener("click", function () {
        kendoConsole.log(`It is ${showDateTime() }`);
    });

});

document.addEventListener('keydown', function (event) {

    if (event.key === '1' && event.altKey && event.ctrlKey) {
        var x = document.getElementById('kendoDisplay');
        x.style.display = x.style.display === 'block' ? 'none' : 'block';
    }

});
function showDateTime() {
    var months = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];
    var days = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
    var d = new Date();
    var day = days[d.getDay()];
    var hr = d.getHours();
    var min = d.getMinutes();
    if (min < 10) {
        min = "0" + min;
    }
    var ampm = "am";
    if (hr > 12) {
        hr -= 12;
        ampm = "pm";
    }
    var date = d.getDate();
    var month = months[d.getMonth()];
    var year = d.getFullYear();
    return `${day} ${hr}:${min}${ampm} ${date} ${month} ${year}`;
    
}
