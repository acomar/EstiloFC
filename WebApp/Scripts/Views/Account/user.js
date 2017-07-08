var User = (function () {
    return {
        createUser: function () {
            if (!User.formUserIsValid())
                return false;
            var url = '/Account/CreateUser';
            var data = $("#formRegister").serialize();
            $.ajax({
                url: url,
                type: 'POST',
                data: data,
                success: User.successCreateUser
            });
        },
        formUserIsValid: function () {
            var result = true;
            if (!$("#formRegister").valid())
                result = false;
            if (!ValidateFields.isBrazilianDate($("#birthday")))
                result = false;
            return result;

        },
        successCreateUser: function (result) {
            if (result.success)
                Modal.showSuccessMessage('Bem-vindo ao Estilo F.C. \n Comece a comprar seus produtos favoritos!', Home.redirectHome);
            else
                User.showMessageEmailAlreadyExists();
        },
        editUser: function () {
            if (!$("#formRegisterEdit").valid())
                return false;
            var url = '/Account/EditUser';
            var data = $("#formRegisterEdit").serialize();
            $.ajax({
                url: url,
                type: 'POST',
                data: data,
                success: User.successEditUser
            });
        },
        successEditUser: function (result) {
            Modal.showSuccessMessage('Cadastro alterado com sucesso!', Home.redirectHome);
        },
        editPassword: function () {
            FormEditPassword.validate();
            if (!$("#formEditPassword").valid())
                return false;
            var url = '/Account/EditPassword';
            var data = $("#formEditPassword").serialize();
            $.ajax({
                url: url,
                type: 'POST',
                data: data,
                success: User.successEditPassword
            });
        },
        successEditPassword: function (result) {
            if (result.success)
                Modal.showSuccessMessage('Senha alterada com sucesso.');
            else
                User.showMessageIncorrectPassword();
        },
        showMessageEmailAlreadyExists: function () {
            ValidateFields.setFieldError($("#confirmEmail"), "E-mail j&aacute; cadastrado em nosso site. <a href='/Account/ForgotPassword' class='error'>Esqueceu sua senha?</a>");
        },
        showMessageIncorrectPassword: function () {
            ValidateFields.setFieldError($("#currentPassword"), "Senha incorreta.");            
        }
    }
})();