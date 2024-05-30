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
        public User(User aux)
        {
            Username = aux.Username;
            Password = aux.Password;
            Win = aux.Win;
            Lose = aux.Lose;
            Tie = aux.Tie;
        }
    }
}
