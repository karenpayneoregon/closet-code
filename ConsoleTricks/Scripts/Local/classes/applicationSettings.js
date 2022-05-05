var $applicationSettings = $applicationSettings || {};
$applicationSettings = function () {

    var init = function (e) {
        $clientSettings.init(e);
    };

    return {
        init: init
    };
}();