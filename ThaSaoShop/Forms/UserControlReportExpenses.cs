using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ThaSaoShop.Models;
using ThaSaoShop.Models.StoredProcedure;

namespace ThaSaoShop.Forms
{
    public partial class UserControlReportExpenses : MetroUserControl
    {
        public StoreEntities db;

        public UserControlReportExpenses(StoreEntities db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void UserControlVillage_Load(object sender, EventArgs e)
        {
            dpTo.Value = dpTo.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dpFrom.MaxDate = dpTo.Value;
            dpTo.MinDate = dpFrom.Value;
            comboType.SelectedIndex = 0;
            Calculate();
        }

        private void ShowYear()
        {
            dtExpenses.Rows.Clear();
            object[] sqlParams =
            {
                new SqlParameter("@startdate", dpFrom.Value.Date),
                new SqlParameter("@enddate", dpTo.Value.Date),
            };
            var expenses = db.Database
                .SqlQuery<SPExpenses>("dbo.SPExpenses @startdate, @enddate", sqlParams).ToList();
            var results = expenses.GroupBy(x => new { year = x.Date.Year })
                .Select(g => new { date = new DateTime(g.Key.year, 1, 1), total = g.Sum(x => x.Total) });
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (var result in results.ToList())
            {
                rows.Add(new DataGridViewRow());
                rows[rows.Count - 1].CreateCells(dtExpenses, result.date, result.total);
            }

            dtExpenses.Columns[0].HeaderText = $"ปี";
            dtExpenses.Columns[0].DefaultCellStyle.Format = $"yyyy";
            dtExpenses.Rows.AddRange(rows.ToArray());
            dtExpenses.ClearSelection();
        }

        private void ShowMonth()
        {
            dtExpenses.Rows.Clear();
            object[] sqlParams =
            {
                new SqlParameter("@startdate", dpFrom.Value.Date),
                new SqlParameter("@enddate", dpTo.Value.Date),
            };
            var expenses = db.Database
                .SqlQuery<SPExpenses>("dbo.SPExpenses @startdate, @enddate", sqlParams).ToList();
            var results = expenses.GroupBy(x => new { year = x.Date.Year, month = x.Date.Month })
                .Select(g => new { date = new DateTime(g.Key.year, g.Key.month, 1), total = g.Sum(x => x.Total) });
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (var result in results.ToList())
            {
                rows.Add(new DataGridViewRow());
                rows[rows.Count - 1].CreateCells(dtExpenses, result.date, result.total);
            }

            dtExpenses.Columns[0].HeaderText = $"เดือน / ปี";
            dtExpenses.Columns[0].DefaultCellStyle.Format = $"MM/yyyy";
            dtExpenses.Rows.AddRange(rows.ToArray());
            dtExpenses.ClearSelection();
        }

        private void ShowDay()
        {
            dtExpenses.Rows.Clear();
            object[] sqlParams =
            {
                new SqlParameter("@startdate", dpFrom.Value.Date),
                new SqlParameter("@enddate", dpTo.Value.Date),
            };
            var expenses = db.Database
                .SqlQuery<SPExpenses>("dbo.SPExpenses @startdate, @enddate", sqlParams).ToList();
            var results = expenses.GroupBy(x => new { year = x.Date.Year, month = x.Date.Month, x.Date.Day })
                .Select(g => new { date = new DateTime(g.Key.year, g.Key.month, g.Key.Day), total = g.Sum(x => x.Total) });
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (var result in results.ToList())
            {
                rows.Add(new DataGridViewRow());
                rows[rows.Count - 1].CreateCells(dtExpenses, result.date, result.total);
            }

            dtExpenses.Columns[0].HeaderText = $"วัน / เดือน / ปี";
            dtExpenses.Columns[0].DefaultCellStyle.Format = $"dd/MM/yyyy";
            dtExpenses.Rows.AddRange(rows.ToArray());
            dtExpenses.ClearSelection();
        }

        private void dpTo_ValueChanged(object sender, EventArgs e)
        {
            dpFrom.MaxDate = dpTo.Value;
            Calculate();
        }

        private void dpFrom_ValueChanged(object sender, EventArgs e)
        {
            dpTo.MinDate = dpFrom.Value;
            Calculate();
        }

        private void Calculate()
        {
            switch (comboType.SelectedIndex)
            {
                case 0:
                    ShowYear();
                    break;
                case 1:
                    ShowMonth();
                    break;
                case 2:
                    ShowDay();
                    break;
                default: return;
            }
        }

        private void dtExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                e.RowIndex >= 0)
            {
                DateTime dateTo;
                DateTime dateFrom;
                var row = dtExpenses.CurrentCell.RowIndex;
                var date = DateTime.Parse(dtExpenses[0, row].Value.ToString());
                switch (comboType.Text)
                {
                    case "รายปี":
                        dateFrom = new DateTime(date.Year, dpFrom.Value.Month, dpFrom.Value.Day);
                        dateTo = dtExpenses.RowCount == row + 1
                            ? dpTo.Value
                            : new DateTime(date.Year, 12, 31);
                        break;
                    case "รายเดือน":
                        dateFrom = new DateTime(date.Year, date.Month, dpFrom.Value.Day);
                        dateTo = dtExpenses.RowCount == row + 1
                            ? dpTo.Value
                            : new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
                        break;
                    default:
                        dateFrom = dateTo = new DateTime(date.Year, date.Month, date.Day);
                        break;
                }

                using (FormChartExpenses form = new FormChartExpenses(dateFrom, dateTo))
                {
                    form.ShowDialog();
                }
            }
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}