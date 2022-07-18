using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaSaoShop.Models;

namespace ThaSaoShop.Forms
{
    public partial class UserControlMember : UserControl
    {
        public StoreEntities db;

        public UserControlMember(StoreEntities db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void UserControlUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dtMember.Rows.Clear();
            List<Member> members;
            if (txtSearch.Text.Trim().Length > 0)
            {
                members = db.Members
                    .Include(x => x.SubDistrict)
                    .Include(x => x.Village)
                    .Where(x => (x.MemberId.ToString().Contains(txtSearch.Text) ||
                                 x.Firstname.Contains(txtSearch.Text) ||
                                 x.Lastname.Contains(txtSearch.Text) ||
                                 x.Share.ToString().Contains(txtSearch.Text) ||
                                 x.SubDistrict.Name.Contains(txtSearch.Text) ||
                                 x.SubDistrict.District.Name.Contains(txtSearch.Text) ||
                                 x.SubDistrict.District.Province.Name.Contains(txtSearch.Text)) &&
                                txtSearch.Text != null)
                    .OrderBy(x => x.MemberId)
                    .ToList();
            }
            else
            {
                members = db.Members
                    .Include(x => x.SubDistrict)
                    .Include(x => x.Village)
                    .OrderBy(x => x.MemberId)
                    .ToList();
            }

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
                    string.IsNullOrWhiteSpace(member.Address) ? address : member.Address + " " + address,
                    member.Share);
            }
            dtMember.Rows.AddRange(rows.ToArray());
            dtMember.ClearSelection();
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            var row = dtMember.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dtMember.Rows[row].Cells[0].Value);
            using (FormMember form = new FormMember(this, id))
            {
                form.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormMember form = new FormMember(this))
            {
                form.ShowDialog();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtMember_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dtMember.Rows)
            {
                var isMember = row.Cells[2].Value.ToString() == "เป็น";
                row.Cells[2].Style.ForeColor = isMember ? Color.Green : Color.Red;
            }
        }

        private void dtMember_SelectionChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = dtMember.SelectedRows.Count > 0;
            btnShare.Enabled = dtMember.SelectedRows.Count > 0;
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            var row = dtMember.CurrentCell.RowIndex;

            var id = Convert.ToInt32(dtMember.Rows[row].Cells[0].Value);
            using (FormMemberShare form = new FormMemberShare(this, id))
            {
                form.ShowDialog();
            }
            LoadData();
        }
    }
}
