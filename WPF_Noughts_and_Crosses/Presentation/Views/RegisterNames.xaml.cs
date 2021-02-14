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
using WPF_Noughts_and_Crosses.Presentation.Views;

namespace WPF_Noughts_and_Crosses.Presentation.Views
{
    /// <summary>
    /// Interaction logic for RegisterNames.xaml
    /// </summary>
    public partial class RegisterNames : Window
    {
        RegisterNamesModel _registerNamesModel;
        public RegisterNames(RegisterNamesModel registerNamesModel)
        {
            _registerNamesModel = registerNamesModel;
            InitializeComponent();
        }
        private void RegisterNames_Click(object sender, RoutedEventArgs e)
        {
            _registerNamesModel.Register(_playerO.Text, _playerX.Text);

        }
    }
}
