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
    public partial class FormExpenses : MetroForm
    {
        StoreEntities db;
        Expense expense = new Expense();
        private UserControlExpense form;

        public FormExpenses(UserControlExpense uc, int id = 0)
        {
            InitializeComponent();
            db = uc.db;
            form = uc;
            LoadData();
            if (id != 0)
            {
                Text = "แก้ไขข้อมูล";
                expense = db.Expenses.Find(id);
                txtId.Text = expense.ExpenseId.ToString();
                numPrice.Value = Convert.ToDecimal(expense.Price);
                txtDetail.Text = expense.Detail;
                comCatExpenses.SelectedValue = expense.ExpenseCategoryId;
            }
        }

        private void LoadData()
        {
            comCatExpenses.DataSource = db.ExpenseCategories.ToList();
            comCatExpenses.DisplayMember = "Name";
            comCatExpenses.ValueMember = "ExpenseCategoryId";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            expense.ExpenseCategoryId = Convert.ToInt32(comCatExpenses.SelectedValue);
            expense.Price = Convert.ToInt32(numPrice.Value);
            expense.Username = Profile.Username;
            expense.Date = DateTime.Now;
            expense.Detail = txtDetail.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                db.Expenses.Add(expense);
            }
            else
            {
                db.Entry(expense).State = EntityState.Modified;
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

        private void numPrice_Enter(object sender, EventArgs e)
        {
            numPrice.Select(0, numPrice.Text.Length);
        }
    }
}
