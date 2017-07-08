$(function () {
    RegisterFormEdit.validate();
    $("#cpf").mask("999.999.999-99");
    $("#areaCode").mask("99");
    $("#number").mask("99999999?9");
    $("#birthday").mask("99/99/9999");
    $("#birthday").blur(function () { ValidateFields.isBrazilianDate($(this)); });
    $("#registerEdit").click(User.editUser);
});

var RegisterFormEdit = (function ()
{
    return {
        validate: function () {
            $('#formRegisterEdit').validate(
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
                    cpf: {
                        required: true
                    },
                    password: {
                        minlength: 6,
                        required: true
                    },

                    confirmPassword: {
                        minlength: 6,
                        equalTo: "#editPassword",
                        required: true
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
                    firstName: {
                        required: this.defaultMessage()
                    },
                    lastName: {
                        required: this.defaultMessage()
                    },
                    cpf: {
                        required: this.defaultMessage()
                    },
                    password: {
                        required: this.defaultMessage(),
                        minlength: "Campo deve ter no m&iacute;nimo 6 caracteres"
                    },
                    confirmPassword: {
                        required: this.defaultMessage(),
                        minlength: "Campo deve ter no m&iacute;nimo 6 caracteres",
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