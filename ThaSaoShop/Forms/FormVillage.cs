using MetroFramework.Forms;
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
using ThaSaoShop.Helpers;
using ThaSaoShop.Models;

namespace ThaSaoShop.Forms
{
    public partial class FormVillage : MetroForm
    {
        StoreEntities db;
        Village village = new Village();
        private UserControlVillage form;

        public FormVillage(UserControlVillage uc, int id = 0)
        {
            InitializeComponent();
            db = uc.db;
            form = uc;
            if (id != 0)
            {
                Text = "แก้ไขข้อมูล";
                village = db.Villages.Find(id);
                txtId.Text = village.VillageId.ToString();
                txtName.Text = village.Name;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.WithError = true;
                return;
            }

            village.Name = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                db.Villages.Add(village);
            }
            else
            {
                db.Entry(village).State = EntityState.Modified;
            }

            try
            {
                db.SaveChanges();
                MessageBox.Show("ทำรายการสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form.LoadData();
                Close();
            }
            catch
            {
                MessageBox.Show("เกิดข้อผิดพลาด", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
