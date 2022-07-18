using MetroFramework.Controls;
using OfficeOpenXml;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ThaSaoShop.Models;
using ThaSaoShop.Models.StoredProcedure;

namespace ThaSaoShop.Forms
{
    public partial class UserControlReportResult : MetroUserControl
    {
        public StoreEntities db;

        public UserControlReportResult(StoreEntities db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void UserControlVillage_Load(object sender, EventArgs e)
        {
            for (int i = DateTime.Now.AddYears(-10).Year; i <= DateTime.Now.AddYears(1).Year; i++)
            {
                comYear.Items.Add(new DateTime(i, 1, 1).ToString("yyyy"));
            }
            comYear.SelectedIndex = 0;
        }

        private void Print(DateTime date)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "สรุปช้อมูประจำปี" + date.ToString("yyyy");
            savefile.Filter = "Excel Files|*.xlsx;";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                string tempPath = Path.GetTempFileName();
                File.WriteAllBytes(tempPath, Properties.Resources.ResultTemplate);
                var template = new FileInfo(tempPath);
                using (var package = new ExcelPackage(template))
                {
                    var buys = db.Database
                        .SqlQuery<SPResultMonth>("dbo.SPResultBuy @year", new SqlParameter("@year", date.Year))
                        .ToList();
                    var sell = db.Database
                        .SqlQuery<SPResultMonth>("dbo.SPResultSeles @year", new SqlParameter("@year", date.Year))
                        .ToList();
                    var expenses = db.Database
                        .SqlQuery<SPResultMonth>("dbo.SPResultExpenses @year", new SqlParameter("@year", date.Year))
                        .ToList();
                    var memberBuyNull = db.Database
                        .SqlQuery<SPResultMemberBuy>("dbo.SPResultMemberBuyNull @year",
                            new SqlParameter("@year", date.Year)).ToList();
                    var memberBuy = db.Database
                        .SqlQuery<SPResultMemberBuy>("dbo.SPResultMemberBuy @year",
                            new SqlParameter("@year", date.Year)).ToList();
                    var share = db.Database
                        .SqlQuery<SPResultShare>("dbo.SPResultShare @year",
                            new SqlParameter("@year", date.Year)).ToList();

                    var workbook = package.Workbook;
                    var worksheet1 = workbook.Worksheets["รายงานผล"];
                    var worksheet2 = workbook.Worksheets["สรุปรายได้"];
                    var worksheet3 = workbook.Worksheets["สรุปปันผลและจดหมายเวียน"];
                    var worksheet4 = workbook.Worksheets["สรุปหุ้น"];
                    var worksheet5 = workbook.Worksheets["สรุปการเพิ่มหุ้น"];

                    worksheet1.Cells["A1"].Value =
                        "ปันผลศูนย์สาธิตการเกษตรร้านค้าชุมชนตำบลท่าเสา ประจำปี " + date.ToString("yyyy");
                    for (int i = 0; i < memberBuy.Count; i++)
                    {
                        int index = i + 3;
                        worksheet1.Cells[$"A{index}"].Formula =
                            $"=IF(ISBLANK(สรุปปันผลและจดหมายเวียน!A{index - 1}),\"\",สรุปปันผลและจดหมายเวียน!A{index - 1})";
                        worksheet1.Cells[$"B{index}"].Formula = $"=IF(ISBLANK(A{index}),\"\",สรุปปันผลและจดหมายเวียน!C{index - 1})";
                        worksheet1.Cells[$"C{index}"].Formula = $"=IF(ISBLANK(A{index}),\"\",สรุปปันผลและจดหมายเวียน!D{index - 1})";
                        worksheet1.Cells[$"D{index}"].Formula = $"=IF(ISBLANK(A{index}),\"\",สรุปปันผลและจดหมายเวียน!E{index - 1})";
                        worksheet1.Cells[$"E{index}"].Formula = $"=IF(ISBLANK(A{index}),\"\",สรุปปันผลและจดหมายเวียน!F{index - 1})";
                        worksheet1.Cells[$"F{index}"].Formula = $"=IF(ISBLANK(A{index}),\"\",สรุปปันผลและจดหมายเวียน!G{index - 1})";
                        worksheet1.Cells[$"G{index}"].Formula = $"=IF(ISBLANK(A{index}),\"\",สรุปปันผลและจดหมายเวียน!I{index - 1})";
                        worksheet1.Cells[$"H{index}"].Formula = $"=IF(ISBLANK(A{index}),\"\",สรุปปันผลและจดหมายเวียน!J{index - 1})";
                        worksheet1.Cells[$"I{index}"].Formula = $"=IF(ISBLANK(A{index}),\"\",สรุปปันผลและจดหมายเวียน!K{index - 1})";
                        worksheet1.Cells[$"J{index}"].Formula = $"=SUM(G{index}:I{index})";
                    }

                    worksheet1.Cells[$"A{memberBuy.Count + 3}:C{memberBuy.Count + 3}"].Merge = true;
                    worksheet1.Cells[$"A{memberBuy.Count + 3}"].Value = "รวม";
                    worksheet1.Cells[$"D{memberBuy.Count + 3}"].Formula = $"=SUM(D3:D{memberBuy.Count + 2})";
                    worksheet1.Cells[$"F{memberBuy.Count + 3}"].Formula = $"=SUM(F3:F{memberBuy.Count + 2})";
                    worksheet1.Cells[$"G{memberBuy.Count + 3}"].Formula = $"=SUM(G3:G{memberBuy.Count + 2})";
                    worksheet1.Cells[$"H{memberBuy.Count + 3}"].Formula = $"=SUM(H3:H{memberBuy.Count + 2})";
                    worksheet1.Cells[$"I{memberBuy.Count + 3}"].Formula = $"=SUM(I3:I{memberBuy.Count + 2})";
                    worksheet1.Cells[$"J{memberBuy.Count + 3}"].Formula = $"=SUM(J3:J{memberBuy.Count + 2})";

                    for (int i = 1; i <= sell.Count; i++)
                        worksheet2.Cells[$"A{i + 3}"].Value = sell[i - 1].Total;
                    for (int i = 1; i <= buys.Count; i++)
                        worksheet2.Cells[$"C{i + 3}"].Value = buys[i - 1].Total;

                    worksheet2.Cells["G5"].Formula =
                        $"={worksheet2.Cells[3, 7]}-สรุปปันผลและจดหมายเวียน!{worksheet3.Cells[memberBuy.Count + 1 + 2, 9]}";
                    worksheet2.Cells["F15"].Formula = $"=สรุปปันผลและจดหมายเวียน!{worksheet3.Cells[memberBuy.Count + 3, 8]}";
                    worksheet2.Cells["G15"].Formula = $"=สรุปปันผลและจดหมายเวียน!{worksheet3.Cells[memberBuy.Count + 3, 9]}";
                    worksheet2.Cells["F22"].Formula =
                        $"=COUNTIFS(สรุปปันผลและจดหมายเวียน!B2:B{memberBuy.Count + 1},\"บุคคล\",สรุปปันผลและจดหมายเวียน!M2:M{memberBuy.Count + 1},\"เป็น\",สรุปปันผลและจดหมายเวียน!N2:N{memberBuy.Count + 1},\"หมู่ 7 บ้านพุมุด\")";
                    worksheet2.Cells["F23"].Formula =
                        $"=COUNTIFS(สรุปปันผลและจดหมายเวียน!B2:B{memberBuy.Count + 1},\"บุคคล\",สรุปปันผลและจดหมายเวียน!M2:M{memberBuy.Count + 1},\"เป็น\",สรุปปันผลและจดหมายเวียน!N2:N{memberBuy.Count + 1},\"หมู่ 8 บ้านพุเตย\")";
                    worksheet2.Cells["G22"].Value =
                        db.Members.FirstOrDefault(x => x.Firstname.Equals($"รวมหุ้น อบต. หมู่ 7"))?.Share;
                    worksheet2.Cells["G23"].Value =
                        db.Members.FirstOrDefault(x => x.Firstname.Equals($"รวมหุ้น อบต. หมู่ 8"))?.Share;
                    worksheet2.Cells["A3"].Value = Convert.ToInt32(numAfter.Value);
                    worksheet2.Cells["C3"].Value = Convert.ToInt32(numBefore.Value);
                    worksheet2.Cells["C16"].Value = expenses.Sum(x => x.Total);

                    for (int i = 0; i < memberBuy.Count; i++)
                    {
                        int index = i + 2;
                        worksheet3.Cells[$"A{index}"].Value = memberBuy[i].MemberId?.ToString("000");
                        worksheet3.Cells[$"B{index}"].Value = memberBuy[i].IsGroup ? "กลุ่ม" : "บุคคล";
                        worksheet3.Cells[$"C{index}"].Value = memberBuy[i].Firstname.Trim();
                        worksheet3.Cells[$"D{index}"].Value = memberBuy[i].Lastname;
                        worksheet3.Cells[$"E{index}"].Value = memberBuy[i].Share;
                        worksheet3.Cells[$"F{index}"].Formula =
                            $"= IF(NOT(ISBLANK({worksheet3.Cells[$"A{index}"]})), สรุปรายได้!F13, \"\")";
                        worksheet3.Cells[$"G{index}"].Value = memberBuy[i].Total;
                        var group =
                            $"=IF(OR({worksheet3.Cells[$"C{index}"]}=\"รวมหุ้น อบต. หมู่ 7\",{worksheet3.Cells[$"C{index}"]}=\"รวมหุ้น อบต. หมู่ 8\"),\"\",";
                        worksheet3.Cells[$"H{index}"].Formula = $"{group}{worksheet3.Cells[$"G{index}"]}*1%)";
                        worksheet3.Cells[$"I{index}"].Formula =
                            $"{group}IF({worksheet3.Cells[$"H{index}"]}<INT({worksheet3.Cells[$"H{index}"]})+0.75,INT({worksheet3.Cells[$"H{index}"]}),INT({worksheet3.Cells[$"H{index}"]})+ 1))";
                        worksheet3.Cells[$"J{index}"].Formula =
                            $"{group}{worksheet3.Cells[$"E{index}"]}*{worksheet3.Cells[$"F{index}"]})";
                        worksheet3.Cells[$"K{index}"].Formula =
                            $"=IF(AND(M{index}=\"เป็น\",N{index}=\"หมู่ 7 บ้านพุมุด\"),สรุปรายได้!I22,IF(AND(M{index}=\"เป็น\",N{index}=\"หมู่ 8 บ้านพุเตย\"),สรุปรายได้!I23,\"\"))";
                        worksheet3.Cells[$"L{index}"].Formula =
                            $"{group}SUM({worksheet3.Cells[$"I{index}"]}:{worksheet3.Cells[$"K{index}"]}))";
                        worksheet3.Cells[$"M{index}"].Value = memberBuy[i].IsMember ? "เป็น" : "ไม่เป็น";
                        worksheet3.Cells[$"N{index}"].Value = memberBuy[i].VillageName;
                    }

                    worksheet3.Cells[$"C{memberBuy.Count + 2}"].Value = "อื่นๆ";
                    worksheet3.Cells[$"G{memberBuy.Count + 2}"].Value = !memberBuyNull.Any() ? 0 : memberBuyNull[0].Total;
                    worksheet3.Cells[$"A{memberBuy.Count + 3}"].Value = "รวม";
                    worksheet3.Cells[$"G{memberBuy.Count + 3}"].Formula = $"=SUM(G2:{worksheet3.Cells[$"G{memberBuy.Count + 2}"]})";
                    worksheet3.Cells[$"H{memberBuy.Count + 3}"].Formula = $"=SUM(H2:{worksheet3.Cells[$"H{memberBuy.Count + 1}"]})";
                    worksheet3.Cells[$"I{memberBuy.Count + 3}"].Formula = $"=SUM(I2:{worksheet3.Cells[$"I{memberBuy.Count + 1}"]})";
                    worksheet3.Cells[$"E{memberBuy.Count + 3}"].Formula = $"=SUM(E2:{worksheet3.Cells[$"E{memberBuy.Count + 1}"]})";
                    worksheet3.Cells[$"J{memberBuy.Count + 3}"].Formula = $"=SUM(J2:{worksheet3.Cells[$"J{memberBuy.Count + 1}"]})";
                    worksheet3.Cells[$"K{memberBuy.Count + 3}"].Formula = $"=SUM(K2:{worksheet3.Cells[$"K{memberBuy.Count + 1}"]})";
                    worksheet3.Cells[$"L{memberBuy.Count + 3}"].Formula = $"=SUM(L2:{worksheet3.Cells[$"L{memberBuy.Count + 1}"]})";

                    ExcelRange range = worksheet3.Cells[$"A1:N{memberBuy.Count + 1}"];
                    worksheet3.Tables.Add(range, "TableResult");

                    worksheet4.Cells["B3"].Formula =
                        $"=COUNTIFS(สรุปปันผลและจดหมายเวียน!B2:B{memberBuy.Count + 1}, \"บุคคล\",สรุปปันผลและจดหมายเวียน!E2:E{memberBuy.Count + 1},\"<>0\")";
                    worksheet4.Cells["C3"].Formula =
                        $"=SUMIF(สรุปปันผลและจดหมายเวียน!B2:B{memberBuy.Count + 1},\"บุคคล\",สรุปปันผลและจดหมายเวียน!E2:E{memberBuy.Count + 1})";
                    worksheet4.Cells["B4"].Formula =
                        $"=COUNTIFS(สรุปปันผลและจดหมายเวียน!B2:B{memberBuy.Count + 1}, \"กลุ่ม\",สรุปปันผลและจดหมายเวียน!E2:E{memberBuy.Count + 1},\"<>0\")";
                    worksheet4.Cells["C4"].Formula =
                        $"=SUMIF(สรุปปันผลและจดหมายเวียน!B2:B{memberBuy.Count + 1},\"กลุ่ม\",สรุปปันผลและจดหมายเวียน!E2:E{memberBuy.Count + 1})";

                    for (int i = 0; i < share.Count; i++)
                    {
                        worksheet5.Cells[$"A{i + 2}"].Value = share[i].MemberId;
                        worksheet5.Cells[$"B{i + 2}"].Value = share[i].Firstname + " " + share[i].Lastname;
                        worksheet5.Cells[$"C{i + 2}"].Value = share[i].Pluse;
                        worksheet5.Cells[$"D{i + 2}"].Value = share[i].Remove;
                    }

                    package.SaveAs(new FileInfo(savefile.FileName));
                    Process.Start(savefile.FileName);
                }
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var dateInfo = comYear.SelectedItem + "/1/1";
            var year = Convert.ToDateTime(dateInfo, new CultureInfo("th-TH"));
            Print(year);
        }
    }
}
