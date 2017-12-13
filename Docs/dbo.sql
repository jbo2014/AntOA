/*
Navicat SQL Server Data Transfer

Source Server         : (LocalDB)v11.0
Source Server Version : 110000
Source Host           : (LocalDB)\v11.0:1433
Source Database       : Ant
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 110000
File Encoding         : 65001

Date: 2017-11-24 17:46:37
*/


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
-- Table structure for WfDelegate
-- ----------------------------
DROP TABLE [dbo].[WfDelegate]
GO
CREATE TABLE [dbo].[WfDelegate] (
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
'TABLE', N'WfDelegate', 
'COLUMN', N'DelegateGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'授权Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfDelegate'
, @level2type = 'COLUMN', @level2name = N'DelegateGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'授权Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfDelegate'
, @level2type = 'COLUMN', @level2name = N'DelegateGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfDelegate', 
'COLUMN', N'PrincipalGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'委托人Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfDelegate'
, @level2type = 'COLUMN', @level2name = N'PrincipalGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'委托人Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfDelegate'
, @level2type = 'COLUMN', @level2name = N'PrincipalGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfDelegate', 
'COLUMN', N'TrusteeGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'受托人Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfDelegate'
, @level2type = 'COLUMN', @level2name = N'TrusteeGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'受托人Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfDelegate'
, @level2type = 'COLUMN', @level2name = N'TrusteeGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfDelegate', 
'COLUMN', N'DelegateType')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'授权类型：
   1.临时委托；
   2.实例；
   3.流程定义委托；
   4.角色委托；
   5.完全授权'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfDelegate'
, @level2type = 'COLUMN', @level2name = N'DelegateType'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'授权类型：
   1.临时委托；
   2.实例；
   3.流程定义委托；
   4.角色委托；
   5.完全授权'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfDelegate'
, @level2type = 'COLUMN', @level2name = N'DelegateType'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfDelegate', 
'COLUMN', N'ObjectGuids')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'0、流程定义、定义节点、实例、实例任务，5种情况的Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfDelegate'
, @level2type = 'COLUMN', @level2name = N'ObjectGuids'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'0、流程定义、定义节点、实例、实例任务，5种情况的Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfDelegate'
, @level2type = 'COLUMN', @level2name = N'ObjectGuids'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfDelegate', 
'COLUMN', N'Status')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfDelegate'
, @level2type = 'COLUMN', @level2name = N'Status'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfDelegate'
, @level2type = 'COLUMN', @level2name = N'Status'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfDelegate', 
'COLUMN', N'EffectTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'生效时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfDelegate'
, @level2type = 'COLUMN', @level2name = N'EffectTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'生效时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfDelegate'
, @level2type = 'COLUMN', @level2name = N'EffectTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfDelegate', 
'COLUMN', N'ExpireTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'失效时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfDelegate'
, @level2type = 'COLUMN', @level2name = N'ExpireTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'失效时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfDelegate'
, @level2type = 'COLUMN', @level2name = N'ExpireTime'
GO

-- ----------------------------
-- Records of WfDelegate
-- ----------------------------

