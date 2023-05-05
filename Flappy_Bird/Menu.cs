using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Flappy_Bird
{
    public partial class Menu : Form
    {
        
        public int highest_score = 0;
        public string level = "easy";
        public List<Image> skins = new List<Image>
        {
           Properties.Resources.skin_default,
           Properties.Resources.skin_goku,
           Properties.Resources.skin_apple_cat,
           Properties.Resources.skin_banana_cat,
           Properties.Resources.skin_donut_cat,
           Properties.Resources.skin_rainbow_cat,
        };
        public int index = 0;
        public int count = 0;

        private MediaPlayer mediaPlayer;
        public SoundPlayer soundPlayer;
        bool isMute = false;
        public Menu()
        {
            InitializeComponent();        
            soundPlayer = new SoundPlayer(Properties.Resources.FullSizeRender);
            PlayMusic();
        }

        private void PlayMusic(string path) // Dùng cho đối tượn MediaPlayer 
        {
            mediaPlayer.Stop();
            mediaPlayer.Open(new Uri(path));
            mediaPlayer.Play();
        }

        private void PlayMusic()
        {
            soundPlayer.Stop();       
            soundPlayer.PlayLooping();
        }
        private void button_right_Click(object sender, EventArgs e)
        {
            
            if (index >= 0 && index < skins.Count - 1)
            {
                index++;
            }
            else if (index == skins.Count - 1)
            {
                index = 0;
            }
            pictureBox_skin.Image = skins[index];
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            if (index >= 1 && index < skins.Count)
                index--;
            else if(index == 0)
            {
                index = skins.Count - 1;
            }
            pictureBox_skin.Image = skins[index];
        }

        private void button_Play_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            GameScreen GS = new GameScreen(skins,index, soundPlayer, isMute, level); 
            GS.ShowDialog();
            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count % 2 ==0)
                label_pick.ForeColor = System.Drawing.Color.Red; 
            else
                label_pick.ForeColor = System.Drawing.Color.Black;
            count++;
        }


        private void button_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Setting_Click(object sender, EventArgs e)
        {
            panel_Setting.Enabled = true;
            panel_Setting.Visible = true;
        }

  

        private void button_Setting_Sound_Max_Vol_Click(object sender, EventArgs e)
        {
            isMute = !isMute;
            if (isMute)
            {
                this.soundPlayer.Stop();
                this.button_Setting_Sound_Max_Vol.BackgroundImage = global::Flappy_Bird.Properties.Resources.Mute_vol;
            }
            else
            {
                this.soundPlayer.Play();
                this.button_Setting_Sound_Max_Vol.BackgroundImage = global::Flappy_Bird.Properties.Resources.Max_vol1;
            }

        }
        private void button_Setting_Sound_Click(object sender, EventArgs e)
        {
            panel_Setting_Sound.Enabled = true;
            panel_Setting_Sound.Visible = true;
        }

        private void btnLevel_Click(object sender, EventArgs e)
        {
            pnlLevel.Enabled = true;
            pnlLevel.Visible = true;
        }

        private void lvlEasy_Click(object sender, EventArgs e)
        {
            level = "easy";
        }

        private void lvlMedium_Click(object sender, EventArgs e)
        {
            level = "medium";
        }

        private void lvlHard_Click(object sender, EventArgs e)
        {
            level = "hard";
        }
    }
}
