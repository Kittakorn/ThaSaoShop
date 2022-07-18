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
    public partial class FormBuy : MetroForm
    {
        StoreEntities db;
        Buy buy = new Buy();
        private int selectIndex;
        private UserControlBuy form;

        public FormBuy(UserControlBuy uc, int id = 0)
        {
            InitializeComponent();
            db = uc.db;
            form = uc;
            LoadData();
            if (id != 0)
            {
                buy = db.Buys.Find(id);
                txtId.Text = buy.BuyId.ToString();
                numPrice.Value = Convert.ToDecimal(buy.Price);
                Text = "แก้ไขข้อมูล";
                comProduct.SelectedValue = buy.ProductId;
            }
        }

        private void LoadData()
        {
            comProduct.DataSource = db.Products.ToList();
            comProduct.DisplayMember = "Name";
            comProduct.ValueMember = "ProductId";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            buy.ProductId = Convert.ToInt32(comProduct.SelectedValue);
            buy.Price = Convert.ToInt32(numPrice.Value);
            buy.Username = Profile.Username;
            buy.Date = DateTime.Now;

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                db.Buys.Add(buy);
            }
            else
            {
                db.Entry(buy).State = EntityState.Modified;
            }

            try
            {
                db.SaveChanges();
                MessageBox.Show("ทำรายการสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form.LoadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numPrice_Enter(object sender, EventArgs e)
        {
            numPrice.Select(0, numPrice.Text.Length);
        }

        private void comProduct_Leave(object sender, EventArgs e)
        {
            comProduct.SelectedIndex = selectIndex;
        }

        private void comProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectIndex = comProduct.SelectedIndex;
        }
    }
}
