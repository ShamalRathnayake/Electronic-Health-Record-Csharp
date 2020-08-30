using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;
using Microsoft.ApplicationBlocks.Data;
using LiveCharts;
using LiveCharts.Wpf;
using SeriesCollection = LiveCharts.SeriesCollection;

namespace EHR
{
    public partial class dashboardControl : UserControl
    {

        MySqlConnection con = new MySqlConnection("Server=localhost;Database=ehr;username=root;password=;");

        public dashboardControl()
        {
            InitializeComponent();


            ShowPieChart();




        }


        private void ShowPieChart()
        {
            String query = "SELECT date,COUNT(id) AS Logins FROM login_attempt GROUP BY date;";
            MySqlDataAdapter adp = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            
            con.Close();

            string[] numbers = new string[dt.Rows.Count];
            string[] dates = new string[dt.Rows.Count];


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dates[i] = dt.Rows[i]["date"].ToString();
                numbers[i] = dt.Rows[i]["Logins"].ToString();
            }






            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            SeriesCollection piechartData = new SeriesCollection { };

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                piechartData.Add(
                                new PieSeries
                                {
                                    Title = dates[i],
                                    Values = new ChartValues<double> { Convert.ToInt32(numbers[i]) },
                                    DataLabels = true,
                                    LabelPoint = labelPoint,
                                     
                                }
                            ) ;

            }

            pieChart1.Series = piechartData;

            pieChart1.LegendLocation = LegendLocation.Right;
            pieChart1.DefaultLegend.Background = System.Windows.Media.Brushes.White;

        }

      
    }
}
