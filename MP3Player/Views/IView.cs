using System;
using System.Drawing;
using System.Windows.Forms;

namespace MP3Player.Views
{
    public interface IView
    {
        Size GetSize { get; }
        Point SetLocation { set; }
        Point GetLocation { get; }
        OpenFileDialog GetOpenFileDialog { get; }
        PictureBox TrackPictureBox { get; }
        TextBox TrackName { get; }
        TextBox TrackSingers { get; }
        TextBox TrackAlbum { get; }
        TrackBar TrackTimeBar { get; }
        TrackBar TrackVolumeLevel { get; }
        Timer Timer { get; }
        Label CurrentTimeLabel { get; }
        Label FullTimeLabel { get; }
        Panel ManageButtonsPanel { get; }
        bool CanI { get; set; }

        Button BackButton { get; }
        Button PlayButton { get; }
        Button PauseButton { get; }
        Button StopButton { get; }
        Button ForwardButton { get; }
        void GoShowForm();

        event EventHandler<EventArgs> PlayButtonClick;
        event EventHandler<EventArgs> PauseButtonClick;
        event EventHandler<EventArgs> StopButtonClick;
        event EventHandler<EventArgs> BackButtonClick;
        event EventHandler<EventArgs> ForwardButtonClick;
        event EventHandler<EventArgs> FileOpened;
        event EventHandler<EventArgs> VolumeValueChanged;
        event EventHandler<EventArgs> TrackBarValueChanged;
        event EventHandler<EventArgs> OpenToolStripButton;
        event EventHandler<EventArgs> ShowPlayListClick;
        event EventHandler<EventArgs> LockClick;
        event EventHandler<EventArgs> FormMoved;
        event EventHandler<EventArgs> LoadModel;
        event EventHandler<EventArgs> SaveModel;

        void SetDefaultView();
        void SetEnabled(Button sender, bool state);
    }
}