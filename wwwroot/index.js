$(document).ready(function () {

    var theForm = $("#theForm");
    theForm.hide();

    var button = $("#buyButton")
    button.on("click", function () {
        console.log("Buying item!");
    });
    var productInfo = $(".products-props li ");
    productInfo.on("click", function () {
        console.log("You clicked on " + $(this).text()); //this.InnerText
    });
    var $loginToggle = $("#loginToggle"); /* använder $ eftersöm det är JQuery objekt */
    var $popupForm = $(".popup-form"); /*popupForm istället av popup-form eftersom - är mer som subrtaktion */

    $loginToggle.on("click", function () {
        $popupForm.fadeToggle(500);  /* on click  - om den är hidden kommer att visas och tvärtom*/
    });

});   

