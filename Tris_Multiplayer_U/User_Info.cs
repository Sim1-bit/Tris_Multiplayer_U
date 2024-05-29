using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tris_Multiplayer_U
{
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
    }
    public partial class User_Info : UserControl
    {
        public event EventHandler Pressed;

        private bool exit_click;
        public bool Exit_click
        {
            get => exit_click;
            set => exit_click = value;
        }
        public User_Info()
        {
            InitializeComponent();
        }

        private void Exit_b_Click(object sender, EventArgs e)
        {
            exit_click = true;
            Pressed?.Invoke(this, EventArgs.Empty);
        }
    }
}
