var Carousel = (function () {
    return {
        createCarousel: function () {
            $('.carousel ul').anoSlide(
            {
                items: 1,
                auto: 4000,
                speed:1000,
                autostart: true,
                prev: 'a.prev[data-prev-paging]',
                next: 'a.next[data-next-paging]',
                lazy: true,
               
                onStart: function (ui) {
                    var paging = $('.paging');

                    paging.find('a').eq(ui.instance.current).addClass('current').siblings().removeClass('current');
                }
            })
        }
    };
})();



