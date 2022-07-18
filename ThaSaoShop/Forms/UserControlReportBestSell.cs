using MetroFramework.Controls;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ThaSaoShop.Models;
using ThaSaoShop.Models.StoredProcedure;

namespace ThaSaoShop.Forms
{
    public partial class UserControlReportBestSell : MetroUserControl
    {
        public StoreEntities db;
        public UserControlReportBestSell(StoreEntities db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void UserControlVillage_Load(object sender, EventArgs e)
        {
            dpTo.Value = dpTo.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dpFrom.MaxDate = dpTo.Value;
            dpTo.MinDate = dpFrom.Value;
            LoadCategory();
            LoadData();
        }

        private void LoadCategory()
        {
            comboCat.DisplayMember = "Text";
            comboCat.ValueMember = "Value";
            comboCat.Items.Add(new { Value = 0, Text = "ทั้งหมด" });
            foreach (var productCategory in db.ProductCategories.Select(x => new { x.Name, x.ProductCategoryId }).ToList())
            {
                comboCat.Items.Add(new { Value = productCategory.ProductCategoryId, Text = productCategory.Name });
            }
            comboCat.SelectedIndex = 0;
            comboCount.SelectedIndex = 0;
        }

        private void LoadData()
        {
            dtSell.Rows.Clear();
            int category = Convert.ToInt32(comboCat.SelectedIndex);

            object[] sqlParams =
            {
                new SqlParameter("@startdate", dpFrom.Value.Date),
                new SqlParameter("@enddate", dpTo.Value.Date),
                new SqlParameter("@type", category),
                new SqlParameter("@count", (comboCount.SelectedIndex + 1) * 10)
            };
            var bestSells = db.Database
                .SqlQuery<SPBestSell>("dbo.SPBestSell @startdate, @enddate, @type, @count", sqlParams).ToList();
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (var result in bestSells.Take((comboCount.SelectedIndex + 1) * 10))
            {
                rows.Add(new DataGridViewRow());
                rows[rows.Count - 1].CreateCells(dtSell, result.ProductName, result.CategoryName, result.Amount);
            }
            dtSell.Rows.AddRange(rows.ToArray());
            dtSell.ClearSelection();
        }


        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dpTo_ValueChanged(object sender, EventArgs e)
        {
            dpFrom.MaxDate = dpTo.Value;
            LoadData();
        }

        private void dpFrom_ValueChanged(object sender, EventArgs e)
        {
            dpTo.MinDate = dpFrom.Value;
            LoadData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "สินค้าขายดี";
            savefile.Filter = "Excel Files|*.xlsx;";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                string tempPath = Path.GetTempFileName();
                File.WriteAllBytes(tempPath, Properties.Resources.BestSellTemplate);
                var template = new FileInfo(tempPath);
                using (var package = new ExcelPackage(template))
                {
                    var workbook = package.Workbook;
                    var worksheet = workbook.Worksheets["สินค้าขายดี"];
                    worksheet.Select();
                    worksheet.HeaderFooter.FirstHeader.CenteredText = "&14&\"Calibri,Bold\" สินค้าขายดี";
                    worksheet.HeaderFooter.FirstHeader.RightAlignedText =
                        $"วันที่ {dpFrom.Value.ToShortDateString()} - {dpTo.Value.ToShortDateString()}";
                    for (int i = 1; i <= dtSell.RowCount; i++)
                    {
                        var row = dtSell.Rows[i - 1];
                        worksheet.Cells[i + 1, 1].Value = i;
                        worksheet.Cells[i + 1, 2].Value = row.Cells[1].Value;
                        worksheet.Cells[i + 1, 3].Value = row.Cells[0].Value;
                        worksheet.Cells[i + 1, 4].Value = row.Cells[2].Value;
                    }
                    package.SaveAs(new FileInfo(savefile.FileName));
                    Process.Start(savefile.FileName);
                }
            }
        }

        private void comboCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
