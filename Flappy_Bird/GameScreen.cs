using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Reflection.Emit;

namespace Flappy_Bird
{
    public partial class GameScreen : Form
    {
        private float formScale = 1f; // tỷ lệ phóng ban đầu của form
        private SoundPlayer soundPlayer;

        int pipe_speed;

        Rectangle coordinateBird, pipeTop1, pipeBottom1, pipeTop2, pipeBottom2;
        int heightTop, heightBot;
        int gravity;
        public int score = 0;
        Random random = new Random();
        List<Image> skins;
        int index;
        bool game_over = false;
        string level;
        Image imgPipeTop = Properties.Resources.pipedown;

        Image imgPipeBot = Properties.Resources.pipe;
        
        public GameScreen( List<Image> skins, int index, SoundPlayer SP, bool isMute, string level)
        {
            InitializeComponent();
            this.skins = skins;
            this.index = index;
            coordinateBird.Width = 70;
            coordinateBird.Height = 62;
            NewGame();
            this.pnlMain.SetDoubleBuffered();
            this.soundPlayer = SP;
            if (!isMute) PlayMusic();
            this.level = level;
            if (level == "easy")
            {
                gravity = 5;
                pipe_speed = 5;
            }
            else if (level == "medium")
            {
                gravity = 10;
                pipe_speed = 5;
            }
            else if (level == "hard")
            {
                gravity = 10;
                pipe_speed = 15;
            }
        }


        private void GameScreen_Load(object sender, EventArgs e)
        {
            this.timer_game.Interval = 25;
            this.formScale = this.Font.Size / 8.25f;
        }

        private void PlayMusic()
        {
            soundPlayer = new SoundPlayer(Properties.Resources.FullSizeRender);
            soundPlayer.Play();
            soundPlayer.PlayLooping();
        }
        private bool IntersectsWith(Rectangle bird, Rectangle pipe)
        {
            if (pipe.X < bird.X + bird.Width && bird.X < pipe.X + pipe.Width && pipe.Y < bird.Y + bird.Height)
            {
                return bird.Y < pipe.Y + pipe.Height;
            }
            return false;
        }
        bool OVER()
        {           
            Rectangle ground = new Rectangle(pictureBox_ground.Location.X, pictureBox_ground.Location.Y, pictureBox_ground.Width, pictureBox_ground.Height);
            return (IntersectsWith(coordinateBird, pipeTop1) || IntersectsWith(coordinateBird, pipeBottom1)) || IntersectsWith(coordinateBird, ground) ||
                coordinateBird.Y <= -coordinateBird.Height;
        }
        private void timer_game_Tick(object sender, EventArgs e)
        {
            this.pnlMain.Refresh();
            coordinateBird.Y += gravity; // Khoảng cách giữa đỉnh bên trái và trần của form
            
            pipeTop1.X -= pipe_speed;
            pipeBottom1.X -= pipe_speed;

            pipeTop2.X -= pipe_speed;
            pipeBottom2.X -= pipe_speed;

            if (pipeBottom1.X < coordinateBird.X && pipeBottom1.X > 140)
            {
                score++;               
            }
            if (pipeBottom1.X < -150)
            {
                pipeBottom1.X = pipeTop1.X = 800;
                if (pipeBottom1.X - pipeBottom2.X <= 200) pipeBottom1.X = pipeTop1.X += 200;
                int distance = this.pictureBox_ground.Top; // Khoang cach tu tran` den san
                                                           //   this.pictureBox_pipe_bot.Size.Height = random.Next(0, distance - this.pictureBox_Flappy.Size.Height - 10);
                int min_y = 30;
                int delta_d = 70;
                pipeBottom1.Height = random.Next(min_y, distance - coordinateBird.Height - delta_d - min_y);
                this.pipeTop1.Size = new Size(100, distance - pipeBottom1.Height - delta_d - coordinateBird.Height);
                this.pipeBottom1.Y = distance - pipeBottom1.Height;

            }
            if (pipeBottom2.X < coordinateBird.X && pipeBottom2.X > 140)
            {
                score++;
            }
            if (pipeBottom2.X < -100)
            {
                pipeBottom2.X = pipeTop2.X = 800;
                if (pipeBottom2.X - pipeBottom1.X <= 200) pipeBottom2.X = pipeTop2.X += 200;
                int distance = this.pictureBox_ground.Top; // Khoang cach tu tran` den san
                                                           //   this.pictureBox_pipe_bot.Size.Height = random.Next(0, distance - this.pictureBox_Flappy.Size.Height - 10);
                int min_y = 30;
                int delta_d = 70;
                pipeBottom2.Height = random.Next(min_y, distance - coordinateBird.Height - delta_d - min_y);
                this.pipeTop2.Size = new Size(100, distance - pipeBottom2.Height - delta_d - coordinateBird.Height);
                this.pipeBottom2.Y = distance - pipeBottom2.Height;

            }

            if (OVER())
            {

                //    pictureBox_Flappy.Location = new Point(pictureBox_Flappy.Location.X,pictureBox_ground.Top);
                coordinateBird.Y = pictureBox_ground.Top - coordinateBird.Height - 1; // Nếu để pictureBox_Flappy.Top = pictureBox_ground.Top thì 2 chim sẽ cùng độ cao với sàn ground và bị che mất
                EndGame();
            }
            this.pnlMain.Refresh();
        }

        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (level == "easy")
                {
                    gravity = -5;

                }
                else if (level == "medium")
                {
                    gravity = -8;

                }
                else if (level == "hard")
                {
                    gravity = -11;

                }
 
