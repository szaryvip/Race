using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race
{
    public partial class Form1 : Form
    {
        private Line line1;
        private Line line_m;
        private Car Player = new Car();
        private Enemy ene1 = new Enemy(335,15);
        private Enemy ene2 = new Enemy(205,118);
        private Enemy ene3 = new Enemy(455,221);
        private Enemy ene4 = new Enemy(605,324);
        private bool game_active = true;
        public Form1()
        {
            InitializeComponent();
            line1 = new Line(0, 100);
            line_m = new Line(775, 0, 5,409);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (game_active)
            {
                game_panel.CreateGraphics().Clear(Color.Black);
                line1.draw(game_panel.CreateGraphics(), new SolidBrush(Color.White));               
                line_m.draw(game_panel.CreateGraphics(), new SolidBrush(Color.Aqua));
                ene1.draw(game_panel.CreateGraphics(), new SolidBrush(Color.Yellow));
                ene2.draw(game_panel.CreateGraphics(), new SolidBrush(Color.Yellow));
                ene3.draw(game_panel.CreateGraphics(), new SolidBrush(Color.Yellow));
                ene4.draw(game_panel.CreateGraphics(), new SolidBrush(Color.Yellow));
                Player.Move();
                if (Player.Lose(ene1.x, ene1.y, ene2.x, ene2.y, ene3.x, ene3.y, ene4.x, ene4.y)) { game_active = false; }             
                Player.draw(game_panel.CreateGraphics(), new SolidBrush(Color.Green));
                if (Player.Win()) game_active = false;
            }
            else
            {
               if(Player.win==true) pictureBox1.Visible = true;
               else
                {
                    pictureBox1.Image = Race.Properties.Resources.przegrana;
                    pictureBox1.Visible = true;
                }
            }
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { Player.inmove = true; }
            if (e.KeyCode == Keys.D) { Player.MoveDown(); }
            if (e.KeyCode == Keys.A) { Player.MoveUp(); }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { Player.inmove = false; }
        }
    }
}