-- ----------------------------
-- Table structure for WfInstance
-- ----------------------------
DROP TABLE [dbo].[WfInstance]
GO
CREATE TABLE [dbo].[WfInstance] (
[InstanceGuid] uniqueidentifier NOT NULL ,
[ProcessGuid] uniqueidentifier NOT NULL ,
[ProcessVersion] nvarchar(11) NOT NULL ,
[InstanceTitle] nvarchar(100) NOT NULL ,
[InstanceStatus] tinyint NOT NULL ,
[CurrentTask] uniqueidentifier NULL ,
[Originator] uniqueidentifier NOT NULL ,
[StartTime] datetime NOT NULL ,
[Terminator] uniqueidentifier NULL ,
[EndTime] datetime NULL ,
[Stamp] timestamp NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfInstance', 
'COLUMN', N'InstanceGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfInstance'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfInstance'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfInstance', 
'COLUMN', N'ProcessGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程定义Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfInstance'
, @level2type = 'COLUMN', @level2name = N'ProcessGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程定义Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfInstance'
, @level2type = 'COLUMN', @level2name = N'ProcessGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfInstance', 
'COLUMN', N'ProcessVersion')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程定义版本'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfInstance'
, @level2type = 'COLUMN', @level2name = N'ProcessVersion'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程定义版本'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfInstance'
, @level2type = 'COLUMN', @level2name = N'ProcessVersion'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfInstance', 
'COLUMN', N'InstanceTitle')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程实例名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfInstance'
, @level2type = 'COLUMN', @level2name = N'InstanceTitle'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程实例名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfInstance'
, @level2type = 'COLUMN', @level2name = N'InstanceTitle'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfInstance', 
'COLUMN', N'InstanceStatus')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfInstance'
, @level2type = 'COLUMN', @level2name = N'InstanceStatus'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfInstance'
, @level2type = 'COLUMN', @level2name = N'InstanceStatus'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfInstance', 
'COLUMN', N'CurrentTask')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程当前任务'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfInstance'
, @level2type = 'COLUMN', @level2name = N'CurrentTask'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程当前任务'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfInstance'
, @level2type = 'COLUMN', @level2name = N'CurrentTask'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfInstance', 
'COLUMN', N'Originator')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程发起人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfInstance'
, @level2type = 'COLUMN', @level2name = N'Originator'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程发起人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfInstance'
, @level2type = 'COLUMN', @level2name = N'Originator'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfInstance', 
'COLUMN', N'StartTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程发起时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfInstance'
, @level2type = 'COLUMN', @level2name = N'StartTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程发起时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfInstance'
, @level2type = 'COLUMN', @level2name = N'StartTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfInstance', 
'COLUMN', N'Terminator')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程结束人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfInstance'
, @level2type = 'COLUMN', @level2name = N'Terminator'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程结束人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfInstance'
, @level2type = 'COLUMN', @level2name = N'Terminator'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfInstance', 
'COLUMN', N'EndTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程结束时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfInstance'
, @level2type = 'COLUMN', @level2name = N'EndTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程结束时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfInstance'
, @level2type = 'COLUMN', @level2name = N'EndTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfInstance', 
'COLUMN', N'Stamp')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'时间戳'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfInstance'
, @level2type = 'COLUMN', @level2name = N'Stamp'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'时间戳'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfInstance'
, @level2type = 'COLUMN', @level2name = N'Stamp'
GO

-- ----------------------------
-- Records of WfInstance
-- ----------------------------

-- ----------------------------
-- Table structure for WfNode
-- ----------------------------
DROP TABLE [dbo].[WfNode]
GO
CREATE TABLE [dbo].[WfNode] (
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
'TABLE', N'WfNode', 
'COLUMN', N'NodeGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'节点Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfNode'
, @level2type = 'COLUMN', @level2name = N'NodeGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'节点Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfNode'
, @level2type = 'COLUMN', @level2name = N'NodeGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfNode', 
'COLUMN', N'InstanceGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfNode'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfNode'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfNode', 
'COLUMN', N'StepDefID')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程定义中节点ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfNode'
, @level2type = 'COLUMN', @level2name = N'StepDefID'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程定义中节点ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfNode'
, @level2type = 'COLUMN', @level2name = N'StepDefID'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfNode', 
'COLUMN', N'NodeType')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'节点类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfNode'
, @level2type = 'COLUMN', @level2name = N'NodeType'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'节点类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfNode'
, @level2type = 'COLUMN', @level2name = N'NodeType'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfNode', 
'COLUMN', N'RawNodeGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'退回前原始节点Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfNode'
, @level2type = 'COLUMN', @level2name = N'RawNodeGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'退回前原始节点Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfNode'
, @level2type = 'COLUMN', @level2name = N'RawNodeGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfNode', 
'COLUMN', N'Sponsor')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'多实例下主办人ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfNode'
, @level2type = 'COLUMN', @level2name = N'Sponsor'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'多实例下主办人ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfNode'
, @level2type = 'COLUMN', @level2name = N'Sponsor'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfNode', 
'COLUMN', N'PassRate')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'通过率'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfNode'
, @level2type = 'COLUMN', @level2name = N'PassRate'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'通过率'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfNode'
, @level2type = 'COLUMN', @level2name = N'PassRate'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfNode', 
'COLUMN', N'AddSign')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'加签类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfNode'
, @level2type = 'COLUMN', @level2name = N'AddSign'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'加签类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfNode'
, @level2type = 'COLUMN', @level2name = N'AddSign'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfNode', 
'COLUMN', N'StartTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'开始时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfNode'
, @level2type = 'COLUMN', @level2name = N'StartTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'开始时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfNode'
, @level2type = 'COLUMN', @level2name = N'StartTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfNode', 
'COLUMN', N'EndTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'结束时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfNode'
, @level2type = 'COLUMN', @level2name = N'EndTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'结束时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfNode'
, @level2type = 'COLUMN', @level2name = N'EndTime'
GO

