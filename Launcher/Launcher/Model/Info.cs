using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Net;

namespace Launcher.Model
{
    public class Info
    {
        public string launcherURL = "http://198.27.120.46/Launcher";
        private string launcherParam = "PARAMENTRO_DO_MAIN";
        public List<Arquivos> fileInfo { get; set; }

        
        public string getJson(int type)
        {
            using (var client = new WebClient())
            {
                try
                {

                    if (type == 0)
                    {
                        return client.DownloadString(launcherURL + "/files.json");
                    }
                    else if (type == 1)
                    {
                        return client.DownloadString(launcherURL + "/news.json");
                    }
                    else
                    {
                        return client.DownloadString(launcherURL + "/online.txt");
                    }

                }
                catch(Exception ex)
                {
                    Log.log(ex.Message.ToString());
                    return null;
                }
            }
        }
    }
}
