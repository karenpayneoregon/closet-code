var $commonUtils = $commonUtils || {};
$commonUtils = function () {

    var stringStripToInt = function (sender) {
        return sender.replace(/\D/g, '');
    };

    var stringStripToDecimal = function (sender) {
        return sender.replace(/[^\d.-]/g, '');
    };

    var isValidWithDashesSSN = function (sender) {

        var ssnPattern = /^[0-9]{3}\-?[0-9]{2}\-?[0-9]{4}$/;
        return ssnPattern.test(sender);
    };

    var translated = function(sender) {

        return sender.toHtmlEntities();
    };

    String.prototype.toHtmlEntities = function () {
        return this.replace(/./gm, function (value) {
            return (value.match(/[a-z0-9\s]+/i)) ? value : "&#" + value.charCodeAt(0) + ";";
        });
    };

    String.fromHtmlEntities = function (string) {
        return (string + "").replace(/&#\d+;/gm,
            function (value) {
                return String.fromCharCode(value.match(/\d+/gm)[0]);
            });
    };

    return {
        isValidWithDashesSSN: isValidWithDashesSSN,
        stringStripToInt: stringStripToInt,
        stringStripToDecimal: stringStripToDecimal
    };

}();