-- ----------------------------
-- Records of WfNode
-- ----------------------------

-- ----------------------------
-- Table structure for WfProcess
-- ----------------------------
DROP TABLE [dbo].[WfProcess]
GO
CREATE TABLE [dbo].[WfProcess] (
[ProcessGuid] uniqueidentifier NOT NULL ,
[ProcessName] nvarchar(50) NOT NULL ,
[IsMaster] bit NULL ,
[ProcessStatus] tinyint NOT NULL ,
[Description] nvarchar(100) NULL ,
[CreateTime] datetime NOT NULL ,
[UpdateTime] datetime NULL ,
[Stamp] timestamp NULL ,
[Version] nvarchar(11) NOT NULL ,
[BpmFile] nvarchar(50) NOT NULL ,
[BpmPath] nvarchar(100) NOT NULL ,
[BpmContent] nvarchar(MAX) NULL ,
[DepotGuid] uniqueidentifier NULL ,
[DepotName] nvarchar(100) NULL 
)


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
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'ProcessName'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'ProcessName'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcess', 
'COLUMN', N'IsMaster')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'Master版本'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'IsMaster'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'Master版本'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'IsMaster'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcess', 
'COLUMN', N'ProcessStatus')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'ProcessStatus'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'ProcessStatus'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcess', 
'COLUMN', N'Description')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'描述'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'Description'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'描述'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'Description'
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
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'更新时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'UpdateTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'更新时间'
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
'COLUMN', N'Version')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程定义的版本号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'Version'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程定义的版本号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'Version'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcess', 
'COLUMN', N'BpmFile')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程定义XML文件的名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'BpmFile'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程定义XML文件的名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'BpmFile'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcess', 
'COLUMN', N'BpmPath')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程定义XML文件的路径'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'BpmPath'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程定义XML文件的路径'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'BpmPath'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcess', 
'COLUMN', N'BpmContent')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程定义的XML'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'BpmContent'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程定义的XML'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'BpmContent'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcess', 
'COLUMN', N'DepotGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程定义仓库Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'DepotGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程定义仓库Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'DepotGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcess', 
'COLUMN', N'DepotName')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'仓库名(流程定义的类别)'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'DepotName'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'仓库名(流程定义的类别)'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcess'
, @level2type = 'COLUMN', @level2name = N'DepotName'
GO

-- ----------------------------
-- Records of WfProcess
-- ----------------------------

-- ----------------------------
-- Table structure for WfProcessDepot
-- ----------------------------
DROP TABLE [dbo].[WfProcessDepot]
GO
CREATE TABLE [dbo].[WfProcessDepot] (
[DepotGuid] uniqueidentifier NOT NULL ,
[ProcessGuid] uniqueidentifier NOT NULL ,
[Version] nvarchar(11) NOT NULL ,
[XmlFile] nvarchar(50) NOT NULL ,
[XmlPath] nvarchar(100) NOT NULL ,
[XmlContent] nvarchar(MAX) NULL ,
[CreateTime] datetime NOT NULL ,
[UpdateTime] datetime NULL ,
[Stamp] timestamp NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcessDepot', 
'COLUMN', N'DepotGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'定义文件Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcessDepot'
, @level2type = 'COLUMN', @level2name = N'DepotGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'定义文件Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcessDepot'
, @level2type = 'COLUMN', @level2name = N'DepotGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcessDepot', 
'COLUMN', N'ProcessGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程定义Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcessDepot'
, @level2type = 'COLUMN', @level2name = N'ProcessGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程定义Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcessDepot'
, @level2type = 'COLUMN', @level2name = N'ProcessGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcessDepot', 
'COLUMN', N'Version')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'版本'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcessDepot'
, @level2type = 'COLUMN', @level2name = N'Version'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'版本'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcessDepot'
, @level2type = 'COLUMN', @level2name = N'Version'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcessDepot', 
'COLUMN', N'XmlFile')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'Xml文件名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcessDepot'
, @level2type = 'COLUMN', @level2name = N'XmlFile'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'Xml文件名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcessDepot'
, @level2type = 'COLUMN', @level2name = N'XmlFile'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcessDepot', 
'COLUMN', N'XmlPath')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'Xml文件路径'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcessDepot'
, @level2type = 'COLUMN', @level2name = N'XmlPath'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'Xml文件路径'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcessDepot'
, @level2type = 'COLUMN', @level2name = N'XmlPath'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcessDepot', 
'COLUMN', N'XmlContent')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'Xml文件内容'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcessDepot'
, @level2type = 'COLUMN', @level2name = N'XmlContent'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'Xml文件内容'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcessDepot'
, @level2type = 'COLUMN', @level2name = N'XmlContent'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcessDepot', 
'COLUMN', N'CreateTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'创建时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcessDepot'
, @level2type = 'COLUMN', @level2name = N'CreateTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcessDepot'
, @level2type = 'COLUMN', @level2name = N'CreateTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcessDepot', 
'COLUMN', N'UpdateTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'最新更新时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcessDepot'
, @level2type = 'COLUMN', @level2name = N'UpdateTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'最新更新时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcessDepot'
, @level2type = 'COLUMN', @level2name = N'UpdateTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfProcessDepot', 
'COLUMN', N'Stamp')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'时间戳'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcessDepot'
, @level2type = 'COLUMN', @level2name = N'Stamp'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'时间戳'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfProcessDepot'
, @level2type = 'COLUMN', @level2name = N'Stamp'
GO

