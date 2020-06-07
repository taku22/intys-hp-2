$(function() {
    var nowScrollY;
    var screenWidth = $(window).width();

    $(window).scroll(function() {
        nowScrollY = $(this).scrollTop();
        if (screenWidth >= 1400) {
            nowScrollY += 700;
            setClass(nowScrollY);
        }
        else if (screenWidth <= 1399 && screenWidth >= 1024) {
            nowScrollY += 200;
            setClass(nowScrollY);
        }
        else if (screenWidth <= 1023 && screenWidth >= 768) {
            nowScrollY += 100;
            setClass(nowScrollY);
        }
        else if (screenWidth <= 767 && screenWidth >= 421) {
            nowScrollY += 100;
            setClass(nowScrollY);
        }
        else if (screenWidth <= 420) {
            nowScrollY += 200;
            setClass(nowScrollY);
        }
    })

    function setClass(nowScrollY) {
        var section01 = $('#about').offset().top;
        var section02 = $('#member').offset().top;
        var section03 = $('#blog').offset().top;

        if (nowScrollY > section03) {
            $('.ro-group03').addClass("appear-ro");
        }
        else if (nowScrollY > section02) {
            $('.ro-group02').addClass("appear-ro");
        }
        else if (nowScrollY > section01) {
            $('.ro-group01').addClass("appear-ro");

        }
    }


})
