#! /usr/bin/env python
# -*- coding: utf-8 -*-

import pymssql

class FetchStruct:

    # 获取结构行
    def GetStructRows(self, host, uid, pwd, db):
        # conn=pymssql.connect(host=r'localhost',user=r'sa',password=r'123@abc',database=r'AntOA')
        conn=pymssql.connect(host=host,user=uid,password=pwd,database=db)

        '''
        如果和本机数据库交互，只需修改链接字符串
        conn=pymssql.connect(host='.',database='Michael')
        '''
        cur=conn.cursor(as_dict=True)

        structSql='''SELECT 
 --OBJECT_ID(a.TABLE_SCHEMA + '.' + a.TABLE_NAME) AS [object_id] ,
        CASE WHEN a.ORDINAL_POSITION = 1
             THEN a.TABLE_SCHEMA + '.' + a.TABLE_NAME
             ELSE ''
        END AS TABLE_NAME ,
        CASE WHEN ( a.ORDINAL_POSITION = 1
                    AND p1.value IS NOT NULL
                  ) THEN p1.value
             ELSE ''
        END AS TABLE_Description ,
        a.COLUMN_NAME ,
				a.DATA_TYPE AS COLUMN_TYPE,
        CASE WHEN ( ( CHARINDEX('char', a.DATA_TYPE) > 0
                      OR CHARINDEX('binary', a.DATA_TYPE) > 0
                    )
                    AND a.CHARACTER_MAXIMUM_LENGTH <> -1
                  )
             THEN CAST(a.CHARACTER_MAXIMUM_LENGTH AS VARCHAR(4))
--              WHEN ( ( CHARINDEX('CHAR', a.DATA_TYPE) > 0
--                       OR CHARINDEX('binary', a.DATA_TYPE) > 0
--                     )
--                     AND a.CHARACTER_MAXIMUM_LENGTH = -1
--                   ) THEN 'max'
             WHEN ( CHARINDEX('numeric', a.DATA_TYPE) > 0 )
             THEN CAST(a.NUMERIC_PRECISION AS VARCHAR(4))
                  + ',' + CAST(a.NUMERIC_SCALE AS VARCHAR(4))
						 ELSE ''
        END AS COLUMN_MAX ,
        CASE WHEN c.IS_IDENTITY = 1 THEN 'YES'
             ELSE 'NO'
        END AS IS_IDENTITY ,
        a.IS_NULLABLE ,
        CASE WHEN a.COLUMN_DEFAULT IS NULL THEN ''
             ELSE a.COLUMN_DEFAULT
        END AS Default_Value ,
        CASE WHEN p.value IS NULL THEN ''
             ELSE p.value
        END AS [COLUMN_Description] ,
        CASE WHEN o.name IS  NULL THEN ''
             ELSE 'YES'
        END AS Is_PrimaryKey ,
        CASE WHEN f.parent_column_id IS NULL THEN ''
             ELSE 'YES'
        END AS Is_Foreignkeys ,
        CASE WHEN referenced_object_id IS NULL THEN ''
             ELSE OBJECT_NAME(referenced_object_id)
        END AS Foreign_Table ,
        CASE WHEN referenced_object_id IS NULL THEN ''
             ELSE ( SELECT  name
                    FROM    sys.columns
                    WHERE   object_id = f.referenced_object_id
                            AND column_id = f.referenced_column_id
                  )
        END AS Foreign_key
FROM    INFORMATION_SCHEMA.COLUMNS a
        INNER JOIN sys.columns c ON OBJECT_ID(a.TABLE_SCHEMA + '.'
                                              + a.TABLE_NAME) = c.OBJECT_ID
                                    AND a.COLUMN_NAME = c.NAME
        LEFT JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE b ON a.TABLE_SCHEMA = b.TABLE_SCHEMA
                                                           AND a.TABLE_NAME = b.TABLE_NAME
                                                           AND a.COLUMN_NAME = b.COLUMN_NAME
        LEFT JOIN sys.sysobjects o ON o.name = b.CONSTRAINT_NAME
                                      AND o.xtype = 'PK'
        LEFT JOIN sys.extended_properties p ON OBJECT_ID(a.TABLE_SCHEMA + '.'
                                                         + a.TABLE_NAME) = p.major_id
                                               AND a.Ordinal_position = p.minor_id
                                               AND p.class_desc = 'OBJECT_OR_COLUMN'
        LEFT JOIN sys.extended_properties p1 ON OBJECT_ID(a.TABLE_SCHEMA + '.'
                                                          + a.TABLE_NAME) = p1.major_id
                                                AND p1.minor_id = 0
        LEFT JOIN SYS.foreign_key_columns f ON OBJECT_ID(a.TABLE_SCHEMA + '.'
                                                         + a.TABLE_NAME) = f.parent_object_id
                                               AND a.ORDINAL_POSITION = f.parent_column_id
-- WHERE   a.TABLE_NAME = 'Address'
-- a.TABLE_NAME IN (SELECT name FROM sys.tables)
ORDER BY a.TABLE_SCHEMA,a.TABLE_NAME, a.ORDINAL_POSITION'''

        cur.execute(structSql)
        #如果update/delete/insert记得要conn.commit()
        #否则数据库事务无法提交

        rows = cur.fetchall()
        cur.close()
        conn.close()
        return rows
