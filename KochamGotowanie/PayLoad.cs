using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Threading;
using System.Diagnostics;

namespace KochamGotowanie
{
    class PayLoad
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendString")]
        public static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnString, int hwndCallback);

        public void InsertCoal()
        {
            DialogResult dialog = MessageBox.Show("Do you want to insert coal?", "insert coal", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                try
                {
                    int result = mciSendString("set cdaudio door open", null, 0, 0);
                    Thread.Sleep(3000);
                    result = mciSendString("set cdaudio door close", null, 0, 0);
                }
                catch(Exception ex)
                { }
            }else
            {
                try
                {
                    int result = mciSendString("set cdaudio door open", null, 0, 0);
                    Thread.Sleep(3000);
                    result = mciSendString("set cdaudio door close", null, 0, 0);
                }
                catch (Exception ex)
                { }
            }
        }

        public void PolishHam()
        {
            Thread thread = new Thread(() =>
                {
                Application.Run(new Form2());
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public void DuckHeh()
        {
            Thread thread = new Thread(() =>
            {
                Application.Run(new Form3());
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public void KaczorTrigger()
        {
            Thread thread = new Thread(() =>
            {
                Application.Run(new Form4());
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
       

    }
}
