﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace PFormula1MongoDB
{
    internal class ConectionDB
    {
        public string DataBase { get; set; }
        public string Local { get; set; }
        public int Port { get; set; }

        public ConectionDB(string dataBase, string local, int port)
        {
            DataBase = dataBase;
            Local = local;
            Port = port;
        }

        public string PathConection(ConectionDB conectionDB)
        {
            return $"{DataBase}://{Local}:{Port}";
        }


        //  mongodb://localhost:27017
    }
}
