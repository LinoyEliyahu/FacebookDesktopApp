using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormShowTop10TaggersChart : Form
    {
        private Dictionary<string, int> m_TopUserTaggers = new Dictionary<string, int>();

        public FormShowTop10TaggersChart(Dictionary<string, int> topUserTaggers)
        {
            m_TopUserTaggers = topUserTaggers;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillTopTaggersChart();
            TopTaggersChart.ChartAreas[0].AxisX.Interval = 1;
        }

        private void fillTopTaggersChart()
        {
            foreach (string name in m_TopUserTaggers.Keys)
            {
                TopTaggersChart.Series["Number of Tags"].Points.AddXY(name, m_TopUserTaggers[name]);
            }
        }
    }
}
