$(function () {
    ForgotPasswordForm.validate();
    $("#showModalForgotPassword").click(ForgotPassword.showModalForgorPassword);
    $("#sendPassword").click(ForgotPassword.sendForgottenPassword);
});

var ForgotPasswordForm = (function () {
    return {
        validate: function () {
            $('#formForgotPassword').validate(
            {
                rules: {
                    emailToSendPassword: {
                        required: true,
                        email: true
                    }
                },
                messages:
                {
                    emailToSendPassword: {
                        required: this.defaultMessage(),
                        email: "E-mail inv&aacute;lido",
                    }
                }
            });
        },
        defaultMessage: function () {
            return '';
        }
    }
})();

var ForgotPassword = (function () {
    return {
        sendForgottenPassword: function () {
            if (!$("#formForgotPassword").valid())
                return false;
            var url = '/Account/SendForgottenPassword';
            var data = {
                sendTo: $("#emailToSendPassword").val()
            };
            $.ajax({
                url: url,
                type: 'POST',
                data: data,
                success: ForgotPassword.successSendForgottenPassword
            });
        },
        successSendForgottenPassword: function () {            
            $("#mensagemPasswordSendSuccess").html('E-mail enviado com sucesso.');
        }
    }
})();
