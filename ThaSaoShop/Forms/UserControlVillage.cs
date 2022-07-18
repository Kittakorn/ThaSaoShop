using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaSaoShop.Helpers;
using ThaSaoShop.Models;

namespace ThaSaoShop.Forms
{
    public partial class UserControlVillage : UserControl
    {
        public StoreEntities db;
        public UserControlVillage(StoreEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void UserControlVillage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dtVillage.Rows.Clear();
            foreach (var village in db.Villages)
            {
                dtVillage.Rows.Add(
                    village.VillageId,
                    village.Name,
                    village.Members.Count);
            }
            dtVillage.ClearSelection();
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            var row = dtVillage.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dtVillage.Rows[row].Cells[0].Value);
            using (FormVillage form = new FormVillage(this, id))
            {
                form.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FormVillage form = new FormVillage(this))
            {
                form.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ยืนยันการลบข้อมูล", "แจ้งเตือน", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) != DialogResult.OK) return;

            var row = dtVillage.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dtVillage.Rows[row].Cells[0].Value.ToString());
            var village = db.Villages.Find(id);
            db.Villages.Remove(village);

            try
            {
                db.SaveChanges();
                LoadData();
            }
            catch
            {
                db.ResetContextState();
                MessageBox.Show("ไม่สามารถลบข้อมูลได้", "แจ้งเตือน", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        private void dtExpense_SelectionChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = dtVillage.SelectedRows.Count > 0;
            btnDelete.Enabled = dtVillage.SelectedRows.Count > 0;
        }
    }
}
