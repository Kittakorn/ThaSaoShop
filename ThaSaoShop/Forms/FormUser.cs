using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaSaoShop.Helpers;
using ThaSaoShop.Models;

namespace ThaSaoShop.Forms
{
    public partial class FormUser : MetroForm
    {
        StoreEntities db;
        User user = new User();
        private UserControlUser userControl;
        public FormUser(UserControlUser uc, string username = null)
        {
            InitializeComponent();
            userControl = uc;
            db = uc.db;
            if (username != null)
            {
                Text = "แก้ไขข้อมูล";
                user = db.Users.Find(username);
                txtUsername.Text = user.Username;
                txtFirstname.Text = user.Firstname;
                txtPhone.Text = user.Phone;
                txtLastname.Text = user.Lastname;
                rdRoleTrue.Checked = user.Role;
                rdRoleFalse.Checked = !user.Role;
                tgEnable.Checked = user.IsEnable;
                tgEnable.Visible = true;
                lbEnable.Visible = true;
                txtUsername.Enabled = false;
                if (username == Profile.Username)
                {
                    rdRoleTrue.Enabled = false;
                    rdRoleFalse.Enabled = false;
                    tgEnable.Enabled = false;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtFirstname.Text) || string.IsNullOrWhiteSpace(txtLastname.Text) || !Regex.IsMatch(txtPhone.Text, @"^[0-9]+$"))
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                    txtUsername.WithError = true;
                if (string.IsNullOrWhiteSpace(txtFirstname.Text))
                    txtFirstname.WithError = true;
                if (string.IsNullOrWhiteSpace(txtLastname.Text))
                    txtLastname.WithError = true;
                if (!Regex.IsMatch(txtPhone.Text, @"^[0-9]+$"))
                    txtPhone.WithError = true;
                return;
            }

            user.Username = txtUsername.Text.Trim();
            user.Phone = txtPhone.Text.Trim();
            user.Firstname = txtFirstname.Text.Trim();
            user.Lastname = txtLastname.Text.Trim();
            user.Role = rdRoleTrue.Checked;
            user.IsEnable = tgEnable.Checked;
            if (txtUsername.Enabled)
            {
                if (db.Users.Find(txtUsername.Text) == null)
                {
                    HashSalt hashSalt = HashSalt.GenerateSaltedHash(64, txtPhone.Text);
                    user.PasswordHash = hashSalt.Hash;
                    user.PasswordSalt = hashSalt.Salt;
                    db.Users.Add(user);
                }
                else
                {
                    MessageBox.Show("ชื่อผู้ใช้นี้มีในระบบแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                db.Entry(user).State = EntityState.Modified;
            }

            try
            {
                db.SaveChanges();
                MessageBox.Show("ทำรายการสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userControl.LoadData();
                Close();
            }
            catch
            {
                MessageBox.Show("เกิดข้อผิดพลาด", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
