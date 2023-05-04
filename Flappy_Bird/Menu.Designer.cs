
using System.Drawing;
using System.Windows.Forms;

namespace Flappy_Bird
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBox_skin = new System.Windows.Forms.PictureBox();
            this.button_left = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_Play = new System.Windows.Forms.Button();
            this.label_BestScore = new System.Windows.Forms.Label();
            this.label_pick = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Quit = new System.Windows.Forms.Button();
            this.button_Setting = new System.Windows.Forms.Button();
            this.panel_Setting = new System.Windows.Forms.Panel();
            this.panel_Setting_Sound = new System.Windows.Forms.Panel();
            this.button_Setting_Sound_Max_Vol = new System.Windows.Forms.Button();
            this.button_Setting_Sound_Mute = new System.Windows.Forms.Button();
            this.button_Setting_Increase_Vol = new System.Windows.Forms.Button();
            this.button_Setting_Sound_Decrease_Vol = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Setting_Sound = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_skin)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_Setting.SuspendLayout();
            this.panel_Setting_Sound.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_skin
            // 
            this.pictureBox_skin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_skin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_skin.Image")));
            this.pictureBox_skin.Location = new System.Drawing.Point(322, 81);
            this.pictureBox_skin.Name = "pictureBox_skin";
            this.pictureBox_skin.Size = new System.Drawing.Size(130, 122);
            this.pictureBox_skin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_skin.TabIndex = 7;
            this.pictureBox_skin.TabStop = false;
            this.pictureBox_skin.Click += new System.EventHandler(this.pictureBox_skin_Click);
            // 
            // button_left
            // 
            this.button_left.BackColor = System.Drawing.Color.Transparent;
            this.button_left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_left.BackgroundImage")));
            this.button_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_left.FlatAppearance.BorderSize = 0;
            this.button_left.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_left.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_left.Location = new System.Drawing.Point(212, 110);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(71, 68);
            this.button_left.TabIndex = 6;
            this.button_left.UseVisualStyleBackColor = false;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_right
            // 
            this.button_right.BackColor = System.Drawing.Color.Transparent;
            this.button_right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_right.BackgroundImage")));
            this.button_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_right.FlatAppearance.BorderSize = 0;
            this.button_right.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_right.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_right.Location = new System.Drawing.Point(480, 110);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(71, 68);
            this.button_right.TabIndex = 5;
            this.button_right.UseVisualStyleBackColor = false;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_Play
            // 
            this.button_Play.BackColor = System.Drawing.Color.Transparent;
            this.button_Play.BackgroundImage = global::Flappy_Bird.Properties.Resources.Start__2_;
            this.button_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Play.FlatAppearance.BorderSize = 0;
            this.button_Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Play.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Play.Location = new System.Drawing.Point(26, 3);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(149, 61);
            this.button_Play.TabIndex = 4;
            this.button_Play.UseVisualStyleBackColor = false;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // label_BestScore
            // 
            this.label_BestScore.AutoSize = true;
            this.label_BestScore.BackColor = System.Drawing.Color.Transparent;
            this.label_BestScore.Font = new System.Drawing.Font("VNI-Fato", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BestScore.Location = new System.Drawing.Point(12, 81);
            this.label_BestScore.Name = "label_BestScore";
            this.label_BestScore.Size = new System.Drawing.Size(154, 28);
            this.label_BestScore.TabIndex = 8;
            this.label_BestScore.Text = "Highest Score:";
            // 
            // label_pick
            // 
            this.label_pick.AutoSize = true;
            this.label_pick.BackColor = System.Drawing.Color.Transparent;
            this.label_pick.Font = new System.Drawing.Font("VNI-Canun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pick.ForeColor = System.Drawing.Color.Black;
            this.label_pick.Location = new System.Drawing.Point(290, 206);
            this.label_pick.Name = "label_pick";
            this.label_pick.Size = new System.Drawing.Size(210, 23);
            this.label_pick.TabIndex = 9;
            this.label_pick.Text = "Pick your Appearance";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button_Quit);
            this.panel1.Controls.Add(this.button_Setting);
            this.panel1.Controls.Add(this.button_Play);
            this.panel1.Location = new System.Drawing.Point(294, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 204);
            this.panel1.TabIndex = 10;
            // 
            // button_Quit
            // 
            this.button_Quit.BackColor = System.Drawing.Color.Transparent;
            this.button_Quit.BackgroundImage = global::Flappy_Bird.Properties.Resources.Quit;
            this.button_Quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Quit.FlatAppearance.BorderSize = 0;
            this.button_Quit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Quit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Quit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Quit.Location = new System.Drawing.Point(26, 132);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(149, 61);
            this.button_Quit.TabIndex = 6;
            this.button_Quit.UseVisualStyleBackColor = false;
            this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
            // 
            // button_Setting
            // 
            this.button_Setting.BackColor = System.Drawing.Color.Transparent;
            this.button_Setting.BackgroundImage = global::Flappy_Bird.Properties.Resources.Setting;
            this.button_Setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Setting.FlatAppearance.BorderSize = 0;
            this.button_Setting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Setting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Setting.Location = new System.Drawing.Point(26, 65);
            this.button_Setting.Name = "button_Setting";
            this.button_Setting.Size = new System.Drawing.Size(149, 61);
            this.button_Setting.TabIndex = 5;
            this.button_Setting.UseVisualStyleBackColor = false;
            this.button_Setting.Click += new System.EventHandler(this.button_Setting_Click);
            // 
            // panel_Setting
            // 
            this.panel_Setting.BackColor = System.Drawing.Color.Transparent;
            this.panel_Setting.Controls.Add(this.panel_Setting_Sound);
            this.panel_Setting.Controls.Add(this.button2);
            this.panel_Setting.Controls.Add(this.button_Setting_Sound);
            this.panel_Setting.Enabled = false;
            this.panel_Setting.Location = new System.Drawing.Point(555, 254);
            this.panel_Setting.Name = "panel_Setting";
            this.panel_Setting.Size = new System.Drawing.Size(245, 187);
            this.panel_Setting.TabIndex = 11;
            this.panel_Setting.Visible = false;
            // 
            // panel_Setting_Sound
            // 
            this.panel_Setting_Sound.Controls.Add(this.button_Setting_Sound_Max_Vol);
            this.panel_Setting_Sound.Controls.Add(this.button_Setting_Sound_Mute);
            this.panel_Setting_Sound.Controls.Add(this.button_Setting_Increase_Vol);
            this.panel_Setting_Sound.Controls.Add(this.button_Setting_Sound_Decrease_Vol);
            this.panel_Setting_Sound.Enabled = false;
            this.panel_Setting_Sound.Location = new System.Drawing.Point(15, 48);
            this.panel_Setting_Sound.Name = "panel_Setting_Sound";
            this.panel_Setting_Sound.Size = new System.Drawing.Size(204, 128);
            this.panel_Setting_Sound.TabIndex = 2;
            this.panel_Setting_Sound.Visible = false;
            // 
            // button_Setting_Sound_Max_Vol
            // 
            this.button_Setting_Sound_Max_Vol.BackColor = System.Drawing.Color.Transparent;
            this.button_Setting_Sound_Max_Vol.BackgroundImage = global::Flappy_Bird.Properties.Resources.Max_vol1;
            this.button_Setting_Sound_Max_Vol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Setting_Sound_Max_Vol.FlatAppearance.BorderSize = 0;
            this.button_Setting_Sound_Max_Vol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Setting_Sound_Max_Vol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Setting_Sound_Max_Vol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Setting_Sound_Max_Vol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Setting_Sound_Max_Vol.Location = new System.Drawing.Point(114, 67);
            this.button_Setting_Sound_Max_Vol.Name = "button_Setting_Sound_Max_Vol";
            this.button_Setting_Sound_Max_Vol.Size = new System.Drawing.Size(61, 50);
            this.button_Setting_Sound_Max_Vol.TabIndex = 10;
            this.button_Setting_Sound_Max_Vol.UseVisualStyleBackColor = false;
            this.button_Setting_Sound_Max_Vol.Click += new System.EventHandler(this.button_Setting_Sound_Max_Vol_Click);
            // 
            // button_Setting_Sound_Mute
            // 
            this.button_Setting_Sound_Mute.BackColor = System.Drawing.Color.Transparent;
            this.button_Setting_Sound_Mute.BackgroundImage = global::Flappy_Bird.Properties.Resources.Mute_vol;
            this.button_Setting_Sound_Mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Setting_Sound_Mute.FlatAppearance.BorderSize = 0;
            this.button_Setting_Sound_Mute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Setting_Sound_Mute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Setting_Sound_Mute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Setting_Sound_Mute.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Setting_Sound_Mute.Location = new System.Drawing.Point(21, 72);
            this.button_Setting_Sound_Mute.Name = "button_Setting_Sound_Mute";
            this.button_Setting_Sound_Mute.Size = new System.Drawing.Size(61, 50);
            this.button_Setting_Sound_Mute.TabIndex = 9;
            this.button_Setting_Sound_Mute.UseVisualStyleBackColor = false;
            this.button_Setting_Sound_Mute.Click += new System.EventHandler(this.button_Setting_Sound_Mute_Click);
            // 
            // button_Setting_Increase_Vol
            // 
            this.button_Setting_Increase_Vol.BackColor = System.Drawing.Color.Transparent;
            this.button_Setting_Increase_Vol.BackgroundImage = global::Flappy_Bird.Properties.Resources.Increse_vol;
            this.button_Setting_Increase_Vol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Setting_Increase_Vol.FlatAppearance.BorderSize = 0;
            this.button_Setting_Increase_Vol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Setting_Increase_Vol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Setting_Increase_Vol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Setting_Increase_Vol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Setting_Increase_Vol.Location = new System.Drawing.Point(114, 5);
            this.button_Setting_Increase_Vol.Name = "button_Setting_Increase_Vol";
            this.button_Setting_Increase_Vol.Size = new System.Drawing.Size(61, 50);
            this.button_Setting_Increase_Vol.TabIndex = 8;
            this.button_Setting_Increase_Vol.UseVisualStyleBackColor = false;
            this.button_Setting_Increase_Vol.Click += new System.EventHandler(this.button_Setting_Increase_Vol_Click);
            // 
            // button_Setting_Sound_Decrease_Vol
            // 
            this.button_Setting_Sound_Decrease_Vol.BackColor = System.Drawing.Color.Transparent;
            this.button_Setting_Sound_Decrease_Vol.BackgroundImage = global::Flappy_Bird.Properties.Resources.Decrease_vol;
            this.button_Setting_Sound_Decrease_Vol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Setting_Sound_Decrease_Vol.FlatAppearance.BorderSize = 0;
            this.button_Setting_Sound_Decrease_Vol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Setting_Sound_Decrease_Vol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Setting_Sound_Decrease_Vol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Setting_Sound_Decrease_Vol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Setting_Sound_Decrease_Vol.Location = new System.Drawing.Point(21, 3);
            this.button_Setting_Sound_Decrease_Vol.Name = "button_Setting_Sound_Decrease_Vol";
            this.button_Setting_Sound_Decrease_Vol.Size = new System.Drawing.Size(61, 50);
            this.button_Setting_Sound_Decrease_Vol.TabIndex = 7;
            this.button_Setting_Sound_Decrease_Vol.UseVisualStyleBackColor = false;
            this.button_Setting_Sound_Decrease_Vol.Click += new System.EventHandler(this.button_Setting_Sound_Decrease_Vol_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("VNI-Cooper", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(144, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "About us";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button_Setting_Sound
            // 
            this.button_Setting_Sound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Setting_Sound.Font = new System.Drawing.Font("VNI-Cooper", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Setting_Sound.Location = new System.Drawing.Point(22, 4);
            this.button_Setting_Sound.Name = "button_Setting_Sound";
            this.button_Setting_Sound.Size = new System.Drawing.Size(75, 38);
            this.button_Setting_Sound.TabIndex = 0;
            this.button_Setting_Sound.Text = "Sound";
            this.button_Setting_Sound.UseVisualStyleBackColor = true;
            this.button_Setting_Sound.Click += new System.EventHandler(this.button_Setting_Sound_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Flappy_Bird.Properties.Resources.background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 464);
            this.Controls.Add(this.panel_Setting);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_pick);
            this.Controls.Add(this.label_BestScore);
            this.Controls.Add(this.pictureBox_skin);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.button_right);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_skin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_Setting.ResumeLayout(false);
            this.panel_Setting_Sound.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_Play;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.PictureBox pictureBox_skin;
        private Label label_BestScore;
        private Label label_pick;
        private Timer timer1;
        private Panel panel1;
        private Button button_Quit;
        private Button button_Setting;
        private Panel panel_Setting;
        private Button button2;
        private Button button_Setting_Sound;
        private Panel panel_Setting_Sound;
        private Button button_Setting_Sound_Decrease_Vol;
        private Button button_Setting_Sound_Max_Vol;
        private Button button_Setting_Sound_Mute;
        private Button button_Setting_Increase_Vol;
    }
}