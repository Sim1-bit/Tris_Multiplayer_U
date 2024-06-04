using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tris_Multiplayer_U
{
    public partial class Game : UserControl
    {
        public static bool Turn;
        public class Tris_Button : Button
        {
            private bool? color;
            public bool? Color
            {
                get => color;
                set
                {
                    color = color == null || value == null ? value : color;
                    if (color == null)
                    {
                        BackColor = System.Drawing.Color.White;
                        ForeColor = System.Drawing.Color.White;
                    }
                    else if ((bool)color)
                    {
                        BackColor = System.Drawing.Color.Red;
                        ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        BackColor = System.Drawing.Color.Blue;
                        ForeColor = System.Drawing.Color.Blue;
                    }
                }
            }
            public Tris_Button(Point aux)
            {
                Visible = true;
                Size = new Size(100, 100);
                Text = "";
                Location = new Point(aux.X, aux.Y);
                Color = null;
            }
        }
        public Tris_Button[,] table = new Tris_Button[0, 0];
        public Game()
        {
            InitializeComponent();
            Clear();
        }

        public void Button_Clicked(object sender, EventArgs e)
        {
            if ((sender as Tris_Button).Color == null)
                (sender as Tris_Button).Color = true;
            else
                return;
            //Cerco gli indici
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (table[i, j] == sender)
                    {
                        object aux = Form1.client.Move(i, j);
                        if ((aux as int[]) != null)
                        {
                            ChangeColor((aux as int[])[0], (aux as int[])[1]);
                        }
                        else
                            MessageBox.Show((aux as bool?).ToString());
                        return;
                    }
                }
            }
        }

        public void ChangeColor(int x, int y)
        {
            table[x, y].Color = false;
        }

        public void Clear()
        {
            foreach(var i  in table)
                this.Controls.Remove(i);

            table = new Tris_Button[3, 3];

            Point aux = new Point(0, 0);
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    aux = new Point(3 * (i * 2 + 1) + 100 * i, 3 * (j * 2 + 1) + 100 * j);
                    table[i, j] = new Tris_Button(aux);
                    table[i, j].Click += Button_Clicked;
                    this.Controls.Add(table[i, j]);
                }
            }
        }
    }
}
