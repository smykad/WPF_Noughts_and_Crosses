using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF_Noughts_and_Crosses.Presentation.ViewModels;

namespace WPF_Noughts_and_Crosses.Presentation.Views
{
    /// <summary>
    /// Interaction logic for StartingScreen.xaml
    /// </summary>
    public partial class StartingScreen : Window
    {
        public StartingScreen()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RegisterNamesModel registerNamesModel = new RegisterNamesModel();
            RegisterNames registerNames = new RegisterNames(registerNamesModel);
            registerNames.DataContext = registerNamesModel;
            registerNames.Show();
            this.Close();
        }

        private void ButtonQuit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
