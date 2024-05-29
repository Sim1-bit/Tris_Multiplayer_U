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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            access1.Pressed += Change_User;
            registration1.Pressed += Change_User;
            user_Info1.Pressed += Change_User;
            connection1.Pressed += Change_User;
        }


        public void Change_User(object sender, EventArgs e)
        {
            if (sender is Access)
                Action(sender as Access);
            else if (sender is Registration)
                Action(sender as Registration);
            else if (sender is User_Info)
                Action(sender as User_Info);
            else if (sender is Connection)
                Action(sender as Connection);
            else if (sender is Game)
            {
            }
        }
        private void Action(Access sender)
        {
            if (sender.Access_click)
            {
                sender.Access_click = false;

                sender.Visible = false;

                user_Info1.Visible = true;
                connection1.Visible = true;
            }
            else if (sender.Registration_click)
            {
                sender.Registration_click = false;

                sender.Visible = false;

                registration1.Visible = true;
            }
        }
        private void Action(Registration sender)
        {
            if (sender.Registration_click)
            {
                sender.Registration_click = false;

                sender.Visible = false;

                user_Info1.Visible = true;
                connection1.Visible = true;
            }
        }
        private void Action(User_Info sender)
        {
            if (sender.Exit_click)
            {
                sender.Exit_click = false;

                sender.Visible = false;
                connection1.Visible = false;
                game1.Visible = false;

                access1.Visible = true;
            }
        }
        private void Action(Connection sender)
        {
            if (sender.Connection_click)
            {
                sender.Connection_click = false;

                if (game1.Visible)
                    game1.Clear();
                game1.Visible = !game1.Visible;
                
            }
        }
    }
}
