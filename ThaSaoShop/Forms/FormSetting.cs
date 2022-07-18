using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaSaoShop.Helpers;

namespace ThaSaoShop.Forms
{
    public partial class FormSetting : MetroForm
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;
            string connectionString =
                $"data source={txtServer.Text};initial catalog={txtDatabase.Text};User ID={txtUsername.Text};Password={txtPassword.Text};Network Library=DBMSSOCN;MultipleActiveResultSets=True;App=EntityFramework";
            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                {
                    AppSetting setting = new AppSetting();
                    setting.SaveConnectionString("StoreEntities", connectionString);
                    MessageBox.Show("บันทึกการตั้งค่าสำเร็จ กรุณาปิดโปรแกรมแล้วเปิดใหม่", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtDatabase.Text) ||
                string.IsNullOrWhiteSpace(txtServer.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                    txtUsername.WithError = true;
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                    txtPassword.WithError = true;
                if (string.IsNullOrWhiteSpace(txtServer.Text))
                    txtServer.WithError = true;
                if (string.IsNullOrWhiteSpace(txtDatabase.Text))
                    txtDatabase.WithError = true;
                return false;
            }

            return true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string connectionString =
                $"Data Source={txtServer.Text};Initial Catalog={txtDatabase.Text};User ID={txtUsername.Text};Password={txtPassword.Text};";
            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                    MessageBox.Show("เชื่อมต่อสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
