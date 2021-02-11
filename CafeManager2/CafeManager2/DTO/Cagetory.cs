﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager2.DTO
{
    public class Cagetory
    {
        private int iD;
        private string name;

        public Cagetory(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
        }
        public Cagetory(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
    }
}
