$(function () {
    $("[data-load]").each(function () {
        $(this).load($(this).data("load"), function () {
        });
    });
})
