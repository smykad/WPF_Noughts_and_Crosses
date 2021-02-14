using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Noughts_and_Crosses.Business;
using WPF_Noughts_and_Crosses.Models;

namespace WPF_Noughts_and_Crosses.Presentation.ViewModels
{
    public class GameViewModel: ObservableObject
    {
        #region Fields

        private GameBusiness _gameBusiness;

        private Gameboard _gameboard;
        private (Player playerOne, Player playerTwo) _currentPlayers;
        private Player _playerX;
        private Player _playerO;
        private string _messageBoxContent;

        #endregion

        #region Properties
        public Gameboard Gameboard
        {
            get { return _gameboard; }
            set
            {
                _gameboard = value;
                OnPropertyChanged(nameof(Gameboard));
            }
        }

        public Player PlayerX
        {
            get { return _playerX; }
            set
            {
                _playerX = value;
                OnPropertyChanged(nameof(PlayerX));
            }
        }

        public Player PlayerO
        {
            get { return _playerO; }
            set
            {
                _playerO = value;
                OnPropertyChanged(nameof(PlayerO));
            }
        }

        public string MessageBoxContent
        {
            get { return _messageBoxContent; }
            set
            {
                _messageBoxContent = value;
                OnPropertyChanged(nameof(MessageBoxContent));
            }
        }

        #endregion

        #region Constructors
        public GameViewModel()
        {

            _gameBusiness = new GameBusiness();

            InitializeGame();
        }

        #endregion

        #region Methods
        private void InitializeGame()
        {
            _currentPlayers = _gameBusiness.GetCurrentPlayers();

            _playerX = _currentPlayers.playerOne;
            _playerO = _currentPlayers.playerTwo;


            _gameboard = new Gameboard();

            _gameboard.CurrentRoundState = Gameboard.GameboardState.PlayerXTurn;
            MessageBoxContent = "Player X Moves";
        }

        public void PlayerMove(int row, int column)
        {
            if (_gameboard.GameboardPositionAvailable(new GameboardPosition(row, column)))
            {
                if (_gameboard.CurrentRoundState == Gameboard.GameboardState.PlayerXTurn)
                {
                    Gameboard.CurrentBoard[row][column] = Gameboard.PLAYER_PIECE_X;
                    OnPropertyChanged(nameof(Gameboard));
                    _gameboard.CurrentRoundState = Gameboard.GameboardState.PlayerOTurn;
                    MessageBoxContent = "Player O Moves";
                }
                else
                {
                    Gameboard.CurrentBoard[row][column] = Gameboard.PLAYER_PIECE_O;
                    OnPropertyChanged(nameof(Gameboard));
                    _gameboard.CurrentRoundState = Gameboard.GameboardState.PlayerXTurn;
                    MessageBoxContent = "Player X Moves";
                }
                UpdateCurrentRoundState();
            }
        }

        internal void GameCommand(string commandName)
        {
            switch (commandName)
            {
                case "NewGame":
                    _gameboard.InitializeGameboard();
                    OnPropertyChanged(nameof(Gameboard));

                    _gameboard.CurrentRoundState = Gameboard.GameboardState.PlayerXTurn;
                    MessageBoxContent = "Player X Moves";
                    break;

                case "ResetGame":
                    ResetGame();
                    break;

                case "Quit":

                    break;

                default:
                    // add code to handle exception
                    break;
            }
        }

        public void UpdateCurrentRoundState()
        {
            _gameboard.UpdateGameboardState();
            if (_gameboard.CurrentRoundState == Gameboard.GameboardState.CatsGame)
            {
                PlayerO.Ties++;
                PlayerX.Ties++;
                MessageBoxContent = "Cat Game";
            }
            else if (_gameboard.CurrentRoundState == Gameboard.GameboardState.PlayerXWin)
            {
                PlayerX.Wins++;
                PlayerO.Losses++;
                MessageBoxContent = "Player X Wins!";
            }
            else if (_gameboard.CurrentRoundState == Gameboard.GameboardState.PlayerOWin)
            {
                PlayerO.Wins++;
                PlayerX.Losses++;
                MessageBoxContent = "Player O Wins!";
            }
        }

        internal void ResetGame()
        {
            _gameboard.InitializeGameboard();
            OnPropertyChanged(nameof(Gameboard));

            _gameboard.CurrentRoundState = Gameboard.GameboardState.PlayerXTurn;
            MessageBoxContent = "Player X Moves";
            PlayerX.Wins = 0;
            PlayerO.Wins = 0;
            PlayerX.Ties = 0;
            PlayerO.Ties = 0;
            PlayerX.Losses = 0;
            PlayerO.Losses = 0;
        }

        #endregion
    }
}