-- ----------------------------
-- Records of WfProcessDepot
-- ----------------------------

-- ----------------------------
-- Table structure for WfSerialNum
-- ----------------------------
DROP TABLE [dbo].[WfSerialNum]
GO
CREATE TABLE [dbo].[WfSerialNum] (
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
'TABLE', N'WfSerialNum', 
'COLUMN', N'SerialGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'序号Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfSerialNum'
, @level2type = 'COLUMN', @level2name = N'SerialGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'序号Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfSerialNum'
, @level2type = 'COLUMN', @level2name = N'SerialGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfSerialNum', 
'COLUMN', N'SerialName')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'序号名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfSerialNum'
, @level2type = 'COLUMN', @level2name = N'SerialName'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'序号名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfSerialNum'
, @level2type = 'COLUMN', @level2name = N'SerialName'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfSerialNum', 
'COLUMN', N'CurrentNum')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'当前序号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfSerialNum'
, @level2type = 'COLUMN', @level2name = N'CurrentNum'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'当前序号'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfSerialNum'
, @level2type = 'COLUMN', @level2name = N'CurrentNum'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfSerialNum', 
'COLUMN', N'Step')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'步长'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfSerialNum'
, @level2type = 'COLUMN', @level2name = N'Step'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'步长'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfSerialNum'
, @level2type = 'COLUMN', @level2name = N'Step'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfSerialNum', 
'COLUMN', N'Filler')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'填充字符'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfSerialNum'
, @level2type = 'COLUMN', @level2name = N'Filler'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'填充字符'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfSerialNum'
, @level2type = 'COLUMN', @level2name = N'Filler'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfSerialNum', 
'COLUMN', N'CreateTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'创建时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfSerialNum'
, @level2type = 'COLUMN', @level2name = N'CreateTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'创建时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfSerialNum'
, @level2type = 'COLUMN', @level2name = N'CreateTime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfSerialNum', 
'COLUMN', N'UpdateTime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'更新时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfSerialNum'
, @level2type = 'COLUMN', @level2name = N'UpdateTime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'更新时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfSerialNum'
, @level2type = 'COLUMN', @level2name = N'UpdateTime'
GO

-- ----------------------------
-- Records of WfSerialNum
-- ----------------------------

