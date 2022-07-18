using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using ThaSaoShop.Helpers;
using ThaSaoShop.Models;

namespace ThaSaoShop.Forms
{
    public partial class FormLogin : MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassoword.Text))
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                    txtUsername.WithError = true;
                if (string.IsNullOrWhiteSpace(txtPassoword.Text))
                    txtPassoword.WithError = true;
                return;
            }
            AppSetting setting = new AppSetting();
            var connectionString = setting.GetConnectionString("StoreEntities");
            SqlHelper helper = new SqlHelper(connectionString);
            try
            {
                if (helper.IsConnection)
                {
                    User user;
                    using (StoreEntities db = new StoreEntities())
                    {
                        user = db.Users.Find(txtUsername.Text);
                    }
                    if (user != null)
                    {
                        var isPasswordMatched = PasswordHashSalt.VerifyPassword(txtPassoword.Text, user.PasswordHash, user.PasswordSalt);
                        if (isPasswordMatched)
                        {
                            if (!user.IsEnable)
                            {
                                MetroMessageBox.Show(this, "ชื่อผู้ใช้ถูกระงับการใช้งาน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtPassoword.Text = null;
                                return;
                            }
                            Profile.SetProfile(user);
                            Form form = new FormMain();
                            form.FormClosing += FormOnClosed;
                            Hide();
                            form.ShowDialog();
                        }
                        else
                        {
                            txtPassoword.Text = null;
                            MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        txtPassoword.Text = null;
                        MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {
                MessageBox.Show("เกิดข้อผิดพลาด", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormOnClosed(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassoword.Text))
            {
                txtPassoword.WithError = true;
                return;
            }

            if (txtPassoword.Text.Equals(Properties.Settings.Default.Password))
            {
                FormSetting form = new FormSetting();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("รหัสผ่านไม่ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
