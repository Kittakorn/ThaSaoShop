using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaSaoShop.Helpers;
using ThaSaoShop.Models;
using ThaSaoShop.Models.StoredProcedure;
using ThaSaoShop.Models.View;

namespace ThaSaoShop.Forms
{
    public partial class FormMain : MetroForm
    {
        private StoreEntities db = new StoreEntities();
        private List<Product> productList = new List<Product>();
        private List<Member> memberList = new List<Member>();
        public List<Sell> sells = new List<Sell>();
        public Member member = new Member();
        public FormMain()
        {
            InitializeComponent();
            lbDate.Text = DateTime.Now.ToString("F");
            lbUser.Text = Profile.Name;
            lbRole.Text = Profile.Role;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ยืนยันการปิดโปรแกรม", "แจ้งเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Close();
        }

        public void LoadSells()
        {
            dtSell.Rows.Clear();
            foreach (var item in sells)
            {
                dtSell.Rows.Add(item.Product.ProductId, item.Product.Name, item.Product.Price, item.Amount,
                    item.Total);
            }

            dtSell.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
            dtSell.ClearSelection();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (Profile.Role != "เจ้าหน้าที่")
            {
                btnManage.Enabled = false;
                btnReport.Enabled = false;
                tbMain.TabPages.RemoveAt(2);
            }
            productList = db.Products.Include(x => x.ProductCategory).ToList();
            memberList = db.Members.Include(x => x.Village).OrderBy(x => x.MemberId).ToList();
            LoadProducts();
            LoadMembers();
            LoadSells();
            LoadBuy();

        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString("F");
        }

        private void LoadMembers()
        {
            dtMember.Rows.Clear();
            List<Member> members;
            if (txtSearchMember.Text.Trim().Length > 0)
            {
                members = memberList
                    .Where(x => (x.MemberId.ToString().Contains(txtSearchMember.Text) ||
                                 x.Firstname.Contains(txtSearchMember.Text) ||
                                 !string.IsNullOrWhiteSpace(x.Lastname) && x.Lastname.Contains(txtSearchMember.Text)) &&
                                txtSearchMember.Text != null)
                    .OrderBy(x => x.MemberId)
                    .Take(20)
                    .ToList();
            }
            else
            {
                members = memberList
                    .Take(20)
                    .OrderBy(x => x.MemberId)
                    .ToList();
            }

            foreach (var item in members)
            {
                dtMember.Rows.Add(item.MemberId, $"{item.Firstname} {item.Lastname}", item.Village.Name);
            }
            dtMember.ClearSelection();
        }

        private void LoadBuy()
        {
            dtBuy.Rows.Clear();
            var viewOrders = db.Database.SqlQuery<ViewOrder>("SELECT * FROM ViewOrder").OrderByDescending(x => x.Date).ToList();

            foreach (var item in viewOrders)
            {
                dtBuy.Rows.Add(item.OrderId, item.Date, item.MemberId, item.Count, item.Sum);
            }
            dtBuy.ClearSelection();
        }
        private void LoadProducts()
        {
            dtProduct.Rows.Clear();
            List<Product> products;
            if (txtSearchProduct.Text.Trim().Length > 0)
            {
                products = productList
                    .Where(x => x.Name.Contains(txtSearchProduct.Text) ||
                                (!string.IsNullOrWhiteSpace(x.Barcode) && x.Barcode.Contains(txtSearchProduct.Text)) ||
                                x.ProductCategory.Name.Contains(txtSearchProduct.Text) &&
                                txtSearchProduct.Text != null)
                    .OrderBy(x => x.Name)
                    .Take(20)
                    .ToList();
            }
            else
            {
                products = productList
                    .OrderBy(x => x.Name)
                    .Take(20)
                    .ToList();
            }
            foreach (var product in products)
            {
                dtProduct.Rows.Add(product.ProductId, product.ProductCategory.Name, product.Name, product.Barcode, product.Price);
            }
            dtProduct.ClearSelection();
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void txtSearchMember_TextChanged(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void tbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtProduct.ClearSelection();
            dtMember.ClearSelection();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            using (FormManagement form = new FormManagement())
            {
                form.ShowDialog();
            }
        }

        private void numMoney_Enter(object sender, EventArgs e)
        {
            numMoney.Select(0, numMoney.Text.Length);
        }

        private void dtProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var row = dtProduct.CurrentCell.RowIndex;
                var id = Convert.ToInt32(dtProduct.Rows[row].Cells[0].Value);
                var product = db.Products.Find(id);
                AddSell(product);
            }
        }