                this.pnlMain.Refresh();
            }
        }

        private void GameScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                gravity = -15;
                this.pnlMain.Refresh();

            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            // if(game_over == false) , ko nen lam nhu nay , neu dat ca space cho restart va nhay , can phai kiem tra game_over moi lan nhan
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
                this.pnlMain.Refresh();
                //  if(e.KeyCode == Keys.)
            }
        }
        void EndGame()
        {
            timer_game.Stop();
            //    pictureBox_Flappy.Top = pictureBox_ground.Top - pictureBox_Flappy.Height - 1;
            //  label_Score.Text += " Game Over !! Press Space or click to the button to PlayAgain or ESC to escape ";
            /*label_Score.Enabled = false;
            label_Score.Visible = false;*/
            game_over = true;
            panel_GameOver.Enabled = true; // Ban đầu ta sẽ đặt 2 thuộc tính này là False, cả khi ấn restart , chỉ
            panel_GameOver.Visible = true;

        }
        private void NewGame()
        {            
            game_over = false;
            coordinateBird.Location = new Point(150, 170);
            int distance = this.pictureBox_ground.Top;
            pipeBottom1.Size = new Size(100, 180);
            pipeBottom2.Size = new Size(100, 70);
            pipeBottom1.Y = distance - pipeBottom1.Size.Height;
            pipeBottom2.Y = distance - pipeBottom2.Size.Height;
            pipeTop1.Size = new Size(100, 160);
            pipeTop2.Size = new Size(100, 240);
            pipeTop1.Y = 0;
            pipeTop2.Y = 0;
            pipeTop1.X = pipeBottom1.X = 700;
            pipeTop2.X = pipeBottom2.X = 1200;
            score = 0;
      
            timer_game.Start();
            panel_GameOver.Enabled = false; // Ban đầu ta sẽ đặt 2 thuộc tính này là False, cả khi ấn restart , chỉ
            panel_GameOver.Visible = false;

        }

        private void button_NewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void button_Menu_Click(object sender, EventArgs e)
        {
            this.Close();           
        }     

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameScreen_Resize(object sender, EventArgs e)
        {
            /*// tính tỷ lệ giữa kích thước ban đầu và kích thước hiện tại của form
            float scaleX = this.Width / 840f;
            float scaleY = this.Height / 600f;
            float scale = Math.Min(scaleX, scaleY);

            // áp dụng tỷ lệ đó cho kích thước và vị trí của các điều khiển bên trong form
            foreach (Control control in this.Controls)
            {
                control.Left = (int)(control.Left * scale / this.formScale);
                control.Top = (int)(control.Top * scale / this.formScale);
                control.Width = (int)(control.Width * scale / this.formScale);
                control.Height = (int)(control.Height * scale / this.formScale);
                control.Font = new Font(control.Font.FontFamily, control.Font.Size * scale / this.formScale);
            }

            // lưu lại tỷ lệ phóng hiện tại của form
            this.formScale = scale;*/
        }   

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            string score_string = "Score: " + score.ToString() + " - Level: " + level;
            e.Graphics.DrawString(score_string, new Font("VNI-Fato", 16), new SolidBrush(Color.Blue), 25, 30);
            e.Graphics.DrawImage(skins[index], coordinateBird.X, coordinateBird.Y, coordinateBird.Width, coordinateBird.Height);
            e.Graphics.DrawImage(imgPipeTop, pipeTop1.X, pipeTop1.Y, 100, pipeTop1.Height);
            e.Graphics.DrawImage(imgPipeBot, pipeBottom1.X, pipeBottom1.Y, 100, pipeBottom1.Height);
            e.Graphics.DrawImage(imgPipeTop, pipeTop2.X, pipeTop2.Y, 100, pipeTop2.Height);
            e.Graphics.DrawImage(imgPipeBot, pipeBottom2.X, pipeBottom2.Y, 100, pipeBottom2.Height);
        }
    }
}
