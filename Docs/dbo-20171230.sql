/*
Navicat SQL Server Data Transfer

Source Server         : SqlServer(local)
Source Server Version : 110000
Source Host           : .:1433
Source Database       : AntOA
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 110000
File Encoding         : 65001

Date: 2017-12-30 10:10:34
*/


-- ----------------------------
-- Table structure for CodeTable
-- ----------------------------
DROP TABLE [dbo].[CodeTable]
GO
CREATE TABLE [dbo].[CodeTable] (
[CodeCD] nvarchar(100) NULL ,
[Group] nvarchar(100) NULL ,
[Name] nvarchar(100) NULL ,
[Value] nvarchar(255) NULL ,
[Sort] int NULL ,
[Description] nvarchar(50) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'CodeTable', 
'COLUMN', N'CodeCD')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'码表CD'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'CodeTable'
, @level2type = 'COLUMN', @level2name = N'CodeCD'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'码表CD'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'CodeTable'
, @level2type = 'COLUMN', @level2name = N'CodeCD'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'CodeTable', 
'COLUMN', N'Group')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'码组'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'CodeTable'
, @level2type = 'COLUMN', @level2name = N'Group'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'码组'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'CodeTable'
, @level2type = 'COLUMN', @level2name = N'Group'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'CodeTable', 
'COLUMN', N'Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'码名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'CodeTable'
, @level2type = 'COLUMN', @level2name = N'Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'码名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'CodeTable'
, @level2type = 'COLUMN', @level2name = N'Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'CodeTable', 
'COLUMN', N'Value')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'码值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'CodeTable'
, @level2type = 'COLUMN', @level2name = N'Value'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'码值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'CodeTable'
, @level2type = 'COLUMN', @level2name = N'Value'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'CodeTable', 
'COLUMN', N'Sort')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'排列顺序'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'CodeTable'
, @level2type = 'COLUMN', @level2name = N'Sort'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'排列顺序'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'CodeTable'
, @level2type = 'COLUMN', @level2name = N'Sort'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'CodeTable', 
'COLUMN', N'Description')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'描述'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'CodeTable'
, @level2type = 'COLUMN', @level2name = N'Description'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'描述'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'CodeTable'
, @level2type = 'COLUMN', @level2name = N'Description'
GO

-- ----------------------------
-- Records of CodeTable
-- ----------------------------
INSERT INTO [dbo].[CodeTable] ([CodeCD], [Group], [Name], [Value], [Sort], [Description]) VALUES (N'StartForm', N'FormType', N'开始表单', N'0', N'0', null)
GO
GO
INSERT INTO [dbo].[CodeTable] ([CodeCD], [Group], [Name], [Value], [Sort], [Description]) VALUES (N'TaskForm', N'FormType', N'任务表单', N'1', N'1', null)
GO
GO
INSERT INTO [dbo].[CodeTable] ([CodeCD], [Group], [Name], [Value], [Sort], [Description]) VALUES (N'ShareForm', N'FormType', N'共享表单', N'2', N'2', null)
GO
GO

-- ----------------------------
-- Table structure for DtFieldDatetime
-- ----------------------------
DROP TABLE [dbo].[DtFieldDatetime]
GO
CREATE TABLE [dbo].[DtFieldDatetime] (
[ColumnGuid] uniqueidentifier NOT NULL ,
[InstanceGuid] uniqueidentifier NOT NULL ,
[Name] nvarchar(50) NULL ,
[Value] datetime NULL ,
[Description] nvarchar(100) NULL ,
[Format] nvarchar(50) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldDatetime', 
NULL, NULL)) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'时间内容存储'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDatetime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'时间内容存储'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDatetime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldDatetime', 
'COLUMN', N'ColumnGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列的GUID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDatetime'
, @level2type = 'COLUMN', @level2name = N'ColumnGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列的GUID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDatetime'
, @level2type = 'COLUMN', @level2name = N'ColumnGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldDatetime', 
'COLUMN', N'InstanceGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'对应流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDatetime'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'对应流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDatetime'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldDatetime', 
'COLUMN', N'Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDatetime'
, @level2type = 'COLUMN', @level2name = N'Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDatetime'
, @level2type = 'COLUMN', @level2name = N'Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldDatetime', 
'COLUMN', N'Value')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDatetime'
, @level2type = 'COLUMN', @level2name = N'Value'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDatetime'
, @level2type = 'COLUMN', @level2name = N'Value'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldDatetime', 
'COLUMN', N'Description')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列描述'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDatetime'
, @level2type = 'COLUMN', @level2name = N'Description'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列描述'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDatetime'
, @level2type = 'COLUMN', @level2name = N'Description'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldDatetime', 
'COLUMN', N'Format')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'时间格式字符串'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDatetime'
, @level2type = 'COLUMN', @level2name = N'Format'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'时间格式字符串'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDatetime'
, @level2type = 'COLUMN', @level2name = N'Format'
GO

-- ----------------------------
-- Records of DtFieldDatetime
-- ----------------------------

-- ----------------------------
-- Table structure for DtFieldDecimal
-- ----------------------------
DROP TABLE [dbo].[DtFieldDecimal]
GO
CREATE TABLE [dbo].[DtFieldDecimal] (
[ColumnGuid] uniqueidentifier NOT NULL ,
[InstanceGuid] uniqueidentifier NOT NULL ,
[Name] nvarchar(50) NULL ,
[Value] decimal(18) NULL ,
[Description] nvarchar(100) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldDecimal', 
NULL, NULL)) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'小数内容存储'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDecimal'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'小数内容存储'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDecimal'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldDecimal', 
'COLUMN', N'ColumnGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列的GUID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDecimal'
, @level2type = 'COLUMN', @level2name = N'ColumnGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列的GUID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDecimal'
, @level2type = 'COLUMN', @level2name = N'ColumnGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldDecimal', 
'COLUMN', N'InstanceGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'对应流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDecimal'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'对应流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDecimal'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldDecimal', 
'COLUMN', N'Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDecimal'
, @level2type = 'COLUMN', @level2name = N'Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDecimal'
, @level2type = 'COLUMN', @level2name = N'Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldDecimal', 
'COLUMN', N'Value')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDecimal'
, @level2type = 'COLUMN', @level2name = N'Value'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDecimal'
, @level2type = 'COLUMN', @level2name = N'Value'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldDecimal', 
'COLUMN', N'Description')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列描述'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDecimal'
, @level2type = 'COLUMN', @level2name = N'Description'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列描述'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldDecimal'
, @level2type = 'COLUMN', @level2name = N'Description'
GO

-- ----------------------------
-- Records of DtFieldDecimal
-- ----------------------------

-- ----------------------------
-- Table structure for DtFieldInt
-- ----------------------------
DROP TABLE [dbo].[DtFieldInt]
GO
CREATE TABLE [dbo].[DtFieldInt] (
[ColumnGuid] uniqueidentifier NOT NULL ,
[InstanceGuid] uniqueidentifier NOT NULL ,
[Name] nvarchar(50) NULL ,
[Value] int NULL ,
[Description] nvarchar(100) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldInt', 
NULL, NULL)) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'整数内容存储'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldInt'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'整数内容存储'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldInt'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldInt', 
'COLUMN', N'ColumnGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列的GUID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldInt'
, @level2type = 'COLUMN', @level2name = N'ColumnGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列的GUID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldInt'
, @level2type = 'COLUMN', @level2name = N'ColumnGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldInt', 
'COLUMN', N'InstanceGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'对应流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldInt'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'对应流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldInt'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldInt', 
'COLUMN', N'Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldInt'
, @level2type = 'COLUMN', @level2name = N'Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldInt'
, @level2type = 'COLUMN', @level2name = N'Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldInt', 
'COLUMN', N'Value')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldInt'
, @level2type = 'COLUMN', @level2name = N'Value'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldInt'
, @level2type = 'COLUMN', @level2name = N'Value'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldInt', 
'COLUMN', N'Description')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列描述'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldInt'
, @level2type = 'COLUMN', @level2name = N'Description'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列描述'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldInt'
, @level2type = 'COLUMN', @level2name = N'Description'
GO

-- ----------------------------
-- Records of DtFieldInt
-- ----------------------------

