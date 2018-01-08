/**
* @license Copyright (c) 2003-2012, CKSource - Frederico Knabben. All rights reserved.
* For licensing, see LICENSE.html or http://ckeditor.com/license
*/
CKEDITOR.dialog.add('tdtextfield', function (editor) {
    var acceptedTypes = {
        v_email: 1,
        v_int: 1,
        v_float: 1,
        v_date: 1,
        v_text: 1
    };
    var fields = $.ajax({
        type: "post",
        url: g_getFieldsURL,
        data: {
            isInstance: isInstance,
            guid: mainID
        },
        cache: false,
        async: false
    }).responseText;
    var jObj = JSON.parse(fields);
    var list = [];
    $.each(jObj, function (i, n) {
        list.push([n.Name, n.Name]);
    });
    return {
        title: editor.lang.tdforms.tdtextfield.dialogTitle,
        minWidth: editor.lang.tdforms.tdtextfield.minWidth,
        minHeight: editor.lang.tdforms.tdtextfield.minHeight,
        onShow: function () {
            delete this.textField;

            var element = this.getParentEditor().getSelection().getSelectedElement();
            if (element && element.getName() == "input" && element.getAttribute('type')=="text") {
                this.textField = element;
                this.setupContent(element);
            }
        },
        onOk: function () {
            var editor = this.getParentEditor(),
            element = this.textField,
            widget_json = '', fieldId = '',
            field_name = this.getValueOf('base', 'title'),
            //widget = this.getValueOf('info', 'widget'),
            height = this.getValueOf('base', 'height'),
            width = this.getValueOf('base', 'width'),
            operate = this.getValueOf('base', 'operate'),
            field = this.getValueOf('bind', 'field'),
            value = this.getValueOf('bind', 'value'),
            isInsertMode = !element;
            widget_json += '{' + '"field_name":' + '"' + field_name + '",' + '"field_attr":' + '{'
                + '"title":' + '"' + field_name + '",' + '"field":' + '"' + field + '",'
                + '"value":' + '"' + value + '",' + '"height":' + '"' + height + '",'
                + '"width":' + '"' + width + '",' + '"operate":' + '"' + operate + '"}}';

            if (isInsertMode) {
                element = editor.document.createElement('input');
                element.setAttribute('type', 'text');
            }
            $(element.$).removeAttr('style');
            element.setAttribute('value', value);
            element.setAttribute('title', field_name);
            element.setAttribute('field', field);
            element.setAttribute('operate', operate);
            //if (fontSize)
            //    $(element.$).css({
            //        "font-size": fontSize + "px"
            //    });
            if (height)
                $(element.$).css({
                    "height": height + "px"
                });
            if (width)
                $(element.$).css({
                    "width": width + "px"
                });
            var data = {
                element: element
            };

            if (isInsertMode) {
                fieldId = $.ajax({
                    type: "post",
                    url: g_requestURL,
                    data: {
                        fieldInfo: widget_json,
                        formID: g_form_id
                    },
                    cache: false,
                    async: false
                }).responseText;
                if (fieldId == 'repeat') {
                    _originalAlert(field_name + ' 字段已存在！');
                    return false;
                } else {
                    element.setAttribute('name', 'data_' + fieldId);
                    element.setAttribute('id', 'data_' + fieldId);
                    editor.insertElement(data.element);
                    this.commitContent(data);
                }
            }

            // Element might be replaced by commitment.
            if (!isInsertMode) {
                fieldId = element.getAttribute('name').split('_')[1];
                fieldId = $.ajax({
                    type: "post",
                    url: g_requestURL,
                    data: {
                        fieldInfo: widget_json,
                        formID: g_form_id,
                        fieldId: fieldId
                    },
                    cache: false,
                    async: false
                }).responseText;
                if (fieldId == 'repeat') {
                    _originalAlert(field_name + ' 字段已存在！');
                    return false;
                } else
                    editor.getSelection().selectElement(data.element);
            }
        },
        contents: [
        {
            id: 'base',
            label: editor.lang.tdforms.common.baseTab,
            elements: [
            {
                type: 'hbox',
                children: [
                {
                    id: 'title',
                    type: 'text',
                    label: editor.lang.common.controlName,
                    validate: CKEDITOR.dialog.validate.notEmpty(editor.lang.common.validateControlFailed),
                    'default': '',
                    accessKey: 'N',
                    setup: function (element) {
                        this.setValue(element.getAttribute('title') || '');
                    },
                    commit: function (data) {
                        var element = data.element;
                        if (this.getValue())
                            element.setAttribute('title', this.getValue());
                    }
                }
                ]
            },
            {
                type: 'hbox',
                widths: ['50%', '50%'],
                children: [
                {
                    id: 'height',
                    type: 'text',
                    label: editor.lang.tdforms.tdtextfield.height,
                    'default': '',
                    accessKey: 'C',
                    validate: CKEDITOR.dialog.validate.integer(editor.lang.common.validateNumberFailed),
                    setup: function (element) {
                        this.setValue(element.$.style.height.substr(0, element.$.style.height.length - 2));
                    }
                },
                {
                    id: 'width',
                    type: 'text',
                    label: editor.lang.tdforms.tdtextfield.width,
                    'default': '',
                    accessKey: 'M',
                    validate: CKEDITOR.dialog.validate.integer(editor.lang.common.validateNumberFailed),
                    setup: function (element) {
                        this.setValue(element.$.style.width.substr(0, element.$.style.width.length - 2));
                    }
                }
                ]
            },
            {
                id: 'operate',
                type: 'select',
                label: editor.lang.tdforms.common.operate,
                validate: CKEDITOR.dialog.validate.notEmpty(editor.lang.common.validateDataType),
                'default': 'NoReadNoWrite',
                accessKey: 'M',
                items: [
                [editor.lang.tdforms.operatelist.NoReadNoWrite, 'NoReadNoWrite'],
                [editor.lang.tdforms.operatelist.ReadNoWrite, 'ReadNoWrite'],
                [editor.lang.tdforms.operatelist.NoReadWrite, 'NoReadWrite'],
                [editor.lang.tdforms.operatelist.ReadWrite, 'ReadWrite']
                ],
                setup: function (element) {
                    this.setValue(element.getAttribute('operate'));
                },
                commit: function (data) {
                    var element = data.element;
                    if (this.getValue())
                        element.setAttribute('operate', this.getValue());
                }
            }
            ]
        }, {
            id: 'bind',
            label: editor.lang.tdforms.common.bindTab,
            elements: [
            {
                type: 'hbox',
                children: [
                {
                    id: 'field',
                    type: 'select',
                    label: editor.lang.tdforms.common.bindField,
                    validate: CKEDITOR.dialog.validate.notEmpty(editor.lang.common.validateDataType),
                    'default': editor.lang.tdforms.common.choice,
                    accessKey: 'M',
                    items: list,
                    setup: function (element) {
                        this.setValue(element.getAttribute('field'));
                    },
                    commit: function (data) {
                        var element = data.element;
                        if (CKEDITOR.env.ie) {
                            var elementType = element.getAttribute('field');
                            var myType = this.getValue();

                            if (elementType != myType) {
                                var replace = CKEDITOR.dom.element.createFromHtml('<input type="text" field="' + myType + '"></input>', editor.document);
                                element.copyAttributes(replace, {
                                    type: 1
                                });
                                replace.replace(element);
                                data.element = replace;
                            }
                        } else
                            element.setAttribute('field', this.getValue());
                    }
                }
                ]
            }, {
                type: 'hbox',
                children: [
                {
                    id: 'newButton',
                    type: 'button',
                    label: editor.lang.tdforms.common.newField,
                    accessKey: 'V',
                    onClick: function (element) {
                        // this = CKEDITOR.ui.dialog.button
                        $('#personModal').modal('show');
                    }
                }
                ]
            }, {
                type: 'hbox',
                children: [
                {
                    id: 'value',
                    type: 'text',
                    label: editor.lang.common.value,
                    'default': '',
                    accessKey: 'V',
                    commit: function (data) {
                        if (CKEDITOR.env.ie && !this.getValue()) {
                            var element = data.element,
                            fresh = new CKEDITOR.dom.element('input', editor.document);
                            element.copyAttributes(fresh, {
                                value: 1
                            });
                            fresh.replace(element);
                            data.element = fresh;
                        }
                    },
                    setup: function (element) {
                        this.setValue(element.getAttribute('value') || '');
                    }
                }
                ]
            }
            ]
        }
        ]
    };
});
