using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaSaoShop.Helpers;
using ThaSaoShop.Models;

namespace ThaSaoShop.Forms
{
    public partial class UserControlProduct : UserControl
    {
        public StoreEntities db;

        public UserControlProduct(StoreEntities db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void UserControlUser_Load(object sender, EventArgs e)
        {
            comDisplay.SelectedIndex = 0;
            LoadData();
        }

        public void LoadData()
        {
            dtProduct.Rows.Clear();
            List<Product> products;
            if (txtSearch.Text.Trim().Length > 0)
            {
                products = db.Products
                    .Include(x => x.ProductCategory)
                    .Where(x => x.Name.Contains(txtSearch.Text) ||
                                x.Barcode.Contains(txtSearch.Text) ||
                                x.ProductCategory.Name.Contains(txtSearch.Text) &&
                                txtSearch.Text != null)
                    .OrderByDescending(x => x.ProductId)
                    .Take(comDisplay.SelectedIndex != 3 ? Convert.ToInt32(comDisplay.SelectedItem) : db.Products.Count())
                    .ToList();
            }
            else
            {
                products = db.Products
                    .Include(x => x.ProductCategory)
                    .OrderByDescending(x => x.ProductId)
                    .Take(comDisplay.SelectedIndex != 3 ? Convert.ToInt32(comDisplay.SelectedItem) : db.Products.Count())
                    .ToList();
            }

            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (var product in products)
            {
                rows.Add(new DataGridViewRow());
                rows[rows.Count - 1].CreateCells(dtProduct, product.ProductId, product.ProductCategory.Name, product.Name, product.Barcode, product.Price);
            }
            dtProduct.Rows.AddRange(rows.ToArray());
            dtProduct.ClearSelection();
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            var row = dtProduct.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dtProduct.Rows[row].Cells[0].Value);
            using (FormProduct form = new FormProduct(this, id))
            {
                form.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormProduct form = new FormProduct(this))
            {
                form.ShowDialog();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("ยืนยันการลบข้อมูล", "แจ้งเตือน", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) != DialogResult.OK) return;

            var row = dtProduct.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dtProduct.Rows[row].Cells[0].Value.ToString());
            var product = db.Products.Find(id);
            db.Products.Remove(product);

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

        private void dtProduct_Sorted(object sender, EventArgs e)
        {
            dtProduct.ClearSelection();
        }

        private void dtProduct_SelectionChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = dtProduct.SelectedRows.Count > 0;
            btnDelete.Enabled = dtProduct.SelectedRows.Count > 0;
        }

        private void comDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
