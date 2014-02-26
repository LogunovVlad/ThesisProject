using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Obfuscator.SourceData;
using System.Windows.Forms.DataVisualization.Charting;

namespace Obfuscator
{
    public partial class Statistics : Form
    {
        CObfuscator obf;
        public Statistics()
        {
            InitializeComponent();         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            chart1.Series.Add("Исходный код %");
            chart1.Series.Add("Комментарии %");            
            
            Series plot = chart1.Series[0];          
            Series plot2 = chart1.Series[1];            
          /*  plot.ChartType = SeriesChartType.Pie;
            plot2.ChartType = SeriesChartType.Pie;*/
            plot.Points.Add(550);
            plot2.Points.Add(40);
        }
        
    }
}
