$(document).ready(function () {
    $("#btnGetProducts").click(function () {
        GetAllProducts();
    });
});

function GetAllProducts() {
    var html = "";
    $.ajax({
        type: 'GET',
        url: 'api/product',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            //$.each(data, function (element, object) {
            //    html += "<div class='col-md-4 thumbnail'>";
            //    html += "<div><a id=" + object.$id + "'>" + "</a></div>";
            //    html += "<div>Titulo: " + object.Description + "</div></div>";
            //    $.each(object.ProductImages, function (element, miniobject) {
            //        html += "<div class='col-md-4 thumbnail'>";
            //        html += "<div><img class='Catalog' style='width:260px; height:180px' src='" + miniobject.ImagURL + "' /></div>";
            //        html += "<div>Caracteristica: " + miniobject.Description + "</div></div>";
            //    });
            //});
            //$("#IMAGE").append(html);
        },
        error: function (a, b, c) {

        }
    });
}

function PostProduct() {
    var myProduct = {
        "title": "myTitle001",
        "description": "myDescription",
        "imgUrl": "Images/img_003.jpg",
        "model": "md0001",
        "price": "2000.00"
    }

    $.ajax({
        type: 'POST',
        url: 'api/product',
        data: myProduct,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {

        },
        error: function (a, b, c) {

        }
    });
}