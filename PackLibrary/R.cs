﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackLibrary
{
    public class R
    {
        public class SQL_SERVER
        {
            public static string SERVIDOR = @"SOPORTE\ETIQUETAS";
            public static string USER = "soporte";
            public static string PASSWORD = "123";
            public static string CONNECTION_STRING = @"Server=" + R.SQL_SERVER.SERVIDOR
                +";Initial Catalog="+DATABASE.NAME_BIOADMIN+";User Id="+R.SQL_SERVER.USER+
                ";PassWord="+SQL_SERVER.PASSWORD;
        }
        public class DATABASE
        {
            public static string NAME_BIOADMIN = "BDBioAdminSQL";


            public class FIELDS_DB
            {
                public class BDBioAdminSQL
                {
                    public static string IDUSER = "IdUser";
                    public static string FECHARECORD = "RecordTime";
                    public static string MACHINE = "MachineNumber";
                }
            }
            public class TABLES
            {
                public static string TABLE_RECORD = "Record";
            }
        }
        public class STRING_SQL
        {
            public static string GET_PONCHES = "SELECT " + R.DATABASE.FIELDS_DB.BDBioAdminSQL.IDUSER + "," +
                R.DATABASE.FIELDS_DB.BDBioAdminSQL.FECHARECORD +","+R.DATABASE.FIELDS_DB.BDBioAdminSQL.MACHINE +
                "FROM "+R.DATABASE.TABLES.TABLE_RECORD;
        }

    }
}
