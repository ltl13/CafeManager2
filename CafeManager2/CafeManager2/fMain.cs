using CafeManager2.DAO;
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
            LoadComboboxTable(cbSwitchTable);
        }

        #region Method
        void LoadCagetory()
        {
            List<Category> listCagetory = CategoryDAO.Instance.GetListCagetory();
            cbCategory.DataSource = listCagetory;
            cbCategory.DisplayMember = "Name";
        }
        void LoadFoodListByCagetoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCagetoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }
        void LoadTable()
        {
            fpnlTable.Controls.Clear();
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
        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }
        #endregion

        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
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

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null) return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCagetoryID(id);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int idFood = (cbFood.SelectedItem as Food).ID;
            int count = (int)nudAmount.Value;
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), idFood, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, count);
            }
            ShowBill(table.ID);
            LoadTable();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nudDiscount.Value;
            double totalPrice = Convert.ToDouble(tbxTotalPrice.Text.Split(',')[0]);
            if (idBill != -1)
            {
                totalPrice = totalPrice * (100 - discount) * 10;
                if (MessageBox.Show(string.Format("Bạn muốn thanh toán hóa đơn {0} \n Tổng tiền (đã giảm {1}%): {2}", table.Name, discount, totalPrice), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount);
                    ShowBill(table.ID);
                }
            }
            LoadTable();
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(string.Format("Bạn muốn chuyển {0} với {1}?", (lsvBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).ID), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int id1 = (lsvBill.Tag as Table).ID;
                int id2 = (cbSwitchTable.SelectedItem as Table).ID;
                TableDAO.Instance.SwitchTable(id1, id2);
                LoadTable();
            }
        }
        #endregion
    }
}
