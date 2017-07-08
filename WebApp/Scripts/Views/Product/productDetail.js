

var ProductDetail = new function () {
    selector =
        {
            idProduct: $("#IdProduct"),
            ddlColors: $("#IdColor"),
            ddlSizes: $("#IdSize"),
            btnAdd: $(".add"),
        };
    this.init = function () {
        ProductDetail.createCarousel();
        ProductDetail.getSizesAndColors();
        ProductDetail.bindAdd();
        selector.ddlColors.change(ProductDetail.getSizes);
        $("#tabs").easytabs();
        // $('.zoom').zoom({ url: '../Content/Images/Products/410x410.jpg' });
    }
    this.bindAdd = function () {

        selector.btnAdd.click(function () {
            basket.add(selector.idProduct.val(), selector.ddlColors.val(), selector.ddlSizes.val());
            var span = $(this).find("span");
            ProductDetail.effectAdd(span);
        });

    };
    this.effectAdd = function (span) {

        var oldText = span.text();
        span.text("Incluindo...");
        setInterval(function () {
            span.text(oldText);
        }, 2000);
    };

    this.createCarousel = function () {

        $('.carousel ul').anoSlide(
        {
            items: 1,
            speed: 500,
            prev: 'a.prev',
            next: 'a.next',
            lazy: true,
            onConstruct: function (instance) {
            },
            onStart: function (ui) {
                var paging = $('.paging');

                paging.find('a').eq(ui.instance.current).addClass('current').siblings().removeClass('current');
            }
        });
    };
    this.getColors = function () {
        ProductDetail.bindSizesAndColors({ isSize: false, isColor: true })
    };
    this.getSizes = function () {
        ProductDetail.bindSizesAndColors({ isSize: true, isColor: false })
    };
    this.getSizesAndColors = function () {
        ProductDetail.bindSizesAndColors({ isSize: true, isColor: true })
    };

    this.populateSizes = function (sizes) {
        var selectedVal = selector.ddlSizes.val();
        selector.ddlSizes.html("");
        $.each(sizes, function (index, size) {
            selector.ddlSizes.append("<option value=" + size.Id + ">" + size.Code + "</option>");
        });
        selector.ddlSizes.val(selectedVal);
    };
    this.populateColors = function (colors) {
        selector.ddlColors.html("");
        $.each(colors, function (index, color) {
            selector.ddlColors.append("<option value=" + color.Id + ">" + color.Name + "</option>");
        });
    };

    this.bindSizesAndColors = function (option) {
        var idProduct = selector.idProduct.val()
        var idColor = selector.ddlColors.val();

        $.ajax({
            url: "/Stock/GetSizesAndColors",
            type: 'POST',
            data: { idProduct: idProduct, idColor: idColor },
            success: function (data) {
                if (option.isSize)
                    ProductDetail.populateSizes(data.Sizes);
                if (option.isColor)
                    ProductDetail.populateColors(data.Colors);
            },
            beforeSend: function () { },
            complete: function () { }
        });
    }
};

$(function () {
    ProductDetail.init();
});