-- ----------------------------
-- Table structure for DtFieldText
-- ----------------------------
DROP TABLE [dbo].[DtFieldText]
GO
CREATE TABLE [dbo].[DtFieldText] (
[ColumnGuid] uniqueidentifier NOT NULL ,
[InstanceGuid] uniqueidentifier NOT NULL ,
[Name] nvarchar(50) NULL ,
[Value] ntext NULL ,
[Description] nvarchar(100) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldText', 
NULL, NULL)) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'大文本内容存储'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldText'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'大文本内容存储'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldText'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldText', 
'COLUMN', N'ColumnGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列的GUID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldText'
, @level2type = 'COLUMN', @level2name = N'ColumnGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列的GUID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldText'
, @level2type = 'COLUMN', @level2name = N'ColumnGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldText', 
'COLUMN', N'InstanceGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'对应流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldText'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'对应流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldText'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldText', 
'COLUMN', N'Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldText'
, @level2type = 'COLUMN', @level2name = N'Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldText'
, @level2type = 'COLUMN', @level2name = N'Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldText', 
'COLUMN', N'Value')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldText'
, @level2type = 'COLUMN', @level2name = N'Value'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldText'
, @level2type = 'COLUMN', @level2name = N'Value'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldText', 
'COLUMN', N'Description')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列描述'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldText'
, @level2type = 'COLUMN', @level2name = N'Description'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列描述'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldText'
, @level2type = 'COLUMN', @level2name = N'Description'
GO

-- ----------------------------
-- Records of DtFieldText
-- ----------------------------

-- ----------------------------
-- Table structure for DtFieldVarchar
-- ----------------------------
DROP TABLE [dbo].[DtFieldVarchar]
GO
CREATE TABLE [dbo].[DtFieldVarchar] (
[ColumnGuid] uniqueidentifier NOT NULL ,
[InstanceGuid] uniqueidentifier NOT NULL ,
[Name] nvarchar(50) NULL ,
[Value] nvarchar(100) NULL ,
[Description] nvarchar(100) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldVarchar', 
NULL, NULL)) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'少量文本存储（限制在100字以内）'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldVarchar'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'少量文本存储（限制在100字以内）'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldVarchar'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldVarchar', 
'COLUMN', N'ColumnGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列的GUID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldVarchar'
, @level2type = 'COLUMN', @level2name = N'ColumnGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列的GUID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldVarchar'
, @level2type = 'COLUMN', @level2name = N'ColumnGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldVarchar', 
'COLUMN', N'InstanceGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'对应流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldVarchar'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'对应流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldVarchar'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldVarchar', 
'COLUMN', N'Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldVarchar'
, @level2type = 'COLUMN', @level2name = N'Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldVarchar'
, @level2type = 'COLUMN', @level2name = N'Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldVarchar', 
'COLUMN', N'Value')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldVarchar'
, @level2type = 'COLUMN', @level2name = N'Value'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldVarchar'
, @level2type = 'COLUMN', @level2name = N'Value'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldVarchar', 
'COLUMN', N'Description')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列描述'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldVarchar'
, @level2type = 'COLUMN', @level2name = N'Description'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列描述'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldVarchar'
, @level2type = 'COLUMN', @level2name = N'Description'
GO

-- ----------------------------
-- Records of DtFieldVarchar
-- ----------------------------

-- ----------------------------
-- Table structure for DtFieldXml
-- ----------------------------
DROP TABLE [dbo].[DtFieldXml]
GO
CREATE TABLE [dbo].[DtFieldXml] (
[ColumnGuid] uniqueidentifier NOT NULL ,
[InstanceGuid] uniqueidentifier NOT NULL ,
[Name] nvarchar(50) NULL ,
[Value] xml NULL ,
[Description] nvarchar(100) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldXml', 
NULL, NULL)) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'大文本内容存储'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldXml'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'大文本内容存储'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldXml'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldXml', 
'COLUMN', N'ColumnGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列的GUID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldXml'
, @level2type = 'COLUMN', @level2name = N'ColumnGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列的GUID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldXml'
, @level2type = 'COLUMN', @level2name = N'ColumnGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldXml', 
'COLUMN', N'InstanceGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'对应流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldXml'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'对应流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldXml'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldXml', 
'COLUMN', N'Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldXml'
, @level2type = 'COLUMN', @level2name = N'Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldXml'
, @level2type = 'COLUMN', @level2name = N'Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldXml', 
'COLUMN', N'Value')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldXml'
, @level2type = 'COLUMN', @level2name = N'Value'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldXml'
, @level2type = 'COLUMN', @level2name = N'Value'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtFieldXml', 
'COLUMN', N'Description')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'列描述'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldXml'
, @level2type = 'COLUMN', @level2name = N'Description'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'列描述'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtFieldXml'
, @level2type = 'COLUMN', @level2name = N'Description'
GO

-- ----------------------------
-- Records of DtFieldXml
-- ----------------------------

-- ----------------------------
-- Table structure for DtParam
-- ----------------------------
DROP TABLE [dbo].[DtParam]
GO
CREATE TABLE [dbo].[DtParam] (
[ParamGuid] uniqueidentifier NOT NULL ,
[InstanceGuid] uniqueidentifier NOT NULL ,
[Name] nvarchar(100) NOT NULL ,
[Type] nvarchar(50) NULL ,
[Value] nvarchar(MAX) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtParam', 
'COLUMN', N'ParamGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'实例变量Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtParam'
, @level2type = 'COLUMN', @level2name = N'ParamGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'实例变量Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtParam'
, @level2type = 'COLUMN', @level2name = N'ParamGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtParam', 
'COLUMN', N'InstanceGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtParam'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtParam'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtParam', 
'COLUMN', N'Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程定义的变量名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtParam'
, @level2type = 'COLUMN', @level2name = N'Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程定义的变量名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtParam'
, @level2type = 'COLUMN', @level2name = N'Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtParam', 
'COLUMN', N'Type')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'变量类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtParam'
, @level2type = 'COLUMN', @level2name = N'Type'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'变量类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtParam'
, @level2type = 'COLUMN', @level2name = N'Type'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'DtParam', 
'COLUMN', N'Value')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'变量值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtParam'
, @level2type = 'COLUMN', @level2name = N'Value'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'变量值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'DtParam'
, @level2type = 'COLUMN', @level2name = N'Value'
GO

-- ----------------------------
-- Records of DtParam
-- ----------------------------

-- ----------------------------
-- Table structure for FmHtml
-- ----------------------------
DROP TABLE [dbo].[FmHtml]
GO
CREATE TABLE [dbo].[FmHtml] (
[FormGuid] uniqueidentifier NOT NULL ,
[Type] nvarchar(50) NULL ,
[Html] ntext NULL ,
[CreateTime] datetime NULL ,
[Name] nvarchar(100) NULL ,
[UpdateTime] datetime NULL ,
[Released] int NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'FmHtml', 
'COLUMN', N'FormGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'表单唯一ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'FmHtml'
, @level2type = 'COLUMN', @level2name = N'FormGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'表单唯一ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'FmHtml'
, @level2type = 'COLUMN', @level2name = N'FormGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'FmHtml', 
'COLUMN', N'Type')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'类型：起始、任务、共享等类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'FmHtml'
, @level2type = 'COLUMN', @level2name = N'Type'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'类型：起始、任务、共享等类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'FmHtml'
, @level2type = 'COLUMN', @level2name = N'Type'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'FmHtml', 
'COLUMN', N'Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'表单名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'FmHtml'
, @level2type = 'COLUMN', @level2name = N'Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'表单名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'FmHtml'
, @level2type = 'COLUMN', @level2name = N'Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'FmHtml', 
'COLUMN', N'UpdateTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'更新时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'FmHtml'
, @level2type = 'COLUMN', @level2name = N'UpdateTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'更新时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'FmHtml'
, @level2type = 'COLUMN', @level2name = N'UpdateTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'FmHtml', 
'COLUMN', N'Released')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'发布次数'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'FmHtml'
, @level2type = 'COLUMN', @level2name = N'Released'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'发布次数'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'FmHtml'
, @level2type = 'COLUMN', @level2name = N'Released'
GO

