﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager2.DTO
{
    class Bill
    {
        private int iD;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int status;
        private int discount;
        private float total;

        public Bill(int iD, DateTime? dateCheckIn, DateTime? dateCheckOut, int status, int discount = 0, float total = 0)
        {
            this.ID = iD;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
            this.Discount = discount;
            this.Total = total;
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];
            var dateCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
            this.Status = (int)row["status"];
            this.Discount = (int)row["discount"];
            var totalTemp = row["total"];
            if (totalTemp.ToString() != "")
                this.Total = (float)Convert.ToDouble(totalTemp);
        }
        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }
        public float Total { get => total; set => total = value; }
    }
}
