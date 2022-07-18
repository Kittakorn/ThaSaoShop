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
    public partial class UserControlExpenseCategory : UserControl
    {
        public StoreEntities db;
        public UserControlExpenseCategory(StoreEntities db)
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
            dtExpenseCategory.Rows.Clear();
            foreach (var expense in db.ExpenseCategories)
            {
                dtExpenseCategory.Rows.Add(expense.ExpenseCategoryId, expense.Name, expense.Expenses.Sum(x => x.Price));
            }
            dtExpenseCategory.ClearSelection();
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            var row = dtExpenseCategory.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dtExpenseCategory.Rows[row].Cells[0].Value);
            using (FormExpensesCategory form = new FormExpensesCategory(this, id))
            {
                form.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (FormExpensesCategory form = new FormExpensesCategory(this))
            {
                form.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ยืนยันการลบข้อมูล", "แจ้งเตือน", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) != DialogResult.OK) return;

            var row = dtExpenseCategory.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dtExpenseCategory.Rows[row].Cells[0].Value.ToString());
            var expense = db.ExpenseCategories.Find(id);
            db.ExpenseCategories.Remove(expense);

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
            btnEdit.Enabled = dtExpenseCategory.SelectedRows.Count > 0;
            btnDelete.Enabled = dtExpenseCategory.SelectedRows.Count > 0;
        }
    }
}
