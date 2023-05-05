﻿
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
            this.timer_game = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_ground = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel_GameOver = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Menu = new System.Windows.Forms.Button();
            this.button_NewGame = new System.Windows.Forms.Button();
            this.pictureBox_GameOver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ground)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.panel_GameOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GameOver)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_game
            // 
            this.timer_game.Enabled = true;
            this.timer_game.Interval = 10;
            this.timer_game.Tick += new System.EventHandler(this.timer_game_Tick);
            // 
            // pictureBox_ground
            // 
            this.pictureBox_ground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox_ground.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ground.Image")));
            this.pictureBox_ground.Location = new System.Drawing.Point(0, 591);
            this.pictureBox_ground.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_ground.Name = "pictureBox_ground";
            this.pictureBox_ground.Size = new System.Drawing.Size(1230, 60);
            this.pictureBox_ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ground.TabIndex = 3;
            this.pictureBox_ground.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = global::Flappy_Bird.Properties.Resources.background_1;
            this.pnlMain.Controls.Add(this.panel_GameOver);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1230, 591);
            this.pnlMain.TabIndex = 4;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
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
            this.panel_GameOver.Location = new System.Drawing.Point(451, 150);
            this.panel_GameOver.Margin = new System.Windows.Forms.Padding(4);
            this.panel_GameOver.Name = "panel_GameOver";
            this.panel_GameOver.Size = new System.Drawing.Size(440, 292);
            this.panel_GameOver.TabIndex = 16;
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
            this.button_Exit.Location = new System.Drawing.Point(284, 214);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(147, 54);
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
            this.button_Menu.Location = new System.Drawing.Point(140, 214);
            this.button_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(135, 54);
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
            this.button_NewGame.Location = new System.Drawing.Point(4, 209);
            this.button_NewGame.Margin = new System.Windows.Forms.Padding(4);
            this.button_NewGame.Name = "button_NewGame";
            this.button_NewGame.Size = new System.Drawing.Size(135, 66);
            this.button_NewGame.TabIndex = 11;
            this.button_NewGame.UseVisualStyleBackColor = true;
            this.button_NewGame.Click += new System.EventHandler(this.button_NewGame_Click);
            // 
            // pictureBox_GameOver
            // 
            this.pictureBox_GameOver.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_GameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_GameOver.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_GameOver.Image")));
            this.pictureBox_GameOver.Location = new System.Drawing.Point(75, -2);
            this.pictureBox_GameOver.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_GameOver.Name = "pictureBox_GameOver";
            this.pictureBox_GameOver.Size = new System.Drawing.Size(318, 107);
            this.pictureBox_GameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_GameOver.TabIndex = 10;
            this.pictureBox_GameOver.TabStop = false;
            this.pictureBox_GameOver.UseWaitCursor = true;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1230, 651);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pictureBox_ground);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameScreen";
            this.Text = "FlappyBird";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GameScreen_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.Resize += new System.EventHandler(this.GameScreen_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ground)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.panel_GameOver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GameOver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer_game;
        private System.Windows.Forms.PictureBox pictureBox_ground;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel_GameOver;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Menu;
        private System.Windows.Forms.Button button_NewGame;
        private System.Windows.Forms.PictureBox pictureBox_GameOver;
    }
}

