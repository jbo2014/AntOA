#! /usr/bin/env python
# -*- coding: utf-8 -*-

import sys
from FetchStruct import FetchStruct
from WriteFile import WriteFile

space = "Model"
csdir = "E:/GitHubs/AntOA/Model"
connname = "SQLDB"

fetch = FetchStruct()  #所有实体表的所有列    
rows = fetch.GetStructRows(r'localhost',r'sa',r'123@abc',r'AntOA')

writer = WriteFile(space, csdir)

length = len(rows)
columns = []    # 一个实体表的所有列
for i,row in enumerate(rows):
    columns.append(row)
    if(i+1 == length or rows[i+1]['TABLE_NAME'] != ''):
        writer.WriteEntityFile(columns, rows)
        writer.WriteMapFile(columns)
        columns = []
writer.WriteConnectFile(connname, rows)   
