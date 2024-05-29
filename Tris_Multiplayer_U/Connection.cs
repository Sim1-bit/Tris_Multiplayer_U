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
    public partial class Connection : UserControl
    {
        public event EventHandler Pressed;
        private bool connection_click;
        public bool Connection_click
        {
            get => connection_click;
            set => connection_click = value;
        }
        public Connection()
        {
            InitializeComponent();
        }

        private void connection_b_Click(object sender, EventArgs e)
        {
            Connection_click = true;
            Pressed?.Invoke(this, EventArgs.Empty);
        }
    }
}
