namespace ThaSaoShop.Forms
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.rdRoleTrue = new MetroFramework.Controls.MetroRadioButton();
            this.rdRoleFalse = new MetroFramework.Controls.MetroRadioButton();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.txtFirstname = new MetroFramework.Controls.MetroTextBox();
            this.txtLastname = new MetroFramework.Controls.MetroTextBox();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.lbPhone = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.btnExit = new MetroFramework.Controls.MetroLink();
            this.lbEnable = new MetroFramework.Controls.MetroLabel();
            this.tgEnable = new MetroFramework.Controls.MetroToggle();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(131, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ชื่อผู้ใช้";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(160, 102);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(33, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "ชื่อ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(122, 138);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "นามสกุล";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(89, 174);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(104, 25);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "เบอร์โทรศัพท์";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(125, 224);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(68, 25);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "ตำแหน่ง";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(366, 213);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(0, 0);
            this.metroLabel6.TabIndex = 7;
            // 
            // rdRoleTrue
            // 
            this.rdRoleTrue.AutoSize = true;
            this.rdRoleTrue.Checked = true;
            this.rdRoleTrue.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rdRoleTrue.Location = new System.Drawing.Point(199, 224);
            this.rdRoleTrue.Name = "rdRoleTrue";
            this.rdRoleTrue.Size = new System.Drawing.Size(91, 25);
            this.rdRoleTrue.TabIndex = 8;
            this.rdRoleTrue.TabStop = true;
            this.rdRoleTrue.Text = "เจ้าหน้าที่";
            this.rdRoleTrue.UseSelectable = true;
            // 
            // rdRoleFalse
            // 
            this.rdRoleFalse.AutoSize = true;
            this.rdRoleFalse.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rdRoleFalse.Location = new System.Drawing.Point(199, 255);
            this.rdRoleFalse.Name = "rdRoleFalse";
            this.rdRoleFalse.Size = new System.Drawing.Size(87, 25);
            this.rdRoleFalse.TabIndex = 9;
            this.rdRoleFalse.Text = "พนักงาน";
            this.rdRoleFalse.UseSelectable = true;
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(252, 2);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(199, 60);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.ShowClearButton = true;
            this.txtUsername.Size = new System.Drawing.Size(280, 30);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMark = "กรุณากรอกข้อมูล";
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtFirstname.Location = new System.Drawing.Point(199, 97);
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
            this.txtFirstname.TabIndex = 2;
            this.txtFirstname.UseSelectable = true;
            this.txtFirstname.WaterMark = "กรุณากรอกข้อมูล";
            this.txtFirstname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirstname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtLastname.Location = new System.Drawing.Point(199, 133);
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
            this.txtLastname.TabIndex = 3;
            this.txtLastname.UseSelectable = true;
            this.txtLastname.WaterMark = "กรุณากรอกข้อมูล";
            this.txtLastname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(252, 2);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(199, 169);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.ShowClearButton = true;
            this.txtPhone.Size = new System.Drawing.Size(280, 30);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMark = "กรุณากรอกข้อมูล";
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(199, 202);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(190, 19);
            this.lbPhone.TabIndex = 16;
            this.lbPhone.Text = "ใช้เบอร์โทรศัพท์เป็นรหัสผ่านเริ่มต้น";
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.Location = new System.Drawing.Point(399, 309);
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
            // lbEnable
            // 
            this.lbEnable.AutoSize = true;
            this.lbEnable.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbEnable.Location = new System.Drawing.Point(136, 278);
            this.lbEnable.Name = "lbEnable";
            this.lbEnable.Size = new System.Drawing.Size(57, 25);
            this.lbEnable.TabIndex = 14;
            this.lbEnable.Text = "สถานะ";
            this.lbEnable.Visible = false;
            // 
            // tgEnable
            // 
            this.tgEnable.AutoSize = true;
            this.tgEnable.Checked = true;
            this.tgEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tgEnable.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.tgEnable.Location = new System.Drawing.Point(199, 286);
            this.tgEnable.Name = "tgEnable";
            this.tgEnable.Size = new System.Drawing.Size(80, 17);
            this.tgEnable.Style = MetroFramework.MetroColorStyle.Green;
            this.tgEnable.TabIndex = 15;
            this.tgEnable.TabStop = false;
            this.tgEnable.Text = "On";
            this.tgEnable.UseSelectable = true;
            this.tgEnable.Visible = false;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 410);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.tgEnable);
            this.Controls.Add(this.lbEnable);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.rdRoleFalse);
            this.Controls.Add(this.rdRoleTrue);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FormUser";
            this.Resizable = false;
            this.Text = "เพิ่มข้อมูล";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroRadioButton rdRoleTrue;
        private MetroFramework.Controls.MetroRadioButton rdRoleFalse;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroTextBox txtFirstname;
        private MetroFramework.Controls.MetroTextBox txtLastname;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroLabel lbPhone;
        private MetroFramework.Controls.MetroLink btnExit;
        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroLabel lbEnable;
        private MetroFramework.Controls.MetroToggle tgEnable;
    }
}