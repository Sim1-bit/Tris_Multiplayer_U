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
            if (Form1.userAccess != null)
                Form1.userAccess = null;
            Form1.client = null;
            exit_click = true;
            Pressed?.Invoke(this, EventArgs.Empty);
        }
    }
}
