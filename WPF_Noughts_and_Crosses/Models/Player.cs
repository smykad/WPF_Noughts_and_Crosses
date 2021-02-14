﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Noughts_and_Crosses.Models
{
    public class Player: ObservableObject
    {
        #region Fields
               
        private string _name;
        private int _wins;
        private int _Losses;
        private int _ties;

        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public int Wins
        {
            get { return _wins; }
            set
            {
                _wins = value;
                OnPropertyChanged(nameof(Wins));
            }
        }

        public int Losses
        {
            get { return _Losses; }
            set
            {
                _Losses = value;
                OnPropertyChanged(nameof(Losses));
            }
        }

        public int Ties
        {
            get { return _ties; }
            set
            {
                _ties = value;
                OnPropertyChanged(nameof(Ties));
            }
        }
        #endregion
    }
}
