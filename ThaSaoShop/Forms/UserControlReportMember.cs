using MetroFramework.Controls;
using OfficeOpenXml;
using OfficeOpenXml.ConditionalFormatting;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ThaSaoShop.Models;

namespace ThaSaoShop.Forms
{
    public partial class UserControlReportMember : MetroUserControl
    {
        public StoreEntities db;
        public List<Member> members;
        public UserControlReportMember(StoreEntities db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void UserControlReportMember_Load(object sender, EventArgs e)
        {
            members = db.Members.OrderBy(x => x.MemberId).ToList();
            LoadMemberList();
            lbMember.Text = members.Count.ToString("N0") + " คน";
            lbMemberShare.Text = members.Count(x => x.Share > 0).ToString("N0") + " คน";
            lbIsMem.Text = members.Count(x => x.IsMember).ToString("N0") + " คน";
            lbGroup.Text = members.Count(x => x.IsGroup).ToString("N0") + " คน";
            lbPerson.Text = members.Count(x => !x.IsGroup).ToString("N0") + " คน";
        }

        public void LoadMemberList()
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (var member in members)
            {
                rows.Add(new DataGridViewRow());
                var address = $"{member.Village.Name} " +
                              $"ต.{member.SubDistrict.Name} " +
                              $"อ.{member.SubDistrict.District.Name} " +
                              $"จ.{member.SubDistrict.District.Province.Name}";
                rows[rows.Count - 1].CreateCells(dtMember, member.MemberId,
                    member.IsGroup ? "กลุ่ม" : "บุคคล",
                    member.IsMember ? "เป็น" : "ไม่เป็น",
                    $"{member.Firstname} {member.Lastname}",
                    member.Village.Name,
                    string.IsNullOrWhiteSpace(member.Address) ? address : member.Address + " " + address,
                    member.Share);
            }
            dtMember.Rows.AddRange(rows.ToArray());
            dtMember.ClearSelection();
        }

        private void dtMember_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            foreach (DataGridViewRow row in dtMember.Rows)
            {
                var isMember = row.Cells[2].Value.ToString() == "เป็น";
                row.Cells[2].Style.ForeColor = isMember ? Color.Green : Color.Red;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "รายชื่อสมาชิก" + DateTime.Now.ToString("ddMMyyyy");
            savefile.Filter = "Excel Files|*.xlsx;";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                string tempPath = Path.GetTempFileName();
                File.WriteAllBytes(tempPath, Properties.Resources.MemberTemplate);
                var template = new FileInfo(tempPath);
                using (var package = new ExcelPackage(template))
                {
                    var workbook = package.Workbook;
                    var worksheet = workbook.Worksheets[1];
                    worksheet.Select();
                    int start = 6;
                    foreach (var member in members)
                    {
                        ExcelRange rng = worksheet.Cells[start, 3];
                        ExcelAddress address = new ExcelAddress(rng.Address);
                        var v = worksheet.ConditionalFormatting.AddThreeIconSet(address, eExcelconditionalFormatting3IconsSetType.Symbols2);
                        v.ShowValue = false;
                        if (!member.IsMember)
                        {
                            v.Reverse = true;
                            v.Icon1.Type = eExcelConditionalFormattingValueObjectType.Num;
                        }

                        worksheet.Cells[start, 1].Value = member.MemberId;
                        worksheet.Cells[start, 2].Value = member.IsGroup ? "กลุ่ม" : "บุคคล";
                        worksheet.Cells[start, 3].Value = member.IsMember ? 1 : 2;
                        worksheet.Cells[start, 4].Value = member.Firstname + " " + member.Lastname;
                        worksheet.Cells[start, 5].Value = member.Village.Name;
                        worksheet.Cells[start, 6].Value = member.Address;
                        worksheet.Cells[start, 7].Value = member.SubDistrict.Name;
                        worksheet.Cells[start, 8].Value = member.SubDistrict.District.Name;
                        worksheet.Cells[start, 9].Value = member.SubDistrict.District.Province.Name;
                        worksheet.Cells[start, 10].Value = member.Share;
                        worksheet.Cells[start, 11].Value = member.Share * 100;
                        start++;

                    }

                    worksheet.Cells["D2"].Formula = $"=COUNT(A6:A{members.Count + 5})";
                    worksheet.Cells["D3"].Formula = $"=COUNTIFS(B6:B{members.Count + 5},\"บุคคล\",K6:K{members.Count + 5},\">0\")";
                    worksheet.Cells["D4"].Formula = $"=COUNTIF(C6:C{members.Count + 5},1)";
                    worksheet.Cells["G2"].Formula = $"=COUNTIF(B6:B{members.Count + 5},\"กลุ่ม\")";
                    worksheet.Cells["G3"].Formula = $"=COUNTIF(B6:B{members.Count + 5},\"บุคคล\")";
                    worksheet.Cells["J2"].Value = DateTime.Now;
                    package.SaveAs(new FileInfo(savefile.FileName));
                    Process.Start(savefile.FileName);
                }
            }
        }
    }
}
