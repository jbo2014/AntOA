/**
 *  下一步按钮
 */
var Next = {
    submit: function (args) {
        $.ajax({
            type: "POST",
            url: gSubmitUrl,
            data: args,
            success: function (xhr) {
                alert(xhr.Message);
                if (xhr.Code==200) {
                    $(window).attr('location', '/Home/List');
                }
            }
        });
    }
};

/**
 *  控件的操作属性
 */
var Operate = {    
    dataFields: {},
    LoadWidget: function () {
        Operate.FetchData();
        Operate.SetData(Operate.dataFields);
        Operate.SetView($('#FormHtml').find('*[field]'));
    },
    FetchData: function () {
        var readFields = [];
        $('#FormHtml').find('*[field]').each(function (i, n) {
            if ($(n).attr('operate') == "ReadNoWrite" || $(n).attr('operate') == "ReadWrite") {
                readFields.push($(n).attr('field'));
            }
        });
        if (readFields.length > 0) {
            $.ajax({
                type: "POST",
                async: false,
                url: gInitWidget,
                data: { "InstanceGuid": gInstanceGuid, "fields": JSON.stringify(readFields) },
                success: function (xhr) {
                    $.each(JSON.parse(xhr.Data), function (i, n) {
                        Operate.dataFields[i] = n;
                    });
                }
            });
        }
    },
    //设置控件的值
    SetData: function (data) {
        $.each(data, function (i, n) {
            $('#FormHtml').find('*[field="'+i+'"]').val(n);
        });
    },
    //设置控件的可见性
    SetView: function (objs) {
        $(objs).each(function (i, n) {
            var o = $(n).attr('operate');
            if (o == 'NoReadNoWrite')
                Operate.NoReadNoWrite(n);
            else if (o == 'ReadNoWrite')
                Operate.ReadNoWrite(n);
            else if (o == 'NoReadWrite')
                Operate.NoReadWrite(n);
            else if (o == 'ReadWrite')
                Operate.ReadWrite(n);
        });
    },
    NoReadNoWrite: function (obj) {
        $(obj).hide();
    },
    ReadNoWrite: function (obj) {
        $(obj).attr("disabled", true);
    },
    NoReadWrite: function (obj) {
        $(obj).val("");
    },
    ReadWrite: function (obj) {
    }
};