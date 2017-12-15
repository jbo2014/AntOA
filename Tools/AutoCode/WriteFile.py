#! /usr/bin/env python
# -*- coding: utf-8 -*-

import datetime
import os

class WriteFile:

    def __init__(self, space, csdir):
        self.space = space
        self.csdir = csdir  
        if(not os.path.exists(csdir)):
            os.mkdir(csdir) 
        if(not os.path.exists(csdir+'/Mapping/')):
            os.mkdir(csdir+'/Mapping/')
        

    # 类型转换
    def ConvertType(self, sqlType):
        reval = None    
        if(sqlType.lower() == "bit"):
            reval = "bool"
        elif(sqlType.lower() == "tinyint"):
            reval = "byte"
        elif(sqlType.lower() == "smallint"):
            reval = "short"
        elif(sqlType.lower() == "int"):
            reval = "int"
        elif(sqlType.lower() == "bigint"):
            reval = "long"
        elif(sqlType.lower() == "real"):
            reval = "float"
        elif(sqlType.lower() == "float"):
            reval = "double"
        elif(sqlType.lower() == "money"):
            reval = "decimal"
        elif(sqlType.lower() == "datetime"):
            reval = "DateTime"
        elif(sqlType.lower() == "char"):
            reval = "string"
        elif(sqlType.lower() == "nchar"):
            reval = "string"
        elif(sqlType.lower() == "varchar"):
            reval = "string"
        elif(sqlType.lower() == "nvarchar"):
            reval = "string"
        elif(sqlType.lower() == "text"):
            reval = "string"
        elif(sqlType.lower() == "ntext"):
            reval = "string"
        elif(sqlType.lower() == "image"):
            reval = "byte[]"
        elif(sqlType.lower() == "binary"):
            reval = "byte[]"
        elif(sqlType.lower() == "timestamp"):
            reval = "byte[]"
        elif(sqlType.lower() == "uniqueidentifier"):
            reval = "Guid"
        return reval

    # 写实体类文件
    def WriteEntityFile(self, columns, rows):
        className = columns[0]['TABLE_NAME'].split('.')[-1]
        classDescription = bytes.decode(columns[0]['TABLE_Description'])

        # 列属性声明
        propertyStr = ''
        colType = None
        foreignStr = ''
        for column in columns:
            colType = self.ConvertType(column['COLUMN_TYPE'])
            if(column['Is_PrimaryKey'].upper()=='YES'):
                propertyStr = propertyStr+'\r\t\t[Key]'
            elif(column['COLUMN_Description'] != '' and column['COLUMN_Description'] is not None):
                propertyStr = propertyStr+'\r\t\t[DisplayName("'+bytes.decode(column['COLUMN_Description']).replace('\r','').replace('\n','')+'")]'
            if(column['IS_NULLABLE'].upper()=='YES' and colType.lower() != 'string' and colType != 'byte[]'):
                propertyStr = propertyStr+'\r\t\tpublic Nullable<'+ colType +'> '+column['COLUMN_NAME'] +' { get; set; }'
            else:
                propertyStr = propertyStr+'\r\t\tpublic '+ colType +' '+ column['COLUMN_NAME'] +' { get; set; }'
            if(column['Is_Foreignkeys'].upper()=='YES'):
                foreignStr = foreignStr+'\r\t\tpublic virtual '+column['Foreign_Table']+' '+column['COLUMN_NAME']+'_FK { get; set; }'

        # 构造函数中的变量初始化
        structFuncStr = ''
        # 关联表的引用
        refStr = ''
        tableName = None
        for row in rows:
            if(row['TABLE_NAME'] != ''):
                tableName = row['TABLE_NAME'].split('.')[-1]
            if(row['Foreign_Table']==className):
                structFuncStr = structFuncStr + '\r\t\t\tthis.' + tableName + '_' + row['COLUMN_NAME'] + 'List = new List<' + tableName + '>();'
                refStr = refStr + '\r\t\tpublic virtual ICollection<' + tableName + '> ' + tableName + '_' + row['COLUMN_NAME'] + 'List { get; set; }'
            else:
                continue
                    
        
        file = open(os.path.dirname(__file__)+'/entity.txt', 'r', encoding= 'utf-8')
        txt = file.read()
        entityStr = txt.format(**{
            "space" : self.space, 
            "classDescription" : classDescription, 
            "date" : datetime.date.today().strftime('%Y-%m-%d'), 
            "className" : className, 
            "structFuncStr" : structFuncStr, 
            "propertyStr" : propertyStr, 
            "refStr" : refStr,
            "foreignStr" : foreignStr
            })

        file = open(self.csdir+'/'+className + '.cs', 'w')
        file.write(entityStr)
        file.close()


    # 写实体映射文件
    def WriteMapFile(self, columns):
        className = columns[0]['TABLE_NAME'].split('.')[-1]
        classDescription = bytes.decode(columns[0]['TABLE_Description'])

        propertyStr = ''
        relationshipStr = ''
        foreignKeyStr = ''
        for column in columns:
            if(column['Is_PrimaryKey'].upper() == 'YES'):
                propertyStr = propertyStr+'\r\t\tthis.HasKey(t => t.'+column['COLUMN_NAME']+');'
            elif(column['COLUMN_MAX'] != ''):
                propertyStr = propertyStr+'\r\t\tthis.Property(t => t.'+column['COLUMN_NAME']+').HasMaxLength('+column['COLUMN_MAX']+');'
            
            relationshipStr = relationshipStr+'\r\t\tthis.Property(t => t.'+column['COLUMN_NAME']+').HasColumnName("'+column['COLUMN_NAME']+'");'

            if(column['Is_Foreignkeys'].upper() == 'YES'):
                foreignKeyStr = foreignKeyStr+'\r\t\tthis.HasOptional(t => t.'+column['COLUMN_NAME']+'_FK).WithMany(t => t.'+className+'_'+column['COLUMN_NAME']+'List).HasForeignKey(d => d.'+column['COLUMN_NAME']+');'
            
        
        file = open(os.path.dirname(__file__)+'/map.txt', 'r', encoding= 'utf-8')
        txt = file.read().format(**{
            "space" : self.space, 
            "classDescription" : classDescription, 
            "date" : datetime.date.today().strftime('%Y-%m-%d'), 
            "className" : className, 
            "propertyStr" : propertyStr,
            "relationshipStr" : relationshipStr,
            "foreignKeyStr" : foreignKeyStr
            })

        file = open(self.csdir+'/Mapping/'+className + 'Map.cs', 'w')
        file.write(txt)
        file.close()



    def WriteConnectFile(self, connname, rows):
        entityStr = ''
        mapStr = ''
        tableName = None
        for row in rows:
            if(row['TABLE_NAME']!=''):
                tableName = row['TABLE_NAME'].split('.')[1]
                entityStr = entityStr + '\r\t\tpublic DbSet<' + tableName + '> ' + tableName + 's { get; set; }'
                mapStr = mapStr + '\r\t\t\tmodelBuilder.Configurations.Add(new ' + tableName + 'Map());'
            else:
                continue            
        
        file = open(os.path.dirname(__file__)+'/SQLDB.txt', 'r', encoding= 'utf-8')
        txt = file.read().format(**{
            "space" : self.space, 
            "date" : datetime.date.today().strftime('%Y-%m-%d'), 
            "connStrName" : connname.strip(), 
            "entityStr" : entityStr.strip(),
            "mapStr" : mapStr.strip()
            })

        file = open(self.csdir+'/'+connname + '.cs', 'w')
        file.write(txt)
        file.close()
