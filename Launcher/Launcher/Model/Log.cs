using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Launcher.Model
{
    /// <summary>
    /// Metodo que recebe os erros
    /// </summary>
    public class Log
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensagem">Variavel que recebe a mensagem</param>
        public static void log(string mensagem)
        {
            if(Directory.Exists("Log"))
            {
                StreamWriter logger;
                logger = File.AppendText(@"Log\" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt");
                logger.WriteLine("[" + DateTime.Now + "]" + "" + mensagem);
                logger.Close();
            }
            else
            {
                Directory.CreateDirectory("Log");

                StreamWriter logger;
                logger = File.AppendText(@"Log\" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt");
                logger.WriteLine("[" + DateTime.Now + "]" + "" + mensagem);
                logger.Close();
            }
             

                
        }
    }
}
