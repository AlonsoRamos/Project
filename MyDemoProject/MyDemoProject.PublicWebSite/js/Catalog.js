//Create a JSON Object my products information
$(document).ready(function () {
    $("#DynamicHTML").append(buildMyProduct(JSONCatalog));
    //LoadMySimpleJson();
});

//Dynamic build your collection
function buildMyProduct(JSONCatalog) {
    var html = "";
    $.each(JSONCatalog, function (element, object) {
        html += "<div class='col-md-4 thumbnail'>";
        html += "<div><a href='Detail2.html?id=" + object.id + "'>" + object.title + "</a></div>";
        html += "<div><img class='Catalog' style='width:260px; height:180px' src='" + object.imgUrl + "' /></div>";
        html += "<div>" + object.description + "</div></div>";
    });
    return html;
}

////ReadingSimpleJSON
//function LoadMySimpleJson()
//{
//    var myJSON = mySimpleJson;
////    $.each(mySimpleJson, function (element, object) {
////});
//}