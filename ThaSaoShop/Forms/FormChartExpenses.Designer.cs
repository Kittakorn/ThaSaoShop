namespace ThaSaoShop.Forms
{
    partial class FormChartExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChartExpenses));
            this.btnExit = new MetroFramework.Controls.MetroLink();
            this.ChartExpenses = new LiveCharts.WinForms.CartesianChart();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.checkedListCate = new System.Windows.Forms.CheckedListBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Image = global::ThaSaoShop.Properties.Resources.cancel_30px;
            this.btnExit.ImageSize = 30;
            this.btnExit.Location = new System.Drawing.Point(1113, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 33);
            this.btnExit.TabIndex = 17;
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ChartExpenses
            // 
            this.ChartExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartExpenses.Location = new System.Drawing.Point(0, 0);
            this.ChartExpenses.Name = "ChartExpenses";
            this.ChartExpenses.Size = new System.Drawing.Size(923, 617);
            this.ChartExpenses.TabIndex = 18;
            this.ChartExpenses.Text = "cartesianChart1";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.checkedListCate);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 617);
            this.metroPanel1.TabIndex = 20;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // checkedListCate
            // 
            this.checkedListCate.CheckOnClick = true;
            this.checkedListCate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListCate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListCate.FormattingEnabled = true;
            this.checkedListCate.Location = new System.Drawing.Point(0, 0);
            this.checkedListCate.Name = "checkedListCate";
            this.checkedListCate.Size = new System.Drawing.Size(200, 617);
            this.checkedListCate.TabIndex = 2;
            this.checkedListCate.SelectedValueChanged += new System.EventHandler(this.checkedListCate_SelectedValueChanged);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.ChartExpenses);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(220, 60);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(923, 617);
            this.metroPanel2.TabIndex = 21;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // FormChartExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 697);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FormChartExpenses";
            this.Resizable = false;
            this.Text = "ยอดค่าใช้จ่ายเบ็ดเตล็ด";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLink btnExit;
        private LiveCharts.WinForms.CartesianChart ChartExpenses;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.CheckedListBox checkedListCate;
    }
}