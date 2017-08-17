$(document).ready(function () {
    $("#btnGetProducts").click(function () {
        GetAllProducts();
    });
});

function GetAllProducts() {
    $.ajax({
        type: 'GET',
       // url: 'http://localhost:56429/api/product',
        url: '/api/product',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data) {

        },
        error: function (a, b, c) {

        }
    });
}