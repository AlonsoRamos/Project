$(document).ready(function () {
    $("#btnGetProducts").click(function (){
    GetAllProducts();
    });
});

function GetAllProducts() {
    $.ajax({
        type: 'GET',
        url: 'api/productX',
        contentType: "application/json; charset=utf"
    })
}