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
/*
        public string[] skins = new string[] {
            "C:/Users/Admins/source/repos/Flappy_Bird/Flappy_Bird/Resources/Skin/skin_default.png",
            "C:/Users/Admins/source/repos/Flappy_Bird/Flappy_Bird/Resources/Skin/skin_apple_cat.png",
            "C:/Users/Admins/source/repos/Flappy_Bird/Flappy_Bird/Resources/Skin/skin_banana_cat.png",
            "C:/Users/Admins/source/repos/Flappy_Bird/Flappy_Bird/Resources/Skin/skin_donut_cat.png",
            "C:/Users/Admins/source/repos/Flappy_Bird/Flappy_Bird/Resources/Skin/skin_goku.png",
            "C:/Users/Admins/source/repos/Flappy_Bird/Flappy_Bird/Resources/Skin/skin_rainbow_cat.png",
        };
*/
        public List<Image> skins = new List<Image>
        {
           Properties.Resources.skin_default,
           Properties.Resources.skin_goku,
           Properties.Resources.skin_apple_cat,
           Properties.Resources.skin_banana_cat,
           Properties.Resources.skin_donut_cat,
           Properties.Resources.skin_rainbow_cat,
           // Properties.Resources
        };
        public int index = 0;
        public int count = 0;

        private MediaPlayer mediaPlayer;

        public SoundPlayer soundPlayer;
        //Gía trị thuộc tính volume của SoundPlayer có giá trị từ 0->1
        public double volume = 0.5;
        public Menu()
        {
            InitializeComponent();
         //   mediaPlayer = new MediaPlayer(); // 

            // Nếu khi thêm FullSizeRender.wav vào bằng Cách Add Existing File cho Resources nhưng không gọi được Properties.Resources.FullSizeRender
            // hay vào file Resources.Designer.cs không tìm thấy Property get được tạo cho FullSizeRender như các file png khác tức là  nó chưa được nhúng vào tài nguyên của ứng dụng
            /*
             Mở file( Nhấp đúp vào Resources.resx trên Soluton) Resources.resx trong thư mục Properties của dự án.
            Nhấn vào nút "Add Resource" và chọn "Add Existing File".
    Chọn file FullSizeRender.wav và nhấn "Open".
    Chọn "WAV audio file" trong danh sách định dạng và nhấn "OK".
    File FullSizeRender.wav đã được thêm vào tài nguyên của ứng dụng và bạn có thể truy cập nó bằng cách gọi "Properties.Resources.FullSizeRender".
                */
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
            //      soundPlayer.Play();
            soundPlayer.PlayLooping();
        }
        private void button_right_Click(object sender, EventArgs e)
        {
            //  pictureBox_skin.Image = Image.FromFile(@"C:\Users\Admins\source\repos\Flappy_Bird\Flappy_Bird\Resources\PLay.png"); 
            /* if( index >= 0 && index < skins.Length - 1)
             {
                 index++;
             }    
             else if(index == skins.Length-1)
             {
                 index = 0;
             }    
             pictureBox_skin.Image = Image.FromFile(skins[index]);
            */
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
            GameScreen GS = new GameScreen(skins,index, soundPlayer); // Khởi tạo form GameScreen , truyền vào đó skins và index để lấy skins[index]           
            GS.ShowDialog();
            /*this.Enabled = false;
            this.Visible = false;*/
          //  this.Close();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count % 2 ==0)
                label_pick.ForeColor = System.Drawing.Color.Red; // KO dùng color.red vi se bi loi ambigious voi color cua thu vien window.media
            else
                label_pick.ForeColor = System.Drawing.Color.Black;
            count++;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_skin_Click(object sender, EventArgs e)
        {

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

        

        private void button_Setting_Sound_Click(object sender, EventArgs e)
        {
            panel_Setting_Sound.Enabled = true;
            panel_Setting_Sound.Visible = true;
        }

        private void button_Setting_Sound_Decrease_Vol_Click(object sender, EventArgs e)
        {

        }

        private void button_Setting_Increase_Vol_Click(object sender, EventArgs e)
        {

        }

        private void button_Setting_Sound_Mute_Click(object sender, EventArgs e)
        {

        }

        private void button_Setting_Sound_Max_Vol_Click(object sender, EventArgs e)
        {

        }
    }
}
