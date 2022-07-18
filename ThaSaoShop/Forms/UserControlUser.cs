using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaSaoShop.Models;

namespace ThaSaoShop.Forms
{
    public partial class UserControlUser : UserControl
    {
        public StoreEntities db;
        public UserControlUser(StoreEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void UserControlUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dtUser.Rows.Clear();
            foreach (var user in db.Users.ToList())
            {
                dtUser.Rows.Add(user.Username, user.Firstname + " " + user.Lastname, user.Phone,
                    user.Role ? "เจ้าหน้าที่" : "พนักงาน", user.IsEnable ? "เปิด" : "ปิด");
            }
            dtUser.ClearSelection();
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var row = dtUser.CurrentCell.RowIndex;
            var username = dtUser.Rows[row].Cells[0].Value.ToString();
            using (FormUser form = new FormUser(this, username))
            {
                form.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormUser form = new FormUser(this))
            {
                form.ShowDialog();
            }
        }

        private void dtUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dtUser.Rows)
            {
                var isEnabled = row.Cells[4].Value.ToString() == "เปิด";
                row.Cells[4].Style.ForeColor = isEnabled ? Color.Green : Color.Red;
            }
        }

        private void dtUser_Sorted(object sender, EventArgs e)
        {
            dtUser.ClearSelection();
        }

        private void dtUser_SelectionChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = dtUser.SelectedRows.Count > 0;
        }
    }
}
