/**
 *
 * 常用工具类
 */
var TUtil = {
    trim: function (str) {
        var trimRegex = /(?:^[ \t\n\r]+)|(?:[ \t\n\r]+$)/g;
        return str.replace(trimRegex, '');
    },
    openUrl: function (url, type, name, width, height, left, top) {
        var availWidth = screen.availWidth - 25;
        var availHeight = screen.availHeight - 70;
        var myWidth = width ? width : availWidth;
        var myHeight = height ? height : availHeight;
        var myLeft = left ? left : (availWidth - myWidth) / 2;
        var myTop = top ? left : (availHeight - myHeight) / 2;
        if (!name)
            name = "";
        if (this.isIE() && type == 'modal')
            var returnValue = window.showModalDialog(url, window, "edge:raised;scroll:1;status:0;help:0;resizable:1;dialogWidth:" + myWidth + "px;dialogHeight:" + myHeight + "px;dialogTop:" + myTop + "px;dialogLeft:" + myLeft + "px", true);
        else {
            opened = window.open(url, name, 'height=' + myHeight + ',width=' + myWidth + ',status=1,toolbar=no,menubar=no,location=no,scrollbars=yes,modal=yes,dependent=yes,dialog=yes,minimizable=no,top=' + myTop + ',left=' + myLeft + ',resizable=yes', true);
            opened.focus();
        }
        if (returnValue == undefined) {
            returnValue = window.returnValue;
        }
        return returnValue;
    },
    winClose: function () {
        if (typeof (window.external.OA_SMS) != "undefined") {
            window.external.OA_SMS('', '', 'CLOSE_WINDOW');
        } else {
            window.close();
        }
    },
    winConfirmClose: function () {
        if (window._originalConfirm("是否确认关闭？")) {
            if (typeof (window.external.OA_SMS) != "undefined") {
                window.external.OA_SMS('', '', 'CLOSE_WINDOW');
            } else {
                window.close();
            }
        }
    },
    isUndefined: function (variable) {
        return typeof variable === 'undefined' ? true : false;
    },
    nl2br: function (str, is_xhtml) {
        var breakTag = (is_xhtml || typeof is_xhtml === 'undefined') ? '<br />' : '<br>';
        return (str + '').replace(/([^>\r\n]?)(\r\n|\n\r|\r|\n)/g, "$1" + breakTag + "$2");
    },
    sprintf: function () {
        var arg = arguments,
            str = arg[0] || '',
            i, n;
        for (i = 1, n = arg.length; i < n; i++) {
            str = str.replace(/%s/, arg[i]);
        }
        return str;
    },

    browserVersion: function () {
        var Sys = {};
        var ua = navigator.userAgent.toLowerCase();
        var s;
        (s = ua.match(/rv:([\d.]+)\) like gecko/)) ? Sys.ie = s[1] :
            (s = ua.match(/msie ([\d.]+)/)) ? Sys.ie = s[1] :
                (s = ua.match(/firefox\/([\d.]+)/)) ? Sys.firefox = s[1] :
                    (s = ua.match(/chrome\/([\d.]+)/)) ? Sys.chrome = s[1] :
                        (s = ua.match(/opera.([\d.]+)/)) ? Sys.opera = s[1] :
                            (s = ua.match(/version\/([\d.]+).*safari/)) ? Sys.safari = s[1] : 0;

        return Sys;
    },

    isIE: function () {
        var obj = this.browserVersion();
        if (obj.ie)
            return true;
        else
            return false;
    },
    ie8FixIcon: function () {
        var head = document.getElementsByTagName('head')[0], style = document.createElement('style');
        style.type = 'text/css';
        style.styleSheet.cssText = ':before,:after{content:"" !important';
        head.appendChild(style);
        setTimeout(function () {
            head.removeChild(style);
        }, 0);
    },
    getOfficeVersion: function () {
        try {
            word = new ActiveXObject("Word.application");
        } catch (e) {
            return false;
        }
        if (word.Version === "11.0") {
            version = "office2003";
        }
        else if (word.Version === "12.0") {
            version = "office2007";
        }
        else if (word.Version === "14.0") {
            version = "office2010";
        }
        word.Application.Quit();
        return version;
    }

};

/**
 *
 * CKeditor工具类
 */
var TCKEditorHelper = {
    getInstance: function (id) {
        if (TUtil.isUndefined(id))
            return null;
        else
            return eval("CKEDITOR.instances." + id);
    },
    insertImage: function (id, src) {
        var editor = this.getInstance(id);
        if (editor)
            editor.insertHtml('<img src="' + src + '">');
    },
    getEditorText: function (id) {
        var editor = this.getInstance(id);
        if (editor) {
            var element = CKEDITOR.dom.element.createFromHtml('<div>' + editor.getData() + '</div>');
            return element.getText();
        }
    },
    getEditorHtml: function (id) {
        var editor = this.getInstance(id);
        if (editor) {
            return editor.getData();
        }
    },
    setEditorHtml: function (id, html) {
        var editor = this.getInstance(id);
        if (editor) {
            editor.setData(html);
        }
    }
};


/**
 *
 * URL管理器
 */
