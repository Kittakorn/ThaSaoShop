using LiveCharts;
using LiveCharts.Wpf;
using MetroFramework.Forms;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ThaSaoShop.Models;
using ThaSaoShop.Models.View;

namespace ThaSaoShop.Forms
{
    public partial class FormChartSell : MetroForm
    {
        private List<ViewSellOrBuy> viewSells;
        public FormChartSell(List<ViewSellOrBuy> viewSells, bool isBuy = true)
        {
            InitializeComponent();
            Text = !isBuy ? "ยอดขายสินค้า" : "ยอดซื้อสินค้า";
            this.viewSells = viewSells;
            ShowAll();
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        private void ShowAll()
        {
            chartSell.Series.Clear();
            List<string> monthName = Enumerable.Range(1, 12).Select(x => new DateTime(DateTime.Now.Year, x, 1).ToString("MMMM")).ToList();
            chartSell.AxisX.Add(new Axis
            {
                Title = "เดือน",
                FontSize = 15,
                Labels = monthName,
            });
            chartSell.AxisY.Add(new Axis
            {
                Title = "จำนวนเงิน",
                FontSize = 15,
                LabelFormatter = value => value.ToString("N0")
            });
            SeriesCollection series = new SeriesCollection();
            var years = viewSells.GroupBy(x => x.Date.Year).Select(x => new { x.Key }).ToList();
            foreach (var year in years)
            {
                List<int> values = new List<int>();
                for (int month = 1; month <= 12; month++)
                {
                    var data = viewSells.Where(x => x.Date.Year == year.Key && x.Date.Month == month)
                        .Select(x => new
                        {
                            total = x.Total
                        }).ToList();

                    values.Add(data.Sum(x => x.total));
                }
                series.Add(new LineSeries() { Title = new DateTime(year.Key, 1, 1).ToString("yyyy"), Values = new ChartValues<int>(values) });
            }
            chartSell.LegendLocation = LegendLocation.Right;
            chartSell.Series = series;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
