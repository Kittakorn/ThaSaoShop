using MetroFramework.Forms;
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
    public partial class FormManagement : MetroForm
    {
        public StoreEntities db = new StoreEntities();
        public FormManagement()
        {
            InitializeComponent();
        }

        private void ShowUC(UserControl userControl, string key = null)
        {
            if (!pnCenter.Controls.ContainsKey(key))
            {
                userControl.Dock = DockStyle.Fill;
                pnCenter.Controls.Add(userControl);
            }
            pnCenter.Controls[key].BringToFront();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ShowUC(new UserControlUser(db), "UserControlUser");
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ShowUC(new UserControlUser(db), "UserControlUser");
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ShowUC(new UserControlProduct(db), "UserControlProduct");
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            ShowUC(new UserControlBuy(db), "UserControlBuy");
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            ShowUC(new UserControlExpense(db), "UserControlExpense");
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            ShowUC(new UserControlMember(db), "UserControlMember");
        }

        private void btnVillage_Click(object sender, EventArgs e)
        {
            ShowUC(new UserControlVillage(db), "UserControlVillage");
        }

        private void btnCatExpenses_Click(object sender, EventArgs e)
        {
            ShowUC(new UserControlExpenseCategory(db), "UserControlExpenseCategory");
        }

        private void btnCatProduct_Click(object sender, EventArgs e)
        {
            ShowUC(new UserControlProductCategory(db), "UserControlProductCategory");

        }
    }
}