var TUrlManager = {
    settings: {
        'baseUrl': window.location.href,
        'params': {},
        'rewrite': true
    },
    parse: function () {
        var self = this;
        var url = this.settings.baseUrl;
        $.each(this.settings.params, function (k, v) {
            if (self.settings.rewrite === true) {
                var exp = new RegExp('/' + k + '/\\w*');
                if (exp.test(url)) {
                    url = url.replace(exp, '/' + k + '/' + v);
                } else {
                    url += '/' + k + '/' + v;
                }
            } else {
                var exp = new RegExp('&' + k + '=' + '\\w*');
                if (exp.test(url)) {
                    url = url.replace(exp, '&' + k + '=' + v);
                } else {
                    url += '&' + k + '=' + v;
                }
            }
        });
        return url;
    },
    parseUrl: function (options) {
        if (typeof options === 'object') {
            if (options.params)
                this.settings = $.extend(this.settings, options || {});
            else
                this.settings.params = options;
        }
        return this.parse();
    }
};

var TTreeUtil = {
    contextMenu: function (contextMenuId, callback, event, treeId, treeNode) {
        event.preventDefault();
        if (!treeNode) {
            return false;
        }
        $.fn.zTree.getZTreeObj(treeId).selectNode(treeNode);
        var contextMenu = $('#' + contextMenuId);
        contextMenu.find(".dropdown-menu").show();
        var x = event.clientX;
        var y = event.clientY;
        contextMenu.css({"top": y + "px", "left": x + "px", "visibility": "visible"});
        if ($(window).height() - event.clientY < contextMenu.find(".dropdown-menu").outerHeight()) {
            contextMenu.addClass('dropup');
        } else {
            contextMenu.removeClass('dropup');
        }

        if (typeof callback === 'function') {
            callback(event, treeId, treeNode);
        }

    }
}

var TDate = {
    getDate: function () {
        var d = new Date();
        if (d) {
            return d.toLocaleDateString(); // 获取日期
        }
    }
};

var TImg = {
    autoResizeImage: function (maxWidth, maxHeight, objImg) {
        var hRatio;
        var wRatio;
        var Ratio = 1;
        var w = objImg.width;
        var h = objImg.height;
        wRatio = maxWidth / w;
        hRatio = maxHeight / h;
        if (maxWidth == 0 && maxHeight == 0) {
            Ratio = 1;
        } else if (maxWidth == 0) { //
            if (hRatio < 1)
                Ratio = hRatio;
        } else if (maxHeight == 0) {
            if (wRatio < 1)
                Ratio = wRatio;
        } else if (wRatio < 1 || hRatio < 1) {
            Ratio = (wRatio <= hRatio ? wRatio : hRatio);
        }
        if (Ratio < 1) {
            w = w * Ratio;
            h = h * Ratio;
        }
        objImg.height = h;
        objImg.width = w;
    }
}

var HtmlUtil = {
    /*1.用浏览器内部转换器实现html转码*/
    htmlEncode: function (html) {
        //1.首先动态创建一个容器标签元素，如DIV
        var temp = document.createElement("p");
        //2.然后将要转换的字符串设置为这个元素的innerText(ie支持)或者textContent(火狐，google支持)
        (temp.textContent != undefined) ? (temp.textContent = html) : (temp.innerText = html);
        //3.最后返回这个元素的innerHTML，即得到经过HTML编码转换的字符串了
        var output = temp.innerHTML;
        temp = null;
        return output;
    },
    /*2.用浏览器内部转换器实现html解码*/
    htmlDecode: function (text) {
        //1.首先动态创建一个容器标签元素，如DIV
        var temp = document.createElement("p");
        //2.然后将要转换的字符串设置为这个元素的innerHTML(ie，火狐，google都支持)
        temp.innerHTML = text;
        //3.最后返回这个元素的innerText(ie支持)或者textContent(火狐，google支持)到经过HTML解码的字符串了。
        var output = temp.innerText || temp.textContent;
        temp = null;
        return output;
    },
    /*3.用正则表达式实现html转码*/
    htmlEncodeByRegExp: function (str) {
        var s = "";
        if (str.length == 0) return "";
        s = str.replace(/&/g, "&amp;");
        s = s.replace(/</g, "&lt;");
        s = s.replace(/>/g, "&gt;");
        s = s.replace(/ /g, "&nbsp;");
        s = s.replace(/\'/g, "&#39;");
        s = s.replace(/\"/g, "&quot;");
        return s;
    },
    /*4.用正则表达式实现html解码*/
    htmlDecodeByRegExp: function (str) {
        var s = "";
        if (str.length == 0) return "";
        s = str.replace(/&amp;/g, "&");
        s = s.replace(/&lt;/g, "<");
        s = s.replace(/&gt;/g, ">");
        s = s.replace(/&nbsp;/g, " ");
        s = s.replace(/&#39;/g, "\'");
        s = s.replace(/&quot;/g, "\"");
        return s;
    }
};

var Doc = {
    heredoc0: function (fn) {
        return fn.toString().split('\n').slice(1, -1).join('\n') + '\n';
    },

    heredoc: function (fn) {
        return fn.toString().slice(14,-3);
    }
};