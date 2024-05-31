﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tris_Multiplayer_U
{
    [Serializable]
    public class User
    {
        public readonly string Username;
        public readonly string Password;

        private int win;
        public int Win
        {
            get => win;
            set => win = value >= 0 ? value : 0;
        }
        private int lose;
        public int Lose
        {
            get => lose;
            set => lose = value >= 0 ? value : 0;
        }
        private int tie;
        public int Tie
        {
            get => tie;
            set => tie = value >= 0 ? value : 0;
        }

        public User()
        {

        }

        public User(string name, string password)
        {
            this.Username = name;
            this.Password = password;
            Win = 0;
            Lose = 0;
            Tie = 0;
        }

        public User(string name, string password, int win, int lose, int tie)
        {
            this.Username = name;
            this.Password = password;
            Win = win;
            Lose = lose;
            Tie = tie;
        }

        public User(User aux)
        {
            Username = aux.Username;
            Password = aux.Password;
            Win = aux.Win;
            Lose = aux.Lose;
            Tie = aux.Tie;
        }

        public User(string[] aux)
        {
            Username = aux[0];
            Password = aux[1];
            Win = Convert.ToInt32(aux[2]);
            Lose = Convert.ToInt32(aux[3]);
            Tie = Convert.ToInt32(aux[4]);
        }

        public bool IsAux
        {
            get => Username == "";
        }
    }
}