-- ----------------------------
-- Records of FmHtml
-- ----------------------------
INSERT INTO [dbo].[FmHtml] ([FormGuid], [Type], [Html], [CreateTime], [Name], [UpdateTime], [Released]) VALUES (N'FA771087-632B-4DED-B99D-5DAB949435D9', N'TaskForm', null, N'2017-12-29 11:08:07.000', N'申请人接收', N'2017-12-29 11:08:07.000', N'1')
GO
GO
INSERT INTO [dbo].[FmHtml] ([FormGuid], [Type], [Html], [CreateTime], [Name], [UpdateTime], [Released]) VALUES (N'27660889-5B1B-4EB4-AB8D-628A97779C89', N'TaskForm', null, N'2017-12-29 11:08:07.000', N'经理审批', N'2017-12-29 11:08:07.000', N'1')
GO
GO
INSERT INTO [dbo].[FmHtml] ([FormGuid], [Type], [Html], [CreateTime], [Name], [UpdateTime], [Released]) VALUES (N'7CF512D2-A62A-4C9F-A5CE-84898B8781AD', N'StartForm', N'', N'2017-12-29 11:07:17.000', N'申请人发起', N'2017-12-29 11:07:17.000', N'1')
GO
GO
INSERT INTO [dbo].[FmHtml] ([FormGuid], [Type], [Html], [CreateTime], [Name], [UpdateTime], [Released]) VALUES (N'DBB9B148-0E1C-4E7C-B709-D4B05CA253C9', N'TaskForm', null, N'2017-12-29 11:08:07.000', N'总经理经理审批', N'2017-12-29 11:08:07.000', N'1')
GO
GO

-- ----------------------------
-- Table structure for RtDelegate
-- ----------------------------
DROP TABLE [dbo].[RtDelegate]
GO
CREATE TABLE [dbo].[RtDelegate] (
[DelegateGuid] uniqueidentifier NOT NULL ,
[PrincipalGuid] uniqueidentifier NOT NULL ,
[TrusteeGuid] uniqueidentifier NOT NULL ,
[DelegateType] tinyint NOT NULL ,
[ObjectGuids] nvarchar(MAX) NULL ,
[Status] tinyint NOT NULL ,
[EffectTime] datetime NOT NULL ,
[ExpireTime] datetime NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtDelegate', 
'COLUMN', N'DelegateGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'授权Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtDelegate'
, @level2type = 'COLUMN', @level2name = N'DelegateGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'授权Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtDelegate'
, @level2type = 'COLUMN', @level2name = N'DelegateGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtDelegate', 
'COLUMN', N'PrincipalGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'委托人Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtDelegate'
, @level2type = 'COLUMN', @level2name = N'PrincipalGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'委托人Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtDelegate'
, @level2type = 'COLUMN', @level2name = N'PrincipalGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtDelegate', 
'COLUMN', N'TrusteeGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'受托人Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtDelegate'
, @level2type = 'COLUMN', @level2name = N'TrusteeGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'受托人Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtDelegate'
, @level2type = 'COLUMN', @level2name = N'TrusteeGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtDelegate', 
'COLUMN', N'DelegateType')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'授权类型：
   1.临时委托；
   2.实例；
   3.流程定义委托；
   4.角色委托；
   5.完全授权'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtDelegate'
, @level2type = 'COLUMN', @level2name = N'DelegateType'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'授权类型：
   1.临时委托；
   2.实例；
   3.流程定义委托；
   4.角色委托；
   5.完全授权'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtDelegate'
, @level2type = 'COLUMN', @level2name = N'DelegateType'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtDelegate', 
'COLUMN', N'ObjectGuids')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'0、流程定义、定义节点、实例、实例任务，5种情况的Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtDelegate'
, @level2type = 'COLUMN', @level2name = N'ObjectGuids'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'0、流程定义、定义节点、实例、实例任务，5种情况的Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtDelegate'
, @level2type = 'COLUMN', @level2name = N'ObjectGuids'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtDelegate', 
'COLUMN', N'Status')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtDelegate'
, @level2type = 'COLUMN', @level2name = N'Status'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtDelegate'
, @level2type = 'COLUMN', @level2name = N'Status'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtDelegate', 
'COLUMN', N'EffectTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'生效时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtDelegate'
, @level2type = 'COLUMN', @level2name = N'EffectTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'生效时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtDelegate'
, @level2type = 'COLUMN', @level2name = N'EffectTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtDelegate', 
'COLUMN', N'ExpireTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'失效时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtDelegate'
, @level2type = 'COLUMN', @level2name = N'ExpireTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'失效时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtDelegate'
, @level2type = 'COLUMN', @level2name = N'ExpireTime'
GO

-- ----------------------------
-- Records of RtDelegate
-- ----------------------------

-- ----------------------------
-- Table structure for RtForm
-- ----------------------------
DROP TABLE [dbo].[RtForm]
GO
CREATE TABLE [dbo].[RtForm] (
[FormCaseGuid] uniqueidentifier NOT NULL ,
[InstanceGuid] uniqueidentifier NULL ,
[FormGuid] uniqueidentifier NULL ,
[FormHtml] ntext NULL ,
[CreateTime] datetime NULL ,
[CreateUser] uniqueidentifier NULL ,
[UpdateTime] datetime NULL ,
[UpdateUser] uniqueidentifier NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtForm', 
NULL, NULL)) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程实例表单定义'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtForm'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程实例表单定义'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtForm'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtForm', 
'COLUMN', N'FormCaseGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'唯一ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtForm'
, @level2type = 'COLUMN', @level2name = N'FormCaseGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'唯一ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtForm'
, @level2type = 'COLUMN', @level2name = N'FormCaseGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtForm', 
'COLUMN', N'InstanceGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'对应流程实例的Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtForm'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'对应流程实例的Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtForm'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtForm', 
'COLUMN', N'FormGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'FormHtml表对应Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtForm'
, @level2type = 'COLUMN', @level2name = N'FormGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'FormHtml表对应Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtForm'
, @level2type = 'COLUMN', @level2name = N'FormGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtForm', 
'COLUMN', N'FormHtml')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'表单Html'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtForm'
, @level2type = 'COLUMN', @level2name = N'FormHtml'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'表单Html'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtForm'
, @level2type = 'COLUMN', @level2name = N'FormHtml'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtForm', 
'COLUMN', N'CreateTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'创建时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtForm'
, @level2type = 'COLUMN', @level2name = N'CreateTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtForm'
, @level2type = 'COLUMN', @level2name = N'CreateTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtForm', 
'COLUMN', N'CreateUser')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'创建用户'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtForm'
, @level2type = 'COLUMN', @level2name = N'CreateUser'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'创建用户'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtForm'
, @level2type = 'COLUMN', @level2name = N'CreateUser'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtForm', 
'COLUMN', N'UpdateTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'更新时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtForm'
, @level2type = 'COLUMN', @level2name = N'UpdateTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'更新时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtForm'
, @level2type = 'COLUMN', @level2name = N'UpdateTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtForm', 
'COLUMN', N'UpdateUser')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'更新用户'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtForm'
, @level2type = 'COLUMN', @level2name = N'UpdateUser'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'更新用户'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtForm'
, @level2type = 'COLUMN', @level2name = N'UpdateUser'
GO

-- ----------------------------
-- Records of RtForm
-- ----------------------------
INSERT INTO [dbo].[RtForm] ([FormCaseGuid], [InstanceGuid], [FormGuid], [FormHtml], [CreateTime], [CreateUser], [UpdateTime], [UpdateUser]) VALUES (N'7E517D5E-779A-40F8-B3DC-0C9FB0998B8F', N'84944CDA-E4DF-4FB0-8A80-B04CBEF1AC16', N'FA771087-632B-4DED-B99D-5DAB949435D9', null, N'2017-12-29 11:11:49.000', null, N'2017-12-29 11:11:49.000', null)
GO
GO
INSERT INTO [dbo].[RtForm] ([FormCaseGuid], [InstanceGuid], [FormGuid], [FormHtml], [CreateTime], [CreateUser], [UpdateTime], [UpdateUser]) VALUES (N'E9EE0B14-7395-430B-9B06-1713B18E5206', N'84944CDA-E4DF-4FB0-8A80-B04CBEF1AC16', N'27660889-5B1B-4EB4-AB8D-628A97779C89', null, N'2017-12-29 11:11:49.000', null, N'2017-12-29 11:11:49.000', null)
GO
GO
INSERT INTO [dbo].[RtForm] ([FormCaseGuid], [InstanceGuid], [FormGuid], [FormHtml], [CreateTime], [CreateUser], [UpdateTime], [UpdateUser]) VALUES (N'BB2AF697-CF0F-4825-9C57-26858CC76A08', N'84944CDA-E4DF-4FB0-8A80-B04CBEF1AC16', N'DBB9B148-0E1C-4E7C-B709-D4B05CA253C9', null, N'2017-12-29 11:11:49.000', null, N'2017-12-29 11:11:49.000', null)
GO
GO
INSERT INTO [dbo].[RtForm] ([FormCaseGuid], [InstanceGuid], [FormGuid], [FormHtml], [CreateTime], [CreateUser], [UpdateTime], [UpdateUser]) VALUES (N'897C0AD9-E219-422C-BF50-3B94EAF00576', N'84944CDA-E4DF-4FB0-8A80-B04CBEF1AC16', N'7CF512D2-A62A-4C9F-A5CE-84898B8781AD', null, N'2017-12-29 11:11:49.000', null, N'2017-12-29 11:11:49.000', null)
GO
GO

