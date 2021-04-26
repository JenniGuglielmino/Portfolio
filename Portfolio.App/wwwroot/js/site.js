$(document).ready(main);

function main(){
    $('.btn-menu').click(function(){
        $('.nav-porfolio').animate({height: 'toggle'});
    });

    var scene = document.getElementById('scene');
    var parallaxInstance = new Parallax(scene);
    parallaxInstance.clipRelativeInput = true;
    parallaxInstance.limitX = 100;
    parallaxInstance.limitY = 10;
}