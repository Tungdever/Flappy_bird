
using System.Drawing;
using System.Windows.Media;

namespace Flappy_Bird
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.pictureBox_Flappy = new System.Windows.Forms.PictureBox();
            this.timer_game = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_pipe_top = new System.Windows.Forms.PictureBox();
            this.pictureBox_pipe_bot = new System.Windows.Forms.PictureBox();
            this.label_Score = new System.Windows.Forms.Label();
            this.pictureBox_GameOver = new System.Windows.Forms.PictureBox();
            this.panel_GameOver = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Menu = new System.Windows.Forms.Button();
            this.button_NewGame = new System.Windows.Forms.Button();
            this.pictureBox_ground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Flappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pipe_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pipe_bot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GameOver)).BeginInit();
            this.panel_GameOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ground)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Flappy
            // 
            this.pictureBox_Flappy.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Flappy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Flappy.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Flappy.Image")));
            this.pictureBox_Flappy.Location = new System.Drawing.Point(223, 262);
            this.pictureBox_Flappy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_Flappy.Name = "pictureBox_Flappy";
            this.pictureBox_Flappy.Size = new System.Drawing.Size(104, 103);
            this.pictureBox_Flappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Flappy.TabIndex = 1;
            this.pictureBox_Flappy.TabStop = false;
            this.pictureBox_Flappy.Click += new System.EventHandler(this.pictureBox_Flappy_Click);
            // 
            // timer_game
            // 
            this.timer_game.Enabled = true;
            this.timer_game.Interval = 20;
            this.timer_game.Tick += new System.EventHandler(this.timer_game_Tick);
            // 
            // pictureBox_pipe_top
            // 
            this.pictureBox_pipe_top.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_pipe_top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_pipe_top.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_pipe_top.Image")));
            this.pictureBox_pipe_top.Location = new System.Drawing.Point(657, -8);
            this.pictureBox_pipe_top.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_pipe_top.Name = "pictureBox_pipe_top";
            this.pictureBox_pipe_top.Size = new System.Drawing.Size(150, 246);
            this.pictureBox_pipe_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_pipe_top.TabIndex = 0;
            this.pictureBox_pipe_top.TabStop = false;
            // 
            // pictureBox_pipe_bot
            // 
            this.pictureBox_pipe_bot.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_pipe_bot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_pipe_bot.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_pipe_bot.Image")));
            this.pictureBox_pipe_bot.Location = new System.Drawing.Point(653, 504);
            this.pictureBox_pipe_bot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_pipe_bot.Name = "pictureBox_pipe_bot";
            this.pictureBox_pipe_bot.Size = new System.Drawing.Size(150, 234);
            this.pictureBox_pipe_bot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_pipe_bot.TabIndex = 2;
            this.pictureBox_pipe_bot.TabStop = false;
            this.pictureBox_pipe_bot.Click += new System.EventHandler(this.pictureBox_pipe_bot_Click);
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.BackColor = System.Drawing.Color.Transparent;
            this.label_Score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Score.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Score.Location = new System.Drawing.Point(0, 46);
            this.label_Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(125, 37);
            this.label_Score.TabIndex = 9;
            this.label_Score.Text = "Score: ";
            // 
            // pictureBox_GameOver
            // 
            this.pictureBox_GameOver.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_GameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_GameOver.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_GameOver.Image")));
            this.pictureBox_GameOver.Location = new System.Drawing.Point(84, -2);
            this.pictureBox_GameOver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_GameOver.Name = "pictureBox_GameOver";
            this.pictureBox_GameOver.Size = new System.Drawing.Size(358, 134);
            this.pictureBox_GameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_GameOver.TabIndex = 10;
            this.pictureBox_GameOver.TabStop = false;
            this.pictureBox_GameOver.UseWaitCursor = true;
            // 
            // panel_GameOver
            // 
            this.panel_GameOver.BackColor = System.Drawing.Color.Transparent;
            this.panel_GameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_GameOver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_GameOver.Controls.Add(this.button_Exit);
            this.panel_GameOver.Controls.Add(this.button_Menu);
            this.panel_GameOver.Controls.Add(this.button_NewGame);
            this.panel_GameOver.Controls.Add(this.pictureBox_GameOver);
            this.panel_GameOver.Enabled = false;
            this.panel_GameOver.Location = new System.Drawing.Point(475, 248);
            this.panel_GameOver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_GameOver.Name = "panel_GameOver";
            this.panel_GameOver.Size = new System.Drawing.Size(494, 364);
            this.panel_GameOver.TabIndex = 11;
            this.panel_GameOver.Visible = false;
            // 
            // button_Exit
            // 
            this.button_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Exit.BackgroundImage")));
            this.button_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Location = new System.Drawing.Point(320, 268);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(165, 68);
            this.button_Exit.TabIndex = 13;
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Menu
            // 
            this.button_Menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Menu.BackgroundImage")));
            this.button_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Menu.FlatAppearance.BorderSize = 0;
            this.button_Menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Menu.Location = new System.Drawing.Point(158, 268);
            this.button_Menu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(152, 68);
            this.button_Menu.TabIndex = 12;
            this.button_Menu.UseVisualStyleBackColor = true;
            this.button_Menu.Click += new System.EventHandler(this.button_Menu_Click);
            // 
            // button_NewGame
            // 
            this.button_NewGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_NewGame.BackgroundImage")));
            this.button_NewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_NewGame.FlatAppearance.BorderSize = 0;
            this.button_NewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_NewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_NewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NewGame.Location = new System.Drawing.Point(4, 261);
            this.button_NewGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_NewGame.Name = "button_NewGame";
            this.button_NewGame.Size = new System.Drawing.Size(152, 82);
            this.button_NewGame.TabIndex = 11;
            this.button_NewGame.UseVisualStyleBackColor = true;
            this.button_NewGame.Click += new System.EventHandler(this.button_NewGame_Click);
            // 
            // pictureBox_ground
            // 
            this.pictureBox_ground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ground.Image")));
            this.pictureBox_ground.Location = new System.Drawing.Point(-2, 736);
            this.pictureBox_ground.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_ground.Name = "pictureBox_ground";
            this.pictureBox_ground.Size = new System.Drawing.Size(1382, 75);
            this.pictureBox_ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ground.TabIndex = 3;
            this.pictureBox_ground.TabStop = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Flappy_Bird.Properties.Resources.background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1384, 814);
            this.Controls.Add(this.pictureBox_ground);
            this.Controls.Add(this.panel_GameOver);
            this.Controls.Add(this.pictureBox_pipe_bot);
            this.Controls.Add(this.label_Score);
            this.Controls.Add(this.pictureBox_Flappy);
            this.Controls.Add(this.pictureBox_pipe_top);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GameScreen";
            this.Text = "FlappyBird";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GameScreen_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.Resize += new System.EventHandler(this.GameScreen_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Flappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pipe_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pipe_bot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GameOver)).EndInit();
            this.panel_GameOver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_game;
        private System.Windows.Forms.PictureBox pictureBox_pipe_top;
        private System.Windows.Forms.PictureBox pictureBox_pipe_bot;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.PictureBox pictureBox_GameOver;
        private System.Windows.Forms.Panel panel_GameOver;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Menu;
        private System.Windows.Forms.Button button_NewGame;
        private System.Windows.Forms.PictureBox pictureBox_Flappy;
        private System.Windows.Forms.PictureBox pictureBox_ground;
    }
}

