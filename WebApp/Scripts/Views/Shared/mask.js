$(function () {
    $("input:text[rel=phone]").mask("(99) 99999-9999");
    $("input:text[rel=cep]").mask("99999-999");
    $("input:text[rel='number']").mask("?99999", { placeholder: " " });
    $("input:text[rel=money]").priceFormat({
        prefix: '',
        centsSeparator: ',',
        thousandsSeparator: '.'
    });
})