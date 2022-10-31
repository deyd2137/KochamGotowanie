using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics;

namespace KochamGotowanie
{
    class CheckUpdate
    {
        public void ChkUpd()
        {
            WebClient webClient = new WebClient();

            try
            {
                if (!webClient.DownloadString("https://pastebin.com/raw/xrmB3SKx").Contains("1.0.1")) ;
                {
                    Process.Start("Updater.exe");
                }
            }
            catch
            {

            }
        }
    }
}