-- ----------------------------
-- Table structure for RtInstance
-- ----------------------------
DROP TABLE [dbo].[RtInstance]
GO
CREATE TABLE [dbo].[RtInstance] (
[InstanceGuid] uniqueidentifier NOT NULL ,
[RepoGuid] uniqueidentifier NOT NULL ,
[InstanceTitle] nvarchar(100) NULL ,
[InstanceStatus] tinyint NOT NULL ,
[CurrentTask] uniqueidentifier NULL ,
[Originator] nvarchar(100) NULL ,
[StartTime] datetime NOT NULL ,
[Terminator] uniqueidentifier NULL ,
[EndTime] datetime NULL ,
[Stamp] timestamp NULL ,
[ProcessXml] ntext NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtInstance', 
'COLUMN', N'InstanceGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtInstance'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtInstance'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtInstance', 
'COLUMN', N'RepoGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程定义Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtInstance'
, @level2type = 'COLUMN', @level2name = N'RepoGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程定义Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtInstance'
, @level2type = 'COLUMN', @level2name = N'RepoGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtInstance', 
'COLUMN', N'InstanceTitle')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程实例名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtInstance'
, @level2type = 'COLUMN', @level2name = N'InstanceTitle'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程实例名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtInstance'
, @level2type = 'COLUMN', @level2name = N'InstanceTitle'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtInstance', 
'COLUMN', N'InstanceStatus')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程状态：
0.初始化
1.新建
2.运行
3.挂起
4.结束'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtInstance'
, @level2type = 'COLUMN', @level2name = N'InstanceStatus'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程状态：
0.初始化
1.新建
2.运行
3.挂起
4.结束'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtInstance'
, @level2type = 'COLUMN', @level2name = N'InstanceStatus'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtInstance', 
'COLUMN', N'CurrentTask')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程当前任务'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtInstance'
, @level2type = 'COLUMN', @level2name = N'CurrentTask'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程当前任务'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtInstance'
, @level2type = 'COLUMN', @level2name = N'CurrentTask'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtInstance', 
'COLUMN', N'Originator')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程发起人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtInstance'
, @level2type = 'COLUMN', @level2name = N'Originator'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程发起人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtInstance'
, @level2type = 'COLUMN', @level2name = N'Originator'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtInstance', 
'COLUMN', N'StartTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程发起时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtInstance'
, @level2type = 'COLUMN', @level2name = N'StartTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程发起时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtInstance'
, @level2type = 'COLUMN', @level2name = N'StartTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtInstance', 
'COLUMN', N'Terminator')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程结束人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtInstance'
, @level2type = 'COLUMN', @level2name = N'Terminator'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程结束人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtInstance'
, @level2type = 'COLUMN', @level2name = N'Terminator'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtInstance', 
'COLUMN', N'EndTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程结束时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtInstance'
, @level2type = 'COLUMN', @level2name = N'EndTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程结束时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtInstance'
, @level2type = 'COLUMN', @level2name = N'EndTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtInstance', 
'COLUMN', N'Stamp')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'时间戳'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtInstance'
, @level2type = 'COLUMN', @level2name = N'Stamp'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'时间戳'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtInstance'
, @level2type = 'COLUMN', @level2name = N'Stamp'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtInstance', 
'COLUMN', N'ProcessXml')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'实例流程定义内容'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtInstance'
, @level2type = 'COLUMN', @level2name = N'ProcessXml'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'实例流程定义内容'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtInstance'
, @level2type = 'COLUMN', @level2name = N'ProcessXml'
GO

-- ----------------------------
-- Records of RtInstance
-- ----------------------------
INSERT INTO [dbo].[RtInstance] ([InstanceGuid], [RepoGuid], [InstanceTitle], [InstanceStatus], [CurrentTask], [Originator], [StartTime], [Terminator], [EndTime], [Stamp], [ProcessXml]) VALUES (N'84944CDA-E4DF-4FB0-8A80-B04CBEF1AC16', N'A40797C6-0DDA-4A23-B104-43607D6A69B9', null, N'0', null, N' a', N'2017-12-26 11:26:14.807', null, null, DEFAULT, null)
GO
GO

-- ----------------------------
-- Table structure for RtNode
-- ----------------------------
DROP TABLE [dbo].[RtNode]
GO
CREATE TABLE [dbo].[RtNode] (
[NodeGuid] uniqueidentifier NOT NULL ,
[InstanceGuid] uniqueidentifier NOT NULL ,
[StepDefID] char(10) NULL ,
[NodeType] tinyint NOT NULL ,
[RawNodeGuid] uniqueidentifier NULL ,
[Sponsor] uniqueidentifier NULL ,
[PassRate] float(53) NULL ,
[AddSign] tinyint NULL ,
[StartTime] datetime NOT NULL ,
[EndTime] datetime NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtNode', 
'COLUMN', N'NodeGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'节点Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtNode'
, @level2type = 'COLUMN', @level2name = N'NodeGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'节点Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtNode'
, @level2type = 'COLUMN', @level2name = N'NodeGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtNode', 
'COLUMN', N'InstanceGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtNode'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtNode'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtNode', 
'COLUMN', N'StepDefID')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程定义中节点ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtNode'
, @level2type = 'COLUMN', @level2name = N'StepDefID'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程定义中节点ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtNode'
, @level2type = 'COLUMN', @level2name = N'StepDefID'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtNode', 
'COLUMN', N'NodeType')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'节点类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtNode'
, @level2type = 'COLUMN', @level2name = N'NodeType'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'节点类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtNode'
, @level2type = 'COLUMN', @level2name = N'NodeType'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtNode', 
'COLUMN', N'RawNodeGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'退回前原始节点Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtNode'
, @level2type = 'COLUMN', @level2name = N'RawNodeGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'退回前原始节点Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtNode'
, @level2type = 'COLUMN', @level2name = N'RawNodeGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtNode', 
'COLUMN', N'Sponsor')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'多实例下主办人ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtNode'
, @level2type = 'COLUMN', @level2name = N'Sponsor'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'多实例下主办人ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtNode'
, @level2type = 'COLUMN', @level2name = N'Sponsor'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtNode', 
'COLUMN', N'PassRate')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'通过率'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtNode'
, @level2type = 'COLUMN', @level2name = N'PassRate'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'通过率'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtNode'
, @level2type = 'COLUMN', @level2name = N'PassRate'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtNode', 
'COLUMN', N'AddSign')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'加签类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtNode'
, @level2type = 'COLUMN', @level2name = N'AddSign'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'加签类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtNode'
, @level2type = 'COLUMN', @level2name = N'AddSign'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtNode', 
'COLUMN', N'StartTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'开始时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtNode'
, @level2type = 'COLUMN', @level2name = N'StartTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'开始时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtNode'
, @level2type = 'COLUMN', @level2name = N'StartTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtNode', 
'COLUMN', N'EndTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'结束时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtNode'
, @level2type = 'COLUMN', @level2name = N'EndTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'结束时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtNode'
, @level2type = 'COLUMN', @level2name = N'EndTime'
GO

-- ----------------------------
-- Records of RtNode
-- ----------------------------

-- ----------------------------
-- Table structure for RtSerialNum
-- ----------------------------
DROP TABLE [dbo].[RtSerialNum]
GO
CREATE TABLE [dbo].[RtSerialNum] (
[SerialGuid] uniqueidentifier NOT NULL ,
[SerialName] nvarchar(50) NOT NULL ,
[CurrentNum] nvarchar(MAX) NOT NULL ,
[Step] int NOT NULL ,
[Filler] nvarchar(100) NULL ,
[CreateTime] datetime NOT NULL ,
[UpdateTime] datetime NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtSerialNum', 
'COLUMN', N'SerialGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'序号Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtSerialNum'
, @level2type = 'COLUMN', @level2name = N'SerialGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'序号Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtSerialNum'
, @level2type = 'COLUMN', @level2name = N'SerialGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtSerialNum', 
'COLUMN', N'SerialName')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'序号名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtSerialNum'
, @level2type = 'COLUMN', @level2name = N'SerialName'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'序号名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtSerialNum'
, @level2type = 'COLUMN', @level2name = N'SerialName'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtSerialNum', 
'COLUMN', N'CurrentNum')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'当前序号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtSerialNum'
, @level2type = 'COLUMN', @level2name = N'CurrentNum'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'当前序号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtSerialNum'
, @level2type = 'COLUMN', @level2name = N'CurrentNum'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtSerialNum', 
'COLUMN', N'Step')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'步长'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtSerialNum'
, @level2type = 'COLUMN', @level2name = N'Step'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'步长'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtSerialNum'
, @level2type = 'COLUMN', @level2name = N'Step'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtSerialNum', 
'COLUMN', N'Filler')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'填充字符'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtSerialNum'
, @level2type = 'COLUMN', @level2name = N'Filler'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'填充字符'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtSerialNum'
, @level2type = 'COLUMN', @level2name = N'Filler'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtSerialNum', 
'COLUMN', N'CreateTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'创建时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtSerialNum'
, @level2type = 'COLUMN', @level2name = N'CreateTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtSerialNum'
, @level2type = 'COLUMN', @level2name = N'CreateTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtSerialNum', 
'COLUMN', N'UpdateTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'更新时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtSerialNum'
, @level2type = 'COLUMN', @level2name = N'UpdateTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'更新时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtSerialNum'
, @level2type = 'COLUMN', @level2name = N'UpdateTime'
GO

