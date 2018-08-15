using System;
using System.Drawing;
using System.Windows.Forms;

namespace MP3Player.Views
{
    public partial class PlayListForm : Form, IViewPL
    {
        public PlayListForm()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            Show();
        }

        public void ActivateForm()
        {
            Activate();
        }

        private void createPLButton_Click(object sender, EventArgs e)
        {
            CreatePLClick.Invoke(sender, e);
        }

        private void deletePLButton_Click(object sender, EventArgs e)
        {
            DeletePLClick.Invoke(sender, e);
            CheckTreeView();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (GetTreeView.SelectedNode.Level == 0)
            {
                renamePLButton.Enabled = true;
                deletePLButton.Enabled = true;
                addFileButton.Enabled = true;
                deleteFileButton.Enabled = false;
                playSelectedButton.Enabled = true;
                repeatButton.Enabled = true;
            }
            else
            {
                renamePLButton.Enabled = false;
                deletePLButton.Enabled = false;
                addFileButton.Enabled = true;
                deleteFileButton.Enabled = true;
                playSelectedButton.Enabled = true;
                repeatButton.Enabled = true;
            }
        }

        public void CheckTreeView()
        {
            if (GetTreeView.TopNode == null)
            {
                renamePLButton.Enabled = false;
                deletePLButton.Enabled = false;
                addFileButton.Enabled = false;
                deleteFileButton.Enabled = false;
                playSelectedButton.Enabled = false;
                repeatButton.Enabled = false;
            }
        }

        private void playSelectedButton_Click(object sender, EventArgs e)
        {
            PlayClick.Invoke(sender, e);
        }

        private void renamePLButton_Click(object sender, EventArgs e)
        {
            RenamePLClick.Invoke(sender, e);
        }

        private void deleteFileButton_Click(object sender, EventArgs e)
        {
            DeleteFileClick.Invoke(sender, e);
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            AddFileClick.Invoke(sender, e);
        }

        private void repeatButton_Click(object sender, EventArgs e)
        {
            if (SystemColors.ControlDark == repeatButton.BackColor)
                repeatButton.BackColor = Color.BlueViolet;
            else
                repeatButton.BackColor = SystemColors.ControlDark;
            RepeatClick.Invoke(sender, e);
        }

        private void PlayListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        #region Events

        public event EventHandler<EventArgs> CreatePLClick;
        public event EventHandler<EventArgs> RenamePLClick;
        public event EventHandler<EventArgs> DeletePLClick;
        public event EventHandler<EventArgs> PlayClick;
        public event EventHandler<EventArgs> RepeatClick;
        public event EventHandler<EventArgs> DeleteFileClick;
        public event EventHandler<EventArgs> AddFileClick;

        #endregion

        #region Properties

        public Point GetLocation => Location;

        public Point SetLocation
        {
            set => Location = value;
        }

        public TreeView GetTreeView => treeView;

        public FolderBrowserDialog GetFolderBrowserDialog => folderBrowserDialog;

        #endregion
    }
}