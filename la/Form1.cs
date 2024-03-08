using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double usd, euro;
        const double k = 0.02;
        bool start = true;
        Random random = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            usd = usd * (1 + k * (random.NextDouble() - 0.5));
            euro = euro * (1 + k * (random.NextDouble() - 0.5));
            chart1.Series[0].Points.AddXY(0, usd);
            chart1.Series[1].Points.AddXY(0, euro);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            usd = (double)NumUSD.Value;
            euro = (double)NumEuro.Value;

            if (start)
            {
                start = false;
                timer1.Start();
            }
            else
            {
                start = true;
                timer1.Stop();
            }
        }
    }
}
