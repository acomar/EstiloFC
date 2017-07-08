$(function () {
    RegisterForm.validate();
    $("#cpf").mask("999.999.999-99");
    $("#birthday").mask("99/99/9999");
    $("#birthday").blur(function () { ValidateFields.isBrazilianDate($(this)); });
    $("#register").click(User.createUser);
});

var RegisterForm = (function () {
    return {
        validate: function () {
            $('#formRegister').validate(
            {
                rules: {
                    firstName: {
                        required: true
                    },
                    lastName: {
                        required: true
                    },
                    areaCode: {
                        required: true
                    },
                    number: {
                        required: true
                    },
                    birthday: {
                        required: true
                    },
                    email: {
                        required: true,
                        email: true
                    },
                    confirmEmail: {
                        equalTo: "#email",
                        required: true,
                        email: true
                    },
                    password: {
                        minlength: 6,
                        required: true
                    },
                    confirmPassword: {
                        minlength: 6,
                        equalTo: "#password",
                        required: true
                    },
                    cpf: {
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
                    firstName: {
                        required: this.defaultMessage()
                    },
                    lastName: {
                        required: this.defaultMessage()
                    },
                    areaCode: {
                        required: this.defaultMessage()
                    },
                    number: {
                        required: this.defaultMessage()
                    },
                    birthday: {
                        required: this.defaultMessage()
                    },
                    email: {
                        required: this.defaultMessage(),
                        email: "E-mail inv&aacute;lido",
                    },
                    confirmEmail: {
                        required: this.defaultMessage(),
                        email: "E-mail inv&aacute;lido",
                        equalTo: "Confirma&ccedil;&atilde;o de e-mail inv&aacute;lida"
                    },
                    password: {
                        required: this.defaultMessage(),
                        minlength: "Campo deve ter no m&iacute;nimo 6 caracteres"
                    },
                    confirmPassword: {
                        minlength: "Campo deve ter no m&iacute;nimo 6 caracteres",
                        required: this.defaultMessage(),
                        equalTo: "Confirma&ccedil;&atilde;o de senha inv&aacute;lida"
                    },
                    cpf: {
                        required: this.defaultMessage()
                    },
                }
            });
        },
        defaultMessage: function () {
            return '';
        }
    }
})();