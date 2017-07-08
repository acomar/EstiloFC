$(function () {
    $(".faq dl dd").hide();
    $(".faq dl dt").on("click", function () {
        $(this).next("dd").slideToggle(300);
    });
});