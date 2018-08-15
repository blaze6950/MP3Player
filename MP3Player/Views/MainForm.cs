using System;
using System.Drawing;
using System.Windows.Forms;

namespace MP3Player.Views
{
    public partial class MainForm : Form, IView
    {
        private bool _isCompact;

        public MainForm()
        {
            InitializeComponent();
        }

        public bool CanI { get; set; } = true;
        public Timer Timer => timer;
        public Label CurrentTimeLabel => currentTimeLabel;

        public Label FullTimeLabel => fullTimeLabel;

        public void SetDefaultView()
        {
            TrackTimeBar.Maximum = 0;
            //manageButtonsPanel.Enabled = false;
            SetEnabled(BackButton, false);
            SetEnabled(PauseButton, false);
            SetEnabled(StopButton, false);
            SetEnabled(ForwardButton, false);
            SetEnabled(PlayButton, true);
            CurrentTimeLabel.Text = "00:00:00";
            FullTimeLabel.Text = "00:00:00";
            TrackAlbum.Text = string.Empty;
            TrackName.Text = string.Empty;
            TrackSingers.Text = string.Empty;
            TrackPictureBox.Image = BackgroundImage;
        }

        public void SetEnabled(Button sender, bool state)
        {
            sender.Enabled = state;
            if (!state)
                sender.BackColor = SystemColors.ControlDark;
            else
                sender.BackColor = Color.Thistle;
        }

        public void GoShowForm()
        {
            Activate();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenToolStripButton.Invoke(sender, e);
        }

        private void volumeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            toolTip.Show(TrackVolumeLevel.Value.ToString(), TrackVolumeLevel);
            VolumeValueChanged?.Invoke(sender, e);
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            TrackBarValueChanged.Invoke(sender, e);
        }

        private void trackBar_KeyDown(object sender, MouseEventArgs e)
        {
            CanI = false;
        }

        private void trackBar_KeyUp(object sender, MouseEventArgs e)
        {
            CanI = true;
        }

        private void showPlayListButton_Click(object sender, EventArgs e)
        {
            ShowPlayListClick.Invoke(sender, e);
        }

        private void compactButton_Click(object sender, EventArgs e)
        {
            if (!_isCompact)
            {
                Width = 189;
                Height = 238;
                TrackTimeBar.Hide();
                infoTrack.Hide();
                TrackPictureBox.Location = new Point(14, 33);
                TrackPictureBox.Height = 98;
                TrackPictureBox.Width = 145;
                var x = 3;
                for (var i = 0; i < ManageButtonsPanel.Controls.Count; i++)
                {
                    ManageButtonsPanel.Controls[i].Location = new Point(x + 33 * i, 3);
                    ManageButtonsPanel.Controls[i].Height = 27;
                    ManageButtonsPanel.Controls[i].Width = 27;
                }
                ManageButtonsPanel.Location = new Point(3, 163);
                ManageButtonsPanel.Height = 34;
                ManageButtonsPanel.Width = 168;
                timePanel.Location = new Point(14, 137);
                timePanel.Height = 20;
                timePanel.Width = 145;
                TopMost = true;
            }
            else
            {
                Width = 434;
                Height = 309;
                TrackTimeBar.Show();
                infoTrack.Show();
                TrackPictureBox.Location = new Point(12, 33);
                TrackPictureBox.Height = 100;
                TrackPictureBox.Width = 100;
                var x = 2;
                for (var i = 0; i < ManageButtonsPanel.Controls.Count; i++)
                {
                    ManageButtonsPanel.Controls[i].Location = new Point(x + 46 * i, 2);
                    ManageButtonsPanel.Controls[i].Height = 40;
                    ManageButtonsPanel.Controls[i].Width = 40;
                }
                ManageButtonsPanel.Location = new Point(12, 217);
                ManageButtonsPanel.Height = 45;
                ManageButtonsPanel.Width = 231;
                timePanel.Location = new Point(12, 191);
                timePanel.Height = 20;
                timePanel.Width = 231;
                TopMost = false;
            }
            _isCompact = !_isCompact;
        }

        private void lockButton_Click(object sender, EventArgs e)
        {
            LockClick.Invoke(sender, e);
        }

        private void MainForm_Move(object sender, EventArgs e)
        {
            FormMoved.Invoke(sender, e);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadModel.Invoke(sender, e);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveModel.Invoke(sender, e);
        }

        #region Events

        public event EventHandler<EventArgs> PlayButtonClick;
        public event EventHandler<EventArgs> PauseButtonClick;
        public event EventHandler<EventArgs> StopButtonClick;
        public event EventHandler<EventArgs> BackButtonClick;
        public event EventHandler<EventArgs> ForwardButtonClick;
        public event EventHandler<EventArgs> FileOpened;
        public event EventHandler<EventArgs> VolumeValueChanged;
        public event EventHandler<EventArgs> TrackBarValueChanged;
        public event EventHandler<EventArgs> OpenToolStripButton;
        public event EventHandler<EventArgs> ShowPlayListClick;
        public event EventHandler<EventArgs> LockClick;
        public event EventHandler<EventArgs> FormMoved;
        public event EventHandler<EventArgs> LoadModel;
        public event EventHandler<EventArgs> SaveModel;

        #endregion

        #region FormPropertiesManagementItems

        public Size GetSize => Size;
        public Point GetLocation => Location;

        public Point SetLocation
        {
            set => Location = value;
        }

        public OpenFileDialog GetOpenFileDialog => openFileDialog;
        public PictureBox TrackPictureBox => trackPictureBox;

        public TextBox TrackName => trackName;

        public TextBox TrackSingers => trackSingers;

        public TextBox TrackAlbum => trackAlbum;

        public TrackBar TrackTimeBar => trackTimeBar;

        public TrackBar TrackVolumeLevel => trackVolumeLevel;

        public Panel ManageButtonsPanel => manageButtonsPanel;

        public Button BackButton => backButton;

        public Button PlayButton => playButton;

        public Button PauseButton => pauseButton;

        public Button StopButton => stopButton;

        public Button ForwardButton => forwardButton;

        #endregion

        #region ManageButtons_ClickEventFunctions

        public void playButton_Click(object sender, EventArgs e)
        {
            PlayButtonClick?.Invoke(sender, e);
            SetEnabled(BackButton, true);
            SetEnabled(PauseButton, true);
            SetEnabled(StopButton, true);
            SetEnabled(ForwardButton, true);
            SetEnabled(PlayButton, false);
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            PauseButtonClick?.Invoke(sender, e);
            SetEnabled(PauseButton, false);
            SetEnabled(PlayButton, true);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            StopButtonClick?.Invoke(sender, e);
            SetEnabled(BackButton, false);
            SetEnabled(PauseButton, false);
            SetEnabled(StopButton, false);
            SetEnabled(ForwardButton, false);
            SetEnabled(PlayButton, true);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            BackButtonClick?.Invoke(sender, e);
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            ForwardButtonClick?.Invoke(sender, e);
        }

        #endregion
    }
}