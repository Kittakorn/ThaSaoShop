using MetroFramework.Controls;
using OfficeOpenXml;
using OfficeOpenXml.ConditionalFormatting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaSaoShop.Helpers;
using ThaSaoShop.Models;
using ThaSaoShop.Models.View;

namespace ThaSaoShop.Forms
{
    public partial class UserControlReportSellDay : UserControl
    {
        public StoreEntities db;
        private List<ViewOrder> sell;

        public UserControlReportSellDay(StoreEntities db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void UserControlVillage_Load(object sender, EventArgs e)
        {
            dpFrom.Value = DateTime.Now;
            LoadData();
        }

        private void LoadData()
        {
            dtSell.Rows.Clear();
            sell = db.Database
               .SqlQuery<ViewOrder>("dbo.SPSellDay @date", new SqlParameter("@date", dpFrom.Value.Date))
               .ToList();
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (var result in sell.ToList())
            {
                rows.Add(new DataGridViewRow());
                rows[rows.Count - 1].CreateCells(dtSell, result.Date, result.MemberId, string.IsNullOrEmpty(result.Firstname) ? "บุคคลทั่วไป" : result.Firstname + "" + result.Lastname, result.Count, result.Sum);
            }

            dtSell.Rows.AddRange(rows.ToArray());
            dtSell.ClearSelection();
            lbList.Text = sell.Count.ToString("N0");
            lbTotal.Text = sell.Sum(x => x.Sum)?.ToString("N0");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "ยอดขายประจำวัน" + DateTime.Now.ToString("ddMMyyyy");
            savefile.Filter = "Excel Files|*.xlsx;";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                string tempPath = Path.GetTempFileName();
                File.WriteAllBytes(tempPath, Properties.Resources.SellDayTemplate);
                var template = new FileInfo(tempPath);
                using (var package = new ExcelPackage(template))
                {
                    var workbook = package.Workbook;
                    var worksheet = workbook.Worksheets[1];
                    worksheet.Select();
                    int start = 3;
                    int index = 1;
                    worksheet.Cells[1, 1].Value = "รายการขายสินค้าประจำวันที่ " + dpFrom.Value.ToString("dd/MM/yyyy");
                    foreach (var item in sell)
                    {
                        worksheet.Cells[start, 1].Value = index;
                        worksheet.Cells[start, 2].Value = item.Date;
                        worksheet.Cells[start, 3].Value = item.MemberId;
                        worksheet.Cells[start, 4].Value = string.IsNullOrEmpty(item.Firstname)
                            ? "บุคคลทั่วไป"
                            : item.Firstname + " " + item.Lastname;
                        worksheet.Cells[start, 5].Value = item.Count;
                        worksheet.Cells[start, 6].Value = item.Sum;
                        start++;
                        index++;
                    }
                    package.SaveAs(new FileInfo(savefile.FileName));
                    Process.Start(savefile.FileName);
                }
            }
        }
    }
}
