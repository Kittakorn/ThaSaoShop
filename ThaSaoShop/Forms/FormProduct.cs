using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaSaoShop.Models;

namespace ThaSaoShop.Forms
{
    public partial class FormProduct : MetroForm
    {
        StoreEntities db;
        UserControlProduct userControl;
        Product product = new Product();
        public FormProduct(UserControlProduct uc, int id = 0)
        {
            InitializeComponent();
            db = uc.db;
            userControl = uc;
            LoadData();
            if (id != 0)
            {
                product = db.Products.Find(id);
                txtId.Text = product.ProductId.ToString();
                txtName.Text = product.Name;
                txtBarcode.Text = product.Barcode;
                numPrice.Value = Convert.ToDecimal(product.Price);
                txtId.Enabled = false;
                Text = "แก้ไขข้อมูล";
                comCategory.SelectedValue = product.ProductCategoryId;
            }
        }

        private void LoadData()
        {
            comCategory.DataSource = db.ProductCategories.ToList();
            comCategory.DisplayMember = "Name";
            comCategory.ValueMember = "ProductCategoryId";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.WithError = true;
                return;
            }

            if (!Regex.IsMatch(txtBarcode.Text, @"(^[0-9]{13}$)") && !string.IsNullOrWhiteSpace(txtBarcode.Text))
            {
                txtBarcode.WithError = true;
                return;
            }

            product.Name = txtName.Text.Trim();
            product.ProductCategoryId = Convert.ToInt32(comCategory.SelectedValue);
            product.Price = Convert.ToInt32(numPrice.Value);
            product.Barcode = txtBarcode.Text.Trim();
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                db.Products.Add(product);
            }
            else
            {
                db.Entry(product).State = EntityState.Modified;
            }

            try
            {
                db.SaveChanges();
                MessageBox.Show("ทำรายการสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userControl.LoadData();
                Close();
            }
            catch
            {
                MessageBox.Show("เกิดข้อผิดพลาด", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numPrice_Enter(object sender, EventArgs e)
        {
            numPrice.Select(0, numPrice.Text.Length);
        }
    }
}
