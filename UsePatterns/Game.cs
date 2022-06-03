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
    public partial class Game : Form
    {
        Player player;
        List<PictureBox> bulletsPicture;
        List<IBullet> bullets;

        EnemyPicture enemyPicture;

        public Game()
        {
            InitializeComponent();
            player = Player.GetPlayer("");
            pictureBox1.Image = Image.FromFile(player.Picture);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            bulletsPicture = new List<PictureBox>();
            bullets = new List<IBullet>();

            enemyPicture = new EnemyPicture();
            enemyPicture.Enemies.Add(new Enemy("C:\\Users\\Admin\\Figures\\bird.png", 4, 100, Width, Height / 2));
            enemyPicture.PictureBoxes.Add(CreatePictureBox
                (100, 30, Color.White, enemyPicture.Enemies[0].Path, Width, Height / 2));
        }

        public PictureBox CreatePictureBox(int h, int w, Color color, string path, int l, int t)
        {
            PictureBox picture = new PictureBox();
            picture.Height = 10;
            picture.Width = 30;
            picture.BackColor = color;
            picture.Left = l;
            picture.Top = t;
            if(path != "")
                picture.Image = Image.FromFile(path);
            Controls.Add(picture);
            return picture;
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Закрывает всё приложение целиком
            Application.Exit();
        }

        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Top = e.Y + 20;
            pictureBox1.Left = e.X + 20;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < bulletsPicture.Count; i++)
            {
                bullets[i].X += bullets[i].Speed;
                bulletsPicture[i].Left = bullets[i].X;
            }
        }

        BulletFactory factory = new BulletFactory();
        private void Game_MouseDown(object sender, MouseEventArgs e)
        {
            IBullet bullet;
            int num = 1;
            if (e.Button == MouseButtons.Left)
                num = 1;
            if (e.Button == MouseButtons.Right)
                num = 2;
            bullet = factory.GetBullet(num, e.X + 30, e.Y + 30);

            bullets.Add(bullet);
            bulletsPicture.Add(CreatePictureBox(10, 30, bullet.BulletColor, "", bullet.X, bullet.Y));
        }
        Random random = new Random();
        private void timer2_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < enemyPicture.Enemies.Count; i++)
            {
                enemyPicture.Enemies[i].X -= enemyPicture.Enemies[i].Speed;
                enemyPicture.PictureBoxes[i].Left = enemyPicture.Enemies[i].X;
            }
            if (random.Next() % 50 == 0)
            {
                Enemy enemy = (Enemy)enemyPicture.Enemies[0].Clone();
                enemy.X = Width;
                enemy.Y = random.Next(Height - 30);
                enemy.Height = random.Next(50) + 50;
                PictureBox picture = CreatePictureBox(enemy.Height, 30, Color.White, enemy.Path, enemy.X, enemy.Y);
                enemyPicture.Enemies.Add(enemy);
                enemyPicture.PictureBoxes.Add(picture);
            }
        }
    }
}
