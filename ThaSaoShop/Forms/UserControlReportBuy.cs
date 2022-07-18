using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaSaoShop.Helpers;
using ThaSaoShop.Models;
using ThaSaoShop.Models.View;

namespace ThaSaoShop.Forms
{
    public partial class UserControlReportBuy : UserControl
    {
        public StoreEntities db;
        List<ViewSellOrBuy> viewSells;
        public UserControlReportBuy(StoreEntities db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void UserControlVillage_Load(object sender, EventArgs e)
        {
            viewSells = db.Database.SqlQuery<ViewSellOrBuy>("SELECT Date,Total FROM ViewBuy").OrderBy(x => x.Date).ToList();
            comboType.SelectedIndex = 0;
        }

        private void ShowYear()
        {
            dtSell.Rows.Clear();
            var results = viewSells.GroupBy(sell => new { year = sell.Date.Year })
                .Select(g => new { date = new DateTime(g.Key.year, 1, 1), total = g.Sum(x => x.Total) });
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (var result in results.ToList())
            {
                rows.Add(new DataGridViewRow());
                rows[rows.Count - 1].CreateCells(dtSell, result.date, result.total);
            }
            dtSell.Columns[0].HeaderText = $"ปี";
            dtSell.Columns[0].DefaultCellStyle.Format = $"yyyy";
            dtSell.Rows.AddRange(rows.ToArray());
            dtSell.ClearSelection();
        }

        private void ShowMonth()
        {
            dtSell.Rows.Clear();
            var results = viewSells.GroupBy(sell => new { year = sell.Date.Year, month = sell.Date.Month })
                .Select(g => new { date = new DateTime(g.Key.year, g.Key.month, 1), total = g.Sum(x => x.Total) });
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (var result in results.ToList())
            {
                rows.Add(new DataGridViewRow());
                rows[rows.Count - 1].CreateCells(dtSell, result.date, result.total);
            }
            dtSell.Columns[0].HeaderText = $"เดือน / ปี";
            dtSell.Columns[0].DefaultCellStyle.Format = $"MM/yyyy";
            dtSell.Rows.AddRange(rows.ToArray());
            dtSell.ClearSelection();
        }

        private void ShowDay()
        {
            dtSell.Rows.Clear();
            var results = viewSells.GroupBy(sell => new
            {
                year = sell.Date.Year,
                month = sell.Date.Month,
                day = sell.Date.Day
            })
                .Select(g => new { date = new DateTime(g.Key.year, g.Key.month, g.Key.day), total = g.Sum(x => x.Total) });
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (var result in results.ToList())
            {
                rows.Add(new DataGridViewRow());
                rows[rows.Count - 1].CreateCells(dtSell, result.date, result.total);
            }
            dtSell.Columns[0].HeaderText = $"วัน / เดือน / ปี";
            dtSell.Columns[0].DefaultCellStyle.Format = $"dd/MM/yyyy";
            dtSell.Rows.AddRange(rows.ToArray());
            dtSell.ClearSelection();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            using (FormChartSell form = new FormChartSell(viewSells))
            {
                form.ShowDialog();
            }
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboType.SelectedIndex)
            {
                case 0: ShowYear(); break;
                case 1: ShowMonth(); break;
                case 2: ShowDay(); break;
                default: return;
            }

            var sum = 0;
            for (int i = 0; i < dtSell.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dtSell[1, i].Value);
            }

            lbTotal.Text = sum.ToString("N0");
            lbList.Text = dtSell.RowCount.ToString("N0");
        }
    }
}
