if (typeof jQuery == 'undefined') {
    console.log('jQuery hasn\'t loaded');
} else {
    console.log('jQuery has loaded');
}
$(document).ready(function () {

    class CaseInsensitiveSet extends Set {
        constructor(values) {
            super(Array.from(values, it => it.toLowerCase()));
        }

        add(value) {
            return super.add(value.toLowerCase());
        }

        has(value) {
            return super.has(value.toLowerCase());
        }

        delete(value) {
            return super.delete(value.toLowerCase());
        }
    }

    var getUrlParameter = function getUrlParameter(pParameter) {

        var pageUrl = window.location.search.substring(1),
            urlVariables = pageUrl.split('&'),
            parameterName,
            index;

        for (index = 0; index < urlVariables.length; index++) {
            parameterName = urlVariables[index].split('=');

            if (parameterName[0] === pParameter) {
                return parameterName[1] === undefined ? true : decodeURIComponent(parameterName[1]);
            } else {
                return "";
            }
        }

        return "satisfy the compiler";
    };


    $applicationSettings.init(getUrlParameter('lang'));


    // Increment counter
    $('#btnNotifications').click(function () {
        var value = parseInt($('#lblIncrement').text());
        var newValue = value + 1;
        $('#lblIncrement').text(newValue);
        //kendoConsole.log("Notification count " + newValue, true);
    });

    //$('#btnNotifications').click(function () {
    //    let arr = ['Movies', 'Cars', 'Games', 'Hike'];

    //    kendoConsole.log(arr.includes('games'));
    //    kendoConsole.log(arr.includes('Games'));

    //});

    //
    // get count from #lblIncrement
    //
    $('#btnGetNotificationCount').click(function (event) {

        var value = parseInt($('#lblIncrement').text());
        kendoConsole.log("Notification count " + value);

        //var countryArray = ["Usa", "Canada", "France"];
        //const countries = new CaseInsensitiveSet(countryArray);

        //var country = "usa";
        //console.log(`countries contains '${country}' ${countries.has(country)}`);
        //country = "Russia";
        //console.log(`countries contains '${country}' ${countries.has(country)}`);

    });

    $('#badgeLikeUs').click(function (event) {

        $('#btnPrimary').focus();

        bootbox.confirm({
            title: "Hey you!!!!", closeButton: false,
            message: "stay will remain on this page, leave will return you to the main menu",
            className: 'zoomIn animated',
            buttons: {
                confirm: {
                    label: $clientSettings.isEnglish() ? 'Leave' : 'Espalda',
                    className: 'btn-success'
                },
                cancel: {
                    label: $clientSettings.isEnglish() ? 'Stay' : 'Confirmar',
                    className: 'btn-info'
                }
            },
            callback: function (result) {
                console.log('This was logged in the callback: ' + result);
            }
        }).find(".modal-dialog")
            .addClass("modal-dialog-centered");



    });

    $('input#alloptions').maxlength({
        alwaysShow: true,
        threshold: 10,
        warningClass: "badge label-success",
        limitReachedClass: "badge label-danger",
        separator: ' of ',
        preText: 'You have ',
        postText: ' chars remaining.'
    });




});