        public void AddSell(Product product)
        {
            var sell = sells.FirstOrDefault(x => x.Product.ProductId.Equals(product.ProductId));
            if (sell == null)
            {
                sells.Add(new Sell(product, 1));
            }
            else
            {
                sell.Amount++;
            }
            LoadSells();
            SetLabel();
        }

        private void SetLabel()
        {
            lbTotal.Text = sells.Sum(x => x.Total).ToString("N0");
            lbProduct.Text = sells.Count().ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            sells.Clear();
            btnMember_Click(null, null);
            dtSell.Rows.Clear();
            SetLabel();
            numMoney.Value = 0;
            txtBarcode.Select();
        }

        private void dtMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var row = dtMember.CurrentCell.RowIndex;
                var id = Convert.ToInt32(dtMember.Rows[row].Cells[0].Value);
                var member = db.Members.Find(id);
                SetMember(member);
            }
        }

        public void SetMember(Member member)
        {
            this.member = member;
            txtMember.Text = $"{this.member.Firstname} {this.member.Lastname}";
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            member = new Member();
            txtMember.Text = "สมาชิกทั่วไป";
        }

        private void txtBarcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtBarcode.Text.Length > 0)
            {
                var product = db.Products.FirstOrDefault(x => x.Barcode.Equals(txtBarcode.Text));
                if (product != null)
                {
                    AddSell(product);
                }

                txtBarcode.Text = null;
            }
        }

        private void FormMain_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    btnNew_Click(null, null);
                    break;
                case Keys.F5:
                    btnSubmit_Click(null, null);
                    break;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (sells.Count < 1)
            {
                SystemSounds.Beep.Play();
                lbMessage.Text = "กรุณาเลือกสินค้า";
                lbMessage.ForeColor = Color.Red;
                return;
            }
            if (numMoney.Value < Convert.ToDecimal(lbTotal.Text))
            {
                SystemSounds.Beep.Play();
                lbMessage.Text = "จำนวนเงินไม่ถูกต้อง";
                lbMessage.ForeColor = Color.Red;
                return;
            }

            if (MessageBox.Show("ยืนยันการชำระเงิน", "แจ้งเตือน", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                var order = new Order
                {
                    Date = DateTime.Now,
                    MemberId = member.MemberId != 0 ? member.MemberId : (int?)null,
                    Username = Profile.Username
                };
                db.Orders.Add(order);
                foreach (var sell in sells)
                {
                    db.OrderDetails.Add(new OrderDetail
                    {
                        Order = order,
                        ProductId = sell.Product.ProductId,
                        Amount = sell.Amount,
                        Price = sell.Total
                    });
                }

                try
                {
                    new FormResult(this).ShowDialog();
                    db.SaveChanges();
                    SystemSounds.Beep.Play();
                    lbMessage.Text = "ทำรายการสำเร็จ";
                    lbMessage.ForeColor = Color.Green;
                    btnNew_Click(null, null);
                    LoadBuy();
                }
                catch
                {
                    MessageBox.Show("เกิดข้อผิดพลาด", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtBarcode.Select(0, txtBarcode.Text.Length);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ยืนยันการออกจากระบบ", "แจ้งเตือน", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
            {
                FormLogin form = new FormLogin();
                form.FormClosed += FormOnFormClosed;
                Hide();
                form.ShowDialog();
            }
        }

        private void FormOnFormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void dtSell_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var row = dtSell.CurrentCell.RowIndex;
                var id = Convert.ToInt32(dtSell.Rows[row].Cells[0].Value);
                var sell = sells.FirstOrDefault(x => x.Product.ProductId == id);
                if (sell.Amount > 1)
                {
                    sells[row].Amount--;
                }
                else
                {
                    sells.Remove(sell);
                }
                LoadSells();
                SetLabel();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            using (FormReport form = new FormReport())
            {
                form.ShowDialog();
            }
        }

        private void dtBuy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var row = dtBuy.CurrentCell.RowIndex;
                if (MessageBox.Show("ยืนยันการยกเลิกรายการ", "แจ้งเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
                var time = Convert.ToDateTime(dtBuy.Rows[row].Cells[1].Value);
                var minutes = (DateTime.Now - time).TotalMinutes;
                if (minutes > 20)
                {
                    MessageBox.Show("การยกเลิกห้ามเกิน 20 นาทีหลังจากทำรายการ", "แจ้งเตือน", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                var id = Convert.ToInt32(dtBuy.Rows[row].Cells[0].Value);
                var order = db.Orders.Find(id);
                db.Orders.Remove(order);
                db.SaveChanges();
                LoadBuy();
                lbMessage.Text = "ทำรายการสำเร็จ";
                lbMessage.ForeColor = Color.Green;
            }
        }
    }
}
