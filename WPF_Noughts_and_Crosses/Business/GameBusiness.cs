using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Noughts_and_Crosses.Models;

namespace WPF_Noughts_and_Crosses.Business
{
    public class GameBusiness
    {
        public enum GameStatus
        {
            QUIT,
            QUIT_SAVE
        }

        List<Player> _allPlayers;

        Player _playerOne;
        Player _playerTwo;

        public GameBusiness()
        {
            InitializeGame();
        }

        private void InitializeGame()
        {

            _allPlayers = new List<Player>()
            {
                new Player()
                {
                    Name = "Darth",
                    Wins = 0,
                    Losses = 0,
                    Ties = 0
                },

                new Player()
                {
                    Name = "Leia",
                    Wins = 0,
                    Losses = 0,
                    Ties = 0
                }
            };

            //
            // choose players for games and add to the tuple
            //
            //_playerOne = _allPlayers.FirstOrDefault(p => p.Name == "Darth");
            //_playerTwo = _allPlayers.FirstOrDefault(p => p.Name == "Leia");
        }


        public (Player playerOne, Player playerTwo) GetCurrentPlayers()
        {
            //
            // choose players for games and add to the tuple
            //
            _playerOne = _allPlayers.FirstOrDefault(p => p.Name == "Darth");
            _playerTwo = _allPlayers.FirstOrDefault(p => p.Name == "Leia");
            (Player playerOne, Player playerTwo) currentPlayers = (_playerOne, _playerTwo);

            return currentPlayers;
        }
    }
}
