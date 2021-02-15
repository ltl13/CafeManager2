﻿using CafeManager2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager2.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }
        private CategoryDAO() { }
        public List<Category> GetListCagetory()
        {
            List<Category> list = new List<Category>();
            string query = "select * from FoodCategory";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Category cagetory = new Category(item);
                list.Add(cagetory);
            }
            return list;
        }
        public Category GetCategoryByID(int id)
        {
            Category category = null;
            string query = "select * from FoodCategory where id = " + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }
            return category;
        }
    }
}
