using System;
using System.Collections.Generic;
using System.IO;

namespace MP3Player
{
    [Serializable]
    public class PlayList
    {
        private string _fullPath;
        private string _name;

        public PlayList()
        {
        }

        public PlayList(string path)
        {
            _fullPath = path;
            _name = Path.GetFileName(path);
            var files = Directory.GetFiles(path);
            foreach (var file in files)
                if (Path.GetExtension(file) == ".mp3")
                    Source.Add(file);
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string FullPath
        {
            get => _fullPath;
            set => _fullPath = value;
        }

        public List<string> Source { get; } = new List<string>();

        public string GetPathFile(string name)
        {
            foreach (var path in Source)
                if (Path.GetFileNameWithoutExtension(path) == name)
                    return path;
            return null;
        }
    }
}