-- ----------------------------
-- Records of RtSerialNum
-- ----------------------------

-- ----------------------------
-- Table structure for RtTask
-- ----------------------------
DROP TABLE [dbo].[RtTask]
GO
CREATE TABLE [dbo].[RtTask] (
[TaskGuid] uniqueidentifier NOT NULL ,
[InstanceGuid] uniqueidentifier NOT NULL ,
[NodeID] nvarchar(50) NULL ,
[TaskTitle] nvarchar(100) NOT NULL ,
[TaskType] tinyint NULL ,
[Status] tinyint NOT NULL ,
[Owner] nvarchar(100) NULL ,
[Executor] nvarchar(100) NULL ,
[Stamp] timestamp NULL ,
[CreateTime] datetime NOT NULL ,
[UpdateTime] datetime NULL ,
[NodeGuid] uniqueidentifier NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtTask', 
'COLUMN', N'TaskGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'任务Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTask'
, @level2type = 'COLUMN', @level2name = N'TaskGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'任务Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTask'
, @level2type = 'COLUMN', @level2name = N'TaskGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtTask', 
'COLUMN', N'InstanceGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTask'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTask'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtTask', 
'COLUMN', N'NodeID')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'实例节点Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTask'
, @level2type = 'COLUMN', @level2name = N'NodeID'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'实例节点Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTask'
, @level2type = 'COLUMN', @level2name = N'NodeID'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtTask', 
'COLUMN', N'TaskTitle')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'任务标题'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTask'
, @level2type = 'COLUMN', @level2name = N'TaskTitle'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'任务标题'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTask'
, @level2type = 'COLUMN', @level2name = N'TaskTitle'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtTask', 
'COLUMN', N'TaskType')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'任务类型：
   0.正常处理
   1.加签者
   2.受托者'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTask'
, @level2type = 'COLUMN', @level2name = N'TaskType'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'任务类型：
   0.正常处理
   1.加签者
   2.受托者'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTask'
, @level2type = 'COLUMN', @level2name = N'TaskType'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtTask', 
'COLUMN', N'Status')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'任务状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTask'
, @level2type = 'COLUMN', @level2name = N'Status'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'任务状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTask'
, @level2type = 'COLUMN', @level2name = N'Status'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtTask', 
'COLUMN', N'Owner')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'任务所有者的用户ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTask'
, @level2type = 'COLUMN', @level2name = N'Owner'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'任务所有者的用户ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTask'
, @level2type = 'COLUMN', @level2name = N'Owner'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtTask', 
'COLUMN', N'Executor')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'实际执行者的用户ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTask'
, @level2type = 'COLUMN', @level2name = N'Executor'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'实际执行者的用户ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTask'
, @level2type = 'COLUMN', @level2name = N'Executor'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtTask', 
'COLUMN', N'Stamp')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'时间戳'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTask'
, @level2type = 'COLUMN', @level2name = N'Stamp'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'时间戳'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTask'
, @level2type = 'COLUMN', @level2name = N'Stamp'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtTask', 
'COLUMN', N'CreateTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'创建时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTask'
, @level2type = 'COLUMN', @level2name = N'CreateTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTask'
, @level2type = 'COLUMN', @level2name = N'CreateTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtTask', 
'COLUMN', N'UpdateTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'更新时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTask'
, @level2type = 'COLUMN', @level2name = N'UpdateTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'更新时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTask'
, @level2type = 'COLUMN', @level2name = N'UpdateTime'
GO

-- ----------------------------
-- Records of RtTask
-- ----------------------------

-- ----------------------------
-- Table structure for RtToken
-- ----------------------------
DROP TABLE [dbo].[RtToken]
GO
CREATE TABLE [dbo].[RtToken] (
[TokenGuid] uniqueidentifier NOT NULL ,
[InstanceGuid] uniqueidentifier NOT NULL ,
[ParentToken] uniqueidentifier NULL ,
[ElementID] nvarchar(50) NULL ,
[Status] tinyint NULL ,
[CreateTime] datetime NULL ,
[UpdateTime] datetime NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtToken', 
'COLUMN', N'InstanceGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'所属实例'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtToken'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'所属实例'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtToken'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtToken', 
'COLUMN', N'ParentToken')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'父Token'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtToken'
, @level2type = 'COLUMN', @level2name = N'ParentToken'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'父Token'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtToken'
, @level2type = 'COLUMN', @level2name = N'ParentToken'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtToken', 
'COLUMN', N'ElementID')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程定义中的元素Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtToken'
, @level2type = 'COLUMN', @level2name = N'ElementID'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程定义中的元素Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtToken'
, @level2type = 'COLUMN', @level2name = N'ElementID'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtToken', 
'COLUMN', N'Status')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'状态：0.等待；1.激活；2.消耗完'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtToken'
, @level2type = 'COLUMN', @level2name = N'Status'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'状态：0.等待；1.激活；2.消耗完'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtToken'
, @level2type = 'COLUMN', @level2name = N'Status'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtToken', 
'COLUMN', N'CreateTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'创建时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtToken'
, @level2type = 'COLUMN', @level2name = N'CreateTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtToken'
, @level2type = 'COLUMN', @level2name = N'CreateTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtToken', 
'COLUMN', N'UpdateTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'更新时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtToken'
, @level2type = 'COLUMN', @level2name = N'UpdateTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'更新时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtToken'
, @level2type = 'COLUMN', @level2name = N'UpdateTime'
GO

-- ----------------------------
-- Records of RtToken
-- ----------------------------

-- ----------------------------
-- Table structure for RtTransition
-- ----------------------------
DROP TABLE [dbo].[RtTransition]
GO
CREATE TABLE [dbo].[RtTransition] (
[TransferGuid] uniqueidentifier NOT NULL ,
[InstanceGuid] uniqueidentifier NOT NULL ,
[TransferType] tinyint NOT NULL ,
[ConditionResult] nvarchar(MAX) NULL ,
[SourceGuid] uniqueidentifier NOT NULL ,
[TargetGuid] uniqueidentifier NOT NULL ,
[Stamp] timestamp NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtTransition', 
'COLUMN', N'TransferGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'转交Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTransition'
, @level2type = 'COLUMN', @level2name = N'TransferGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'转交Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTransition'
, @level2type = 'COLUMN', @level2name = N'TransferGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtTransition', 
'COLUMN', N'InstanceGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTransition'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTransition'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtTransition', 
'COLUMN', N'TransferType')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'转交类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTransition'
, @level2type = 'COLUMN', @level2name = N'TransferType'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'转交类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTransition'
, @level2type = 'COLUMN', @level2name = N'TransferType'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtTransition', 
'COLUMN', N'ConditionResult')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'条件解析结果'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTransition'
, @level2type = 'COLUMN', @level2name = N'ConditionResult'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'条件解析结果'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTransition'
, @level2type = 'COLUMN', @level2name = N'ConditionResult'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtTransition', 
'COLUMN', N'SourceGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'原节点Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTransition'
, @level2type = 'COLUMN', @level2name = N'SourceGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'原节点Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTransition'
, @level2type = 'COLUMN', @level2name = N'SourceGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtTransition', 
'COLUMN', N'TargetGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'目标节点Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTransition'
, @level2type = 'COLUMN', @level2name = N'TargetGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'目标节点Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTransition'
, @level2type = 'COLUMN', @level2name = N'TargetGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'RtTransition', 
'COLUMN', N'Stamp')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'时间戳'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTransition'
, @level2type = 'COLUMN', @level2name = N'Stamp'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'时间戳'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'RtTransition'
, @level2type = 'COLUMN', @level2name = N'Stamp'
GO

