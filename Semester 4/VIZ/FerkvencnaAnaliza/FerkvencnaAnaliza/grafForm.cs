using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FerkvencnaAnaliza
{
    public partial class grafForm : Form
    {
        public grafForm(Datoteka dat)
        {
            InitializeComponent();
            graf.ChartAreas[0].AxisX.Interval = 1;
            foreach (var par in dat.ferkvencnaAnaliza)
            {
                graf.Series["znaki"].Points.Add(par.Value).AxisLabel = ((char)par.Key).ToString();
            }
            
        }
    }
}
