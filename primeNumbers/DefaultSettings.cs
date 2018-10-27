﻿using System.Drawing;
using System;

namespace primeNumbers
{
    public class DefaultSettings
    {
        // PhpMyAdmin  http://192.168.10.226:85

        public string language = "Ru";
        public string dataBase = "simple";
        public string table = "simple";
        public string tableBackup = "simpleBackup";
        public string connectionString = "Server=192.168.10.226;Database=simple;Uid=simple;Pwd=mYUXLmSmqxd2F6Iu";
        public string typeBase = "MySql";
        public string allotmentLeft = "[ ";
        public string AllotmentRigth = " ]";
        public int lengthOutput = 10;
        //public string checkSimpleMethod = "maths.CheckSimple";
        public int threadSleep = 0;
        public int countTo = 50000;
        public int timeOutput=1000;
        public int getFrom = 0;
        public int getTo = 1000;
        public int getColumns = 10;
       
    }
}
