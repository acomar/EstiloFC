var RegisterFeedbackForm = (function () {
    return {
        validateRegisterForm: function () {
            $('#formFeedback').validate(
            {
                rules: {
                    description: {
                        required: true
                    }
                },
                messages:
                {
                    description: {
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

var Feedback = (function () {
    return {
        createFeedback: function () {
            if (!$("#formFeedback").valid())
                return false;
            var url = '/Feedback/CreateFeedback';
            var data = $("#formFeedback").serialize();
            $.ajax({
                url: url,
                type: 'POST',
                data: data,
                success: Feedback.successCreateFeedback
            });
        },
        successCreateFeedback: function (result) {
            Modal.showSuccessMessage('Obrigado por esse feedback! Faremos o m&aacute;ximo para atingirmos as suas expectativas.');
        }
    }
})();

$(function () {
    RegisterFeedbackForm.validateRegisterForm();
    $("#sendFeedback").click(Feedback.createFeedback);
});