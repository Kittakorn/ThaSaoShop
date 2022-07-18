using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaSaoShop.Helpers;
using ThaSaoShop.Models;

namespace ThaSaoShop.Forms
{
    public partial class UserControlExpense : UserControl
    {
        public StoreEntities db;
        public UserControlExpense(StoreEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void UserControlExpense_Load(object sender, EventArgs e)
        {
            dpTo.Value = dpTo.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dpFrom.MaxDate = dpTo.Value;
            dpTo.MinDate = dpFrom.Value;
            comDisplay.SelectedIndex = 0;
            LoadData();
        }

        public void LoadData()
        {
            dtExpense.Rows.Clear();
            List<Expense> expenses;
            if (txtSearch.Text.Trim().Length > 0)
            {
                expenses = db.Expenses
                    .Include(x => x.User)
                    .Include(x => x.ExpenseCategory)
                    .AsEnumerable()
                    .Where(x => x.ExpenseCategory.Name.Contains(txtSearch.Text) ||
                                !string.IsNullOrEmpty(x.Detail) &&
                                x.Detail.Contains(txtSearch.Text) ||
                                x.Date.ToString("dd/MM/yyyy").Contains(txtSearch.Text) &&
                                txtSearch.Text != null)
                    .OrderByDescending(x => x.Date)
                    .Take(Convert.ToInt32(comDisplay.SelectedItem))
                    .ToList();
            }
            else
            {
                expenses = db.Expenses
                    .Include(x => x.User)
                    .Include(x => x.ExpenseCategory)
                    .OrderByDescending(x => x.Date)
                    .Take(Convert.ToInt32(comDisplay.SelectedItem))
                    .ToList();
            }
            expenses = expenses.Where(x => x.Date >= dpFrom.Value.Date && x.Date <= dpTo.Value.Date.AddMinutes(1439)).ToList();

            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (var expense in expenses)
            {
                rows.Add(new DataGridViewRow());
                rows[rows.Count - 1].CreateCells(dtExpense, expense.ExpenseId, expense.Date, expense.ExpenseCategory.Name, expense.Detail, expense.Price, expense.User.Firstname + " " + expense.User.Lastname);
            }
            dtExpense.Rows.AddRange(rows.ToArray());
            dtExpense.ClearSelection();
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            dpFrom.Value = new DateTime(2018, 1, 1);
            dpTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            txtSearch.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            var row = dtExpense.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dtExpense.Rows[row].Cells[0].Value);
            using (FormExpenses form = new FormExpenses(this, id))
            {
                form.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (FormExpenses form = new FormExpenses(this))
            {
                form.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ยืนยันการลบข้อมูล", "แจ้งเตือน", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) != DialogResult.OK) return;

            var row = dtExpense.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dtExpense.Rows[row].Cells[0].Value.ToString());
            var expense = db.Expenses.Find(id);
            db.Expenses.Remove(expense);

            try
            {
                db.SaveChanges();
                LoadData();
            }
            catch
            {
                db.ResetContextState();
                MessageBox.Show("เกิดข้อผิดพลาด", "แจ้งเตือน", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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

        private void dtExpense_SelectionChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = dtExpense.SelectedRows.Count > 0;
            btnDelete.Enabled = dtExpense.SelectedRows.Count > 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
