using MetroFramework.Forms;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaSaoShop.Models;

namespace ThaSaoShop.Forms
{
    public partial class FormReport : MetroForm
    {
        public StoreEntities db = new StoreEntities();
        public FormReport()
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
            ShowUC(new UserControlReportBarcode(db), "UserControlReportBarcode");
        }

        private void btnBestSell_Click(object sender, EventArgs e)
        {
            ShowUC(new UserControlReportBestSell(db), "UserControlReportBestSell");
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            ShowUC(new UserControlReportExpenses(db), "UserControlReportExpenses");
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            ShowUC(new UserControlReportResult(db), "UserControlReportResult");
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            ShowUC(new UserControlReportMember(db), "UserControlReportMember");
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            ShowUC(new UserControlReportSell(db), "UserControlReportSell");
        }


        private void btnBarcode_Click(object sender, EventArgs e)
        {
            ShowUC(new UserControlReportBarcode(db), "UserControlReportBarcode");
        }

        private void btnBuy_Click_1(object sender, EventArgs e)
        {
            ShowUC(new UserControlReportBuy(db), "UserControlReportBuy");
        }

        private void btnSellDay_Click(object sender, EventArgs e)
        {
            ShowUC(new UserControlReportSellDay(db), "UserControlReportSellDay");
        }
    }
}
