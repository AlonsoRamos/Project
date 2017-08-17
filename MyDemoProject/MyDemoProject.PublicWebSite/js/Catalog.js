//Create a JSON Object my products information
$(document).ready(function () {
    $("#DynamicHTML").append(buildMyProduct(JSONCatalog));
    //LoadMySimpleJson();
});
//GetAllProducts
function buildMyProduct() {
    var html = "";
    $.ajax({
        type: 'GET',
        url: 'http://localhost:56429/api/Product',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            $.each(data, function (element, object) {
                html += "<div class='col-md-4 thumbnail'>";
                html += "<div><a href='Detail2.html?id=" + object.$id + "'>" + object.Description + "</a></div>";
                html += "<div><img class='Catalog' style='width:260px; height:180px' src='" + object.ImagURL + "' /></div>";
                html += "<div>Model: " + object.Model + "</div>";
                html += "<div>Price: " + object.Price + "</div></div>";
            });
            $("#IMAGE").append(html);
        },
        error: function (a, b, c) {

        }
    });
}
//Dynamic build your collection
//function buildMyProduct(JSONCatalog) {
//    var html = "";
//    $.each(JSONCatalog, function (element, object) {
//        html += "<div class='col-md-4 thumbnail'>";
//        html += "<div><a href='Detail2.html?id=" + object.id + "'>" + object.title + "</a></div>";
//        html += "<div><img class='Catalog' style='width:260px; height:180px' src='" + object.imgUrl + "' /></div>";
//        html += "<div>" + object.description + "</div></div>";
//    });
//    return html;
//}

////ReadingSimpleJSON
//function LoadMySimpleJson()
//{
//    var myJSON = mySimpleJson;
////    $.each(mySimpleJson, function (element, object) {
////});
//}