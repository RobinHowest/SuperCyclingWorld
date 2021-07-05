var menuKnoppen;

$(document).ready(function () {
    jQuery.fn.shake = function (interval, distance, times) {
        interval = typeof interval == "undefined" ? 100 : interval;
        distance = typeof distance == "undefined" ? 10 : distance;
        times = typeof times == "undefined" ? 3 : times;
        var jTarget = $(this);
        jTarget.css('position', 'relative');
        for (var iter = 0; iter < (times + 1); iter++) {
            jTarget.animate({ left: ((iter % 2 == 0 ? distance : distance * -1)) }, interval);
        }
        return jTarget.animate({ left: 0 }, interval);
    }



    menuKnoppen = document.querySelectorAll(".menuKnop")
    chartTexten = document.querySelectorAll(".chartText")


    for (let menuKnop of menuKnoppen) {
        menuKnop.addEventListener("mouseover", Enlarge);
        menuKnop.addEventListener("mouseleave", Delarge);
    }

    for (let charText of chartTexten) {
        charText.addEventListener("mouseover", TogglePicto)
    }

    function TogglePicto(e) {

        $(e.currentTarget.parentNode.parentNode.parentNode).children().first().addClass('shakeIt');
        $('.shakeIt').shake(160, 5, 2);
        $(e.currentTarget.parentNode.parentNode.parentNode).children().first().removeClass('shakeIt');
    }


    function Enlarge(e) {
        $(e.currentTarget).animate({paddingBottom: 42}, 200)
    }

    function Delarge(e) {

        $(event.currentTarget).animate({paddingBottom: 15 }, 200)
    }



});
