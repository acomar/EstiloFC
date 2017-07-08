$(function () {
    $("body").on('click', '#loginUser', Login.loginUser);
    $("#logout").click(Login.logout);
    $("#modalShowPageRegister").click(Home.showPageRegister);
    $("#formLogin").submit(Login.loginUser);

    Login.isLogged();
});

var Login = (function () {
    return {
        isLogged: function () {
            var url = '/Account/GetFirstNameIfIsLogged';
            $.ajax({
                url: url,
                type: 'POST',
                success: Login.resultLoginSuccess,
                beforeSend: function () { },
                complete: function () { }
            });
        },
        loginUser: function () {
            var url = '/Account/Login';
            var data = $("#formLogin").serialize();
            $.ajax({
                url: url,
                type: 'POST',
                data: data,
                success: Login.successLoginUser
            });
            return false;
        },
        successLoginUser: function (result) {
            if (result.success)
                Login.resultLoginSuccess(result);
            else
                $("#invalidUser").html('E-mail ou senha inv&aacute;lido.');
            $("#textLogin").show();
        },
        resultLoginSuccess: function (result) {
            if (result.success) {
                basket.getProducts();
                Modal.hideModal();
                $("#textLogin").html('Bem vindo, ' + result.firstName + '! <a href="/Order/ViewOrders")">Meus Pedidos</a> - <a href="/Account/RegisterEdit">Editar Conta</a> - <a href="#" onClick="Login.logout();" class="logout">Sair</a>');
            }
            $("#textLogin").show();
        },
        logout: function () {
            var url = '/Account/Logout';
            window.location = url;
        }
    }
})();
