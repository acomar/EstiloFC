function Product(id, name, description, price, imagePath, idSize, idColor) {
    this.id = id;
    this.name = name;
    this.size = size;
    this.color = color;
    this.description = description;
    this.sellingPrice = Number(price.replace(',', '.'));
    this.imagePath = imagePath;
    this.idSize = idSize;
    this.idColor = idColor;
}

(function (root, undefined) {
    var lib = {};
    lib.settings = {
        url: {
            get: "/Basket/Get",
            add: "/Basket/Add",
            rem: "/Basket/Rem",
            res: "/Basket/Res",
            promo:"/Basket/Promo",
            empty: "/Basket/Empty"
        },
        selector: {
            totalValue: ".totalValue",
            totalItens: ".totalItens"
        },
        promoDiscount : 0,
        miniBasket: $("#MiniBasket"),
        basket: $("#basket"),
        intro: "Antes de finalizar sua compra, confira os produtos na sua sacola.",
        emptyMessage: "Sua sacola est\u00e1 vazia.",

        imageAdd: "/Content/Images/circleAdd.png",
        imageSub: "/Content/Images/circleSubtract.png",
        table: {
            columns: [{ id: "Imagem", title: "Imagem", value: "imagePath", img: true, isText: false },
                        { id: "Produto", title: "Produto", value: "name", isText: true },
                        { id: "Tamanho", title: "Tamanho", value: "size", isText: true },
                        { id: "Cor", title: "Cor", value: "color", isText: true },
                        { id: "Quantidade", title: "Quantidade", func: getInputQuantity, param: "id", param1: "idColor", param2: "idSize", isText: false },
                        { id: "valor", title: "Valor Unit\u00e1rio", func: accounting.formatMoney, param: "sellingPrice", isText: true },
                        { id: "total", title: "Valor Total", func: getTotalPriceById, param: "id", param1: "idColor", param2: "idSize", isText: true }
            ]
        }
    };

    var products = [];
    lib.init = function () {

        $(window).bind('scroll', function () {
            lib.settings.miniBasket.attr('class', '');
            if ($(this).scrollTop() > 100) {
                lib.settings.miniBasket.attr('class', 'mini-basket');
                lib.settings.miniBasket.css({
                    position: 'fixed',
                    top: '0px',
                    right: '0px'
                });
            } else {
                lib.settings.miniBasket.attr('class', 'basket');
                lib.settings.miniBasket.css({
                    position: 'relative',
                    top: '0px'
                });

            }
        });

        if (typeof exports !== 'undefined') {
            if (typeof module !== 'undefined' && module.exports) {
                exports = module.exports = lib;
            }
            exports.basket = lib;
        } else if (typeof define === 'function' && define.amd) {
            define([], function () {
                return lib;
            });
        }
        else {
            lib.noConflict = (function (oldBasket) {
                return function () {
                    root.basket = oldBasket;
                    lib.noConflict = undefined;
                    return lib;
                };
            })(root.basket);

            root['basket'] = lib;
        }
        lib.getProducts();
    };
    lib.getProducts = function () {
        $.ajax({
            url: lib.settings.url.get,
            type: 'POST',
            success: function (data) {
                products = data;
                update();
            },
            beforeSend: function () { },
            complete: function () { }
        });
    };
    lib.rem = function (id, idColor, idSize) {
        $.ajax({
            url: lib.settings.url.rem,
            type: 'POST',
            data: { id: id, idSize: idSize, idColor : idColor  },
            success: lib.getProducts
        });
    };
    lib.add = function (id,idColor, idSize) {
        $.ajax({
            url: lib.settings.url.add,
            type: 'POST',
            data: { id: id, idSize: idSize, idColor : idColor  },
            success: lib.getProducts,
        });
    };
    lib.res = function (id, idSize, idColor) {
        $.ajax({
            url: lib.settings.url.res,
            type: 'POST',
            data: { id: id, idSize: idSize, idColor: idColor },
            success: lib.getProducts,
            beforeSend: function () { },
            complete: function () { }
        });
    };
    lib.promo = function () {
        update();
    };
    lib.empty = function () {
        $.ajax({
            url: lib.settings.url.empty,
            type: 'POST',
            success: lib.getProducts
        });
    };
    lib.find = function (id) {
        for (var i in products) {
            if (products[i].id == id)
                return products[i];
        }
    };

    lib.getDiscount = function () {
        lib.settings.promoDiscount = 0;
        var promoCode = $("#promoCode").val();
        var total = lib.getTotalPrice().toString().replace(".", ",");
        
        if (promoCode!= undefined && promoCode != "") {
            $.ajax({
                url: lib.settings.url.promo,
                async: false,
                type: 'POST',
                data: { code: promoCode, total:total },
                success: function (val) {
           
                    if(val != undefined && val > 0)
                        lib.settings.promoDiscount = val;
                    else
                        Modal.showStatusMessage("C\u00f3digo inv\u00e1lido.", null, "Falha");
                },
                beforeSend: function () { },
                complete: function () { }
            });
        }
        return lib.settings.promoDiscount;
    };
    lib.getTotalPrice = function () {
        var total = 0.0;
        for (var i in products) {
            total += products[i].sellingPrice;
        }
        return total - lib.settings.promoDiscount;
    };
    var selector = lib.settings.selector;
    lib.setTotalPrice = function () {
        var total = lib.getTotalPrice();
        var formatedTotal = accounting.formatMoney(total);
        $(selector.totalValue).text(formatedTotal);
    };
    lib.setTotalItens = function () {
        $(selector.totalItens).text(products.length);
    };
    lib.setMiniBasket = function () {
        lib.setTotalItens();
        lib.setTotalPrice();
    };
    lib.setBasket = function () {
        var itensShow = $('#basketClear, #basketCheckout, .form-entrega, .promo-code');
        $('#basket').html("");
        if (products.length == 0) {
            $('#basketIntro').html(lib.settings.emptyMessage);
            itensShow.hide();
        }
        else {
            var thead = buildThead();
            var tbody = buildTbody();
            var tfooter = buildTfooter();
            var table = $("<table>").attr('class', 'tbl tbl-sacola');
            table.append(thead);
            table.append(tbody);
            table.append(tfooter);
            $('#basket').append(table);
            itensShow.show();
        }
    };
    lib.getTotalProducts = function () {
        return  products.length;
    };

    function distinct(produtos) {
        var flags = [], output = [], l = produtos.length, i;
        for (i = 0; i < l; i++) {
            if (flags[produtos[i].id + produtos[i].idColor + produtos[i].idSize]) continue;
            flags[produtos[i].id + produtos[i].idColor + produtos[i].idSize] = true;
            output.push(produtos[i]);
        }
        return output;
    }
    function buildThead() {
        var table = lib.settings.table;
        var tr = $("<tr>");
        $.each(table.columns, function (i, el) {
            if (!el.hidden) {
                var th = $('<th>');
                th.attr("id", el.id);
                th.text(el.title);
                tr.append(th);
            }
        });
        return $('<thead>').append(tr);
    }
    function buildTbody() {
        var table = lib.settings.table;
        var tbody = $('<tbody>');
        $.each(distinct(products), function (i, product) {
            var tr = $("<tr>");
            $.each(table.columns, function (j, coll) {
                var td = $("<td>");
                td.attr("headers", coll.id);
                var value;
                if (coll.img)
                    value = $('<img>').attr('src', product[coll.value]);
                else if (coll.func) {
                 
                    value = coll.func(product[coll.param], product[coll.param1], product[coll.param2]);
                } else
                    value = product[coll.value];

                if (coll.isText)
                    td.text(value);
                else
                    td.append(value);

                tr.append(td);
            });
            tbody.append(tr);
        });
        return tbody;
    };

    function buildTfooter() {
        var tfooter = $('<tfoot>');
        tfooter.append(
            $('<tr class="deliveryCost">')
                .append($('<td colspan="6" style="text-align: right;" id="frete">').text('Desconto:'))
                .append($('<td class="teste" headers="total">').text(accounting.formatMoney(lib.getDiscount()))));
        
        
        tfooter.append(
            $('<tr class="total">')
                .append($('<td colspan="6" class="label" id="total-do-carrinho">').text('Valor Total:'))
                .append($('<td class="soma" headers="total">').text(accounting.formatMoney(lib.getTotalPrice()))));
        return tfooter;
    };
    function getTotalById(id, idColor, idSize) {
        var total = 0;
        for (var i in products) {
            if (products[i].id == id && products[i].idColor == idColor && products[i].idSize == idSize) {
                total += 1;
            }
        };
        return total;
    };

    function getInputQuantity(id, idColor, idSize) {
      
        return $("<div>")
            .append($("<img class='pointer-left'>").attr("src", lib.settings.imageSub).click(function () {
                lib.rem(id, idColor, idSize);
            }))
            .append($("<span>").text(getTotalById(id, idColor, idSize)))
            .append($("<img class='pointer-right'>").attr("src", lib.settings.imageAdd).click(function () {
                lib.add(id, idColor, idSize);
            }));
    };
    function getTotalPriceById(id, idColor, idSize) {
        var total = 0;
        for (var i in products) {
            if (products[i].id == id && products[i].idColor == idColor && products[i].idSize == idSize) {
                total += products[i].sellingPrice;
            }
        };
        return accounting.formatMoney(total);
    };
    function update() {
        lib.setBasket();
        lib.setMiniBasket();
    }
    lib.init();
}(this));