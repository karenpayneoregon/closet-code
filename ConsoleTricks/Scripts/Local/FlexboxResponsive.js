$(document).ready(function () {
    $('#saveMe').click(function (event) {
        bootbox.confirm({
                title: "OED - Question", closeButton: false,
                message: "Continue with save?",
            className: 'jackInTheBox animated',
                buttons: {
                    confirm: {
                        label: 'Yes',
                        className: 'btn-success'
                    },
                    cancel: {
                        label: 'No',
                        className: 'btn-info'
                    }
                },
                callback: function (result) {
                    console.log('This was logged in the callback: ' + result);
                }
            }).find(".modal-dialog")
            .addClass("modal-dialog-centered");
    });

    $('#cancelMe').click(function (event) {
        bootbox.confirm({
                title: "BAD Use of colors", closeButton: false,
                message: "Discard changes?",
                //className: 'jackInTheBox animated',
                buttons: {
                    confirm: {
                        label: 'Yes',
                        className: 'btn-danger'
                    },
                    cancel: {
                        label: 'No',
                        className: 'btn-primary'
                    }
                },
                callback: function (result) {
                    console.log('This was logged in the callback: ' + result);
                }
            }).find(".modal-dialog")
            .addClass("modal-dialog-centered")
            .find('.modal-content').css({ 'background-color': 'red', 'font-weight': 'bold', color: 'white', 'font-size': '2em', 'font-weight': 'bold' });


        //bootbox.alert('Danger!!' ).find('.modal-content').css({'background-color': '#f99', 'font-weight' : 'bold', color: '#F00', 'font-size': '2em', 'font-weight' : 'bold'} )
    });
});