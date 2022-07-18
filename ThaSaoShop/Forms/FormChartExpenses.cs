using LiveCharts;
using LiveCharts.Wpf;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ThaSaoShop.Models;
using ThaSaoShop.Models.StoredProcedure;

namespace ThaSaoShop.Forms
{
    public partial class FormChartExpenses : MetroForm
    {
        StoreEntities db = new StoreEntities();
        SeriesCollection series = new SeriesCollection();
        public FormChartExpenses(DateTime dateFrom, DateTime dateTo)
        {
            InitializeComponent();
            ShowData(dateFrom, dateTo);
        }

        private void ShowData(DateTime dateFrom, DateTime dateTo)
        {
            ChartExpenses.Series.Clear();
            ChartExpenses.DataTooltip.Visibility = Visibility.Hidden;

            object[] sqlParams =
            {
                new SqlParameter("@startdate", dateFrom.Date),
                new SqlParameter("@enddate", dateTo.Date),
                new SqlParameter("@cate", 1),
            };
            var expenses = db.Database
                .SqlQuery<SPExpenses>("dbo.SPExpenses @startdate, @enddate, @cate", sqlParams).ToList();


            ChartExpenses.AxisY.Add(new Axis
            {
                Title = "ค่าใช้จ่าย",
                FontSize = 15,
                LabelFormatter = value => value.ToString("N0"),
                Foreground = Brushes.Black
            });
            ChartExpenses.AxisX.Add(new Axis
            {
                Title = null,
                ShowLabels = false
            });

            ChartExpenses.LegendLocation = LegendLocation.Right;
            foreach (var item in expenses)
            {
                series.Add(new ColumnSeries
                {
                    DataLabels = true,
                    MaxColumnWidth = double.MaxValue,
                    LabelPoint = point => point.Y.ToString("N0"),
                    Title = $"{item.Name}",
                    FontSize = 15,
                    Values = new ChartValues<int> { item.Total },
                });
            }

            ChartExpenses.Series = series;
            foreach (var item in expenses)
            {
                checkedListCate.Items.Add(item.Name);
            }

            for (int i = 0; i < checkedListCate.Items.Count; i++)
            {
                checkedListCate.SetItemChecked(i, true);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkedListCate_SelectedValueChanged(object sender, EventArgs e)
        {
            var index = checkedListCate.SelectedIndex;
            if (series.Count > 0)
            {
                ColumnSeries seriesToHide = (series[index] as ColumnSeries);
                seriesToHide.Visibility = seriesToHide.Visibility == Visibility.Visible
                    ? Visibility.Hidden
                    : Visibility.Visible;
            }

        }
    }
}