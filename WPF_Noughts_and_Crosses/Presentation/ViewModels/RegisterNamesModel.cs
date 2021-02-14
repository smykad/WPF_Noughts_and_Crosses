using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using WPF_Noughts_and_Crosses.Presentation.ViewModels;
using WPF_Noughts_and_Crosses.Presentation.Views;

namespace WPF_Noughts_and_Crosses.Presentation.ViewModels
{
    public class RegisterNamesModel : ObservableObject
    {
        #region Fields

        private string _message;

        #endregion

        #region Properties
        public string MessageContext
        {
            get => _message;
            set
            {
                _message = value;
                OnPropertyChanged(nameof(MessageContext));
            }
        }

        #endregion

        #region Methods

        public void Register(string playerO, string playerX)
        {
            Regex rx = new Regex(@"^(?=[a-zA-Z])[-\w.]{0,23}([a-zA-Z\d]|(?<![-.])_)$");
            bool isValidPlayerO = rx.IsMatch(playerO);
            bool isValidPlayerX = rx.IsMatch(playerX);

            if (!isValidPlayerX)
            {
                MessageContext = "Invalid Player Name";
                
            }
            if (!isValidPlayerO)
            {
                _message = "Invalid Player Name";
                OnPropertyChanged(nameof(MessageContext));
            }

            if (isValidPlayerO && isValidPlayerX)
            {
                _message = null;
                InitializeGame(playerO, playerX);
                foreach (Window item in Application.Current.Windows)
                {
                    if (item.DataContext == this) item.Close();
                }
            }
        }
        public void InitializeGame(string playerO, string playerX)
        {
            GameViewModel gameViewModel = new GameViewModel();
            GameView gameView = new GameView(gameViewModel);
            gameView.DataContext = gameViewModel;

            gameViewModel.PlayerX.Name = playerX;
            gameViewModel.PlayerO.Name = playerO;
            gameView.Show();
        }

        #endregion

        #region Constructor

        public RegisterNamesModel()
        {

        }

        #endregion

    }
}
