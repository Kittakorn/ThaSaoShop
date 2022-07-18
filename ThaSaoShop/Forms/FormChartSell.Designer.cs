namespace ThaSaoShop.Forms
{
    partial class FormChartSell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChartSell));
            this.btnExit = new MetroFramework.Controls.MetroLink();
            this.chartSell = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Image = global::ThaSaoShop.Properties.Resources.cancel_30px;
            this.btnExit.ImageSize = 30;
            this.btnExit.Location = new System.Drawing.Point(949, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 33);
            this.btnExit.TabIndex = 17;
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chartSell
            // 
            this.chartSell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartSell.Location = new System.Drawing.Point(20, 60);
            this.chartSell.Name = "chartSell";
            this.chartSell.Size = new System.Drawing.Size(960, 520);
            this.chartSell.TabIndex = 18;
            this.chartSell.Text = "cartesianChart1";
            // 
            // FormSellChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ControlBox = false;
            this.Controls.Add(this.chartSell);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FormSellChart";
            this.Resizable = false;
            this.Text = "ยอดขาย";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLink btnExit;
        private LiveCharts.WinForms.CartesianChart chartSell;
    }
}