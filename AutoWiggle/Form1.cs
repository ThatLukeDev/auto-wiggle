using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoWiggle
{
    public partial class AutoWiggle : Form
    {
        int frequency = 60;

        public AutoWiggle()
        {
            InitializeComponent();
        }

        private void slider_Scroll(object sender, EventArgs e)
        {
            switch (slider.Value)
            {
                case 0:
                    frequency = 5;
                    break;
                case 1:
                    frequency = 10;
                    break;
                case 2:
                    frequency = 30;
                    break;
                case 3:
                    frequency = 60;
                    break;
                case 4:
                    frequency = 120;
                    break;
                case 5:
                    frequency = 300;
                    break;
                case 6:
                    frequency = 600;
                    break;
            }

            int mins = frequency / 60;

            if (mins > 0)
                amount.Text = $"Timer: {mins} mins";
            else
                amount.Text = $"Timer: {frequency} secs";
        }
    }
}
