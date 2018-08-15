using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using MP3Player.Models;
using MP3Player.Views;
using NAudio.Wave;
using File = TagLib.File;

namespace MP3Player.Presenters
{
    public class Presenter
    {
        private readonly Model _model = new Model();
        private readonly IView _view;
        private PlayList _currentPlayList;
        private int _currentTrack;

        private bool _isLock;
        private bool _isPlayList;
        private bool _isRepeat;
        private IViewPL _viewPL;

        public Presenter(IView view)
        {
            _view = view;
            _view.OpenToolStripButton += OpenToolStripButtonClick;
            _view.FileOpened += OpenFile;
            _view.PlayButtonClick += PlayFile;
            _view.PauseButtonClick += PauseFile;
            _view.StopButtonClick += StopFile;
            _view.BackButtonClick += BackButton;
            _view.ForwardButtonClick += ForwardButton;
            _view.VolumeValueChanged += VolumeChanged;
            _view.TrackBarValueChanged += TrackBarChanged;
            _view.Timer.Tick += TickTimer;
            _view.ShowPlayListClick += ShowPlayList;
            _view.LockClick += Lock;
            _view.FormMoved += FormMoved;
            _view.LoadModel += LoadModel;
            _view.SaveModel += SaveModel;

            _viewPL = new PlayListForm();
            _viewPL.CreatePLClick += CreatePL;
            _viewPL.RenamePLClick += RenamePl;
            _viewPL.DeletePLClick += DeletePL;
            _viewPL.AddFileClick += AddFile;
            _viewPL.DeleteFileClick += DeleteFile;
            _viewPL.PlayClick += Play;
            _viewPL.RepeatClick += Repeat;

            _model.TrackIsEnd += IsEnd;
        }

        public string NameOfNewPL { get; set; }

