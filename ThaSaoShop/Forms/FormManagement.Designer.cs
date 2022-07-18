namespace ThaSaoShop.Forms
{
    partial class FormManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagement));
            this.pnMain = new MetroFramework.Controls.MetroPanel();
            this.pnCenter = new MetroFramework.Controls.MetroPanel();
            this.pnLeft = new MetroFramework.Controls.MetroPanel();
            this.btnVillage = new MetroFramework.Controls.MetroTile();
            this.btnCatProduct = new MetroFramework.Controls.MetroTile();
            this.btnCatExpenses = new MetroFramework.Controls.MetroTile();
            this.btnExpenses = new MetroFramework.Controls.MetroTile();
            this.btnBuy = new MetroFramework.Controls.MetroTile();
            this.btnProduct = new MetroFramework.Controls.MetroTile();
            this.btnUser = new MetroFramework.Controls.MetroTile();
            this.btnMember = new MetroFramework.Controls.MetroTile();
            this.btnExit = new MetroFramework.Controls.MetroLink();
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
            this.pnCenter.Location = new System.Drawing.Point(292, 0);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(1034, 665);
            this.pnCenter.TabIndex = 4;
            this.pnCenter.VerticalScrollbarBarColor = true;
            this.pnCenter.VerticalScrollbarHighlightOnWheel = false;
            this.pnCenter.VerticalScrollbarSize = 10;
            // 
            // pnLeft
            // 
            this.pnLeft.Controls.Add(this.btnVillage);
            this.pnLeft.Controls.Add(this.btnCatProduct);
            this.pnLeft.Controls.Add(this.btnCatExpenses);
            this.pnLeft.Controls.Add(this.btnExpenses);
            this.pnLeft.Controls.Add(this.btnBuy);
            this.pnLeft.Controls.Add(this.btnProduct);
            this.pnLeft.Controls.Add(this.btnUser);
            this.pnLeft.Controls.Add(this.btnMember);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.HorizontalScrollbarBarColor = true;
            this.pnLeft.HorizontalScrollbarHighlightOnWheel = false;
            this.pnLeft.HorizontalScrollbarSize = 10;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(292, 665);
            this.pnLeft.TabIndex = 2;
            this.pnLeft.VerticalScrollbarBarColor = true;
            this.pnLeft.VerticalScrollbarHighlightOnWheel = false;
            this.pnLeft.VerticalScrollbarSize = 10;
            // 
            // btnVillage
            // 
            this.btnVillage.ActiveControl = null;
            this.btnVillage.Location = new System.Drawing.Point(149, 363);
            this.btnVillage.Name = "btnVillage";
            this.btnVillage.Size = new System.Drawing.Size(140, 115);
            this.btnVillage.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnVillage.TabIndex = 9;
            this.btnVillage.Text = "หมู่บ้าน";
            this.btnVillage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVillage.TileImage = global::ThaSaoShop.Properties.Resources.home_50px;
            this.btnVillage.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVillage.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnVillage.UseSelectable = true;
            this.btnVillage.UseTileImage = true;
            this.btnVillage.Click += new System.EventHandler(this.btnVillage_Click);
            // 
            // btnCatProduct
            // 
            this.btnCatProduct.ActiveControl = null;
            this.btnCatProduct.Location = new System.Drawing.Point(4, 363);
            this.btnCatProduct.Name = "btnCatProduct";
            this.btnCatProduct.Size = new System.Drawing.Size(140, 115);
            this.btnCatProduct.Style = MetroFramework.MetroColorStyle.Green;
            this.btnCatProduct.TabIndex = 8;
            this.btnCatProduct.Text = "ประเภทสินค้า";
            this.btnCatProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCatProduct.TileImage = global::ThaSaoShop.Properties.Resources.price_tag_50px;
            this.btnCatProduct.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCatProduct.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnCatProduct.UseSelectable = true;
            this.btnCatProduct.UseTileImage = true;
            this.btnCatProduct.Click += new System.EventHandler(this.btnCatProduct_Click);
            // 
            // btnCatExpenses
            // 
            this.btnCatExpenses.ActiveControl = null;
            this.btnCatExpenses.Location = new System.Drawing.Point(149, 242);
            this.btnCatExpenses.Name = "btnCatExpenses";
            this.btnCatExpenses.Size = new System.Drawing.Size(140, 115);
            this.btnCatExpenses.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnCatExpenses.TabIndex = 7;
            this.btnCatExpenses.Text = "ประเภทรายจ่าย";
            this.btnCatExpenses.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCatExpenses.TileImage = global::ThaSaoShop.Properties.Resources.pricing_50px;
            this.btnCatExpenses.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCatExpenses.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnCatExpenses.UseSelectable = true;
            this.btnCatExpenses.UseTileImage = true;
            this.btnCatExpenses.Click += new System.EventHandler(this.btnCatExpenses_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.ActiveControl = null;
            this.btnExpenses.Location = new System.Drawing.Point(4, 242);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(140, 115);
            this.btnExpenses.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnExpenses.TabIndex = 6;
            this.btnExpenses.Text = "รายจ่าย";
            this.btnExpenses.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExpenses.TileImage = global::ThaSaoShop.Properties.Resources.general_ledger_50px;
            this.btnExpenses.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExpenses.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnExpenses.UseSelectable = true;
            this.btnExpenses.UseTileImage = true;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.ActiveControl = null;
            this.btnBuy.Location = new System.Drawing.Point(150, 121);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(140, 115);
            this.btnBuy.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnBuy.TabIndex = 5;
            this.btnBuy.Text = "ซื้อสินค้า";
            this.btnBuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuy.TileImage = global::ThaSaoShop.Properties.Resources.buy_50px;
            this.btnBuy.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuy.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnBuy.UseSelectable = true;
            this.btnBuy.UseTileImage = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.ActiveControl = null;
            this.btnProduct.Location = new System.Drawing.Point(4, 121);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(140, 115);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Text = "สินค้า";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduct.TileImage = global::ThaSaoShop.Properties.Resources.cube_50px;
            this.btnProduct.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProduct.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnProduct.UseSelectable = true;
            this.btnProduct.UseTileImage = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnUser
            // 
            this.btnUser.ActiveControl = null;
            this.btnUser.Location = new System.Drawing.Point(149, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(140, 115);
            this.btnUser.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "พนักงาน";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUser.TileImage = global::ThaSaoShop.Properties.Resources.user_account_50px;
            this.btnUser.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUser.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnUser.UseSelectable = true;
            this.btnUser.UseTileImage = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnMember
            // 
            this.btnMember.ActiveControl = null;
            this.btnMember.Location = new System.Drawing.Point(3, 0);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(140, 115);
            this.btnMember.Style = MetroFramework.MetroColorStyle.Red;
            this.btnMember.TabIndex = 2;
            this.btnMember.Text = "สมาชิก";
            this.btnMember.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMember.TileImage = global::ThaSaoShop.Properties.Resources.user_groups_50px;
            this.btnMember.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMember.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnMember.UseSelectable = true;
            this.btnMember.UseTileImage = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
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
            // FormManagement
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
            this.Name = "FormManagement";
            this.Resizable = false;
            this.Text = "จัดการข้อมูล";
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
        private MetroFramework.Controls.MetroTile btnUser;
        private MetroFramework.Controls.MetroTile btnMember;
        private MetroFramework.Controls.MetroTile btnProduct;
        private MetroFramework.Controls.MetroTile btnBuy;
        private MetroFramework.Controls.MetroLink btnExit;
        private MetroFramework.Controls.MetroTile btnCatExpenses;
        private MetroFramework.Controls.MetroTile btnExpenses;
        private MetroFramework.Controls.MetroTile btnCatProduct;
        private MetroFramework.Controls.MetroTile btnVillage;
    }
}