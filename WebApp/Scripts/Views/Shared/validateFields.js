var ValidateFields = (function () {
    return {
       isBrazilianDate: function(date) {
            var field = date;
            var value = date.val();
            if (value == "") {
                return true;
            }
            var ardt = new Array;
            var ExpReg = new RegExp("(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/[12][0-9]{3}");
            ardt = value.split("/");
            erro = false;

            if (value.search(ExpReg) == -1) {
                erro = true;
            }
            else if (ardt[2] < 1800)
                erro = true;
            else if (((ardt[1] == 4) || (ardt[1] == 6) || (ardt[1] == 9) || (ardt[1] == 11)) && (ardt[0] > 30))
                erro = true;
            else if (ardt[1] == 2) {
                if ((ardt[0] > 28) && ((ardt[2] % 4) != 0))
                    erro = true;
                if ((ardt[0] > 29) && ((ardt[2] % 4) == 0))
                    erro = true;
            }
            if (erro) {
                date.addClass('error');
                return false;
            } else {
                date.removeClass('error');
                return true;
            }
       },
       setFieldError: function (field, message) {
           if (field.next().length == 0)
               field.after("<label for='" + field.attr('id') + "' generated='true' class='error'>" + message + "</label>");
           else
               field.next().html("<label for='" + field.attr('id') + "' generated='true' class='error'>" + message + "</label>").show();
       }
    };
})();