        private void SaveModel(object sender, EventArgs eventArgs)
        {
            FileStream stream = null;

            try
            {
                stream = new FileStream("playlists.bin", FileMode.Create, FileAccess.Write);

                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, _model.DataList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }

        private void LoadModel(object sender, EventArgs eventArgs)
        {
            FileStream stream = null;
            try
            {
                stream = new FileStream("playlists.bin", FileMode.Open, FileAccess.Read);

                var formatter = new BinaryFormatter();
                _model.DataList = (List<PlayList>) formatter.Deserialize(stream);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            foreach (var item in _model.DataList)
            {
                _viewPL.GetTreeView.Nodes.Add(item.Name);
                _viewPL.GetTreeView.Nodes[_viewPL.GetTreeView.Nodes.Count - 1].Tag = item;
                if (item.Source.Count > 0)
                    foreach (var item2 in item.Source)
                        _viewPL.GetTreeView.Nodes[_viewPL.GetTreeView.Nodes.Count - 1].Nodes
                            .Add(Path.GetFileNameWithoutExtension(item2));
            }
        }

        private void IsEnd(object sender, EventArgs eventArgs)
        {
            _view.Timer.Stop();
            if (_isRepeat)
            {
                if (_isPlayList)
                    if (_currentPlayList.Source.Count > 1)
                        if (_currentPlayList.Source.Count - 1 > _currentTrack)
                            _currentTrack++;
                        else
                            _currentTrack = 0;
                ClearFile(sender, eventArgs);
                OpenFile(sender, eventArgs);
                PlayFile(sender, eventArgs);
            }
            else
            {
                _view.SetDefaultView();
                if (_isPlayList)
                    if (_currentPlayList.Source.Count > 1)
                        if (_currentPlayList.Source.Count - 1 > _currentTrack)
                        {
                            _currentTrack++;
                            ClearFile(sender, eventArgs);
                            OpenFile(sender, eventArgs);
                            PlayFile(sender, eventArgs);
                            _view.PlayButton.PerformClick();
                        }
            }
        }

        #region MainFormMethods

        private void FormMoved(object sender, EventArgs eventArgs)
        {
            if (_isLock)
            {
                var location = _view.GetLocation;
                location.Y += _view.GetSize.Height;
                if (_viewPL != null)
                    _viewPL.SetLocation = location;
            }
        }

        private void Lock(object sender, EventArgs eventArgs)
        {
            _isLock = !_isLock;
        }

        private void ShowPlayList(object sender, EventArgs eventArgs)
        {
            if (_viewPL == null)
            {
                _viewPL = new PlayListForm();
                _viewPL.CreatePLClick += CreatePL;
                _viewPL.RenamePLClick += RenamePl;
                _viewPL.DeletePLClick += DeletePL;
                _viewPL.AddFileClick += AddFile;
                _viewPL.DeleteFileClick += DeleteFile;
                _viewPL.PlayClick += Play;
                _viewPL.RepeatClick += Repeat;
            }
            _viewPL.ShowForm();
            _viewPL.ActivateForm();
            var location = _view.GetLocation;
            location.Y += _view.GetSize.Height;
            _viewPL.SetLocation = location;
        }

        private void OpenToolStripButtonClick(object sender, EventArgs eventArgs)
        {
            if (_currentPlayList != null)
            {
                _view.Timer.Stop();
                ClearFile(sender, eventArgs);
                _currentPlayList = null;
                _currentTrack = 0;
                _view.SetDefaultView();
            }
            var res = _view.GetOpenFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                _currentPlayList = new PlayList();
                _currentPlayList.Source.Add(_view.GetOpenFileDialog.FileName);
                _view.SetEnabled(_view.PlayButton, true);
                OpenFile(sender, eventArgs);
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            _view.Timer.Stop();
            _model.AudioFile = new AudioFileReader(_currentPlayList.Source[_currentTrack]);
            _view.TrackTimeBar.Minimum = 0;
            _view.TrackTimeBar.Maximum = (int) _model.AudioFile.TotalTime.TotalSeconds;
            var time = new TimeSpan(0, 0, 0, (int) _model.AudioFile.TotalTime.TotalSeconds);
            _view.FullTimeLabel.Text = time.ToString();
            var tagFile = File.Create(_currentPlayList.Source[_currentTrack]);
            _view.TrackSingers.Text = tagFile.Tag.FirstPerformer;
            _view.TrackAlbum.Text = tagFile.Tag.Album;
            if (tagFile.Tag.Title == null)
            {
                _view.TrackName.Text = Path.GetFileNameWithoutExtension(_currentPlayList.Source[_currentTrack]);
            }
            else
            {
                _view.TrackName.Text = tagFile.Tag.Title;
            }
            if (tagFile.Tag.Pictures.Length > 0)
            {
                var image = tagFile.Tag.Pictures[0];
                var stream = new MemoryStream(image.Data.Data); // create an in memory stream
                Image im = new Bitmap(stream);
                _view.TrackPictureBox.Image = im;
            }
        }

        private void PlayFile(object sender, EventArgs e)
        {
            _model.PlayFile();
            _view.Timer.Start();
        }

        private void StopFile(object sender, EventArgs e)
        {
            _model.PauseFile();
            _model.SetPositionFile(0);
            _view.Timer.Stop();
            _view.TrackTimeBar.Value = 0;
        }

        private void PauseFile(object sender, EventArgs e)
        {
            _model.PauseFile();
        }

        private void ClearFile(object sender, EventArgs e)
        {
            _model.StopFile();
        }

        private void VolumeChanged(object sender, EventArgs e)
        {
            _model.Volume = ((TrackBar) sender).Value;
        }

        private void TrackBarChanged(object sender, EventArgs e)
        {
            var time = new TimeSpan(0, 0, 0, _view.TrackTimeBar.Value);
            if (_model.AudioFile != null)
                _model.AudioFile.CurrentTime = time;
            _view.CurrentTimeLabel.Text = time.ToString();
        }

        private void ForwardButton(object sender, EventArgs eventArgs)
        {
            if (_isPlayList)
                if (_currentPlayList.Source.Count > 1)
                {
                    if (_currentPlayList.Source.Count - 1 > _currentTrack)
                        _currentTrack++;
                    else
                        _currentTrack = 0;
                    ClearFile(sender, eventArgs);
                    OpenFile(sender, eventArgs);
                    PlayFile(sender, eventArgs);
                }
        }

        private void BackButton(object sender, EventArgs eventArgs)
        {
            if (_isPlayList)
                if (_currentPlayList.Source.Count > 1)
                {
                    if (0 < _currentTrack)
                        _currentTrack--;
                    else
                        _currentTrack = _currentPlayList.Source.Count - 1;
                    ClearFile(sender, eventArgs);
                    OpenFile(sender, eventArgs);
                    PlayFile(sender, eventArgs);
                }
        }

        private void TickTimer(object sender, EventArgs e)
        {
            if (_view.CanI)
                if (_model.AudioFile != null)
                {
                    var currentseconds = _model.AudioFile.CurrentTime.TotalSeconds;
                    if (_view.TrackTimeBar.Value != currentseconds)
                    {
                        _view.TrackTimeBar.Value = (int) currentseconds;
                        var time = new TimeSpan(0, 0, 0, _view.TrackTimeBar.Value);
                        _view.CurrentTimeLabel.Text = time.ToString();
                    }
                }
        }

        #endregion

        #region PlayListFormMethods

        private void Play(object sender, EventArgs eventArgs)
        {
            _isPlayList = true;
            _view.GoShowForm();
            if (_currentPlayList != null)
            {
                _view.Timer.Stop();
                ClearFile(sender, eventArgs);
                _currentPlayList = null;
                _view.SetDefaultView();
            }
            if (_viewPL.GetTreeView.SelectedNode.Level == 0)
            {
                if (_viewPL.GetTreeView.SelectedNode.Nodes.Count != 0)
                {
                    _currentPlayList = (PlayList) _viewPL.GetTreeView.SelectedNode.Tag;
                    _currentTrack = 0;
                    OpenFile(sender, eventArgs);
                }
                else
                {
                    _currentPlayList = (PlayList) _viewPL.GetTreeView.SelectedNode.Tag;
                    _currentTrack = 0;
                }
            }
            else if (_viewPL.GetTreeView.SelectedNode.Level == 1)
            {
                _currentPlayList = (PlayList) _viewPL.GetTreeView.SelectedNode.Parent.Tag;
                _currentTrack = _viewPL.GetTreeView.SelectedNode.Index;
                OpenFile(sender, eventArgs);
            }
        }

        private void Repeat(object sender, EventArgs eventArgs)
        {
            _isRepeat = !_isRepeat;
            var selectedNodeLevel = _viewPL.GetTreeView.SelectedNode?.Level;
            if (selectedNodeLevel != null)
                if (selectedNodeLevel == 0)
                    _isPlayList = true;
                else
                    _isPlayList = false;
        }

        private void DeletePL(object sender, EventArgs eventArgs)
        {
            if (_viewPL.GetTreeView.SelectedNode.Level == 0)
            {
                _model.DataList.Remove((PlayList) _viewPL.GetTreeView.SelectedNode.Tag);
                _viewPL.GetTreeView.SelectedNode.Remove();
            }
        }

        private void RenamePl(object sender, EventArgs eventArgs)
        {
            if (_viewPL.GetTreeView.SelectedNode.Level == 0)
            {
                var newNamePlForm = new NewNamePLForm(this);
                if (newNamePlForm.ShowDialog() == DialogResult.OK)
                {
                    ((PlayList) _viewPL.GetTreeView.SelectedNode.Tag).Name = NameOfNewPL;
                    _viewPL.GetTreeView.SelectedNode.Text = NameOfNewPL;
                }
            }
        }

        public void CreatePL(object sender, EventArgs eventArgs)
        {
            var res = MessageBox.Show("Do you want to choose folder?", "Create or open?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                res = _viewPL.GetFolderBrowserDialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    var isExclusive = true;
                    foreach (var node in _viewPL.GetTreeView.Nodes)
                        if (((PlayList) ((TreeNode) node).Tag).FullPath == _viewPL.GetFolderBrowserDialog.SelectedPath)
                        {
                            isExclusive = false;
                            break;
                        }
                    if (isExclusive)
                    {
                        _model.DataList.Add(new PlayList(_viewPL.GetFolderBrowserDialog.SelectedPath));
                        _viewPL.GetTreeView.Nodes.Add(_model.DataList[_model.DataList.Count - 1].Name);
                        _viewPL.GetTreeView.Nodes[_viewPL.GetTreeView.Nodes.Count - 1].Tag =
                            _model.DataList[_model.DataList.Count - 1];
                        foreach (var path in _model.DataList[_model.DataList.Count - 1].Source)
                            _viewPL.GetTreeView.Nodes[_viewPL.GetTreeView.Nodes.Count - 1].Nodes
                                .Add(Path.GetFileNameWithoutExtension(path));
                    }
                    else
                    {
                        MessageBox.Show("That folder is already exists!", "Ooops", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                var newNamePlForm = new NewNamePLForm(this);
                if (newNamePlForm.ShowDialog() == DialogResult.OK)
                {
                    _viewPL.GetTreeView.Nodes.Add(NameOfNewPL);
                    var newPlaylist = new PlayList();
                    newPlaylist.Name = NameOfNewPL;
                    _model.DataList.Add(newPlaylist);
                    _viewPL.GetTreeView.Nodes[_viewPL.GetTreeView.Nodes.Count - 1].Tag = _model.DataList[_model.DataList.Count - 1];
                }
            }
        }

        private void DeleteFile(object sender, EventArgs eventArgs)
        {
            if (_viewPL.GetTreeView.SelectedNode.Level == 1)
            {
                var index = ((PlayList) _viewPL.GetTreeView.SelectedNode.Parent.Tag).Source.FindIndex(p =>
                    Path.GetFileNameWithoutExtension(p) == _viewPL.GetTreeView.SelectedNode
                        .Text);
                ((PlayList) _viewPL.GetTreeView.SelectedNode.Parent.Tag).Source.RemoveAt(index);

                _viewPL.GetTreeView.SelectedNode.Remove();
            }
        }

        private void AddFile(object sender, EventArgs eventArgs)
        {
            if (_viewPL.GetTreeView.SelectedNode.Level == 0)
            {
                var res = _view.GetOpenFileDialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                }
                var index = ((PlayList) _viewPL.GetTreeView.SelectedNode.Tag).Source.FindIndex(p =>
                    p == _view.GetOpenFileDialog.FileName);
                if (index == -1)
                {
                    ((PlayList) _viewPL.GetTreeView.SelectedNode.Tag).Source.Add(_view.GetOpenFileDialog.FileName);
                    _viewPL.GetTreeView.SelectedNode.Nodes.Add(
                        Path.GetFileNameWithoutExtension(_view.GetOpenFileDialog.SafeFileName));
                }
                else
                {
                    MessageBox.Show("That file is already exists!", "Ooops!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else if (_viewPL.GetTreeView.SelectedNode.Level == 1)
            {
                var res = _view.GetOpenFileDialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                }
                var index = ((PlayList) _viewPL.GetTreeView.SelectedNode.Parent.Tag).Source.FindIndex(p =>
                    p == _view.GetOpenFileDialog.FileName);
                if (index == -1)
                {
                    ((PlayList) _viewPL.GetTreeView.SelectedNode.Parent.Tag).Source.Add(_view.GetOpenFileDialog
                        .FileName);
                    _viewPL.GetTreeView.SelectedNode.Parent.Nodes.Add(
                        Path.GetFileNameWithoutExtension(_view.GetOpenFileDialog.SafeFileName));
                }
                else
                {
                    MessageBox.Show("That file is already exists!", "Ooops!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        #endregion
    }
}