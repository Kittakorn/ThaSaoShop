namespace ThaSaoShop.Forms
{
    partial class FormExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExpenses));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.btnExit = new MetroFramework.Controls.MetroLink();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.comCatExpenses = new MetroFramework.Controls.MetroComboBox();
            this.txtDetail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(100, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "รหัสรายจ่าย";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(80, 107);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(114, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "ประเภทรายจ่าย";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(365, 172);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(0, 0);
            this.metroLabel6.TabIndex = 7;
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(252, 2);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Enabled = false;
            this.txtId.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(199, 60);
            this.txtId.MaxLength = 20;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.ShowClearButton = true;
            this.txtId.Size = new System.Drawing.Size(280, 30);
            this.txtId.TabIndex = 1;
            this.txtId.TabStop = false;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMark = "สร้างอัตโนมัติ";
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.Location = new System.Drawing.Point(398, 286);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 90);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 18;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "บันทึก";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TileImage = global::ThaSaoShop.Properties.Resources.save_30px;
            this.btnSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseTileImage = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::ThaSaoShop.Properties.Resources.cancel_30px;
            this.btnExit.ImageSize = 30;
            this.btnExit.Location = new System.Drawing.Point(443, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 33);
            this.btnExit.TabIndex = 17;
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(106, 137);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(87, 25);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "รายละเอียด";
            // 
            // numPrice
            // 
            this.numPrice.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.numPrice.Location = new System.Drawing.Point(200, 238);
            this.numPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(279, 34);
            this.numPrice.TabIndex = 5;
            this.numPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPrice.Enter += new System.EventHandler(this.numPrice_Enter);
            // 
            // comCatExpenses
            // 
            this.comCatExpenses.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.comCatExpenses.FormattingEnabled = true;
            this.comCatExpenses.ItemHeight = 29;
            this.comCatExpenses.Location = new System.Drawing.Point(199, 96);
            this.comCatExpenses.Name = "comCatExpenses";
            this.comCatExpenses.Size = new System.Drawing.Size(280, 35);
            this.comCatExpenses.TabIndex = 20;
            this.comCatExpenses.UseSelectable = true;
            // 
            // txtDetail
            // 
            // 
            // 
            // 
            this.txtDetail.CustomButton.Image = null;
            this.txtDetail.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtDetail.CustomButton.Name = "";
            this.txtDetail.CustomButton.Size = new System.Drawing.Size(93, 93);
            this.txtDetail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDetail.CustomButton.TabIndex = 1;
            this.txtDetail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDetail.CustomButton.UseSelectable = true;
            this.txtDetail.CustomButton.Visible = false;
            this.txtDetail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDetail.Lines = new string[0];
            this.txtDetail.Location = new System.Drawing.Point(199, 137);
            this.txtDetail.MaxLength = 100;
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.PasswordChar = '\0';
            this.txtDetail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetail.SelectedText = "";
            this.txtDetail.SelectionLength = 0;
            this.txtDetail.SelectionStart = 0;
            this.txtDetail.ShortcutsEnabled = true;
            this.txtDetail.ShowClearButton = true;
            this.txtDetail.Size = new System.Drawing.Size(280, 95);
            this.txtDetail.TabIndex = 21;
            this.txtDetail.TabStop = false;
            this.txtDetail.UseSelectable = true;
            this.txtDetail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDetail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(147, 247);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 25);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "ราคา";
            // 
            // FormExpensesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 384);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.comCatExpenses);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FormExpensesAdd";
            this.Resizable = false;
            this.Text = "เพิ่มข้อมูล";
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLink btnExit;
        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.NumericUpDown numPrice;
        private MetroFramework.Controls.MetroComboBox comCatExpenses;
        private MetroFramework.Controls.MetroTextBox txtDetail;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}