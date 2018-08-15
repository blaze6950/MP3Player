using System;
using System.Collections.Generic;
using NAudio.Wave;

namespace MP3Player.Models
{
    [Serializable]
    public class Model
    {
        [NonSerialized] private AudioFileReader _audioFile;

        private List<PlayList> _dataList = new List<PlayList>();

        [NonSerialized] private WaveOutEvent _outputDevice = new WaveOutEvent();

        private int _volume = 10; // min 0, max 100

        public Model()
        {
            OutputDevice.PlaybackStopped += OnPlaybackStopped;
        }

        public AudioFileReader AudioFile
        {
            get => _audioFile;
            set
            {
                _audioFile = value;
                if (_audioFile != null)
                {
                    _audioFile.Volume = Volume / 100f;
                    if (OutputDevice == null)
                    {
                        OutputDevice = new WaveOutEvent();
                        OutputDevice.PlaybackStopped += OnPlaybackStopped;
                    }
                }
            }
        }

        public WaveOutEvent OutputDevice
        {
            get => _outputDevice;
            set => _outputDevice = value;
        }

        public int Volume
        {
            get => _volume;
            set
            {
                _volume = value;
                if (AudioFile != null)
                    AudioFile.Volume = value / 100f;
            }
        }

        public List<PlayList> DataList
        {
            get => _dataList;

            set => _dataList = value;
        }

        public event EventHandler<EventArgs> TrackIsEnd;

        public void PlayFile()
        {
            if (AudioFile != null)
            {
                if (OutputDevice.PlaybackState == PlaybackState.Stopped)
                    OutputDevice.Init(AudioFile);
                OutputDevice.Play();
            }
        }

        public void StopFile()
        {
            //OutputDevice?.Stop();
            OnPlaybackStopped(this, new StoppedEventArgs());
        }

        public void PauseFile()
        {
            OutputDevice?.Pause();
        }

        public void SetPositionFile(long pos)
        {
            if (AudioFile != null)
                AudioFile.Position = pos;
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            if (AudioFile != null && AudioFile.FileName != string.Empty)
                if (sender is Model)
                {
                    OutputDevice?.Dispose();
                    OutputDevice = null;
                    AudioFile?.Dispose();
                    AudioFile = null;
                }
                else if ((int) (AudioFile.CurrentTime.TotalSeconds + 0.026) == (int) AudioFile.TotalTime.TotalSeconds)
                {
                    OutputDevice?.Dispose();
                    OutputDevice = null;
                    AudioFile?.Dispose();
                    AudioFile = null;
                    TrackIsEnd.Invoke(sender, args);
                }
        }
    }
}