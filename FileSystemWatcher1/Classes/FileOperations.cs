using System;
using System.IO;
using static System.IO.Path;

namespace FileSystemWatcher1.Classes
{
    public class FileOperations : FileSystemWatcher
    {
        /// <summary>
        /// Path to check for file
        /// </summary>
        public string MonitorPath { get; set; }
        /// <summary>
        /// File name to watch for
        /// </summary>
        public string FileName { get; set; }
        
        public FileOperations(string monitorPath, string fileName)
        {
            if (!Directory.Exists(monitorPath))
            {
                throw new Exception($"Missing {monitorPath}");
            }

            MonitorPath = monitorPath;

            Created += OnCreated;

            Path = MonitorPath;
            Filter = fileName;
            FileName = fileName;
            EnableRaisingEvents = true;
            NotifyFilter = NotifyFilters.FileName;
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            var fileName = Combine(MonitorPath, GetFileName(e.FullPath));
            
            if (fileName.Equals(Combine(MonitorPath,FileName), StringComparison.OrdinalIgnoreCase))
            {
                // TODO
            }
        }
        public void Start()
        {
            EnableRaisingEvents = true;
        }
        public void Stop()
        {
            EnableRaisingEvents = false;
        }
    }
}