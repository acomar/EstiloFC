var AjaxEvents = (function () {
    return {
        ajaxError: function (result) {
            if (result.status === 401)
                Modal.showModal($("#modalLogin"));
        },
        ajaxBeforeSend: function (result) {
            $("#divLoading").show();
        },
        ajaxComplete: function (result) {
            $("#divLoading").hide();
        }
    };
})();

$.ajaxSetup({
    beforeSend: AjaxEvents.ajaxBeforeSend,
    complete: AjaxEvents.ajaxComplete,
    error: AjaxEvents.ajaxError,
    cache: false,
    global: true
});



