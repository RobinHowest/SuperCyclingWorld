var menuKnoppen;
var bodyImage;



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
    chartPictures = document.querySelectorAll(".chartPicture")
    menuListItems = document.querySelectorAll(".menuListItem");
    meerWeetKnoppen = document.querySelectorAll(".meerWeten")
    


    for (let menuKnop of menuKnoppen) {
        menuKnop.addEventListener("mouseover", Enlarge);
        menuKnop.addEventListener("mouseleave", Delarge);
    }

    for (let charText of chartTexten) {
        charText.addEventListener("mouseover", TogglePicto)
    }

    for (let meerWeten of meerWeetKnoppen) {
        meerWeten.innerHTML = "Meer weten ?"
        meerWeten.addEventListener("click", EnlargeChartTextDiv)
    }

    for (let charPicture of chartPictures) {
        charPicture.addEventListener("mouseover", DeleteShadow)
        charPicture.addEventListener("mouseout", ShowShadow)
    }

    for (let menuListItem of menuListItems) {
        menuListItem.addEventListener("click", ChangeBackgroundBody);
    }

    function TogglePicto(e) {

        $(e.currentTarget.parentNode.parentNode.parentNode).children().first().addClass('shakeIt');
        $('.shakeIt').shake(160, 5, 2);
        $(e.currentTarget.parentNode.parentNode.parentNode).children().first().removeClass('shakeIt');
        $(e.currentTarget.parentNode.parentNode).removeEventListener("mouseover", TogglePicto);
    }


    function Enlarge(e) {
        $(e.currentTarget).animate({paddingBottom: 42}, 200)
    }

    function Delarge(e) {

        $(e.currentTarget).animate({paddingBottom: 15 }, 200)
    }

    function EnlargeChartTextDiv(e) {

        let meerWetenKnop = e.currentTarget;

        if (!$(meerWetenKnop).hasClass("clicked")) {
            $(e.currentTarget.parentNode.parentNode.parentNode.parentNode).animate({ height: 800 }, 1000)
            $(e.currentTarget.parentNode.parentNode.parentNode).animate({ height: 800 }, 1000)
            $(e.currentTarget.parentNode.parentNode).animate({ height: 800 }, 1000)
            $(e.currentTarget.parentNode).animate({ height: 600 }, 1000, function () {
                meerWetenKnop.innerHTML = "Terug";
                $(meerWetenKnop).addClass("clicked")
            })

        }
        else {
            $(e.currentTarget.parentNode.parentNode.parentNode.parentNode).animate({ height: 300 }, 1000)
            $(e.currentTarget.parentNode.parentNode.parentNode).animate({ height: 300 }, 1000)
            $(e.currentTarget.parentNode.parentNode).animate({ height: 300 }, 1000)
            $(e.currentTarget.parentNode).animate({ height: 180 }, 1000, function () {
                meerWetenKnop.innerHTML = "Meer weten ?"
                $(meerWetenKnop).removeClass("clicked")
            })

            
        }
    }

    function DeleteShadow(e) {
        $(e.currentTarget).css("box-shadow", "none");
    }

    function ShowShadow(e) {
        $(e.currentTarget).css("box-shadow", "5px 5px 10px rgba(0, 0, 0, 0.8)");
    }

    function ChangeBackgroundBody() {
        let body = document.body;
        body.className = "info";
       // document.body.style.backgroundImage = "url(../images/sign.jpg)";
    }
});
