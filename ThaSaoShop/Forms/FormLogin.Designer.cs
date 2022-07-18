namespace ThaSaoShop.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lbUsername = new MetroFramework.Controls.MetroLabel();
            this.lbPassword = new MetroFramework.Controls.MetroLabel();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.txtPassoword = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.btnSetting = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbUsername.Location = new System.Drawing.Point(73, 68);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(88, 25);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "ชื่อผู้ใช้งาน";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbPassword.Location = new System.Drawing.Point(90, 104);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(71, 25);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "รหัสผ่าน";
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
            this.txtUsername.Location = new System.Drawing.Point(167, 63);
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
            // txtPassoword
            // 
            // 
            // 
            // 
            this.txtPassoword.CustomButton.Image = null;
            this.txtPassoword.CustomButton.Location = new System.Drawing.Point(252, 2);
            this.txtPassoword.CustomButton.Name = "";
            this.txtPassoword.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPassoword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassoword.CustomButton.TabIndex = 1;
            this.txtPassoword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassoword.CustomButton.UseSelectable = true;
            this.txtPassoword.CustomButton.Visible = false;
            this.txtPassoword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPassoword.Lines = new string[0];
            this.txtPassoword.Location = new System.Drawing.Point(167, 99);
            this.txtPassoword.MaxLength = 20;
            this.txtPassoword.Name = "txtPassoword";
            this.txtPassoword.PasswordChar = '●';
            this.txtPassoword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassoword.SelectedText = "";
            this.txtPassoword.SelectionLength = 0;
            this.txtPassoword.SelectionStart = 0;
            this.txtPassoword.ShortcutsEnabled = true;
            this.txtPassoword.Size = new System.Drawing.Size(280, 30);
            this.txtPassoword.TabIndex = 2;
            this.txtPassoword.UseSelectable = true;
            this.txtPassoword.UseSystemPasswordChar = true;
            this.txtPassoword.WaterMark = "กรุณากรอกข้อมูล";
            this.txtPassoword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassoword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnLogin
            // 
            this.btnLogin.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLogin.Highlight = true;
            this.btnLogin.Location = new System.Drawing.Point(332, 135);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 39);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "เข้าสู่ระบบ";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSetting.Location = new System.Drawing.Point(167, 135);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(115, 39);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.TabStop = false;
            this.btnSetting.Text = "ตั้งค่า";
            this.btnSetting.UseSelectable = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 240);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassoword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FormLogin";
            this.Resizable = false;
            this.Text = "ลงชื่อเข้าใช้งาน";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbUsername;
        private MetroFramework.Controls.MetroLabel lbPassword;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroTextBox txtPassoword;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroButton btnSetting;
    }
}