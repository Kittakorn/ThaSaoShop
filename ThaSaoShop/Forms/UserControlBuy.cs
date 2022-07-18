using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using ThaSaoShop.Helpers;
using ThaSaoShop.Models;

namespace ThaSaoShop.Forms
{
    public partial class UserControlBuy : UserControl
    {
        public StoreEntities db;

        public UserControlBuy(StoreEntities db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void UserControlBuy_Load(object sender, EventArgs e)
        {
            dpTo.Value = dpTo.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dpFrom.MaxDate = dpTo.Value;
            dpTo.MinDate = dpFrom.Value;
            comDisplay.SelectedIndex = 0;
            LoadData();
        }

        public void LoadData()
        {
            dtBuy.Rows.Clear();
            List<Buy> buys;
            if (txtSearch.Text.Trim().Length > 0)
            {
                buys = db.Buys
                    .Include(x => x.Product)
                    .Include(x => x.User)
                    .AsEnumerable()
                    .Where(x => x.Product.Name.Contains(txtSearch.Text) ||
                                x.Date.ToString("dd/MM/yyyy").Contains(txtSearch.Text) ||
                                x.User.Firstname.Contains(txtSearch.Text) ||
                                x.User.Lastname.Contains(txtSearch.Text) &&
                                txtSearch.Text != null)
                    .OrderByDescending(x => x.Date)
                    .Take(Convert.ToInt32(comDisplay.SelectedItem))
                    .ToList();
            }
            else
            {
                buys = db.Buys
                    .Include(x => x.Product)
                    .Include(x => x.User)
                    .OrderByDescending(x => x.Date)
                    .Take(Convert.ToInt32(comDisplay.SelectedItem))
                    .ToList();
            }
            buys = buys.Where(x => x.Date >= dpFrom.Value.Date && x.Date <= dpTo.Value.Date.AddMinutes(1439)).ToList();
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (var buy in buys)
            {
                rows.Add(new DataGridViewRow());
                rows[rows.Count - 1].CreateCells(dtBuy, buy.BuyId, buy.Date, buy.Product.Name, buy.Price,
                    buy.User.Firstname + " " + buy.User.Lastname);
            }
            dtBuy.Rows.AddRange(rows.ToArray());
            dtBuy.ClearSelection();
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            dpFrom.Value = new DateTime(2018, 1, 1);
            dpTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var row = dtBuy.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dtBuy.Rows[row].Cells[0].Value);
            using (FormBuy form = new FormBuy(this, id))
            {
                form.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (FormBuy form = new FormBuy(this))
            {
                form.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ยืนยันการลบข้อมูล", "แจ้งเตือน", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) != DialogResult.OK) return;

            var row = dtBuy.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dtBuy.Rows[row].Cells[0].Value.ToString());
            var buy = db.Buys.Find(id);
            db.Buys.Remove(buy);
            try
            {
                db.SaveChanges();
                LoadData();
            }
            catch
            {
                db.ResetContextState();
                MessageBox.Show("ไม่สามารถลบข้อมูลได้", "แจ้งเตือน", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void dpTo_ValueChanged(object sender, EventArgs e)
        {
            dpFrom.MaxDate = dpTo.Value;
        }

        private void dpFrom_ValueChanged(object sender, EventArgs e)
        {
            dpTo.MinDate = dpFrom.Value;
        }

        private void dtBuy_SelectionChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = dtBuy.SelectedRows.Count > 0;
            btnDelete.Enabled = dtBuy.SelectedRows.Count > 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
