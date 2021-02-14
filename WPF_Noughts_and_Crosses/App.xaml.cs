using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF_Noughts_and_Crosses.Presentation.Views;

namespace WPF_Noughts_and_Crosses
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            StartingScreen startingScreen = new StartingScreen();
            startingScreen.Show();
        }
    }
}
