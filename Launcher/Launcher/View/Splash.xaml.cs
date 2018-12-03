using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading;
using Launcher.Model;


namespace Launcher
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Show();
            Thread.Sleep(1000);
            Log.log("Splash iniciado...");
            Info status = new Info();
            string jsonData = status.getJson(0);
            if(jsonData == null)
            {
                MessageBox.Show("Sem conexão!", "Sem conexão!");
            }
        }
    }
}
