jQuery(document).ready(function ($) {
    $('html').niceScroll();

    $('.page-scroll a, a.page-scroll').bind('click', function(event) {
        var $anchor = $(this);
        $('html, body').stop().animate({
            scrollTop: $( $anchor.attr('href') ).offset().top
        }, 1500, 'easeInOutExpo');
        event.preventDefault();
    });

    $('.draggable').draggable({
        revert: true,
        containment: 'html'
    }).css({'z-index':999999}).on('dragstart', function (e, ui) {
        $(this).parents('.jumbotron').css({'overflow':'visible'});
    }).on('dragstop', function (e, ui) {
        $(this).parents('.jumbotron').css({'overflow':'hidden'})
    });

    $('[data-bg]').each(function () {
        var bg = $(this).data('bg');
        $(this).css({'background-color': bg});
    });
    $('[data-img]').each(function () {
        var bg = $(this).data('img');
        $(this).css({'background-image': bg});
    });


    $('.date').text( function (e) {
        var startDate = $(this).data('default-date');
        var currentDate = new Date().getFullYear();
        var text = startDate;
        if( parseInt(startDate) < parseInt(currentDate) )
        {
            text = startDate + " - " + currentDate;
        }
        return text;
    });

})