$(function () {    
    $("#showModalEditPassword").click(EditPassword.showModal);
    $("body").on('click', '#editPassword', User.editPassword);
});

var FormEditPassword = (function () {
    return {
        validate: function () {
            $('#formEditPassword').validate(
            {
                rules: {
                    currentPassword: {
                        required: true
                    },
                    newPassword: {
                        minlength: 6,
                        required: true
                    },
                    confirmPassword: {
                        equalTo: "#newPassword",
                        required: true
                    },
                    highlight: function (element) {
                        $(element).closest('.control-group').removeClass('success').addClass('error');
                    },
                    success: function (element) {
                        element.closest('.control-group').removeClass('error').addClass('success');
                    }
                },
                messages:
                {
                    currentPassword: {
                        required: this.defaultMessage()
                    },
                    newPassword: {
                        required: this.defaultMessage(),
                        minlength: "Campo deve ter no m&iacute;nimo 6 caracteres"
                    },
                    confirmPassword: {
                        required: this.defaultMessage(),
                        equalTo: "Confirma&ccedil;&atilde;o de senha inv&aacute;lida"
                    }
                }
            });
        },
        defaultMessage: function () {
            return '';
        }
    }
})();

var EditPassword = (function () {
    return {
        showModal: function () {
            Modal.showModal($("#modalEditPassword"));
        }
    }
})();