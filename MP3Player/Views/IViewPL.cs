using System;
using System.Drawing;
using System.Windows.Forms;

namespace MP3Player.Views
{
    public interface IViewPL
    {
        Point GetLocation { get; }
        Point SetLocation { set; }
        TreeView GetTreeView { get; }
        FolderBrowserDialog GetFolderBrowserDialog { get; }
        event EventHandler<EventArgs> CreatePLClick;
        event EventHandler<EventArgs> RenamePLClick;
        event EventHandler<EventArgs> DeletePLClick;
        event EventHandler<EventArgs> PlayClick;
        event EventHandler<EventArgs> RepeatClick;
        event EventHandler<EventArgs> DeleteFileClick;
        event EventHandler<EventArgs> AddFileClick;

        void ShowForm();
        void ActivateForm();
    }
}