using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ThaSaoShop.Models;

namespace ThaSaoShop.Forms
{
    public partial class UserControlReportBarcode : UserControl
    {
        public StoreEntities db;
        public UserControlReportBarcode(StoreEntities db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void UserControlReportBarcode_Load(object sender, EventArgs e)
        {
            LoadData();
            comboCategory_SelectionChangeCommitted(null, null);
        }

        private void LoadData()
        {
            comboCategory.DataSource = db.ProductCategories.ToList();
            comboCategory.DisplayMember = "Name";
            comboCategory.ValueMember = "ProductCategoryId";
            comboCategory.SelectedIndex = 0;
        }

        private void UserControlReportBarcode_SizeChanged(object sender, EventArgs e)
        {
            dtBarcode.Width = (Width / 2) - 70;
            dtSelect.Width = (Width / 2) + 70;
        }

        private void dtBarcode_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                e.RowIndex >= 0)
            {
                var row = dtBarcode.CurrentCell.RowIndex;
                foreach (DataGridViewRow index in dtSelect.Rows)
                {
                    bool exist = index.Cells[0].Value == dtBarcode[0, row].Value;
                    if (exist)
                        return;
                }
                dtSelect.Rows.Insert(0, dtBarcode[0, row].Value, dtBarcode[1, row].Value, dtBarcode[2, row].Value, dtBarcode[3, row].Value, dtBarcode[4, row].Value);
            }
            dtSelect.ClearSelection();
            btnExport.Enabled = dtSelect.RowCount > 0;
            btnPrint.Enabled = true;
        }

        private void dtSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                e.RowIndex >= 0)
            {
                var row = dtSelect.CurrentCell.RowIndex;
                dtSelect.Rows.RemoveAt(row);
                dtSelect.ClearSelection();
            }
            btnExport.Enabled = dtSelect.RowCount > 0;
        }

        private void comboCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtBarcode.Rows.Clear();
            int id = Convert.ToInt32(comboCategory.SelectedValue.ToString());
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            var data = db.Products.Include(x => x.ProductCategory)
                .AsNoTracking()
                .Where(x => x.ProductCategoryId.Equals(id) && !string.IsNullOrEmpty(x.Barcode));
            foreach (var product in data)
            {
                rows.Add(new DataGridViewRow());
                rows[rows.Count - 1].CreateCells(dtBarcode, product.ProductId, product.ProductCategory.Name, product.Name, product.Price, product.Barcode);
            }
            dtBarcode.Rows.AddRange(rows.ToArray());
            dtBarcode.ClearSelection();
            btnPrint.Enabled = false;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "บาร์โค้ดสินค้า";
            savefile.Filter = "Excel Files|*.xlsx;";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                string tempPath = Path.GetTempFileName();
                File.WriteAllBytes(tempPath, Properties.Resources.BarcodeTemplate);
                var template = new FileInfo(tempPath);
                using (var package = new ExcelPackage(template))
                {
                    var workbook = package.Workbook;
                    var worksheet = workbook.Worksheets["Barcode"];
                    worksheet.Select();
                    int start = 0;
                    int loop = dtSelect.Rows.Count / 2 + dtSelect.Rows.Count % 2;
                    for (int i = 1; i <= loop; i++)
                    {
                        var row = dtSelect.Rows[start];
                        worksheet.Cells[i, 1].Value = row.Cells[2].Value;
                        worksheet.Cells[i, 2].Value = row.Cells[3].Value;
                        worksheet.Cells[i, 3].Value = "*" + row.Cells[4].Value + "*";
                        start++;
                        if (start <= dtSelect.Rows.Count - 1)
                        {
                            row = dtSelect.Rows[start];
                            worksheet.Cells[i, 4].Value = row.Cells[2].Value;
                            worksheet.Cells[i, 5].Value = row.Cells[3].Value;
                            worksheet.Cells[i, 6].Value = "*" + row.Cells[4].Value + "*";
                            start++;
                        }
                    }
                    package.SaveAs(new FileInfo(savefile.FileName));
                    Process.Start(savefile.FileName);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtSelect.Rows.Clear();
            btnExport.Enabled = dtSelect.RowCount > 0;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "บาร์โค้ดแปะสินค้า";
            savefile.Filter = "Excel Files|*.xlsx;";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                string tempPath = Path.GetTempFileName();
                File.WriteAllBytes(tempPath, Properties.Resources.BarcodePrintTemplate);
                var template = new FileInfo(tempPath);
                using (var package = new ExcelPackage(template))
                {
                    var workbook = package.Workbook;
                    var worksheet = workbook.Worksheets["Barcode"];
                    worksheet.Select();
                    int loop = Convert.ToInt32(numCount.Value) / 4 + (Convert.ToInt32(numCount.Value) % 4 != 0 ? 1 : 0);
                    var row = dtBarcode.CurrentCell.RowIndex;
                    int count = 1;
                    for (int i = 1; i <= loop; i++)
                    {
                        for (int j = 1; j <= 4; j++)
                        {
                            if (count <= numCount.Value)
                            {
                                worksheet.Cells[i, j].Value = "*" + dtBarcode[4, row].Value + "*";
                                count++;
                            }
                        }
                    }
                    package.SaveAs(new FileInfo(savefile.FileName));
                    Process.Start(savefile.FileName);
                }
            }
        }

    }
}
