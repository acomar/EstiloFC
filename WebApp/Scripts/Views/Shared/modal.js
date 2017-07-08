var Modal = (function () {
    return {
        showSuccessMessage: function (message, buttonOk) {
            Modal.showStatusMessage(message, buttonOk, "Sucesso");
        },
        showStatusMessage: function (message, buttonOk, status) {
            var modal = $("#modalMessage");
            modal.find("#titleMessage").html(status);
            modal.find("#message").html(message);
            Modal.setButtonOkEvent(buttonOk);
            Modal.showModal(modal);
        },
        setButtonOkEvent: function (buttonOk) {
            $('body').off('click', '#okMessage');
            if (buttonOk != undefined)
                $('body').on('click', '#okMessage', buttonOk);
            $('body').on('click', '#okMessage', Modal.hideModal);
        },
        showModal: function (divModal) {
            var html = Modal.setHtmlModal(divModal);
            $("#loaded-content").show();
            $("#loaded-content").html(html);
            Modal.loadFadeInModal();
            Modal.loadCloseModalButton();            
        },
        setHtmlModal: function (divModal) {
            if (typeof (divModal) == 'object')
                return divModal.html();
            else
                return divModal;
        },
        loadFadeInModal: function () {
            $("#modal-overlay").fadeIn(100, function () {
                $("#modal").animate({                    
                    marginTop: -($("#modal").height() / 2)
                }, 200);
            });
        },
        loadCloseModalButton: function () {
            $("#bt-close-modal").on("click", function (e) {
                Modal.hideModal();
            });
        },
        hideModal: function () {
            $("#modal-overlay").fadeOut(300)
            $("#modal").animate({
                marginTop: "-1000px"
            }, 300);
            $("#modal #loaded-content").hide();
        }
    }
})();
