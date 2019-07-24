(function($) {
    'use strict';

    /*=======================================
         PRELOADER                     
    ======================================= */
    $(window).on('load', function() {
        $('#preloader').fadeOut('slow', function() {
            $(this).remove();
        });
        $(".slides__preload_wrapper").fadeOut(1500);
    });

 
 
    /* =======================================
        For slider
    =======================================*/
    $(".slider_home").owlCarousel({
        items: 1,
        nav: true,
        dots: false,
        autoplay: true,
        autoplayTimeout: 5000, // Default is 5000
        smartSpeed: 1000, // Default is 250
        loop: true,
        navText: ["<i class='icon-glyph-229'></i>", "<i class='icon-glyph-229'></i>"],
        mouseDrag: false,
        touchDrag: false,
    });


    /*=======================================
        slider Section
     ========================================== */
 
    $(".slider_home").on("translate.owl.carousel", function() {
        $(".single_slider h2, .single_slider h5, .single_slider p").removeClass("animated fadeInUp").css("opacity", "0");
        $(".single_slider .slider_btn").removeClass("animated fadeInDown").css("opacity", "0");
    });

    $(".slider_home").on("translated.owl.carousel", function() {
        $(".single_slider h2, .single_slider h5, .single_slider p").addClass("animated fadeInUp").css("opacity", "1");
        $(".single_slider .slider_btn").addClass("animated fadeInDown").css("opacity", "1");
    });



    /* =======================================
           Team Section 
       =======================================*/
    $("#team").owlCarousel({
        items: 6, //Set Team items
        loop: true,
        margin: 30,
        autoplay: true,
        autoplayTimeout: 4000, // Default is 5000
        smartSpeed: 1000, // Default is 250
        singleItem: true,
        touchDrag: true,
        mouseDrag: true,
        pagination: true,
        nav: true,
        dots: false,
        navText: ['<span class="owl_text"><i class="icon-glyph-41"></i></span>', 
        '<span class="owl_text"><i class="icon-glyph-40"></i></span>'],
        responsive: {
            1200: {
                items: 6
            },
            992: {
                items: 4
            },
            768: {
                items: 3
            },
            480: {
                items: 2
            },
            320: {
                items: 1
            },
            280: {
                items: 1
            }
        }
    });

    /* =======================================
              Blog Section 
          =======================================*/
    $("#blog_carousel").owlCarousel({
        items: 3, //Set Team items
        loop: true,
        margin: 30,
        autoplay: true,
        autoplayTimeout: 3000, // Default is 5000
        smartSpeed: 1000, // Default is 250
        singleItem: true,
        touchDrag: true,
        mouseDrag: true,
        pagination: false,
        nav: false,
        dots: false,
        navText: ['<span class="owl_text"><i class="fa flm fa-long-arrow-left"></i>Previous</span>', 
        '<span class="owl_text">Next<i class="fa flm fa-long-arrow-right"></i></span>'],
        responsive: {
            1200: {
                items: 3
            },
            992: {
                items: 3
            },
            768: {
                items: 2
            },
            480: {
                items: 1
            },
            320: {
                items: 1
            },
            280: {
                items: 1
            }
        }
    }); 


    
    /* =======================================
           Testimonial Section 
       =======================================*/
    $("#testimonial").owlCarousel({
        autoPlay: 3000, //Set AutoPlay to 5 seconds
        autoplay: true,
        smartSpeed: 1000, // Default is 250
        items: 2, //Set Testimonial items
        loop: true,
        margin: 30,
        singleItem: true,
        touchDrag: true,
        mouseDrag: true,
        pagination: true,
        nav: true,
        dots: false,
        navText: ['<span class="owl_text"><i class="icon-glyph-205"></i></span>', 
        '<span class="owl_text"><i class="icon-glyph-204"></i></span>'],
        responsive: {
            1200: {
                items: 2
            },
            992: {
                items: 2
            },
            768: {
                items: 2
            },
            480: {
                items: 1
            },
            320: {
                items: 1
            },
            280: {
                items: 1
            }
        }
    });

    
    /* =======================================
           Testimonial Section 
       =======================================*/
    $("#service_carousel").owlCarousel({
        autoPlay: 3000, //Set AutoPlay to 5 seconds
        autoplay: true,
        smartSpeed: 1000, // Default is 250
        items: 3, //Set Testimonial items
        loop: true,
        margin: 30,
        singleItem: true,
        touchDrag: true,
        mouseDrag: true,
        pagination: true,
        nav: true,
        dots: false,
        navText: ['<span class="owl_text"><i class="icon-glyph-205"></i></span>', 
        '<span class="owl_text"><i class="icon-glyph-204"></i></span>'],
        responsive: {
            1200: {
                items: 3
            },
            992: {
                items: 3
            },
            768: {
                items: 2
            },
            480: {
                items: 1
            },
            320: {
                items: 1
            },
            280: {
                items: 1
            }
        }
    });
    /*=======================================
		Client Section  
	=======================================*/
    $("#client").owlCarousel({
        autoPlay: 3000, //Set AutoPlay to 6 seconds
        autoplay: true,
        smartSpeed: 1000, // Default is 250
        items: 5,
        margin: 30,
        loop: true,
        touchDrag: true,
        mouseDrag: true,
        pagination: true,
        dots: false,
        nav: false,
        responsive: {
            1200: {
                items: 5
            },
            992: {
                items: 4
            },
            768: {
                items: 4
            },
            480: {
                items: 3
            },
            320: {
                items: 2
            },
            280: {
                items: 1
            }
        }
    });
        /* =======================================
            single Page Nav
     =======================================*/
 
    // The actual plugin
    $('.single-page-nav').singlePageNav({
        offset: $('.single-page-nav').outerHeight(),
        filter: ':not(.external)',
        updateHash: true,
    });

    /* =======================================
        For Menu
    =======================================*/
    $("#navigation").menumaker({
        title: "",
        format: "multitoggle"
    });

    /* =======================================
    		WOW ANIMATION
    ======================================= */
    var wow = new WOW({
        mobile: false
    });
    wow.init();


    /*=======================================
        Scroll Top
    =======================================*/
    $(".scrollup").on('click', function() {
        $('html,body').animate({
            'scrollTop': '0'
        }, 4000);
        return false;
    });



})(jQuery);