-- ----------------------------
-- Records of RtTransition
-- ----------------------------

-- ----------------------------
-- Table structure for SysDepartment
-- ----------------------------
DROP TABLE [dbo].[SysDepartment]
GO
CREATE TABLE [dbo].[SysDepartment] (
[DeptGuid] uniqueidentifier NOT NULL ,
[DeptName] nvarchar(100) NOT NULL ,
[HiDeptGuid] uniqueidentifier NOT NULL ,
[DeptLeader] uniqueidentifier NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SysDepartment', 
'COLUMN', N'DeptGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'部门Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysDepartment'
, @level2type = 'COLUMN', @level2name = N'DeptGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'部门Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysDepartment'
, @level2type = 'COLUMN', @level2name = N'DeptGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SysDepartment', 
'COLUMN', N'DeptName')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'部门名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysDepartment'
, @level2type = 'COLUMN', @level2name = N'DeptName'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'部门名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysDepartment'
, @level2type = 'COLUMN', @level2name = N'DeptName'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SysDepartment', 
'COLUMN', N'HiDeptGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'上级部门Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysDepartment'
, @level2type = 'COLUMN', @level2name = N'HiDeptGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'上级部门Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysDepartment'
, @level2type = 'COLUMN', @level2name = N'HiDeptGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SysDepartment', 
'COLUMN', N'DeptLeader')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'部门负责人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysDepartment'
, @level2type = 'COLUMN', @level2name = N'DeptLeader'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'部门负责人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysDepartment'
, @level2type = 'COLUMN', @level2name = N'DeptLeader'
GO

-- ----------------------------
-- Records of SysDepartment
-- ----------------------------

-- ----------------------------
-- Table structure for SysDeptUser
-- ----------------------------
DROP TABLE [dbo].[SysDeptUser]
GO
CREATE TABLE [dbo].[SysDeptUser] (
[DeptUserGuid] uniqueidentifier NOT NULL ,
[DeptGuid] uniqueidentifier NOT NULL ,
[UserGuid] uniqueidentifier NOT NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SysDeptUser', 
'COLUMN', N'DeptUserGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'关系Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysDeptUser'
, @level2type = 'COLUMN', @level2name = N'DeptUserGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'关系Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysDeptUser'
, @level2type = 'COLUMN', @level2name = N'DeptUserGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SysDeptUser', 
'COLUMN', N'DeptGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'部门Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysDeptUser'
, @level2type = 'COLUMN', @level2name = N'DeptGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'部门Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysDeptUser'
, @level2type = 'COLUMN', @level2name = N'DeptGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SysDeptUser', 
'COLUMN', N'UserGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'用户Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysDeptUser'
, @level2type = 'COLUMN', @level2name = N'UserGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'用户Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysDeptUser'
, @level2type = 'COLUMN', @level2name = N'UserGuid'
GO

-- ----------------------------
-- Records of SysDeptUser
-- ----------------------------

-- ----------------------------
-- Table structure for SysRole
-- ----------------------------
DROP TABLE [dbo].[SysRole]
GO
CREATE TABLE [dbo].[SysRole] (
[RoleGuid] uniqueidentifier NOT NULL ,
[RoleName] nvarchar(100) NOT NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SysRole', 
'COLUMN', N'RoleGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'角色Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysRole'
, @level2type = 'COLUMN', @level2name = N'RoleGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'角色Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysRole'
, @level2type = 'COLUMN', @level2name = N'RoleGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SysRole', 
'COLUMN', N'RoleName')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'角色名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysRole'
, @level2type = 'COLUMN', @level2name = N'RoleName'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'角色名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysRole'
, @level2type = 'COLUMN', @level2name = N'RoleName'
GO

-- ----------------------------
-- Records of SysRole
-- ----------------------------

-- ----------------------------
-- Table structure for SysRoleUser
-- ----------------------------
DROP TABLE [dbo].[SysRoleUser]
GO
CREATE TABLE [dbo].[SysRoleUser] (
[RoleUserGuid] uniqueidentifier NOT NULL ,
[RoleGuid] uniqueidentifier NOT NULL ,
[UserGuid] uniqueidentifier NOT NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SysRoleUser', 
'COLUMN', N'RoleUserGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'关系Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysRoleUser'
, @level2type = 'COLUMN', @level2name = N'RoleUserGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'关系Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysRoleUser'
, @level2type = 'COLUMN', @level2name = N'RoleUserGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SysRoleUser', 
'COLUMN', N'RoleGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'角色Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysRoleUser'
, @level2type = 'COLUMN', @level2name = N'RoleGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'角色Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysRoleUser'
, @level2type = 'COLUMN', @level2name = N'RoleGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SysRoleUser', 
'COLUMN', N'UserGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'用户Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysRoleUser'
, @level2type = 'COLUMN', @level2name = N'UserGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'用户Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysRoleUser'
, @level2type = 'COLUMN', @level2name = N'UserGuid'
GO

-- ----------------------------
-- Records of SysRoleUser
-- ----------------------------

-- ----------------------------
-- Table structure for SysUser
-- ----------------------------
DROP TABLE [dbo].[SysUser]
GO
CREATE TABLE [dbo].[SysUser] (
[UserGuid] uniqueidentifier NOT NULL ,
[UserID] nvarchar(50) NOT NULL ,
[UserPwd] nvarchar(50) NOT NULL ,
[UserName] nvarchar(50) NOT NULL ,
[UserSex] bit NULL ,
[Phone] nvarchar(12) NULL ,
[Email] nvarchar(50) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SysUser', 
'COLUMN', N'UserGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'用户Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysUser'
, @level2type = 'COLUMN', @level2name = N'UserGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'用户Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysUser'
, @level2type = 'COLUMN', @level2name = N'UserGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SysUser', 
'COLUMN', N'UserID')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'登录帐号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysUser'
, @level2type = 'COLUMN', @level2name = N'UserID'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'登录帐号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysUser'
, @level2type = 'COLUMN', @level2name = N'UserID'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SysUser', 
'COLUMN', N'UserPwd')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'登录密码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysUser'
, @level2type = 'COLUMN', @level2name = N'UserPwd'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'登录密码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysUser'
, @level2type = 'COLUMN', @level2name = N'UserPwd'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SysUser', 
'COLUMN', N'UserName')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'用户姓名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysUser'
, @level2type = 'COLUMN', @level2name = N'UserName'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'用户姓名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysUser'
, @level2type = 'COLUMN', @level2name = N'UserName'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SysUser', 
'COLUMN', N'UserSex')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'性别'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysUser'
, @level2type = 'COLUMN', @level2name = N'UserSex'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'性别'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysUser'
, @level2type = 'COLUMN', @level2name = N'UserSex'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SysUser', 
'COLUMN', N'Phone')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'手机'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysUser'
, @level2type = 'COLUMN', @level2name = N'Phone'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'手机'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysUser'
, @level2type = 'COLUMN', @level2name = N'Phone'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'SysUser', 
'COLUMN', N'Email')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'邮箱'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysUser'
, @level2type = 'COLUMN', @level2name = N'Email'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'邮箱'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'SysUser'
, @level2type = 'COLUMN', @level2name = N'Email'
GO

-- ----------------------------
-- Records of SysUser
-- ----------------------------
INSERT INTO [dbo].[SysUser] ([UserGuid], [UserID], [UserPwd], [UserName], [UserSex], [Phone], [Email]) VALUES (N'E3F7DE4A-8F06-4660-8BD7-101316F97527', N'b', N'b', N'b', null, null, null)
GO
GO
INSERT INTO [dbo].[SysUser] ([UserGuid], [UserID], [UserPwd], [UserName], [UserSex], [Phone], [Email]) VALUES (N'5511CA92-EAD9-48EA-810A-F7D557143BD5', N'a', N'a', N'a', null, null, null)
GO
GO

-- ----------------------------
-- Table structure for WfField
-- ----------------------------
DROP TABLE [dbo].[WfField]
GO
CREATE TABLE [dbo].[WfField] (
[FieldGuid] uniqueidentifier NOT NULL ,
[Name] nvarchar(50) NOT NULL ,
[Type] nvarchar(50) NULL ,
[IsArray] bit NULL ,
[GroupName] nvarchar(50) NULL ,
[Value] nvarchar(255) NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfField', 
'COLUMN', N'FieldGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'变量Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfField'
, @level2type = 'COLUMN', @level2name = N'FieldGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'变量Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfField'
, @level2type = 'COLUMN', @level2name = N'FieldGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfField', 
'COLUMN', N'Name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'变量名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfField'
, @level2type = 'COLUMN', @level2name = N'Name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'变量名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfField'
, @level2type = 'COLUMN', @level2name = N'Name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfField', 
'COLUMN', N'Type')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'变量类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfField'
, @level2type = 'COLUMN', @level2name = N'Type'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'变量类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfField'
, @level2type = 'COLUMN', @level2name = N'Type'
GO

