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

namespace Flappy_Bird
{
    public partial class GameScreen : Form
    {
        private float formScale = 1f; // tỷ lệ phóng ban đầu của form
        private SoundPlayer soundPlayer;

        int pipe_speed = 8;
        int gravity = 10;
        public int score = 0;
        Random random = new Random();

        bool game_over = false;
        public GameScreen()
        {
            InitializeComponent();
            
        }
        public GameScreen( List<Image> skins, int index, SoundPlayer SP)
            {
            InitializeComponent();
           // this.plMain.SetDoubleBuffered();
            this.pictureBox_Flappy.Image = skins[index];
            this.soundPlayer = SP;
            PlayMusic();
        }


        private void GameScreen_Load(object sender, EventArgs e)
        {
            this.timer_game.Interval = 25;
            this.formScale = this.Font.Size / 8.25f;
        }

        private void PlayMusic()
        {
            soundPlayer = new SoundPlayer(Properties.Resources.FullSizeRender);
            soundPlayer.Stop();
            //      soundPlayer.Play();
            soundPlayer.PlayLooping();
        }
        private void PlayMusic(SoundPlayer soundPlayer1)
        {
            soundPlayer.Stop();
            soundPlayer1.Play();
        }
        bool OVER()
        {
            return (pictureBox_Flappy.Bounds.IntersectsWith(pictureBox_pipe_bot.Bounds) || pictureBox_Flappy.Bounds.IntersectsWith(pictureBox_pipe_top.Bounds) || pictureBox_Flappy.Bounds.IntersectsWith(pictureBox_ground.Bounds) || pictureBox_Flappy.Top <= -1 * pictureBox_Flappy.Height);
        }
        private void timer_game_Tick(object sender, EventArgs e)
        {
            //  this.plMain.Focus();
            pictureBox_Flappy.Top += gravity; // Khoảng cách giữa đỉnh bên trái và trần của form
            pictureBox_pipe_bot.Left -= pipe_speed;
            pictureBox_pipe_top.Left -= pipe_speed;
            label_Score.Text = "Score : " + score;

            /*if(pictureBox_pipe_top.Left < -100)
            {
                pictureBox_pipe_top.Left = 800;
                score++;
            }
            if (pictureBox_pipe_bot.Left < -120)
            {
                pictureBox_pipe_bot.Left = 900;
                score++;
            }    */

            // Nếu dùng cách này , khi đi qa nhân vật mà vẫn chưa đi hết màn hình , vẫn sẽ + điểm
            /*if (pictureBox_pipe_top.Left < pictureBox_Flappy.Left || pictureBox_pipe_top.Left < pictureBox_Flappy.Left)
               score++;*/
            if (pictureBox_pipe_bot.Left < -1 * pictureBox_pipe_bot.Width)
            {
                score++;
                pictureBox_pipe_bot.Left = pictureBox_pipe_top.Left = 420;

                int distance = this.pictureBox_ground.Top; // Khoang cach tu tran` den san
                                                           //   this.pictureBox_pipe_bot.Size.Height = random.Next(0, distance - this.pictureBox_Flappy.Size.Height - 10);
                int min_y = 30;
                int delta_d = 70;
                this.pictureBox_pipe_bot.Size = new Size(this.pictureBox_pipe_bot.Width, random.Next(min_y, distance - this.pictureBox_Flappy.Size.Height - delta_d - min_y));
                this.pictureBox_pipe_top.Size = new Size(this.pictureBox_pipe_top.Width, distance - pictureBox_pipe_bot.Height - delta_d - this.pictureBox_Flappy.Size.Height);
                this.pictureBox_pipe_bot.Top = distance - this.pictureBox_pipe_bot.Height; // -this.pictureBox_ground.Height;
                this.pictureBox_pipe_top.Top = 0;

            }

            if (OVER())
            {

                //    pictureBox_Flappy.Location = new Point(pictureBox_Flappy.Location.X,pictureBox_ground.Top);
                pictureBox_Flappy.Top = pictureBox_ground.Top - pictureBox_Flappy.Height - 1; // Nếu để pictureBox_Flappy.Top = pictureBox_ground.Top thì 2 chim sẽ cùng độ cao với sàn ground và bị che mất
                soundPlayer = new SoundPlayer(Properties.Resources.Bruh_sound_effect_www_tiengdong_com);
                soundPlayer.Play();

                EndGame();
            }

        }

        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
                gravity = -10;
        }

        private void GameScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
                gravity = -15;
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
          // if(game_over == false) , ko nen lam nhu nay , neu dat ca space cho restart va nhay , can phai kiem tra game_over moi lan nhan
             if(e.KeyCode == Keys.Space)
                 gravity = 10;
           //  if(e.KeyCode == Keys.)
        }
        void EndGame()
        {
            timer_game.Stop();
            //    pictureBox_Flappy.Top = pictureBox_ground.Top - pictureBox_Flappy.Height - 1;
            //  label_Score.Text += " Game Over !! Press Space or click to the button to PlayAgain or ESC to escape ";
            /*label_Score.Enabled = false;
            label_Score.Visible = false;*/
            game_over = true;
            panel_GameOver.Controls.Add(label_Score);
            label_Score.Location = new Point(0, panel_GameOver.Height / 2);
            panel_GameOver.Enabled = true; // Ban đầu ta sẽ đặt 2 thuộc tính này là False, cả khi ấn restart , chỉ
            panel_GameOver.Visible = true;

        }
        private void NewGame()
        {
            panel_GameOver.Controls.Remove(label_Score);
            this.Controls.Add(label_Score);
            label_Score.Location = new Point(0, 30);
            PlayMusic();
            game_over = false;
            pictureBox_Flappy.Location = new Point(150, 170);

            pictureBox_pipe_bot.Left = 420;
            pictureBox_pipe_top.Left = 420;

            int distance = this.pictureBox_ground.Top;

            pictureBox_pipe_bot.Size = new Size(100, 180);
            pictureBox_pipe_bot.Top = distance - pictureBox_pipe_bot.Size.Height;

            pictureBox_pipe_top.Size = new Size(100, 160);
            pictureBox_pipe_top.Top = 0;

            score = 0;
            pipe_speed = 8;
            gravity = 10;
            label_Score.Text = "Score: 0";
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

            Menu mainMenu = new Menu();
            mainMenu.ShowDialog();
          //  Application.Exit();
        }

        private void pictureBox_pipe_bot_Click(object sender, EventArgs e)
        {

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

        private void pictureBox_Flappy_Click(object sender, EventArgs e)
        {

        }

        private void plMain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
                gravity = -10;

        }

        private void plMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
