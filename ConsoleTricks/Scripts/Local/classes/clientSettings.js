var $clientSettings = $clientSettings || {};
$clientSettings = function () {
    var language;

    var init = function (e) {
        if (e === "") {
            language = 'E';
        } else {
            language = e.toUpperCase() === 'E' ? 'E' : 'S';
        }
    };

    this.getCurrentLanguage = function () {
        return language;
    };

    this.isEnglish = function () {
        return getCurrentLanguage() === 'E';
    };

    this.isSpanish = function () {
        return getCurrentLanguage() === 'S';
    };


    return {
        init: init,
        isEnglish: isEnglish,
        isSpanish: isSpanish,
        getCurrentLanguage: getCurrentLanguage
    };
}();