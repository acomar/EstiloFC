$(function () {
   
    Home.enablePlaceholder();
    Home.prepareClickMenuCategories();
    $("#showModalLogin").click(Home.showModalLogin);
    $("#showPageRegister").click(Home.showPageRegister);
    $(".showModalFeedback").click(Home.showModalFeedback);
    $(".showPageBasket").click(Home.showPageBasket);
    //Home.showModalResearchDeliveryArea();
    Home.prepareCarousel();
});

var Home = (function () {
    return {
        showPageBasket: function () {
            var url = '/Home/IsLogged';
            $.ajax({
                url: url,
                type: 'POST',
                success: Home.successIsLogged,
                beforeSend: function () { },
                complete: function () { }
            });
        },
        successIsLogged: function (result) {
            if (result.success)
                if (basket.getTotalProducts() == 0)
                    Modal.showStatusMessage("Sua sacola est&aacute; vazia.", null, "Sacola vazia");
                else
                window.location = '/sacola';
            else
                Home.showModalLogin();
        },
        showModalLogin: function () {
            Modal.showModal($("#modalLogin"));
        },
        showModalFeedback: function () {
            var url = '/Home/ShowModalFeedback';
            $.ajax({
                url: url,
                type: 'POST',
                success: Home.successShowModalFeedback
            });
        },
        successShowModalFeedback: function (result) {
            Modal.showModal(result);
        },
        showModalResearchDeliveryArea: function () {
            var researchAnswered = $.cookie('researchAnswered');
            if (researchAnswered == "true")
                return false;
            var url = '/Home/ShowModalResearchDeliveryArea';
            $.ajax({
                url: url,
                type: 'POST',
                success: Home.successShowResearchDeliveryArea
            });
        },
        successShowResearchDeliveryArea: function (result) {
            $.cookie('researchAnswered', true, { expires: 20 });
            Modal.showModal(result);
        },
        redirectHome: function () {
            var url = '/Home';
            window.location = url;
        },
        prepareClickMenuCategories: function () {
            //$(".categories > ul > li > a").on("click", function (e) {
            //    e.preventDefault();
            //    $(this).toggleClass("active").next(".submenu").slideToggle(300);
            //});
        },
        enablePlaceholder: function () {
            $('input[placeholder]').simplePlaceholder();
            $('textarea[placeholder]').simplePlaceholder();
        },
        prepareCarousel: function () {
            Carousel.createCarousel();
        }
    }
})();