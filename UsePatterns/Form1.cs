using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsePatterns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "";
            if (radioButton1.Checked)
                path = "C:\\Users\\Admin\\Figures\\bird.png";
            if (radioButton2.Checked)
                path = "C:\\Users\\Admin\\Figures\\tube.png";
            if (radioButton3.Checked)
                path = "C:\\Users\\Admin\\Pictures\\GameCenter\\Warface\\Warface_190130_2027.jpg";
            Player player = Player.GetPlayer(path);
            Game game = new Game();
            game.Show();
            Hide(); //Прячет форму, скрывая её
        }
    }
}
