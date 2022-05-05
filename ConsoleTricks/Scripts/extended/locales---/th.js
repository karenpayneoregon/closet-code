// bootbox.js locale configuration
// locale : Thai
// author : Ishmael๛

(function (global, factory) {
    'use strict';
    if (typeof define === 'function' && define.amd) {
        define(['../bootbox'], factory);
    } else if (typeof module === 'object' && module.exports) {
        factory(require('../bootbox'));
    } else {
        factory(global.bootbox);
    }
}(this, function (bootbox) {
    'use strict';
    bootbox.addLocale('th', {
        OK      : 'ตกลง',
        CANCEL  : 'ยกเลิก',
        CONFIRM : 'ยืนยัน'
    });
}));