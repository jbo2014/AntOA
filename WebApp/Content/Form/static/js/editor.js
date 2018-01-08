/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
var AIPDesigner = {
    
}
var editor = {
    editorObj: null,
    hideTitle: '展开列表',
    showTitle: '收起列表',
    init: function () {
        if ($.cookie('leftBar')) {
            var icon = $.cookie('leftBar') == 'hide' ? 'left-16' : 'right-17';
            var title = $.cookie('leftBar') == 'hide' ? editor.hideTitle : editor.showTitle;
            $('#collapsing i').addClass('icon-arrow-' + icon);
            $('#collapsing').attr('title', title);
        } else {
            $('#collapsing i').addClass('icon-arrow-right-17');
            $('#collapsing').attr('title', editor.showTitle);
            $.cookie('leftBar', 'show');
        }
        $('#collapsing i').on('click', editor.toogle);
        this.editorObj = CKEDITOR.instances.FormHtml_print_model;
    },
    remove: function (obj) {
        var dataID = $(obj).parents('tr').attr('id');
        dataID = dataID.substr(6, dataID.length);
        var key = $(obj).parents('tr').attr('key');
        var eleObj = editor.editorObj.document.getById(dataID);

        if (eleObj) {
            window.confirm('确认要删除控件？', function (ret) {
                if (ret == true) {
                    $.post(g_removeURL, {
                        id: key
                    }, function (data) {
                        if (data == 'OK') {
                            $(obj).parents('tr').remove();
                            $(eleObj.$).parent().hasClass("input-prepend") ? $(eleObj.$).parent().remove() : eleObj.remove();
                            $.notify({
                                type: 'success',
                                message: {
                                    text: '删除成功'
                                }
                            }).show();
                        }
                    });
                }
            });
        } else {
            console.log('对象不存在 or 对象为隐藏域');
        }
    },
    update: function (obj) {
        var eleType = $(obj).parents('tr').attr('field_type');
        var dataID = $(obj).parents('tr').attr('id');
        dataID = dataID.substr(6, dataID.length);
        var ele = editor.editorObj.document.getById(dataID);
        if (eleType == 'label')
            ele = ele.getChild(0);
        else if (eleType == 'hidden') {
            console.log('暂不支持隐藏域编辑');
            return false;
        }
        ele.focus()
        var selection = editor.editorObj.getSelection();
        selection.selectElement(ele);
        switch (eleType) {
            case 'v_text':
            case 'v_int':
            case 'v_float':
            case 'v_date':
            case 'v_email':
                editor.editorObj.openDialog('tdtextfield');
                break;
            case 'textarea':
                editor.editorObj.openDialog('tdtextarea');
                break;
            case 'countersign':
                editor.editorObj.openDialog('countersign');
                break;
            case 'select':
                editor.editorObj.openDialog('tdselect');
                break;
            case 'label':
                editor.editorObj.openDialog('tdradio');
                break;
            case 'checkbox':
                editor.editorObj.openDialog('tdcheckbox');
                break;
            case 'hidden':
                editor.editorObj.openDialog('tdhidden');
                break;
            case 'macro':
                editor.editorObj.openDialog('macro');
                break;
            case 'tcount':
                editor.editorObj.openDialog('tcount');
                break;
            case 'date':
            case 'datetime':
            case 'custom':
                editor.editorObj.openDialog('cdxdtpicker');
                break;
            case 'user':
            case 'dept':
                editor.editorObj.openDialog('suseranddept');
                break;
            case 'listview':
                editor.editorObj.openDialog('listview');
                break;
            case 'signature':
                editor.editorObj.openDialog('signature');
                break;
            case 'pdf417':
            case 'qrcode':
                editor.editorObj.openDialog('dimensionalcode');
                break;
            case 'writesign':
                editor.editorObj.openDialog('writesign');
                break;
            case 'fileupload':
                editor.editorObj.openDialog('fileupload');
                break;
            case 'syscode':
                editor.editorObj.openDialog('syscode');
                break;
            default:
                alert('未定义的控件类型：' + eleType);
                break;

        }
    },
    toogle: function () {
        if ($(this).attr('class') == 'icon-arrow-right-17') {
            $.cookie('leftBar', 'hide');
            $('#collapsing').attr('title', editor.hideTitle);
            $(this).removeClass('icon-arrow-right-17').addClass('icon-arrow-left-16');
            $("#left_bar").hide('slow', function () {
                $(window).trigger('resize');
            });
        } else {
            $.cookie('leftBar', 'show');
            $('#collapsing').attr('title', editor.showTitle);
            $(this).removeClass('icon-arrow-left-16').addClass('icon-arrow-right-17');
            $(window).trigger('resize');
            $("#left_bar").show('slow');
        }
    },
    formSave: function () {
        window.onbeforeunload = function () { };        
        $('#form-html-form').submit();
    },
    close: function () {
        window.confirm('确认离开此页面？', function (ret) {
            if (ret == true) {
                window.onbeforeunload = function () { };
                if ($.browser.msie) {
                    window.opener = null;
                    window.open('', '_self');
                }
                window.close();
            }
        });
    }
}
window.onbeforeunload = function (e) {
    var msg = '离开前请确认表单是否已经保存？';
    e = e || window.event;
    if (e) {
        e.returnValue = msg
    }
    return msg;
};