-- ----------------------------
-- Table structure for WfTask
-- ----------------------------
DROP TABLE [dbo].[WfTask]
GO
CREATE TABLE [dbo].[WfTask] (
[TaskGuid] uniqueidentifier NOT NULL ,
[InstanceGuid] uniqueidentifier NOT NULL ,
[NodeGuid] uniqueidentifier NOT NULL ,
[TaskTitle] nvarchar(100) NOT NULL ,
[TaskType] tinyint NULL ,
[TaskStatus] tinyint NOT NULL ,
[TaskOwner] uniqueidentifier NOT NULL ,
[TaskActor] uniqueidentifier NOT NULL ,
[Stamp] timestamp NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfTask', 
'COLUMN', N'TaskGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'任务Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTask'
, @level2type = 'COLUMN', @level2name = N'TaskGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'任务Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTask'
, @level2type = 'COLUMN', @level2name = N'TaskGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfTask', 
'COLUMN', N'InstanceGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTask'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTask'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfTask', 
'COLUMN', N'NodeGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'实例节点Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTask'
, @level2type = 'COLUMN', @level2name = N'NodeGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'实例节点Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTask'
, @level2type = 'COLUMN', @level2name = N'NodeGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfTask', 
'COLUMN', N'TaskTitle')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'任务标题'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTask'
, @level2type = 'COLUMN', @level2name = N'TaskTitle'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'任务标题'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTask'
, @level2type = 'COLUMN', @level2name = N'TaskTitle'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfTask', 
'COLUMN', N'TaskType')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'任务类型：
   0.正常处理
   1.加签者
   2.受托者'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTask'
, @level2type = 'COLUMN', @level2name = N'TaskType'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'任务类型：
   0.正常处理
   1.加签者
   2.受托者'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTask'
, @level2type = 'COLUMN', @level2name = N'TaskType'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfTask', 
'COLUMN', N'TaskStatus')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'任务状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTask'
, @level2type = 'COLUMN', @level2name = N'TaskStatus'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'任务状态'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTask'
, @level2type = 'COLUMN', @level2name = N'TaskStatus'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfTask', 
'COLUMN', N'TaskOwner')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'任务所有者的用户ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTask'
, @level2type = 'COLUMN', @level2name = N'TaskOwner'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'任务所有者的用户ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTask'
, @level2type = 'COLUMN', @level2name = N'TaskOwner'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfTask', 
'COLUMN', N'TaskActor')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'实际执行者的用户ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTask'
, @level2type = 'COLUMN', @level2name = N'TaskActor'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'实际执行者的用户ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTask'
, @level2type = 'COLUMN', @level2name = N'TaskActor'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfTask', 
'COLUMN', N'Stamp')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'时间戳'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTask'
, @level2type = 'COLUMN', @level2name = N'Stamp'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'时间戳'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTask'
, @level2type = 'COLUMN', @level2name = N'Stamp'
GO

-- ----------------------------
-- Records of WfTask
-- ----------------------------

-- ----------------------------
-- Table structure for WfTransition
-- ----------------------------
DROP TABLE [dbo].[WfTransition]
GO
CREATE TABLE [dbo].[WfTransition] (
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
'TABLE', N'WfTransition', 
'COLUMN', N'TransferGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'转交Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTransition'
, @level2type = 'COLUMN', @level2name = N'TransferGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'转交Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTransition'
, @level2type = 'COLUMN', @level2name = N'TransferGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfTransition', 
'COLUMN', N'InstanceGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTransition'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTransition'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfTransition', 
'COLUMN', N'TransferType')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'转交类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTransition'
, @level2type = 'COLUMN', @level2name = N'TransferType'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'转交类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTransition'
, @level2type = 'COLUMN', @level2name = N'TransferType'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfTransition', 
'COLUMN', N'ConditionResult')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'条件解析结果'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTransition'
, @level2type = 'COLUMN', @level2name = N'ConditionResult'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'条件解析结果'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTransition'
, @level2type = 'COLUMN', @level2name = N'ConditionResult'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfTransition', 
'COLUMN', N'SourceGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'原节点Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTransition'
, @level2type = 'COLUMN', @level2name = N'SourceGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'原节点Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTransition'
, @level2type = 'COLUMN', @level2name = N'SourceGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfTransition', 
'COLUMN', N'TargetGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'目标节点Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTransition'
, @level2type = 'COLUMN', @level2name = N'TargetGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'目标节点Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTransition'
, @level2type = 'COLUMN', @level2name = N'TargetGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfTransition', 
'COLUMN', N'Stamp')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'时间戳'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTransition'
, @level2type = 'COLUMN', @level2name = N'Stamp'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'时间戳'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfTransition'
, @level2type = 'COLUMN', @level2name = N'Stamp'
GO

-- ----------------------------
-- Records of WfTransition
-- ----------------------------

-- ----------------------------
-- Table structure for WfVar
-- ----------------------------
DROP TABLE [dbo].[WfVar]
GO
CREATE TABLE [dbo].[WfVar] (
[ParamGuid] uniqueidentifier NOT NULL ,
[InstanceGuid] uniqueidentifier NOT NULL ,
[ParamName] nvarchar(100) NOT NULL ,
[Value] nvarchar(MAX) NOT NULL 
)


GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfVar', 
'COLUMN', N'ParamGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'实例变量Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfVar'
, @level2type = 'COLUMN', @level2name = N'ParamGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'实例变量Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfVar'
, @level2type = 'COLUMN', @level2name = N'ParamGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfVar', 
'COLUMN', N'InstanceGuid')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfVar'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程实例Guid'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfVar'
, @level2type = 'COLUMN', @level2name = N'InstanceGuid'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfVar', 
'COLUMN', N'ParamName')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'流程定义的变量名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfVar'
, @level2type = 'COLUMN', @level2name = N'ParamName'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'流程定义的变量名'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfVar'
, @level2type = 'COLUMN', @level2name = N'ParamName'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'WfVar', 
'COLUMN', N'Value')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'变量值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfVar'
, @level2type = 'COLUMN', @level2name = N'Value'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'变量值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'WfVar'
, @level2type = 'COLUMN', @level2name = N'Value'
GO

-- ----------------------------
-- Records of WfVar
-- ----------------------------

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
-- Indexes structure for table WfDelegate
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table WfDelegate
-- ----------------------------
ALTER TABLE [dbo].[WfDelegate] ADD PRIMARY KEY ([DelegateGuid])
GO

-- ----------------------------
-- Indexes structure for table WfInstance
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table WfInstance
-- ----------------------------
ALTER TABLE [dbo].[WfInstance] ADD PRIMARY KEY ([InstanceGuid])
GO

-- ----------------------------
-- Indexes structure for table WfNode
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table WfNode
-- ----------------------------
ALTER TABLE [dbo].[WfNode] ADD PRIMARY KEY ([NodeGuid])
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
-- Indexes structure for table WfProcessDepot
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table WfProcessDepot
-- ----------------------------
ALTER TABLE [dbo].[WfProcessDepot] ADD PRIMARY KEY ([DepotGuid])
GO

-- ----------------------------
-- Indexes structure for table WfSerialNum
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table WfSerialNum
-- ----------------------------
ALTER TABLE [dbo].[WfSerialNum] ADD PRIMARY KEY ([SerialGuid])
GO

-- ----------------------------
-- Indexes structure for table WfTask
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table WfTask
-- ----------------------------
ALTER TABLE [dbo].[WfTask] ADD PRIMARY KEY ([TaskGuid])
GO

-- ----------------------------
-- Indexes structure for table WfTransition
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table WfTransition
-- ----------------------------
ALTER TABLE [dbo].[WfTransition] ADD PRIMARY KEY ([TransferGuid])
GO

-- ----------------------------
-- Indexes structure for table WfVar
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table WfVar
-- ----------------------------
ALTER TABLE [dbo].[WfVar] ADD PRIMARY KEY ([ParamGuid])
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
-- Foreign Key structure for table [dbo].[WfInstance]
-- ----------------------------
ALTER TABLE [dbo].[WfInstance] ADD FOREIGN KEY ([ProcessGuid]) REFERENCES [dbo].[WfProcess] ([ProcessGuid]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[WfNode]
-- ----------------------------
ALTER TABLE [dbo].[WfNode] ADD FOREIGN KEY ([InstanceGuid]) REFERENCES [dbo].[WfInstance] ([InstanceGuid]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[WfProcessDepot]
-- ----------------------------
ALTER TABLE [dbo].[WfProcessDepot] ADD FOREIGN KEY ([ProcessGuid]) REFERENCES [dbo].[WfProcess] ([ProcessGuid]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[WfTask]
-- ----------------------------
ALTER TABLE [dbo].[WfTask] ADD FOREIGN KEY ([InstanceGuid]) REFERENCES [dbo].[WfInstance] ([InstanceGuid]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [dbo].[WfTask] ADD FOREIGN KEY ([NodeGuid]) REFERENCES [dbo].[WfNode] ([NodeGuid]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[WfTransition]
-- ----------------------------
ALTER TABLE [dbo].[WfTransition] ADD FOREIGN KEY ([InstanceGuid]) REFERENCES [dbo].[WfInstance] ([InstanceGuid]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[WfVar]
-- ----------------------------
ALTER TABLE [dbo].[WfVar] ADD FOREIGN KEY ([InstanceGuid]) REFERENCES [dbo].[WfInstance] ([InstanceGuid]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
