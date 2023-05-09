
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
            this.button_Setting_Sound_Max_Vol = new System.Windows.Forms.Button();
            this.pnlLevel = new System.Windows.Forms.Panel();
            this.lvlHard = new System.Windows.Forms.Button();
            this.lvlMedium = new System.Windows.Forms.Button();
            this.lvlEasy = new System.Windows.Forms.Button();
            this.panel_Setting = new System.Windows.Forms.Panel();
            this.panel_Setting_Sound = new System.Windows.Forms.Panel();
            this.btnLevel = new System.Windows.Forms.Button();
            this.button_Setting_Sound = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_skin)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlLevel.SuspendLayout();
            this.panel_Setting.SuspendLayout();
            this.panel_Setting_Sound.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_skin
            // 
            this.pictureBox_skin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_skin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_skin.Image")));
            this.pictureBox_skin.Location = new System.Drawing.Point(429, 100);
            this.pictureBox_skin.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_skin.Name = "pictureBox_skin";
            this.pictureBox_skin.Size = new System.Drawing.Size(173, 150);
            this.pictureBox_skin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_skin.TabIndex = 7;
            this.pictureBox_skin.TabStop = false;
            // 
            // button_left
            // 
            this.button_left.BackColor = System.Drawing.Color.Transparent;
            this.button_left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_left.BackgroundImage")));
            this.button_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_left.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_left.FlatAppearance.BorderSize = 0;
            this.button_left.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_left.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_left.Location = new System.Drawing.Point(283, 135);
            this.button_left.Margin = new System.Windows.Forms.Padding(4);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(95, 84);
            this.button_left.TabIndex = 6;
            this.button_left.UseVisualStyleBackColor = false;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_right
            // 
            this.button_right.BackColor = System.Drawing.Color.Transparent;
            this.button_right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_right.BackgroundImage")));
            this.button_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_right.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_right.FlatAppearance.BorderSize = 0;
            this.button_right.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_right.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_right.Location = new System.Drawing.Point(640, 135);
            this.button_right.Margin = new System.Windows.Forms.Padding(4);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(95, 84);
            this.button_right.TabIndex = 5;
            this.button_right.UseVisualStyleBackColor = false;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_Play
            // 
            this.button_Play.BackColor = System.Drawing.Color.Transparent;
            this.button_Play.BackgroundImage = global::Flappy_Bird.Properties.Resources.Start__2_;
            this.button_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Play.FlatAppearance.BorderSize = 0;
            this.button_Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Play.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Play.Location = new System.Drawing.Point(35, 4);
            this.button_Play.Margin = new System.Windows.Forms.Padding(4);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(199, 75);
            this.button_Play.TabIndex = 4;
            this.button_Play.UseVisualStyleBackColor = false;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // label_BestScore
            // 
            this.label_BestScore.AutoSize = true;
            this.label_BestScore.BackColor = System.Drawing.Color.Transparent;
            this.label_BestScore.Font = new System.Drawing.Font("VNI-Fato", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BestScore.Location = new System.Drawing.Point(16, 100);
            this.label_BestScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BestScore.Name = "label_BestScore";
            this.label_BestScore.Size = new System.Drawing.Size(197, 36);
            this.label_BestScore.TabIndex = 8;
            this.label_BestScore.Text = "Highest Score:";
            // 
            // label_pick
            // 
            this.label_pick.AutoSize = true;
            this.label_pick.BackColor = System.Drawing.Color.Transparent;
            this.label_pick.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pick.ForeColor = System.Drawing.Color.Black;
            this.label_pick.Location = new System.Drawing.Point(387, 254);
            this.label_pick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_pick.Name = "label_pick";
            this.label_pick.Size = new System.Drawing.Size(216, 24);
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
            this.panel1.Location = new System.Drawing.Point(392, 292);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 251);
            this.panel1.TabIndex = 10;
            // 
            // button_Quit
            // 
            this.button_Quit.BackColor = System.Drawing.Color.Transparent;
            this.button_Quit.BackgroundImage = global::Flappy_Bird.Properties.Resources.Quit;
            this.button_Quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Quit.FlatAppearance.BorderSize = 0;
            this.button_Quit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Quit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Quit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Quit.Location = new System.Drawing.Point(35, 162);
            this.button_Quit.Margin = new System.Windows.Forms.Padding(4);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(199, 75);
            this.button_Quit.TabIndex = 6;
            this.button_Quit.UseVisualStyleBackColor = false;
            this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
            // 
            // button_Setting
            // 
            this.button_Setting.BackColor = System.Drawing.Color.Transparent;
            this.button_Setting.BackgroundImage = global::Flappy_Bird.Properties.Resources.Setting;
            this.button_Setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Setting.FlatAppearance.BorderSize = 0;
            this.button_Setting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Setting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Setting.Location = new System.Drawing.Point(35, 80);
            this.button_Setting.Margin = new System.Windows.Forms.Padding(4);
            this.button_Setting.Name = "button_Setting";
            this.button_Setting.Size = new System.Drawing.Size(199, 75);
            this.button_Setting.TabIndex = 5;
            this.button_Setting.UseVisualStyleBackColor = false;
            this.button_Setting.Click += new System.EventHandler(this.button_Setting_Click);
            // 
            // button_Setting_Sound_Max_Vol
            // 
            this.button_Setting_Sound_Max_Vol.BackColor = System.Drawing.Color.Transparent;
            this.button_Setting_Sound_Max_Vol.BackgroundImage = global::Flappy_Bird.Properties.Resources.Max_vol1;
            this.button_Setting_Sound_Max_Vol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Setting_Sound_Max_Vol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Setting_Sound_Max_Vol.FlatAppearance.BorderSize = 0;
            this.button_Setting_Sound_Max_Vol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Setting_Sound_Max_Vol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Setting_Sound_Max_Vol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Setting_Sound_Max_Vol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Setting_Sound_Max_Vol.Location = new System.Drawing.Point(9, 4);
            this.button_Setting_Sound_Max_Vol.Margin = new System.Windows.Forms.Padding(4);
            this.button_Setting_Sound_Max_Vol.Name = "button_Setting_Sound_Max_Vol";
            this.button_Setting_Sound_Max_Vol.Size = new System.Drawing.Size(81, 62);
            this.button_Setting_Sound_Max_Vol.TabIndex = 10;
            this.button_Setting_Sound_Max_Vol.UseVisualStyleBackColor = false;
            this.button_Setting_Sound_Max_Vol.Click += new System.EventHandler(this.button_Setting_Sound_Max_Vol_Click);
            // 
            // pnlLevel
            // 
            this.pnlLevel.Controls.Add(this.lvlHard);
            this.pnlLevel.Controls.Add(this.lvlMedium);
            this.pnlLevel.Controls.Add(this.lvlEasy);
            this.pnlLevel.Enabled = false;
            this.pnlLevel.Location = new System.Drawing.Point(16, 206);
            this.pnlLevel.Name = "pnlLevel";
            this.pnlLevel.Size = new System.Drawing.Size(331, 90);
            this.pnlLevel.TabIndex = 11;
            this.pnlLevel.Visible = false;
            // 
            // lvlHard
            // 
            this.lvlHard.BackgroundImage = global::Flappy_Bird.Properties.Resources.hard;
            this.lvlHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lvlHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvlHard.Location = new System.Drawing.Point(210, 3);
            this.lvlHard.Name = "lvlHard";
            this.lvlHard.Size = new System.Drawing.Size(81, 80);
            this.lvlHard.TabIndex = 2;
            this.lvlHard.UseVisualStyleBackColor = true;
            this.lvlHard.Click += new System.EventHandler(this.lvlHard_Click);
            // 
            // lvlMedium
            // 
            this.lvlMedium.BackColor = System.Drawing.Color.Transparent;
            this.lvlMedium.BackgroundImage = global::Flappy_Bird.Properties.Resources.medium;
            this.lvlMedium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lvlMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvlMedium.ForeColor = System.Drawing.Color.Transparent;
            this.lvlMedium.Location = new System.Drawing.Point(107, 3);
            this.lvlMedium.Name = "lvlMedium";
            this.lvlMedium.Size = new System.Drawing.Size(84, 80);
            this.lvlMedium.TabIndex = 1;
            this.lvlMedium.UseVisualStyleBackColor = false;
            this.lvlMedium.Click += new System.EventHandler(this.lvlMedium_Click);
            // 
            // lvlEasy
            // 
            this.lvlEasy.BackColor = System.Drawing.Color.Transparent;
            this.lvlEasy.BackgroundImage = global::Flappy_Bird.Properties.Resources.easy;
            this.lvlEasy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lvlEasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvlEasy.ForeColor = System.Drawing.Color.Transparent;
            this.lvlEasy.Location = new System.Drawing.Point(3, 3);
            this.lvlEasy.Name = "lvlEasy";
            this.lvlEasy.Size = new System.Drawing.Size(84, 80);
            this.lvlEasy.TabIndex = 0;
            this.lvlEasy.UseVisualStyleBackColor = false;
            this.lvlEasy.Click += new System.EventHandler(this.lvlEasy_Click);
            // 
            // panel_Setting
            // 
            this.panel_Setting.BackColor = System.Drawing.Color.Transparent;
            this.panel_Setting.Controls.Add(this.panel_Setting_Sound);
            this.panel_Setting.Controls.Add(this.btnLevel);
            this.panel_Setting.Controls.Add(this.button_Setting_Sound);
            this.panel_Setting.Controls.Add(this.pnlLevel);
            this.panel_Setting.Enabled = false;
            this.panel_Setting.Location = new System.Drawing.Point(713, 254);
            this.panel_Setting.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Setting.Name = "panel_Setting";
            this.panel_Setting.Size = new System.Drawing.Size(373, 304);
            this.panel_Setting.TabIndex = 12;
            this.panel_Setting.Visible = false;
            // 
            // panel_Setting_Sound
            // 
            this.panel_Setting_Sound.Controls.Add(this.button_Setting_Sound_Max_Vol);
            this.panel_Setting_Sound.Enabled = false;
            this.panel_Setting_Sound.Location = new System.Drawing.Point(190, 23);
            this.panel_Setting_Sound.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Setting_Sound.Name = "panel_Setting_Sound";
            this.panel_Setting_Sound.Size = new System.Drawing.Size(96, 74);
            this.panel_Setting_Sound.TabIndex = 2;
            this.panel_Setting_Sound.Visible = false;
            // 
            // btnLevel
            // 
            this.btnLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel.Font = new System.Drawing.Font("VNI-Cooper", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel.Location = new System.Drawing.Point(16, 141);
            this.btnLevel.Margin = new System.Windows.Forms.Padding(4);
            this.btnLevel.Name = "btnLevel";
            this.btnLevel.Size = new System.Drawing.Size(100, 47);
            this.btnLevel.TabIndex = 1;
            this.btnLevel.Text = "Level";
            this.btnLevel.UseVisualStyleBackColor = true;
            this.btnLevel.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // button_Setting_Sound
            // 
            this.button_Setting_Sound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Setting_Sound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Setting_Sound.Font = new System.Drawing.Font("VNI-Cooper", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Setting_Sound.Location = new System.Drawing.Point(16, 38);
            this.button_Setting_Sound.Margin = new System.Windows.Forms.Padding(4);
            this.button_Setting_Sound.Name = "button_Setting_Sound";
            this.button_Setting_Sound.Size = new System.Drawing.Size(100, 47);
            this.button_Setting_Sound.TabIndex = 0;
            this.button_Setting_Sound.Text = "Sound";
            this.button_Setting_Sound.UseVisualStyleBackColor = true;
            this.button_Setting_Sound.Click += new System.EventHandler(this.button_Setting_Sound_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Flappy_Bird.Properties.Resources.background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1117, 571);
            this.Controls.Add(this.panel_Setting);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_pick);
            this.Controls.Add(this.label_BestScore);
            this.Controls.Add(this.pictureBox_skin);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.button_right);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_skin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlLevel.ResumeLayout(false);
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
        private Button button_Setting_Sound_Max_Vol;
        private Panel pnlLevel;
        private Panel panel_Setting;
        private Panel panel_Setting_Sound;
        private Button btnLevel;
        private Button button_Setting_Sound;
        private Button lvlHard;
        private Button lvlMedium;
        private Button lvlEasy;
    }
}