namespace ThaSaoShop.Forms
{
    partial class FormReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            this.pnMain = new MetroFramework.Controls.MetroPanel();
            this.pnCenter = new MetroFramework.Controls.MetroPanel();
            this.pnLeft = new MetroFramework.Controls.MetroPanel();
            this.btnExit = new MetroFramework.Controls.MetroLink();
            this.btnSellDay = new MetroFramework.Controls.MetroTile();
            this.btnSell = new MetroFramework.Controls.MetroTile();
            this.btnBuy = new MetroFramework.Controls.MetroTile();
            this.btnMember = new MetroFramework.Controls.MetroTile();
            this.btnExpenses1 = new MetroFramework.Controls.MetroTile();
            this.btnExpenses = new MetroFramework.Controls.MetroTile();
            this.btnBestSell = new MetroFramework.Controls.MetroTile();
            this.btnBarcode = new MetroFramework.Controls.MetroTile();
            this.pnMain.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.pnCenter);
            this.pnMain.Controls.Add(this.pnLeft);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.HorizontalScrollbarBarColor = true;
            this.pnMain.HorizontalScrollbarHighlightOnWheel = false;
            this.pnMain.HorizontalScrollbarSize = 10;
            this.pnMain.Location = new System.Drawing.Point(20, 60);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1326, 665);
            this.pnMain.TabIndex = 0;
            this.pnMain.VerticalScrollbarBarColor = true;
            this.pnMain.VerticalScrollbarHighlightOnWheel = false;
            this.pnMain.VerticalScrollbarSize = 10;
            // 
            // pnCenter
            // 
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.HorizontalScrollbarBarColor = true;
            this.pnCenter.HorizontalScrollbarHighlightOnWheel = false;
            this.pnCenter.HorizontalScrollbarSize = 10;
            this.pnCenter.Location = new System.Drawing.Point(264, 0);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(1062, 665);
            this.pnCenter.TabIndex = 4;
            this.pnCenter.VerticalScrollbarBarColor = true;
            this.pnCenter.VerticalScrollbarHighlightOnWheel = false;
            this.pnCenter.VerticalScrollbarSize = 10;
            // 
            // pnLeft
            // 
            this.pnLeft.Controls.Add(this.btnSellDay);
            this.pnLeft.Controls.Add(this.btnSell);
            this.pnLeft.Controls.Add(this.btnBuy);
            this.pnLeft.Controls.Add(this.btnMember);
            this.pnLeft.Controls.Add(this.btnExpenses1);
            this.pnLeft.Controls.Add(this.btnExpenses);
            this.pnLeft.Controls.Add(this.btnBestSell);
            this.pnLeft.Controls.Add(this.btnBarcode);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.HorizontalScrollbarBarColor = true;
            this.pnLeft.HorizontalScrollbarHighlightOnWheel = false;
            this.pnLeft.HorizontalScrollbarSize = 10;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(264, 665);
            this.pnLeft.TabIndex = 2;
            this.pnLeft.VerticalScrollbarBarColor = true;
            this.pnLeft.VerticalScrollbarHighlightOnWheel = false;
            this.pnLeft.VerticalScrollbarSize = 10;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::ThaSaoShop.Properties.Resources.back_arrow_25px;
            this.btnExit.ImageSize = 30;
            this.btnExit.Location = new System.Drawing.Point(23, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 33);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSellDay
            // 
            this.btnSellDay.ActiveControl = null;
            this.btnSellDay.Location = new System.Drawing.Point(107, 363);
            this.btnSellDay.Name = "btnSellDay";
            this.btnSellDay.Size = new System.Drawing.Size(154, 115);
            this.btnSellDay.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnSellDay.TabIndex = 11;
            this.btnSellDay.Text = "ยอดขายของวัน";
            this.btnSellDay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSellDay.TileImage = global::ThaSaoShop.Properties.Resources.land_sales_50px;
            this.btnSellDay.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSellDay.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnSellDay.UseSelectable = true;
            this.btnSellDay.UseTileImage = true;
            this.btnSellDay.Click += new System.EventHandler(this.btnSellDay_Click);
            // 
            // btnSell
            // 
            this.btnSell.ActiveControl = null;
            this.btnSell.Location = new System.Drawing.Point(131, 484);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(130, 115);
            this.btnSell.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnSell.TabIndex = 9;
            this.btnSell.Text = "ยอดขายสินค้า";
            this.btnSell.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSell.TileImage = global::ThaSaoShop.Properties.Resources.sale_50px;
            this.btnSell.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSell.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnSell.UseSelectable = true;
            this.btnSell.UseTileImage = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.ActiveControl = null;
            this.btnBuy.Location = new System.Drawing.Point(4, 484);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(121, 115);
            this.btnBuy.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnBuy.TabIndex = 10;
            this.btnBuy.Text = "ยอดซื้อสินค้า";
            this.btnBuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuy.TileImage = global::ThaSaoShop.Properties.Resources.buy_50px1;
            this.btnBuy.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuy.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnBuy.UseSelectable = true;
            this.btnBuy.UseTileImage = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click_1);
            // 
            // btnMember
            // 
            this.btnMember.ActiveControl = null;
            this.btnMember.Location = new System.Drawing.Point(4, 363);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(97, 115);
            this.btnMember.Style = MetroFramework.MetroColorStyle.Green;
            this.btnMember.TabIndex = 8;
            this.btnMember.Text = "สมาชิก";
            this.btnMember.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMember.TileImage = global::ThaSaoShop.Properties.Resources.user_groups_60px;
            this.btnMember.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMember.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnMember.UseSelectable = true;
            this.btnMember.UseTileImage = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnExpenses1
            // 
            this.btnExpenses1.ActiveControl = null;
            this.btnExpenses1.Location = new System.Drawing.Point(4, 242);
            this.btnExpenses1.Name = "btnExpenses1";
            this.btnExpenses1.Size = new System.Drawing.Size(257, 115);
            this.btnExpenses1.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnExpenses1.TabIndex = 6;
            this.btnExpenses1.Text = "สรุปข้อมูลประจำปี";
            this.btnExpenses1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExpenses1.TileImage = global::ThaSaoShop.Properties.Resources.general_ledger_50px;
            this.btnExpenses1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExpenses1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnExpenses1.UseSelectable = true;
            this.btnExpenses1.UseTileImage = true;
            this.btnExpenses1.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.ActiveControl = null;
            this.btnExpenses.Location = new System.Drawing.Point(169, 121);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(92, 115);
            this.btnExpenses.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnExpenses.TabIndex = 5;
            this.btnExpenses.Text = "รายจ่าย";
            this.btnExpenses.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExpenses.TileImage = global::ThaSaoShop.Properties.Resources.card_payment_50px;
            this.btnExpenses.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExpenses.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnExpenses.UseSelectable = true;
            this.btnExpenses.UseTileImage = true;
            this.btnExpenses.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnBestSell
            // 
            this.btnBestSell.ActiveControl = null;
            this.btnBestSell.Location = new System.Drawing.Point(4, 121);
            this.btnBestSell.Name = "btnBestSell";
            this.btnBestSell.Size = new System.Drawing.Size(159, 115);
            this.btnBestSell.TabIndex = 4;
            this.btnBestSell.Text = "สินค้าขายดี";
            this.btnBestSell.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBestSell.TileImage = global::ThaSaoShop.Properties.Resources.increase_50px;
            this.btnBestSell.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBestSell.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnBestSell.UseSelectable = true;
            this.btnBestSell.UseTileImage = true;
            this.btnBestSell.Click += new System.EventHandler(this.btnBestSell_Click);
            // 
            // btnBarcode
            // 
            this.btnBarcode.ActiveControl = null;
            this.btnBarcode.Location = new System.Drawing.Point(3, 0);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(258, 115);
            this.btnBarcode.Style = MetroFramework.MetroColorStyle.Red;
            this.btnBarcode.TabIndex = 2;
            this.btnBarcode.Text = "พิมพ์รหัสบาร์โค้ดสินค้า";
            this.btnBarcode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBarcode.TileImage = global::ThaSaoShop.Properties.Resources.barcode_50px;
            this.btnBarcode.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBarcode.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnBarcode.UseSelectable = true;
            this.btnBarcode.UseTileImage = true;
            this.btnBarcode.Click += new System.EventHandler(this.btnBarcode_Click);
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 745);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FormReport";
            this.Resizable = false;
            this.Text = "รายงาน";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnMain.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnMain;
        private MetroFramework.Controls.MetroPanel pnLeft;
        private MetroFramework.Controls.MetroPanel pnCenter;
        private MetroFramework.Controls.MetroTile btnBarcode;
        private MetroFramework.Controls.MetroTile btnBestSell;
        private MetroFramework.Controls.MetroTile btnExpenses;
        private MetroFramework.Controls.MetroLink btnExit;
        private MetroFramework.Controls.MetroTile btnExpenses1;
        private MetroFramework.Controls.MetroTile btnMember;
        private MetroFramework.Controls.MetroTile btnSell;
        private MetroFramework.Controls.MetroTile btnBuy;
        private MetroFramework.Controls.MetroTile btnSellDay;
    }
}