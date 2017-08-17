$(document).ready(function () {
    loadProduct();

});

function loadProduct() {
    var myProduct = FindMyProduct(getJsonFromUrl())
    buildMyProduct(myProduct);
}

function FindMyProduct(id) {
    var ProductDetails = "";
    $.each(JSONDetails, function (element, object) {
        if (object.id == id)
            ProductDetails = object;
    });
    return ProductDetails;
}


//Dynamic build your collection
function buildMyProduct(myProduct) {
    var html = "";
    html += "<div class='row'>";
    html += "<div><h3 style='padding-left:20px;'>" + myProduct.title + "</h3></div>";
    html += "<div class='col-md-3 thumbnail'style='width:250px; height:180px;'><img style='width:250px; height:170px;' src='" + myProduct.MainImage + "' /></div>";
    html += "<div class='col-md-3 container'><div>" + myProduct.price +"<div>"+ myProduct.model +"</div>"+ "</div>"+"<div>"+myProduct.description + "</div></div>";
    html += "</div>";
    html += "<div class='row' id='Similares' style='padding-left:6px;'>";
    $.each(myProduct.ProductImage, function (element, obj) {
        html += "<img class='col-md-3 thumbnail' style='width:80px; height:80px;' src='" + obj.imgUrl + "'/>";
    });
    html += "</div>";



    $("#MyDynamicProductDetail").append(html);
}

function getJsonFromUrl() {
    var query = location.search.substr(1);
    var result = {};
    query.split("&").forEach(function(part) {
        var item = part.split("=");

        //Decode to avoid errors due to blank spaces on the URL
        result[item[0]] = decodeURIComponent(item[1]);
    });
    //we need only the ID
    return result.id;
}