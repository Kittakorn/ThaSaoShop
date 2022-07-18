using MetroFramework.Forms;
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
    public partial class FormProductCategory : MetroForm
    {
        StoreEntities db;
        ProductCategory category = new ProductCategory();
        private UserControlProductCategory form;

        public FormProductCategory(UserControlProductCategory uc, int id = 0)
        {
            InitializeComponent();
            db = uc.db;
            form = uc;
            if (id != 0)
            {
                Text = "แก้ไขข้อมูล";
                category = db.ProductCategories.Find(id);
                txtId.Text = category.ProductCategoryId.ToString();
                txtName.Text = category.Name;
            }
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
            category.Name = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                db.ProductCategories.Add(category);
            }
            else
            {
                db.Entry(category).State = EntityState.Modified;
            }

            try
            {
                db.SaveChanges();
                MessageBox.Show("ทำรายการสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form.LoadData();
                Close();
            }
            catch
            {
                MessageBox.Show("เกิดข้อผิดพลาด", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