-- ----------------------------
-- Records of WfField
-- ----------------------------

-- ----------------------------
-- Table structure for WfProcess
-- ----------------------------
DROP TABLE [dbo].[WfProcess]
GO
CREATE TABLE [dbo].[WfProcess] (
[ProcessGuid] uniqueidentifier NOT NULL ,
[ProcessName] nvarchar(50) NULL ,
[MasterVer] nvarchar(10) NULL ,
[CreateTime] datetime NOT NULL ,
[UpdateTime] datetime NULL ,
[Stamp] timestamp NULL ,
[Status] tinyint NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcess', 
NULL, NULL)) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程定义表'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程定义表'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcess', 
'COLUMN', N'ProcessGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程定义Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'ProcessGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程定义Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'ProcessGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcess', 
'COLUMN', N'ProcessName')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程定义名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'ProcessName'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程定义名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'ProcessName'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcess', 
'COLUMN', N'MasterVer')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'主版本（当前时间新建流程时使用的流程版本）'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'MasterVer'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'主版本（当前时间新建流程时使用的流程版本）'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'MasterVer'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcess', 
'COLUMN', N'CreateTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'创建时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'CreateTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'CreateTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcess', 
'COLUMN', N'UpdateTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'最新更新时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'UpdateTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'最新更新时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'UpdateTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcess', 
'COLUMN', N'Stamp')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'时间戳'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'Stamp'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'时间戳'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'Stamp'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcess', 
'COLUMN', N'Status')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'状态：0未发布；1已发布；2重构中；3测试中'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'Status'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'状态：0未发布；1已发布；2重构中；3测试中'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'Status'
GO

-- ----------------------------
-- Records of WfProcess
-- ----------------------------
INSERT INTO [dbo].[WfProcess] ([ProcessGuid], [ProcessName], [MasterVer], [CreateTime], [UpdateTime], [Stamp], [Status]) VALUES (N'3043934F-DA04-4A96-B010-623BD047DABD', N'请假', N'1', N'2017-12-15 10:41:09.000', N'2017-12-15 10:41:09.000', DEFAULT, N'1')
GO
GO

-- ----------------------------
-- Table structure for WfRepository
-- ----------------------------
DROP TABLE [dbo].[WfRepository]
GO
CREATE TABLE [dbo].[WfRepository] (
[RepoGuid] uniqueidentifier NOT NULL ,
[Description] nvarchar(100) NULL ,
[CreateTime] datetime NOT NULL ,
[UpdateTime] datetime NULL ,
[Stamp] timestamp NULL ,
[Version] nvarchar(10) NULL ,
[BpmFile] nvarchar(50) NULL ,
[BpmPath] nvarchar(100) NULL ,
[BpmContent] ntext NULL ,
[ProcessGuid] uniqueidentifier NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfRepository', 
'COLUMN', N'RepoGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'定义文件Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfRepository'
, @level2type = 'COLUMN', @level2name = N'RepoGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'定义文件Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfRepository'
, @level2type = 'COLUMN', @level2name = N'RepoGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfRepository', 
'COLUMN', N'Description')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'描述'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfRepository'
, @level2type = 'COLUMN', @level2name = N'Description'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'描述'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfRepository'
, @level2type = 'COLUMN', @level2name = N'Description'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfRepository', 
'COLUMN', N'CreateTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'创建时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfRepository'
, @level2type = 'COLUMN', @level2name = N'CreateTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfRepository'
, @level2type = 'COLUMN', @level2name = N'CreateTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfRepository', 
'COLUMN', N'UpdateTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'更新时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfRepository'
, @level2type = 'COLUMN', @level2name = N'UpdateTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'更新时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfRepository'
, @level2type = 'COLUMN', @level2name = N'UpdateTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfRepository', 
'COLUMN', N'Stamp')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'时间戳'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfRepository'
, @level2type = 'COLUMN', @level2name = N'Stamp'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'时间戳'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfRepository'
, @level2type = 'COLUMN', @level2name = N'Stamp'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfRepository', 
'COLUMN', N'Version')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程定义的版本号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfRepository'
, @level2type = 'COLUMN', @level2name = N'Version'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程定义的版本号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfRepository'
, @level2type = 'COLUMN', @level2name = N'Version'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfRepository', 
'COLUMN', N'BpmFile')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程定义XML文件的名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfRepository'
, @level2type = 'COLUMN', @level2name = N'BpmFile'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程定义XML文件的名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfRepository'
, @level2type = 'COLUMN', @level2name = N'BpmFile'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfRepository', 
'COLUMN', N'BpmPath')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程定义XML文件的路径'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfRepository'
, @level2type = 'COLUMN', @level2name = N'BpmPath'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程定义XML文件的路径'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfRepository'
, @level2type = 'COLUMN', @level2name = N'BpmPath'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfRepository', 
'COLUMN', N'BpmContent')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程定义的XML'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfRepository'
, @level2type = 'COLUMN', @level2name = N'BpmContent'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程定义的XML'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfRepository'
, @level2type = 'COLUMN', @level2name = N'BpmContent'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfRepository', 
'COLUMN', N'ProcessGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程定义Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfRepository'
, @level2type = 'COLUMN', @level2name = N'ProcessGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程定义Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfRepository'
, @level2type = 'COLUMN', @level2name = N'ProcessGuid'
GO

