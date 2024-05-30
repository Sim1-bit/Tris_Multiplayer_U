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
            if (Username_tb.Text.Contains(' ') || Username_tb.Text.Contains('\t') || Username_tb.Text == "" || Password_tp.Text.Contains('\t') || Password_tp.Text == "" || Password_tp.Text != Password_tp1.Text)
            {
                return;
            }
            Form1.client.Registration(Username_tb.Text, Password_tp.Text, Password_tp1.Text);
            Form1.client.accessRegistration.WaitAsync();
            if (Form1.userAccess != null)
            {
                Registration_click = true;
                Pressed?.Invoke(this, EventArgs.Empty);
            }        
        }
    }
}
