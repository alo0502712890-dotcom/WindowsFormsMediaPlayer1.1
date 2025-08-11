namespace WindowsFormsMediaPlayer
{
    partial class MainPlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPlayerForm));
            this.statusStrip_Info = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Info = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Controls = new System.Windows.Forms.Panel();
            this.trackBar_Sound = new System.Windows.Forms.TrackBar();
            this.button_SoundMute = new System.Windows.Forms.Button();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Options = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_PauseStop = new System.Windows.Forms.Button();
            this.button_Prev = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.videoView_Player = new LibVLCSharp.WinForms.VideoView();
            this.statusStrip_Info.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel_Controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Sound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoView_Player)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip_Info
            // 
            this.statusStrip_Info.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_Info.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Info});
            this.statusStrip_Info.Location = new System.Drawing.Point(0, 528);
            this.statusStrip_Info.Name = "statusStrip_Info";
            this.statusStrip_Info.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip_Info.Size = new System.Drawing.Size(1067, 26);
            this.statusStrip_Info.TabIndex = 0;
            this.statusStrip_Info.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Info
            // 
            this.toolStripStatusLabel_Info.Name = "toolStripStatusLabel_Info";
            this.toolStripStatusLabel_Info.Size = new System.Drawing.Size(59, 20);
            this.toolStripStatusLabel_Info.Text = "Ready...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.playlistsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // playlistsToolStripMenuItem
            // 
            this.playlistsToolStripMenuItem.Name = "playlistsToolStripMenuItem";
            this.playlistsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.playlistsToolStripMenuItem.Text = "Playlists";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panel_Controls
            // 
            this.panel_Controls.Controls.Add(this.trackBar_Sound);
            this.panel_Controls.Controls.Add(this.button_SoundMute);
            this.panel_Controls.Controls.Add(this.button_Open);
            this.panel_Controls.Controls.Add(this.button_Options);
            this.panel_Controls.Controls.Add(this.button_Next);
            this.panel_Controls.Controls.Add(this.button_PauseStop);
            this.panel_Controls.Controls.Add(this.button_Prev);
            this.panel_Controls.Controls.Add(this.button1);
            this.panel_Controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Controls.Location = new System.Drawing.Point(0, 454);
            this.panel_Controls.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Controls.Name = "panel_Controls";
            this.panel_Controls.Size = new System.Drawing.Size(1067, 74);
            this.panel_Controls.TabIndex = 2;
            // 
            // trackBar_Sound
            // 
            this.trackBar_Sound.Location = new System.Drawing.Point(480, 18);
            this.trackBar_Sound.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar_Sound.Maximum = 100;
            this.trackBar_Sound.Name = "trackBar_Sound";
            this.trackBar_Sound.Size = new System.Drawing.Size(500, 56);
            this.trackBar_Sound.TabIndex = 7;
            this.trackBar_Sound.Scroll += new System.EventHandler(this.trackBar_Sound_Scroll);
            // 
            // button_SoundMute
            // 
            this.button_SoundMute.BackgroundImage = global::WindowsFormsMediaPlayer.Properties.Resources.soundon1;
            this.button_SoundMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_SoundMute.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_SoundMute.Location = new System.Drawing.Point(987, 0);
            this.button_SoundMute.Margin = new System.Windows.Forms.Padding(4);
            this.button_SoundMute.Name = "button_SoundMute";
            this.button_SoundMute.Size = new System.Drawing.Size(80, 74);
            this.button_SoundMute.TabIndex = 6;
            this.button_SoundMute.UseVisualStyleBackColor = true;
            this.button_SoundMute.Click += new System.EventHandler(this.button_SoundMute_Click);
            // 
            // button_Open
            // 
            this.button_Open.BackgroundImage = global::WindowsFormsMediaPlayer.Properties.Resources.openfile1;
            this.button_Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Open.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Open.Location = new System.Drawing.Point(400, 0);
            this.button_Open.Margin = new System.Windows.Forms.Padding(4);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(80, 74);
            this.button_Open.TabIndex = 5;
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button_Options
            // 
            this.button_Options.BackgroundImage = global::WindowsFormsMediaPlayer.Properties.Resources.options1;
            this.button_Options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Options.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Options.Location = new System.Drawing.Point(320, 0);
            this.button_Options.Margin = new System.Windows.Forms.Padding(4);
            this.button_Options.Name = "button_Options";
            this.button_Options.Size = new System.Drawing.Size(80, 74);
            this.button_Options.TabIndex = 4;
            this.button_Options.UseVisualStyleBackColor = true;
            // 
            // button_Next
            // 
            this.button_Next.BackgroundImage = global::WindowsFormsMediaPlayer.Properties.Resources.next1;
            this.button_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Next.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Next.Location = new System.Drawing.Point(240, 0);
            this.button_Next.Margin = new System.Windows.Forms.Padding(4);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(80, 74);
            this.button_Next.TabIndex = 3;
            this.button_Next.UseVisualStyleBackColor = true;
            // 
            // button_PauseStop
            // 
            this.button_PauseStop.BackgroundImage = global::WindowsFormsMediaPlayer.Properties.Resources.stop1;
            this.button_PauseStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_PauseStop.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_PauseStop.Location = new System.Drawing.Point(160, 0);
            this.button_PauseStop.Margin = new System.Windows.Forms.Padding(4);
            this.button_PauseStop.Name = "button_PauseStop";
            this.button_PauseStop.Size = new System.Drawing.Size(80, 74);
            this.button_PauseStop.TabIndex = 2;
            this.button_PauseStop.UseVisualStyleBackColor = true;
            // 
            // button_Prev
            // 
            this.button_Prev.BackgroundImage = global::WindowsFormsMediaPlayer.Properties.Resources.prev1;
            this.button_Prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Prev.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Prev.Location = new System.Drawing.Point(80, 0);
            this.button_Prev.Margin = new System.Windows.Forms.Padding(4);
            this.button_Prev.Name = "button_Prev";
            this.button_Prev.Size = new System.Drawing.Size(80, 74);
            this.button_Prev.TabIndex = 1;
            this.button_Prev.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsMediaPlayer.Properties.Resources.play1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 74);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // videoView_Player
            // 
            this.videoView_Player.BackColor = System.Drawing.Color.Black;
            this.videoView_Player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView_Player.Location = new System.Drawing.Point(0, 28);
            this.videoView_Player.Margin = new System.Windows.Forms.Padding(4);
            this.videoView_Player.MediaPlayer = null;
            this.videoView_Player.Name = "videoView_Player";
            this.videoView_Player.Size = new System.Drawing.Size(1067, 426);
            this.videoView_Player.TabIndex = 3;
            this.videoView_Player.Text = "videoView1";
            // 
            // MainPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.videoView_Player);
            this.Controls.Add(this.panel_Controls);
            this.Controls.Add(this.statusStrip_Info);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Madia Player v1.0.1";
            this.statusStrip_Info.ResumeLayout(false);
            this.statusStrip_Info.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_Controls.ResumeLayout(false);
            this.panel_Controls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Sound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoView_Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip_Info;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Info;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Controls;
        private LibVLCSharp.WinForms.VideoView videoView_Player;
        private System.Windows.Forms.Button button_Prev;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar_Sound;
        private System.Windows.Forms.Button button_SoundMute;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button button_Options;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_PauseStop;
    }
}