-- ----------------------------
-- Records of WfRepository
-- ----------------------------
INSERT INTO [dbo].[WfRepository] ([RepoGuid], [Description], [CreateTime], [UpdateTime], [Stamp], [Version], [BpmFile], [BpmPath], [BpmContent], [ProcessGuid]) VALUES (N'A40797C6-0DDA-4A23-B104-43607D6A69B9', null, N'2017-12-18 15:52:33.000', N'2017-12-18 15:52:33.000', DEFAULT, N'1', null, null, N'<?xml version="1.0" encoding="utf-8"?>
<Process>
    <ProcessID>A7F1FF45-0711-492C-AE29-9854FC048DB5</ProcessID>
    <Title>请假申请</Title>
    <Author>admin</Author>
    <CodeType>CS</CodeType>
    <!--<loglevel>2</loglevel>-->
    <!--<Startobject>Startevent_0001</Startobject>-->
    <Version>1</Version>
    <Created>2017-12-19T14:48:00</Created>
    <Release>1</Release>
    <!--0未发布，1已发布-->
    <!--<Isbpmn2></Isbpmn2>-->
    <!--是否bpmn2格式显示，0否，1是-->
    <!--流程图元素-->
    <Flows>
        <Sequences>
            <Sequence ID="sequence_0001" Source="0001" Target="0008" />
            <Sequence ID="sequence_0002" Source="0008" Target="0006" />
            <Sequence ID="sequence_0004" Name="no" Source="0006" Target="0002">
                <Express>&amp;IsLeader==1</Express>
            </Sequence>
            <Sequence ID="sequence_0005" Name="no" Source="0006" Target="0003">
                <Express>&amp;IsLeader==0</Express>
            </Sequence>
            <Sequence ID="sequence_0006" Source="0002" Target="0007" />
            <Sequence ID="sequence_0007" Source="0003" Target="0007" />
            <Sequence ID="sequence_0008" Source="0007" Target="0009" />
        </Sequences>
        <Steps>
            <StartEvent ID="0001" />
            <StartEvent ID="0005">
                <type>Timer</type>
                <Define>20171224</Define>
            </StartEvent>
            <EndEvent ID="0009"/>
            <UserTask ID="0008" Name="申请人填写入境申请表单">
                <TaskTitle>''请填写：''+&amp;Title</TaskTitle>
                <TaskPage>0041</TaskPage>
            </UserTask>
            <UserTask ID="0002" Name="部门经理审批">
                <TaskTitle>''请审批：''+&amp;Title</TaskTitle>
                <TaskPage>0042</TaskPage>
            </UserTask>
            <UserTask ID="0003" Name="总经理审批">
                <TaskTitle>''请审批：''+&amp;Title</TaskTitle>
                <TaskPage>0043</TaskPage>
            </UserTask>
            <UserTask ID="0004" Name="申请人确认">
                <TaskTitle>''请确认：''+&amp;Title</TaskTitle>
                <TaskPage>0044</TaskPage>
            </UserTask>
            <ExclusiveGateway ID="0006"/>
            <ExclusiveGateway ID="0007" />
        </Steps>
        <Graph></Graph>
    </Flows>
    <!--活动/事件-->
    <Pages>
        <!--表单页面-->
        <Page ID="1" Name="2">
            <Type>3</Type>
            <Url>4</Url>
            <Fields>5</Fields>
            <Content>6</Content>
            <OnCreate>7</OnCreate>
            <OnSubmit>8</OnSubmit>
            <Methods>9</Methods>
        </Page>
    </Pages>
    <!--表单页面-->
    <Params>
        <!--流程变量定义-->
        <Param Name="&amp;IsLeader">
            <Type>string</Type>
            <IsArray>1</IsArray>
            <Value>0</Value>
            <GroupName>0</GroupName>
        </Param>
        <Param Name="&amp;Title">
            <Type>string</Type>
            <IsArray>0</IsArray>
            <Value>请审批</Value>
            <GroupName>0</GroupName>
        </Param>
    </Params>
    <!--流程变量定义-->
</Process>', N'3043934F-DA04-4A96-B010-623BD047DABD')
GO
GO

-- ----------------------------
-- Indexes structure for table DtFieldDatetime
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table DtFieldDatetime
-- ----------------------------
ALTER TABLE [dbo].[DtFieldDatetime] ADD PRIMARY KEY ([ColumnGuid])
GO

-- ----------------------------
-- Indexes structure for table DtFieldDecimal
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table DtFieldDecimal
-- ----------------------------
ALTER TABLE [dbo].[DtFieldDecimal] ADD PRIMARY KEY ([ColumnGuid])
GO

-- ----------------------------
-- Indexes structure for table DtFieldInt
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table DtFieldInt
-- ----------------------------
ALTER TABLE [dbo].[DtFieldInt] ADD PRIMARY KEY ([ColumnGuid])
GO

-- ----------------------------
-- Indexes structure for table DtFieldText
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table DtFieldText
-- ----------------------------
ALTER TABLE [dbo].[DtFieldText] ADD PRIMARY KEY ([ColumnGuid])
GO

-- ----------------------------
-- Indexes structure for table DtFieldVarchar
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table DtFieldVarchar
-- ----------------------------
ALTER TABLE [dbo].[DtFieldVarchar] ADD PRIMARY KEY ([ColumnGuid])
GO

-- ----------------------------
-- Indexes structure for table DtFieldXml
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table DtFieldXml
-- ----------------------------
ALTER TABLE [dbo].[DtFieldXml] ADD PRIMARY KEY ([ColumnGuid])
GO

-- ----------------------------
-- Indexes structure for table DtParam
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table DtParam
-- ----------------------------
ALTER TABLE [dbo].[DtParam] ADD PRIMARY KEY ([ParamGuid])
GO

-- ----------------------------
-- Indexes structure for table FmHtml
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table FmHtml
-- ----------------------------
ALTER TABLE [dbo].[FmHtml] ADD PRIMARY KEY ([FormGuid])
GO

-- ----------------------------
-- Indexes structure for table RtDelegate
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table RtDelegate
-- ----------------------------
ALTER TABLE [dbo].[RtDelegate] ADD PRIMARY KEY ([DelegateGuid])
GO

-- ----------------------------
-- Indexes structure for table RtForm
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table RtForm
-- ----------------------------
ALTER TABLE [dbo].[RtForm] ADD PRIMARY KEY ([FormCaseGuid])
GO

-- ----------------------------
-- Indexes structure for table RtInstance
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table RtInstance
-- ----------------------------
ALTER TABLE [dbo].[RtInstance] ADD PRIMARY KEY ([InstanceGuid])
GO

-- ----------------------------
-- Indexes structure for table RtNode
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table RtNode
-- ----------------------------
ALTER TABLE [dbo].[RtNode] ADD PRIMARY KEY ([NodeGuid])
GO

-- ----------------------------
-- Indexes structure for table RtSerialNum
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table RtSerialNum
-- ----------------------------
ALTER TABLE [dbo].[RtSerialNum] ADD PRIMARY KEY ([SerialGuid])
GO

-- ----------------------------
-- Indexes structure for table RtTask
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table RtTask
-- ----------------------------
ALTER TABLE [dbo].[RtTask] ADD PRIMARY KEY ([TaskGuid])
GO

-- ----------------------------
-- Indexes structure for table RtToken
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table RtToken
-- ----------------------------
ALTER TABLE [dbo].[RtToken] ADD PRIMARY KEY ([TokenGuid])
GO

-- ----------------------------
-- Indexes structure for table RtTransition
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table RtTransition
-- ----------------------------
ALTER TABLE [dbo].[RtTransition] ADD PRIMARY KEY ([TransferGuid])
GO

-- ----------------------------
-- Indexes structure for table SysDepartment
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table SysDepartment
-- ----------------------------
ALTER TABLE [dbo].[SysDepartment] ADD PRIMARY KEY ([DeptGuid])
GO

-- ----------------------------
-- Indexes structure for table SysDeptUser
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table SysDeptUser
-- ----------------------------
ALTER TABLE [dbo].[SysDeptUser] ADD PRIMARY KEY ([DeptUserGuid])
GO

-- ----------------------------
-- Indexes structure for table SysRole
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table SysRole
-- ----------------------------
ALTER TABLE [dbo].[SysRole] ADD PRIMARY KEY ([RoleGuid])
GO

-- ----------------------------
-- Indexes structure for table SysRoleUser
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table SysRoleUser
-- ----------------------------
ALTER TABLE [dbo].[SysRoleUser] ADD PRIMARY KEY ([RoleUserGuid])
GO

-- ----------------------------
-- Indexes structure for table SysUser
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table SysUser
-- ----------------------------
ALTER TABLE [dbo].[SysUser] ADD PRIMARY KEY ([UserGuid])
GO

-- ----------------------------
-- Indexes structure for table WfField
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table WfField
-- ----------------------------
ALTER TABLE [dbo].[WfField] ADD PRIMARY KEY ([FieldGuid])
GO

-- ----------------------------
-- Indexes structure for table WfProcess
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table WfProcess
-- ----------------------------
ALTER TABLE [dbo].[WfProcess] ADD PRIMARY KEY ([ProcessGuid])
GO

-- ----------------------------
-- Indexes structure for table WfRepository
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table WfRepository
-- ----------------------------
ALTER TABLE [dbo].[WfRepository] ADD PRIMARY KEY ([RepoGuid])
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[DtParam]
-- ----------------------------
ALTER TABLE [dbo].[DtParam] ADD FOREIGN KEY ([InstanceGuid]) REFERENCES [dbo].[RtInstance] ([InstanceGuid]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[RtInstance]
-- ----------------------------
ALTER TABLE [dbo].[RtInstance] ADD FOREIGN KEY ([RepoGuid]) REFERENCES [dbo].[WfRepository] ([RepoGuid]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[RtNode]
-- ----------------------------
ALTER TABLE [dbo].[RtNode] ADD FOREIGN KEY ([InstanceGuid]) REFERENCES [dbo].[RtInstance] ([InstanceGuid]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[RtTask]
-- ----------------------------
ALTER TABLE [dbo].[RtTask] ADD FOREIGN KEY ([InstanceGuid]) REFERENCES [dbo].[RtInstance] ([InstanceGuid]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[RtTransition]
-- ----------------------------
ALTER TABLE [dbo].[RtTransition] ADD FOREIGN KEY ([InstanceGuid]) REFERENCES [dbo].[RtInstance] ([InstanceGuid]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[SysDeptUser]
-- ----------------------------
ALTER TABLE [dbo].[SysDeptUser] ADD FOREIGN KEY ([DeptGuid]) REFERENCES [dbo].[SysDepartment] ([DeptGuid]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [dbo].[SysDeptUser] ADD FOREIGN KEY ([UserGuid]) REFERENCES [dbo].[SysUser] ([UserGuid]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[SysRoleUser]
-- ----------------------------
ALTER TABLE [dbo].[SysRoleUser] ADD FOREIGN KEY ([RoleGuid]) REFERENCES [dbo].[SysRole] ([RoleGuid]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [dbo].[SysRoleUser] ADD FOREIGN KEY ([UserGuid]) REFERENCES [dbo].[SysUser] ([UserGuid]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[WfRepository]
-- ----------------------------
ALTER TABLE [dbo].[WfRepository] ADD FOREIGN KEY ([ProcessGuid]) REFERENCES [dbo].[WfProcess] ([ProcessGuid]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
