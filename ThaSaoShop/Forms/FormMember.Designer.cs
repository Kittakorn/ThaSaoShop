namespace ThaSaoShop.Forms
{
    partial class FormMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMember));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.btnExit = new MetroFramework.Controls.MetroLink();
            this.comVillage = new MetroFramework.Controls.MetroComboBox();
            this.txtFirstname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtLastname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.comSub = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.comDIstrict = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.groupBoxMember = new System.Windows.Forms.GroupBox();
            this.radioButtonMemberTrue = new System.Windows.Forms.RadioButton();
            this.radioButtonMemberFalse = new System.Windows.Forms.RadioButton();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.radioButtonTypeTrue = new System.Windows.Forms.RadioButton();
            this.radioButtonTypeFalse = new System.Windows.Forms.RadioButton();
            this.comProvince = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.numShare = new System.Windows.Forms.NumericUpDown();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.groupBoxMember.SuspendLayout();
            this.groupBoxType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numShare)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(103, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "รหัสสมาชิก";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(131, 214);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "หมู่บ้าน";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(366, 360);
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
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.Location = new System.Drawing.Point(400, 555);
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
            this.btnExit.Location = new System.Drawing.Point(465, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 33);
            this.btnExit.TabIndex = 17;
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // comVillage
            // 
            this.comVillage.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.comVillage.FormattingEnabled = true;
            this.comVillage.ItemHeight = 29;
            this.comVillage.Location = new System.Drawing.Point(199, 204);
            this.comVillage.Name = "comVillage";
            this.comVillage.Size = new System.Drawing.Size(280, 35);
            this.comVillage.TabIndex = 20;
            this.comVillage.UseSelectable = true;
            // 
            // txtFirstname
            // 
            // 
            // 
            // 
            this.txtFirstname.CustomButton.Image = null;
            this.txtFirstname.CustomButton.Location = new System.Drawing.Point(252, 2);
            this.txtFirstname.CustomButton.Name = "";
            this.txtFirstname.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtFirstname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirstname.CustomButton.TabIndex = 1;
            this.txtFirstname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirstname.CustomButton.UseSelectable = true;
            this.txtFirstname.CustomButton.Visible = false;
            this.txtFirstname.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtFirstname.Lines = new string[0];
            this.txtFirstname.Location = new System.Drawing.Point(199, 96);
            this.txtFirstname.MaxLength = 50;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.PasswordChar = '\0';
            this.txtFirstname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstname.SelectedText = "";
            this.txtFirstname.SelectionLength = 0;
            this.txtFirstname.SelectionStart = 0;
            this.txtFirstname.ShortcutsEnabled = true;
            this.txtFirstname.ShowClearButton = true;
            this.txtFirstname.Size = new System.Drawing.Size(280, 30);
            this.txtFirstname.TabIndex = 26;
            this.txtFirstname.UseSelectable = true;
            this.txtFirstname.WaterMark = "กรุณากรอกข้อมูล";
            this.txtFirstname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirstname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(160, 101);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(33, 25);
            this.metroLabel7.TabIndex = 25;
            this.metroLabel7.Text = "ชื่อ";
            // 
            // txtLastname
            // 
            // 
            // 
            // 
            this.txtLastname.CustomButton.Image = null;
            this.txtLastname.CustomButton.Location = new System.Drawing.Point(252, 2);
            this.txtLastname.CustomButton.Name = "";
            this.txtLastname.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtLastname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastname.CustomButton.TabIndex = 1;
            this.txtLastname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastname.CustomButton.UseSelectable = true;
            this.txtLastname.CustomButton.Visible = false;
            this.txtLastname.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtLastname.Lines = new string[0];
            this.txtLastname.Location = new System.Drawing.Point(199, 132);
            this.txtLastname.MaxLength = 50;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.PasswordChar = '\0';
            this.txtLastname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastname.SelectedText = "";
            this.txtLastname.SelectionLength = 0;
            this.txtLastname.SelectionStart = 0;
            this.txtLastname.ShortcutsEnabled = true;
            this.txtLastname.ShowClearButton = true;
            this.txtLastname.Size = new System.Drawing.Size(280, 30);
            this.txtLastname.TabIndex = 28;
            this.txtLastname.UseSelectable = true;
            this.txtLastname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(132, 137);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(61, 25);
            this.metroLabel8.TabIndex = 27;
            this.metroLabel8.Text = "นาสกุล";
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(252, 2);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(199, 168);
            this.txtAddress.MaxLength = 100;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.ShowClearButton = true;
            this.txtAddress.Size = new System.Drawing.Size(280, 30);
            this.txtAddress.TabIndex = 30;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(151, 173);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(42, 25);
            this.metroLabel9.TabIndex = 29;
            this.metroLabel9.Text = "ที่อยู่";
            // 
            // comSub
            // 
            this.comSub.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.comSub.FormattingEnabled = true;
            this.comSub.ItemHeight = 29;
            this.comSub.Location = new System.Drawing.Point(200, 327);
            this.comSub.Name = "comSub";
            this.comSub.Size = new System.Drawing.Size(280, 35);
            this.comSub.TabIndex = 32;
            this.comSub.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.Location = new System.Drawing.Point(143, 337);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(50, 25);
            this.metroLabel10.TabIndex = 31;
            this.metroLabel10.Text = "ตำบล";
            // 
            // comDIstrict
            // 
            this.comDIstrict.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.comDIstrict.FormattingEnabled = true;
            this.comDIstrict.ItemHeight = 29;
            this.comDIstrict.Location = new System.Drawing.Point(200, 286);
            this.comDIstrict.Name = "comDIstrict";
            this.comDIstrict.Size = new System.Drawing.Size(280, 35);
            this.comDIstrict.TabIndex = 34;
            this.comDIstrict.UseSelectable = true;
            this.comDIstrict.SelectionChangeCommitted += new System.EventHandler(this.comboBoxDistrict_SelectionChangeCommitted);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.Location = new System.Drawing.Point(138, 296);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(56, 25);
            this.metroLabel11.TabIndex = 33;
            this.metroLabel11.Text = "อำเภอ";
            // 
            // groupBoxMember
            // 
            this.groupBoxMember.Controls.Add(this.radioButtonMemberTrue);
            this.groupBoxMember.Controls.Add(this.radioButtonMemberFalse);
            this.groupBoxMember.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMember.Location = new System.Drawing.Point(198, 408);
            this.groupBoxMember.Name = "groupBoxMember";
            this.groupBoxMember.Size = new System.Drawing.Size(280, 61);
            this.groupBoxMember.TabIndex = 52;
            this.groupBoxMember.TabStop = false;
            this.groupBoxMember.Text = "สมาชิก อ.บ.ต";
            // 
            // radioButtonMemberTrue
            // 
            this.radioButtonMemberTrue.AutoSize = true;
            this.radioButtonMemberTrue.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.radioButtonMemberTrue.Location = new System.Drawing.Point(21, 30);
            this.radioButtonMemberTrue.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonMemberTrue.Name = "radioButtonMemberTrue";
            this.radioButtonMemberTrue.Size = new System.Drawing.Size(56, 29);
            this.radioButtonMemberTrue.TabIndex = 33;
            this.radioButtonMemberTrue.Text = "เป็น";
            this.radioButtonMemberTrue.UseVisualStyleBackColor = true;
            this.radioButtonMemberTrue.CheckedChanged += new System.EventHandler(this.radioButtonMemberTrue_CheckedChanged);
            // 
            // radioButtonMemberFalse
            // 
            this.radioButtonMemberFalse.AutoSize = true;
            this.radioButtonMemberFalse.Checked = true;
            this.radioButtonMemberFalse.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.radioButtonMemberFalse.Location = new System.Drawing.Point(102, 30);
            this.radioButtonMemberFalse.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonMemberFalse.Name = "radioButtonMemberFalse";
            this.radioButtonMemberFalse.Size = new System.Drawing.Size(73, 29);
            this.radioButtonMemberFalse.TabIndex = 34;
            this.radioButtonMemberFalse.TabStop = true;
            this.radioButtonMemberFalse.Text = "ไม่เป็น";
            this.radioButtonMemberFalse.UseVisualStyleBackColor = true;
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.radioButtonTypeTrue);
            this.groupBoxType.Controls.Add(this.radioButtonTypeFalse);
            this.groupBoxType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxType.Location = new System.Drawing.Point(198, 475);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(281, 63);
            this.groupBoxType.TabIndex = 51;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "ประเภท";
            // 
            // radioButtonTypeTrue
            // 
            this.radioButtonTypeTrue.AutoSize = true;
            this.radioButtonTypeTrue.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.radioButtonTypeTrue.Location = new System.Drawing.Point(21, 30);
            this.radioButtonTypeTrue.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonTypeTrue.Name = "radioButtonTypeTrue";
            this.radioButtonTypeTrue.Size = new System.Drawing.Size(60, 29);
            this.radioButtonTypeTrue.TabIndex = 33;
            this.radioButtonTypeTrue.Text = "กลุ่ม";
            this.radioButtonTypeTrue.UseVisualStyleBackColor = true;
            this.radioButtonTypeTrue.CheckedChanged += new System.EventHandler(this.radioButtonTypeTrue_CheckedChanged);
            // 
            // radioButtonTypeFalse
            // 
            this.radioButtonTypeFalse.AutoSize = true;
            this.radioButtonTypeFalse.Checked = true;
            this.radioButtonTypeFalse.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.radioButtonTypeFalse.Location = new System.Drawing.Point(102, 30);
            this.radioButtonTypeFalse.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonTypeFalse.Name = "radioButtonTypeFalse";
            this.radioButtonTypeFalse.Size = new System.Drawing.Size(70, 29);
            this.radioButtonTypeFalse.TabIndex = 34;
            this.radioButtonTypeFalse.TabStop = true;
            this.radioButtonTypeFalse.Text = "บุคคล";
            this.radioButtonTypeFalse.UseVisualStyleBackColor = true;
            // 
            // comProvince
            // 
            this.comProvince.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.comProvince.FormattingEnabled = true;
            this.comProvince.ItemHeight = 29;
            this.comProvince.Location = new System.Drawing.Point(200, 245);
            this.comProvince.Name = "comProvince";
            this.comProvince.Size = new System.Drawing.Size(280, 35);
            this.comProvince.TabIndex = 53;
            this.comProvince.UseSelectable = true;
            this.comProvince.SelectionChangeCommitted += new System.EventHandler(this.comboBoxProvince_SelectionChangeCommitted);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(136, 255);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 25);
            this.metroLabel2.TabIndex = 54;
            this.metroLabel2.Text = "จังหวัด";
            // 
            // numShare
            // 
            this.numShare.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.numShare.Location = new System.Drawing.Point(199, 368);
            this.numShare.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numShare.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numShare.Name = "numShare";
            this.numShare.Size = new System.Drawing.Size(279, 34);
            this.numShare.TabIndex = 55;
            this.numShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numShare.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numShare.Enter += new System.EventHandler(this.numPrice_Enter);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(115, 377);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(78, 25);
            this.metroLabel5.TabIndex = 56;
            this.metroLabel5.Text = "หุ้นเริ่มต้น";
            // 
            // FormMemberAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 657);
            this.ControlBox = false;
            this.Controls.Add(this.numShare);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.comProvince);
            this.Controls.Add(this.groupBoxMember);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.comDIstrict);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.comSub);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.comVillage);
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
            this.Name = "FormMemberAdd";
            this.Resizable = false;
            this.Text = "เพิ่มข้อมูล";
            this.Load += new System.EventHandler(this.FormExpensesAdd_Load);
            this.groupBoxMember.ResumeLayout(false);
            this.groupBoxMember.PerformLayout();
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numShare)).EndInit();
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
        private MetroFramework.Controls.MetroComboBox comVillage;
        private MetroFramework.Controls.MetroTextBox txtFirstname;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtLastname;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroComboBox comSub;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroComboBox comDIstrict;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.GroupBox groupBoxMember;
        private System.Windows.Forms.RadioButton radioButtonMemberTrue;
        private System.Windows.Forms.RadioButton radioButtonMemberFalse;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.RadioButton radioButtonTypeTrue;
        private System.Windows.Forms.RadioButton radioButtonTypeFalse;
        private MetroFramework.Controls.MetroComboBox comProvince;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.NumericUpDown numShare;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}