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
    public partial class Access : UserControl
    {
        public event EventHandler Pressed;

        private bool access_click;
        public bool Access_click
        {
            get => access_click;
            set => access_click = value;
        }

        public bool registration_click;
        public bool Registration_click
        {
            get => registration_click;
            set => registration_click = value;
        }

        public Access()
        {
            InitializeComponent();
        }

        private void Access_b_Click(object sender, EventArgs e)
        {
            if(Username_tb.Text.Contains(' ') || Username_tb.Text.Contains('\t') || Username_tb.Text == "" || Password_tp.Text.Contains('\t') || Password_tp.Text == "")
            {
                return;
            }
            Form1.client.Access(Username_tb.Text, Password_tp.Text);
            //Form1.client.accessRegistration.WaitAsync();
            if(Form1.userAccess != null)
            {
                Access_click = true;
                Pressed?.Invoke(this, EventArgs.Empty);
            }
        }

        private void Registration_b_Click(object sender, EventArgs e)
        {
            registration_click = true;
            Pressed?.Invoke(this, EventArgs.Empty);
        }
    }
}
