using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ResourcesWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow dlg = new MainWindow();
            dlg.ShowDialog();
        }

        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    ResourcesWithCodeBehind dlg = new ResourcesWithCodeBehind();
        //    dlg.ShowDialog();
        //}
    }
}
