﻿using CafeManager2.DAO;
using CafeManager2.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = CafeManager2.DTO.Menu;

namespace CafeManager2
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            LoadTable();
            LoadCagetory();
        }

        #region Method
        void LoadCagetory()
        {

        }
        void LoadFoodListByCagetoryID(int id)
        {

        }
        void LoadTable()
        {
            List<Table> listTable = TableDAO.Instance.LoadTableList();
            foreach (Table item in listTable)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + "\n" + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.LightGreen;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                fpnlTable.Controls.Add(btn);
            }
        }
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach(Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            //Change currency system
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VN");
            tbxTotalPrice.Text = totalPrice.ToString("c", culture);
        }
        #endregion

        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            ShowBill(tableID);
        }
        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccount fAcc = new fAccount();
            fAcc.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin fAd = new fAdmin();
            fAd.ShowDialog();
        }
        #endregion

        private void cbCagetory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            LoadFoodListByCagetoryID(id);
        }
    }
}
