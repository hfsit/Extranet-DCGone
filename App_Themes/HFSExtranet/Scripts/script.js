// Run all this only when the DOM is ready!
$(document).ready(function () {

    disableIESmoothScroll();

    var supportsTouch = 'ontouchstart' in window || navigator.msMaxTouchPoints !== undefined;
    if (supportsTouch) bindTaphoverElementClicks();

    $('table').attr('cellspacing', '0') // Fix gaps between table cells in all browsers. Can't do this in css.



    /* When elements with the .taphover class are clicked on a mobile device, add the .hover class
     * first instead of activating the link right away. This way, we can share rollover content between
     * mobile and desktop with similar functionality. */
    function bindTaphoverElementClicks() {
        var taphoverElements = $('.taphover');
        taphoverElements.on('click', function (e) {
            var thisElement = $(this); // Pre-select for speed!
            if (!thisElement.hasClass('hover')) {
                thisElement.addClass('hover');
                taphoverElements.not(this).removeClass('hover'); // Only allow one to be active at a time
                e.preventDefault(); // Don't follow the link yet
            }
        });
    }

    function disableIESmoothScroll() {
        var browserIsIE = !!window.navigator.userAgent.match(/MSIE|Trident|Edge/);
        if (browserIsIE) {
            $('body').on('mousewheel', function () {
                event.preventDefault();
                var wheelDelta = event.wheelDelta;
                var currentScrollPosition = window.pageYOffset;
                window.scrollTo(0, currentScrollPosition - wheelDelta);
            });
        }
    } 
});


