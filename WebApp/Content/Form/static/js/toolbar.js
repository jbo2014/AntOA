function ReLayoutToolbar() {
    $(".cke_inner").append("<div id='news' style='float: left;'></div>");
    var xdiv = null;
    var xspan = null;
    $(".cke_toolbox > span").each(function (i, n) {
        if ($(n).hasClass("cke_toolbar")) {
            xdiv = $("<div></div>").appendTo(news);
            $(n).children(".cke_toolgroup").children("a").each(function (i, m) {
                if ((i + 1) % 3 == 1) {
                    xspan = $("<span></span>").appendTo(xdiv);
                }
                xspan.append(m);
            });
        } else if ($(n).hasClass("cke_toolbar_break")) {
            $(news).append("<span>aaaaaaaaaaaa</span>");
        }
    })
    $("#news span").css({ "display": "inline-block", "height": "100px" });
    $("#news a").css({ "display": "block" });
    $(".cke_toolbox").empty();
}