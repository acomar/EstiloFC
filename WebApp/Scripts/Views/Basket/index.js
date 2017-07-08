$(function () {
    Basket.init();
    FinalizeOrder.init();
    OrderForm.validate();

});

var OrderForm = (function () {
    return {
        validate: function () {
            $('#formOrder').validate();
            $('#state').rules("add", {
                required: true,
                messages: {
                    required: ''
                }
            });
            $('#zipCode').rules("add", {
                required: true,
                messages: {
                    required: ''
                }
            });
            $('#address').rules("add", {
                required: true,
                messages: {
                    required: ''
                }
            });
            $('#number').rules("add", {
                required: true,
                messages: {
                    required: ''
                }
            });
            $('#neighborhood').rules("add", {
                required: true,
                messages: {
                    required: ''
                }
            });
        }
    }
})();
var Basket = (function () {
    return {
        init: function () {
            $("#basketClear").click(function () {
                basket.empty();
            });
        }
    }
})();

var FinalizeOrder = (function () {
    var finalizeOrderOldValue = "";
    return {
        init: function () {
            FinalizeOrder.showChangeForIfIsMoney();
            $(".finalizar").click(FinalizeOrder.checkout);
            $("#paymentType").change(FinalizeOrder.showChangeForIfIsMoney);
            $("#state").change(FinalizeOrder.bindCities);
            $("#btnPromoCode").click(basket.promo);
            FinalizeOrder.bindCities();
        },
        checkout: function () {
            var url = '/Basket/FinalizeOrder';
            $("#hdnPromoCode").val($("#promoCode").val());
            var data = $("#formOrder").serialize();
            if (!$("#formOrder").valid())
                return false;
            $.ajax({
                url: url,
                type: 'POST',
                data: data,
                success: FinalizeOrder.successFinalizeOrder,
                beforeSend: FinalizeOrder.ajaxBeforeSend,
                complete: function () { }
            });
        },
        successFinalizeOrder: function (result) {
            var url = result.url;
            if (result.success){
                window.location = url;
            }
            else
            {
                $("#divLoading").hide();
                $("#finalizeOrder").val(finalizeOrderOldValue);
                $("#finalizeOrder").removeAttr('disabled');
                Modal.showStatusMessage(result.message, null, "Falha");
                basket.empty();
            }
        },
        showChangeForIfIsMoney: function () {
            if ($("#paymentType").val() == '1')
                $("#spanChangeFor").show();
            else {
                $("#spanChangeFor").hide();
                $("#changeFor").val('');
            }
        },

        ajaxBeforeSend: function () {
            finalizeOrderOldValue = $("#finalizeOrder").val();
            $("#finalizeOrder").val('Finalizando pedido...');
            $("#finalizeOrder").attr('disabled', 'disabled');
            $("#divLoading").show();
        },
        bindCities: function (option) {
       
            var idState = $("#state").val()
            $.ajax({
                url: "/Basket/GetCities",
                type: 'POST',
                data: { idState: idState },
                success: function (data) {
                    $("#city").html("");
                    $.each(data.cities, function (index, obj) {
                        $("#city").append("<option value=" + obj.Id + ">" + obj.Name + "</option>");
                    });
                    $("#city").val($("#hdnIdCity").val());
                },
                beforeSend: function () { },
                complete: function () { }
            });
        }
    }
})();
