using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ThaSaoShop.Helpers;
using ThaSaoShop.Models;

namespace ThaSaoShop.Forms
{
    public partial class FormMemberShare : MetroForm
    {
        StoreEntities db;
        private Member member;
        public FormMemberShare(UserControlMember uc, int id)
        {
            InitializeComponent();
            db = uc.db;
            member = db.Members.Find(id);
            txtUsername.Text = $"{member.Firstname} {member.Lastname}";
            txtShare.Text = member.Share.ToString("N0");
            LoadData();
        }

        private void LoadData()
        {
            dtShare.Rows.Clear();
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (var share in db.Shares.Where(x => x.MemberId.Equals(member.MemberId)).OrderByDescending(x => x.Date))
            {
                rows.Add(new DataGridViewRow());
                rows[rows.Count - 1].CreateCells(dtShare, share.Date, share.Type ? "เพิ่ม" : "ถอน", share.Amount, share.User.Firstname + " " + share.User.Lastname);
            }

            dtShare.Rows.AddRange(rows.ToArray());
            dtShare.ClearSelection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (radioButtonTypeTrue.Checked)
            {
                member.Share += (int)numAmount.Value;

            }
            else
            {
                if (member.Share < numAmount.Value)
                {
                    MessageBox.Show("จำนวนหุ้นไม่เพียงพอ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                member.Share -= (int)numAmount.Value;
            }

            db.Entry(member).State = EntityState.Modified;
            db.Shares.Add(new Share()
            {
                Date = DateTime.Now,
                Amount = (int)numAmount.Value,
                MemberId = member.MemberId,
                Username = Profile.Username,
                Type = radioButtonTypeTrue.Checked
            });
            try
            {
                db.SaveChanges();
                txtShare.Text = member.Share.ToString("N0");
                LoadData();
                numAmount.Value = 1;
                MessageBox.Show("ทำรายการสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                db.ResetContextState();
                MessageBox.Show("เกิดข้อผิดพลาด", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtShare_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dtShare.Rows)
            {
                var typeTrue = row.Cells[1].Value.ToString() == "เพิ่ม";
                row.Cells[1].Style.ForeColor = typeTrue ? Color.Green : Color.Red;
            }
        }
    }
}
