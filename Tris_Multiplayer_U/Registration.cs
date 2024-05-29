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
    public partial class Registration : UserControl
    {
        public event EventHandler Pressed;

        public bool registration_click;
        public bool Registration_click
        {
            get => registration_click;
            set => registration_click = value;
        }
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_b_Click(object sender, EventArgs e)
        {
            registration_click = true;
            Pressed?.Invoke(this, EventArgs.Empty);
        }
    }
}
