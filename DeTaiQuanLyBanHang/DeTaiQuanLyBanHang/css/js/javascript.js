$(document).ready(function () {
    setInterval(function () {
        $('.top ul').animate({ 'margin-left': '-=1000px' }, 1000, function () {
            $('.top ul li:first').appendTo('.top ul');
            $('.top ul').css('margin-left', 0);
        });
    }, 3000);
});
