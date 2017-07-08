$(function () {
    RegisterContactUsForm.validateRegisterForm();
    $("#sendContactUs").click(ContactUs.createContact);
});

var RegisterContactUsForm = (function ()
{
    return {
        validateRegisterForm: function () {
            $('#formContactUs').validate(
            {
                rules: {
                    name: {
                        required: true
                    },
                    email: {
                        required: true,
                        email: true
                    },
                    message: {
                        required: true                        
                    }
                },
                messages:
                {
                    name: {
                        required: this.defaultMessage()
                    },
                    email: {
                        required: this.defaultMessage(),
                        email: "E-mail inv&aacute;lido"
                    },
                    message: {
                        required: this.defaultMessage()                        
                    }
                }
            });
        },
        defaultMessage: function () {
            return '';
        }
    }
})();

var ContactUs = (function () {
    return {
        createContact: function () {
            if (!$("#formContactUs").valid())
                return false;
            var url = '/ContactUs/CreateContact';
            var data = $("#formContactUs").serialize();
            $.ajax({
                url: url,
                type: 'POST',
                data: data,
                success: ContactUs.successCreateContactUs
            });
        },
        successCreateContactUs: function (result) {
            $("#successSendMessage").html("Mensagem enviada com sucesso! Em breve retornaremos o contato.");
        }
    }
})();