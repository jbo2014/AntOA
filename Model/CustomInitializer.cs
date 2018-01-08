using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.IO;

namespace Model
{
    public class CustomInitializer : DropCreateDatabaseIfModelChanges<SQLDB>
    {
        protected override void Seed(SQLDB db)
        {

            DateTime now = DateTime.Now;

            var ct = new WfForm();
            ct.FormGuid = new Guid("FA771087-632B-4DED-B99D-5DAB949435D9");
            ct.MasterGuid = new Guid("A40797C6-0DDA-4A23-B104-43607D6A69B9");
            ct.Type = "TaskForm";
            ct.Html = @"总经理：<input field='&amp;Leader' id='data_561dc40ced034' name='data_561dc40ced034' title='leader' type='text' value='' />";
            //ct.CreateTime = now;
            ct.Name = "总经理";
            //ct.UpdateTime = now;
            ct.Released = 1;
            db.WfForms.Add(ct);

            ct = new WfForm();
            ct.FormGuid = new Guid("27660889-5B1B-4EB4-AB8D-628A97779C89");
            ct.MasterGuid = new Guid("A40797C6-0DDA-4A23-B104-43607D6A69B9");
            ct.Type = "TaskForm";
            ct.Html = @"部门经理：<input field='&amp;Manager' id='data_561dc3f2759ef' name='data_561dc3f2759ef' title='manager' type='text' value='' />";
            ct.Name = "部门经理";
            ct.Released = 1;
            db.WfForms.Add(ct);

            ct = new WfForm();
            ct.FormGuid = new Guid("7CF512D2-A62A-4C9F-A5CE-84898B8781AD");
            ct.MasterGuid = new Guid("A40797C6-0DDA-4A23-B104-43607D6A69B9");
            ct.Type = "StartForm";
            ct.Html = @"发起人：<input field='&amp;Applicant' id='data_561dc3c314fbd' name='data_561dc3c314fbd' title='applicant' type='text' value='' />";
            ct.Name = "发起申请";
            ct.Released = 1;
            db.WfForms.Add(ct);

            ct = new WfForm();
            ct.FormGuid = new Guid("DBB9B148-0E1C-4E7C-B709-D4B05CA253C9");
            ct.MasterGuid = new Guid("A40797C6-0DDA-4A23-B104-43607D6A69B9");
            ct.Type = "TaskForm";
            ct.Name = "申请人接收";
            ct.Released = 1;
            db.WfForms.Add(ct);

            //---------------------------------------------------

            var wf = new WfField();
            wf.FieldGuid = new Guid("D3C3F2EE-3B81-445A-91EE-D015FF8BCD46");
            wf.MasterGuid = new Guid("A40797C6-0DDA-4A23-B104-43607D6A69B9");
            wf.Name = "&Leader";
            wf.Type = "string";
            wf.IsArray = false;
            db.WfFields.Add(wf);

            wf = new WfField();
            wf.FieldGuid = new Guid("AB7A8476-867D-4186-8F44-892EAE25B62B");
            wf.MasterGuid = new Guid("A40797C6-0DDA-4A23-B104-43607D6A69B9");
            wf.Name = "&Applicant";
            wf.Type = "string";
            wf.IsArray = false;
            db.WfFields.Add(wf);

            wf = new WfField();
            wf.FieldGuid = new Guid("7ADD5FED-AC15-49CE-967A-6E705B2878B3");
            wf.MasterGuid = new Guid("A40797C6-0DDA-4A23-B104-43607D6A69B9");
            wf.Name = "&Manager";
            wf.Type = "string";
            wf.IsArray = false;
            db.WfFields.Add(wf);

            wf = new WfField();
            wf.FieldGuid = new Guid("F1B655B8-AF13-4B0C-B7D1-DB81DC8267CC");
            wf.MasterGuid = new Guid("A40797C6-0DDA-4A23-B104-43607D6A69B9");
            wf.Name = "&Title";
            wf.Type = "string";
            wf.IsArray = false;
            db.WfFields.Add(wf);

            //---------------------------------------------------

            //var rth = new RtForm();
            //rth.FormGuid = new Guid("7E517D5E-779A-40F8-B3DC-0C9FB0998B8F");
            //rth.InstanceGuid = new Guid("84944CDA-E4DF-4FB0-8A80-B04CBEF1AC16");
            //rth.TaskPage = new Guid("FA771087-632B-4DED-B99D-5DAB949435D9");
            //db.RtForms.Add(rth);

            //rth = new RtForm();
            //rth.FormGuid = new Guid("E9EE0B14-7395-430B-9B06-1713B18E5206");
            //rth.InstanceGuid = new Guid("84944CDA-E4DF-4FB0-8A80-B04CBEF1AC16");
            //rth.TaskPage = new Guid("27660889-5B1B-4EB4-AB8D-628A97779C89");
            //db.RtForms.Add(rth);

            //rth = new RtForm();
            //rth.FormGuid = new Guid("BB2AF697-CF0F-4825-9C57-26858CC76A08");
            //rth.InstanceGuid = new Guid("84944CDA-E4DF-4FB0-8A80-B04CBEF1AC16");
            //rth.TaskPage = new Guid("DBB9B148-0E1C-4E7C-B709-D4B05CA253C9");
            //db.RtForms.Add(rth);

            //rth = new RtForm();
            //rth.FormGuid = new Guid("897C0AD9-E219-422C-BF50-3B94EAF00576");
            //rth.InstanceGuid = new Guid("84944CDA-E4DF-4FB0-8A80-B04CBEF1AC16");
            //rth.TaskPage = new Guid("7CF512D2-A62A-4C9F-A5CE-84898B8781AD");
            //db.RtForms.Add(rth);

            //---------------------------------------------------

            var code = new CodeTable();
            code.CodeCD = "ShareForm";
            code.Group = "FormType";
            code.Name = "共享表单";
            code.Value = 2;
            code.Sort = 2;
            db.CodeTables.Add(code);

            code = new CodeTable();
            code.CodeCD = "StartForm";
            code.Group = "FormType";
            code.Name = "开始表单";
            code.Value = 0;
            code.Sort = 0;
            db.CodeTables.Add(code);

            code = new CodeTable();
            code.CodeCD = "TaskForm";
            code.Group = "FormType";
            code.Name = "任务表单";
            code.Value = 1;
            code.Sort = 1;
            db.CodeTables.Add(code);

            code = new CodeTable();
            code.CodeCD = "IntField";
            code.Group = "FieldType";
            code.Name = "Int字段";
            code.Value = 1;
            code.Sort = 1;
            db.CodeTables.Add(code);

            code = new CodeTable();
            code.CodeCD = "FloatField";
            code.Group = "FieldType";
            code.Name = "浮点字段";
            code.Value = 2;
            code.Sort = 2;
            db.CodeTables.Add(code);

            code = new CodeTable();
            code.CodeCD = "StringField";
            code.Group = "FieldType";
            code.Name = "字符串字段";
            code.Value = 3;
            code.Sort = 3;
            db.CodeTables.Add(code);

            code = new CodeTable();
            code.CodeCD = "DateTimeField";
            code.Group = "FieldType";
            code.Name = "时间字段";
            code.Value = 4;
            code.Sort = 4;
            db.CodeTables.Add(code);

            code = new CodeTable();
            code.CodeCD = "XmlField";
            code.Group = "FieldType";
            code.Name = "Xml字段";
            code.Value = 5;
            code.Sort = 5;
            db.CodeTables.Add(code);

            code = new CodeTable();
            code.CodeCD = "NoReadNoWrite";
            code.Group = "ControlType";
            code.Name = "不可读不可写";
            code.Value = 0;
            code.Sort = 0;
            code.Description = "表单控件控制属性";
            db.CodeTables.Add(code);

            code = new CodeTable();
            code.CodeCD = "ReadNoWrite";
            code.Group = "ControlType";
            code.Name = "可读不可写";
            code.Value = 1;
            code.Sort = 1;
            code.Description = "表单控件控制属性";
            db.CodeTables.Add(code);

            code = new CodeTable();
            code.CodeCD = "NoReadWrite";
            code.Group = "ControlType";
            code.Name = "不可读可写";
            code.Value = 2;
            code.Sort = 2;
            code.Description = "表单控件控制属性";
            db.CodeTables.Add(code);

            code = new CodeTable();
            code.CodeCD = "ReadWrite";
            code.Group = "ControlType";
            code.Name = "可读可写";
            code.Value = 3;
            code.Sort = 3;
            code.Description = "表单控件控制属性";
            db.CodeTables.Add(code);

            //---------------------------------------------------

            //var i = new RtInstance();
            //i.InstanceGuid = new Guid("84944CDA-E4DF-4FB0-8A80-B04CBEF1AC16");
            //i.RepoGuid = new Guid("A40797C6-0DDA-4A23-B104-43607D6A69B9");
            //i.InstanceTitle = "请假";
            //i.InstanceStatus = 0;
            //db.RtInstances.Add(i);

            //---------------------------------------------------

            var p = new WfProcess();
            p.ProcessGuid = new Guid("3043934F-DA04-4A96-B010-623BD047DABD");
            p.ProcessName = "请假";
            p.MasterVer = "1";
            p.Status = 1;
            db.WfProcesss.Add(p);

            //---------------------------------------------------

            var rp = new WfRepository();
            rp.RepoGuid = new Guid("A40797C6-0DDA-4A23-B104-43607D6A69B9");
            rp.Version = "1";
            //rp.BpmContent = System.IO.File.ReadAllText(@"E:/GitHubs/AntOA/WebApp/Bpmx/xxxxx.bpmx");
            FileStream stream = new FileStream(System.Configuration.ConfigurationSettings.AppSettings["BpmxPath"], FileMode.Open, FileAccess.Read, FileShare.Read);
            StreamReader reader = new StreamReader(stream);
            rp.BpmContent = reader.ReadToEnd();
            rp.ProcessGuid = new Guid("3043934F-DA04-4A96-B010-623BD047DABD");
            db.WfRepositorys.Add(rp);
            stream.Close();

            //---------------------------------------------------

            var u1 = new SysUser();
            u1.UserGuid = new Guid("BC348BD4-27A9-4EB0-ABE4-5DE39C2A50F5");
            u1.UserID = "a";
            db.SysUsers.Add(u1);

            var u2 = new SysUser();
            u2.UserGuid = new Guid("530C035C-30BC-43AA-B5E2-68177E5244D8");
            u2.UserID = "b";
            db.SysUsers.Add(u2);

            var u3 = new SysUser();
            u3.UserGuid = new Guid("E4850284-BB32-4A68-842A-26D0108717F8");
            u3.UserID = "c";
            db.SysUsers.Add(u3);

            //---------------------------------------------------

            var r1 = new SysRole();
            r1.RoleGuid = new Guid("1CC1BFE2-DA3A-4819-BDD9-BC95BD91BBE9");
            r1.RoleName = "Manager";
            db.SysRoles.Add(r1);

            var r2 = new SysRole();
            r2.RoleGuid = new Guid("AAF2B23F-742B-4DFC-BD2E-C5E5D48C9405");
            r2.RoleName = "Leader";
            db.SysRoles.Add(r2);

            //---------------------------------------------------

            var ru1 = new SysRoleUser();
            ru1.RoleUserGuid = Guid.NewGuid();
            ru1.RoleGuid = new Guid("1CC1BFE2-DA3A-4819-BDD9-BC95BD91BBE9");
            ru1.UserGuid = new Guid("530C035C-30BC-43AA-B5E2-68177E5244D8");
            db.SysRoleUsers.Add(ru1);

            var ru2 = new SysRoleUser();
            ru2.RoleUserGuid = Guid.NewGuid();
            ru2.RoleGuid = new Guid("AAF2B23F-742B-4DFC-BD2E-C5E5D48C9405");
            ru2.UserGuid = new Guid("E4850284-BB32-4A68-842A-26D0108717F8");
            db.SysRoleUsers.Add(ru2);




            db.SaveChanges();

            base.Seed(db);

        }
    }
}
