var RegisterResearchDeliveryAreaForm = (function () {
    return {
        validateResearchDeliveryAreaForm: function () {
            $('#formResearch').validate(
            {
                rules: {
                    IdDeliveryArea: {
                        required: true
                    },
                    otherDeliveryArea: {
                        required: {
                            depends: function (element) {
                                return $("#deliveryArea").val() == '17';
                            }
                        }
                    }
                },
                messages:
                {
                    IdDeliveryArea: {
                        required: this.defaultMessage()
                    },
                    otherDeliveryArea: {
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

var ResearchDeliveryArea = (function () {
    return {
        deliveryAreaChange: function () {
            var otherDeliveryArea = 17;
            if ($(this).val() == otherDeliveryArea)
                $("#spanOtherDeliveryArea").show();
            else {
                $("#spanOtherDeliveryArea").hide();
                $("#otherDeliveryArea").val('');
            }
        },
        sendResearch: function () {
            if (!$("#formResearch").valid())
                return false;
            var url = '/Home/saveResearchDeliveryArea';
            var data = $("#formResearch").serialize();
            $.ajax({
                url: url,
                type: 'POST',
                data: data,
                success: ResearchDeliveryArea.successResearch
            });
        },
        successResearch: function (result) {
            Modal.hideModal();
        }
    }
})();

$(function () {
    RegisterResearchDeliveryAreaForm.validateResearchDeliveryAreaForm();
    $("#spanOtherDeliveryArea").hide();
    $("#deliveryArea").change(ResearchDeliveryArea.deliveryAreaChange);
    $("#sendResearch").click(ResearchDeliveryArea.sendResearch);
});

