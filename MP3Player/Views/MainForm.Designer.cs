namespace MP3Player.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.trackPictureBox = new System.Windows.Forms.PictureBox();
            this.infoTrack = new System.Windows.Forms.GroupBox();
            this.trackAlbum = new System.Windows.Forms.TextBox();
            this.trackSingers = new System.Windows.Forms.TextBox();
            this.trackName = new System.Windows.Forms.TextBox();
            this.albumLabel = new System.Windows.Forms.Label();
            this.singersLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.trackTimeBar = new System.Windows.Forms.TrackBar();
            this.backButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.manageButtonsPanel = new System.Windows.Forms.Panel();
            this.volumeGB = new System.Windows.Forms.GroupBox();
            this.trackVolumeLevel = new System.Windows.Forms.TrackBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.showPlayListButton = new System.Windows.Forms.ToolStripButton();
            this.compactButton = new System.Windows.Forms.ToolStripButton();
            this.lockButton = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timePanel = new System.Windows.Forms.Panel();
            this.fullTimeLabel = new System.Windows.Forms.Label();
            this.separatorLabel = new System.Windows.Forms.Label();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackPictureBox)).BeginInit();
            this.infoTrack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackTimeBar)).BeginInit();
            this.manageButtonsPanel.SuspendLayout();
            this.volumeGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolumeLevel)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.timePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackPictureBox
            // 
            this.trackPictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trackPictureBox.Location = new System.Drawing.Point(12, 33);
            this.trackPictureBox.Name = "trackPictureBox";
            this.trackPictureBox.Size = new System.Drawing.Size(100, 100);
            this.trackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trackPictureBox.TabIndex = 0;
            this.trackPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.trackPictureBox, "Track image");
            // 
            // infoTrack
            // 
            this.infoTrack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.infoTrack.Controls.Add(this.trackAlbum);
            this.infoTrack.Controls.Add(this.trackSingers);
            this.infoTrack.Controls.Add(this.trackName);
            this.infoTrack.Controls.Add(this.albumLabel);
            this.infoTrack.Controls.Add(this.singersLabel);
            this.infoTrack.Controls.Add(this.nameLabel);
            this.infoTrack.Location = new System.Drawing.Point(118, 33);
            this.infoTrack.Name = "infoTrack";
            this.infoTrack.Size = new System.Drawing.Size(288, 100);
            this.infoTrack.TabIndex = 1;
            this.infoTrack.TabStop = false;
            this.infoTrack.Text = "Info";
            // 
            // trackAlbum
            // 
            this.trackAlbum.Location = new System.Drawing.Point(63, 71);
            this.trackAlbum.Name = "trackAlbum";
            this.trackAlbum.ReadOnly = true;
            this.trackAlbum.Size = new System.Drawing.Size(219, 20);
            this.trackAlbum.TabIndex = 0;
            this.trackAlbum.TabStop = false;
            // 
            // trackSingers
            // 
            this.trackSingers.Location = new System.Drawing.Point(63, 45);
            this.trackSingers.Name = "trackSingers";
            this.trackSingers.ReadOnly = true;
            this.trackSingers.Size = new System.Drawing.Size(219, 20);
            this.trackSingers.TabIndex = 0;
            this.trackSingers.TabStop = false;
            // 
            // trackName
            // 
            this.trackName.Location = new System.Drawing.Point(63, 18);
            this.trackName.Name = "trackName";
            this.trackName.ReadOnly = true;
            this.trackName.Size = new System.Drawing.Size(219, 20);
            this.trackName.TabIndex = 0;
            this.trackName.TabStop = false;
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Location = new System.Drawing.Point(18, 74);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(39, 13);
            this.albumLabel.TabIndex = 2;
            this.albumLabel.Text = "Album:";
            // 
            // singersLabel
            // 
            this.singersLabel.AutoSize = true;
            this.singersLabel.Location = new System.Drawing.Point(6, 48);
            this.singersLabel.Name = "singersLabel";
            this.singersLabel.Size = new System.Drawing.Size(51, 13);
            this.singersLabel.TabIndex = 1;
            this.singersLabel.Text = "Singer(s):";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(19, 21);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // trackTimeBar
            // 
            this.trackTimeBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.trackTimeBar.Location = new System.Drawing.Point(12, 140);
            this.trackTimeBar.Maximum = 0;
            this.trackTimeBar.Name = "trackTimeBar";
            this.trackTimeBar.Size = new System.Drawing.Size(394, 45);
            this.trackTimeBar.TabIndex = 0;
            this.trackTimeBar.TabStop = false;
            this.trackTimeBar.TickFrequency = 0;
            this.trackTimeBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackTimeBar.MouseCaptureChanged += new System.EventHandler(this.trackBar_ValueChanged);
            this.trackTimeBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar_KeyDown);
            this.trackTimeBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_KeyUp);
            // 
            // backButton
            // 
            this.backButton.Enabled = false;
            this.backButton.Location = new System.Drawing.Point(2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(40, 40);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "<<";
            this.toolTip.SetToolTip(this.backButton, "Play previous track");
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(94, 2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(40, 40);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "▶";
            this.toolTip.SetToolTip(this.playButton, "Play");
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Enabled = false;
            this.pauseButton.Location = new System.Drawing.Point(186, 2);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(40, 40);
            this.pauseButton.TabIndex = 5;
            this.pauseButton.Text = "| |";
            this.toolTip.SetToolTip(this.pauseButton, "Pause");
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(140, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(40, 40);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "■";
            this.toolTip.SetToolTip(this.stopButton, "Stop");
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Enabled = false;
            this.forwardButton.Location = new System.Drawing.Point(48, 2);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(40, 40);
            this.forwardButton.TabIndex = 2;
            this.forwardButton.Text = ">>";
            this.toolTip.SetToolTip(this.forwardButton, "Play next track");
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // manageButtonsPanel
            // 
            this.manageButtonsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manageButtonsPanel.Controls.Add(this.backButton);
            this.manageButtonsPanel.Controls.Add(this.forwardButton);
            this.manageButtonsPanel.Controls.Add(this.playButton);
            this.manageButtonsPanel.Controls.Add(this.stopButton);
            this.manageButtonsPanel.Controls.Add(this.pauseButton);
            this.manageButtonsPanel.Location = new System.Drawing.Point(12, 217);
            this.manageButtonsPanel.Name = "manageButtonsPanel";
            this.manageButtonsPanel.Size = new System.Drawing.Size(231, 45);
            this.manageButtonsPanel.TabIndex = 8;
            // 
            // volumeGB
            // 
            this.volumeGB.Controls.Add(this.trackVolumeLevel);
            this.volumeGB.Location = new System.Drawing.Point(249, 191);
            this.volumeGB.Name = "volumeGB";
            this.volumeGB.Size = new System.Drawing.Size(157, 71);
            this.volumeGB.TabIndex = 9;
            this.volumeGB.TabStop = false;
            this.volumeGB.Text = "Volume";
            // 
            // trackVolumeLevel
            // 
            this.trackVolumeLevel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.trackVolumeLevel.Location = new System.Drawing.Point(6, 19);
            this.trackVolumeLevel.Maximum = 100;
            this.trackVolumeLevel.Name = "trackVolumeLevel";
            this.trackVolumeLevel.Size = new System.Drawing.Size(145, 45);
            this.trackVolumeLevel.TabIndex = 0;
            this.trackVolumeLevel.TabStop = false;
            this.trackVolumeLevel.TickFrequency = 5;
            this.trackVolumeLevel.Value = 10;
            this.trackVolumeLevel.ValueChanged += new System.EventHandler(this.volumeTrackBar_ValueChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.showPlayListButton,
            this.compactButton,
            this.lockButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(418, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(49, 22);
            this.openToolStripButton.Text = "Open...";
            this.openToolStripButton.ToolTipText = "Open file";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // showPlayListButton
            // 
            this.showPlayListButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.showPlayListButton.Image = ((System.Drawing.Image)(resources.GetObject("showPlayListButton.Image")));
            this.showPlayListButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showPlayListButton.Name = "showPlayListButton";
            this.showPlayListButton.Size = new System.Drawing.Size(60, 22);
            this.showPlayListButton.Text = "PlayList...";
            this.showPlayListButton.ToolTipText = "Open window playlist";
            this.showPlayListButton.Click += new System.EventHandler(this.showPlayListButton_Click);
            // 
            // compactButton
            // 
            this.compactButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.compactButton.Image = ((System.Drawing.Image)(resources.GetObject("compactButton.Image")));
            this.compactButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.compactButton.Name = "compactButton";
            this.compactButton.Size = new System.Drawing.Size(60, 22);
            this.compactButton.Text = "Compact";
            this.compactButton.ToolTipText = "Enable/Disable compact view";
            this.compactButton.Click += new System.EventHandler(this.compactButton_Click);
            // 
            // lockButton
            // 
            this.lockButton.CheckOnClick = true;
            this.lockButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lockButton.Image = ((System.Drawing.Image)(resources.GetObject("lockButton.Image")));
            this.lockButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lockButton.Name = "lockButton";
            this.lockButton.Size = new System.Drawing.Size(36, 22);
            this.lockButton.Text = "Lock";
            this.lockButton.ToolTipText = "Lock playlist window";
            this.lockButton.Click += new System.EventHandler(this.lockButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Sound files (*.mp3)|*.mp3";
            // 
            // timer
            // 
            this.timer.Interval = 500;
            // 
            // timePanel
            // 
            this.timePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timePanel.Controls.Add(this.fullTimeLabel);
            this.timePanel.Controls.Add(this.separatorLabel);
            this.timePanel.Controls.Add(this.currentTimeLabel);
            this.timePanel.Location = new System.Drawing.Point(12, 191);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(231, 20);
            this.timePanel.TabIndex = 11;
            // 
            // fullTimeLabel
            // 
            this.fullTimeLabel.AutoSize = true;
            this.fullTimeLabel.Location = new System.Drawing.Point(85, 3);
            this.fullTimeLabel.Name = "fullTimeLabel";
            this.fullTimeLabel.Size = new System.Drawing.Size(49, 13);
            this.fullTimeLabel.TabIndex = 2;
            this.fullTimeLabel.Text = "00:00:00";
            // 
            // separatorLabel
            // 
            this.separatorLabel.AutoSize = true;
            this.separatorLabel.Location = new System.Drawing.Point(61, 3);
            this.separatorLabel.Name = "separatorLabel";
            this.separatorLabel.Size = new System.Drawing.Size(12, 13);
            this.separatorLabel.TabIndex = 1;
            this.separatorLabel.Text = "/";
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Location = new System.Drawing.Point(3, 3);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(49, 13);
            this.currentTimeLabel.TabIndex = 0;
            this.currentTimeLabel.Text = "00:00:00";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(418, 270);
            this.Controls.Add(this.timePanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.volumeGB);
            this.Controls.Add(this.manageButtonsPanel);
            this.Controls.Add(this.trackTimeBar);
            this.Controls.Add(this.infoTrack);
            this.Controls.Add(this.trackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mp3 player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Move += new System.EventHandler(this.MainForm_Move);
            ((System.ComponentModel.ISupportInitialize)(this.trackPictureBox)).EndInit();
            this.infoTrack.ResumeLayout(false);
            this.infoTrack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackTimeBar)).EndInit();
            this.manageButtonsPanel.ResumeLayout(false);
            this.volumeGB.ResumeLayout(false);
            this.volumeGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolumeLevel)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox infoTrack;
        private System.Windows.Forms.Label albumLabel;
        private System.Windows.Forms.Label singersLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox trackAlbum;
        private System.Windows.Forms.TextBox trackName;
        private System.Windows.Forms.TextBox trackSingers;
        private System.Windows.Forms.TrackBar trackVolumeLevel;
        private System.Windows.Forms.GroupBox volumeGB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.Label separatorLabel;
        public System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripButton showPlayListButton;
        private System.Windows.Forms.ToolStripButton compactButton;
        private System.Windows.Forms.ToolStripButton lockButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox trackPictureBox;
        private System.Windows.Forms.TrackBar trackTimeBar;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Panel manageButtonsPanel;
        private System.Windows.Forms.Label fullTimeLabel;
        private System.Windows.Forms.Label currentTimeLabel;
    }
}