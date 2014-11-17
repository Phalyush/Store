

$(window).load(function () {
    var e = $(".MenuBtn");
    e.each(function (params) {
        var e = $("#" + this.id);
        if ($("#" + e.attr("id") + "ShowWin")) {
            var menuBlock = $("#menuBlock");
            // var offsetLeftE = e.offset().left;
            //  var midleMenuBlock = parseInt(menuBlock.css("width")) / 2;
            params = $.extend({
                marginTop: "0",
                marginLeft: "0",
                speedShow: '1000',
                way: 50,
            }, params);

            //creat ShoWin

            var elemId = e.attr("id") + 'ShowWin';


            //position ShoWin
            var position = function (marginTop, marginLeft, way) {
                var widthParentEl = menuBlock.width();
                // var heightParentEl = parseInt(e.css("height"));
                //  var marginLeftParentEl = parseInt(e.css("margin-left"));
                var WidthMenuBlock = menuBlock.width();
                var PositionElemetFromParent = e.offset().left - menuBlock.offset().left
                var WidthSlideElement = $("#" + elemId).width();
                if ((WidthMenuBlock - PositionElemetFromParent) < WidthSlideElement) {
                    $("#" + elemId).css({ "margin-left": +(WidthMenuBlock - WidthSlideElement) + "px" })
                }
                else { $("#" + elemId).css({ "margin-left": +PositionElemetFromParent + "px" }) }

                $("#" + elemId).css({ "margin-top": way + "px" })

                to = 0; // Конечная координата X
                from = way; // Начальная координата X


            };
            position(params.marginTop, params.marginLeft, params.way);
            //animate
            var anim;
            function animate() {
                var start = new Date().getTime(); // Время старта
                anim = setTimeout(function () {
                    var now = (new Date().getTime()) - start; // Текущее время
                    var progress = now / params.speedShow; // Прогресс анимации
                    var result = (to - from) * delta(progress) + from;
                    $("#" + elemId).css({ "margin-top": +result + "px" });
                    if (progress < 1) // Если анимация не закончилась, продолжаем
                    {
                        if ($("#" + elemId).hasClass("visibleShoWin"))
                            setTimeout(arguments.callee, 10);
                        else
                            $("#" + elemId).hide();
                    }

                }, 10);
            }

            //способи анимации
            function delta(progress) {
                function d(progress) {
                    for (var a = 0, b = 1, result; 1; a += b, b /= 2) {
                        if (progress >= (7 - 4 * a) / 11)
                            return -Math.pow((11 - 6 * a - 11 * progress) / 4, 2) + Math.pow(b, 2);
                    }
                }
                return 1 - d(1 - progress);
            }


            $(this).mouseenter(function () {
                clearTimeout(anim);
                $(".showWin").removeClass("visibleShoWin").hide();
                if (!$("#" + elemId).hasClass("visibleShoWin")) {
                    mouseEnterFromBtn = setTimeout(function () {
                        $("#" + elemId).addClass("visibleShoWin").show(0);
                        animate();
                    }, 300)
                }
            })
                .mouseleave(function () {
                    clearTimeout(mouseEnterFromBtn);
                    mouseLeaveFromBtn = setTimeout(function () {
                        $("#" + elemId).hide(0).removeClass("visibleShoWin");
                        animate();
                    }, 300)
                });


            $("#" + elemId).mouseleave(function () {
                mouseLeaveFromBtn = setTimeout(function () {
                    $("#" + elemId).hide(0).removeClass("visibleShoWin");
                    animate();
                }, 300)

            }).mouseenter(function () { clearTimeout(mouseLeaveFromBtn) })

        }
    });

});