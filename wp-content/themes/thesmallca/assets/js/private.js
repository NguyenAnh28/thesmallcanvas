if($(window).innerWidth() >= 1024){
    history.scrollRestoration = "manual";
    $(window).on('beforeunload', function(){
        $(window).scrollTop(0);
    });
    const lenis = new Lenis({
        duration: 1.2,
    })
    function raf(time) {
        lenis.raf(time);
        ScrollTrigger.update();
        requestAnimationFrame(raf)
    }
    requestAnimationFrame(raf)
}

AOS.init({
    duration: 1200,
})


history.scrollRestoration = "manual";
$(window).on('beforeunload', function(){
    $(window).scrollTop(0);
});

$(".clc-menu").click(function(){
    $('.nav-menu').toggleClass('open_menu');
    $('body').toggleClass('active');
});

$('.head-ard').click(function(){
    $('.item-exh .answer').slideUp(300);
    $('.head-ard').removeClass('active');
    var tab_id = $(this).attr('data-tab');
    $('.head-ard').removeClass('active');
    $('.sidebar-ex .avarta').removeClass('active');
    $(this).addClass('active');
    $("#"+tab_id).addClass('active');
    $(this).next().slideToggle(300);
})

$('.picture_wrapper a').click(function(){
    $('body, .overlay').addClass('active');
    var tab_id = $(this).attr('data-tab');
    $(this).addClass('active');
    $("#"+tab_id).addClass('active lenis lenis-smooth');
})

$('.close-galley a').click(function(){
    $('.overlay, body').removeClass('active');
    $('.item-gallery').removeClass('active lenis lenis-smooth');
})

$('.overlay').click(function(){
    $('.overlay, body').removeClass('active');
    $('.item-gallery').removeClass('active lenis lenis-smooth');
})