using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaSaoShop.Helpers;
using ThaSaoShop.Models;

namespace ThaSaoShop.Forms
{
    public partial class UserControlProductCategory : UserControl
    {
        public StoreEntities db;
        public UserControlProductCategory(StoreEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void UserControlExpenseCategory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dtProductCategory.Rows.Clear();
            foreach (var product in db.ProductCategories)
            {
                dtProductCategory.Rows.Add(product.ProductCategoryId, product.Name, product.Products.Count);
            }
            dtProductCategory.ClearSelection();
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            var row = dtProductCategory.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dtProductCategory.Rows[row].Cells[0].Value);
            using (FormProductCategory form = new FormProductCategory(this, id))
            {
                form.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (FormProductCategory form = new FormProductCategory(this))
            {
                form.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ยืนยันการลบข้อมูล", "แจ้งเตือน", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) != DialogResult.OK) return;

            var row = dtProductCategory.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dtProductCategory.Rows[row].Cells[0].Value.ToString());
            var category = db.ProductCategories.Find(id);
            db.ProductCategories.Remove(category);

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
        private void dtExpense_SelectionChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = dtProductCategory.SelectedRows.Count > 0;
            btnDelete.Enabled = dtProductCategory.SelectedRows.Count > 0;
        }
    }
}
