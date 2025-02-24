using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoWiggle
{
    public partial class AutoWiggle : Form
    {
        // Mouse movement and detection
        [DllImport("user32.dll", SetLastError = true)]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        // Mouse constants
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;

        public static void mouseMoveDelta(int x, int y)
        {
            mouse_event(MOUSEEVENTF_MOVE, (uint)x, (uint)y, 0, 0);
        }

        int frequency = 60;
        int movement = 5;

        Point lastPos = new Point();
        DateTime lastTime = DateTime.Now;

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

        private async void AutoWiggle_Load(object sender, EventArgs e)
        {
            while (true)
            {
                if (Cursor.Position != lastPos)
                {
                    lastPos = Cursor.Position;
                    lastTime = DateTime.Now;
                }

                if (DateTime.Now > lastTime.AddSeconds(frequency))
                {
                    Random rnd = new Random();

                    for (int i = 0; i < 100; i++)
                    {
                        mouseMoveDelta(rnd.Next(10), rnd.Next(10) - 5);
                        await Task.Delay(10);
                    }

                    lastPos = Cursor.Position;
                    lastTime = DateTime.Now;
                }

                await Task.Delay(1);
            }
        }
    }
}
