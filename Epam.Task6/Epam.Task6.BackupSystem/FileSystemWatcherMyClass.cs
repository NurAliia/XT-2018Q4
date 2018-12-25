// <copyright file="FileSystemWatcherMyClass.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task6.BackupSystem
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Security.Permissions;
    using System.Threading;

    /// <summary>
    ///  This class performs a back up system.
    /// </summary>
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    public class FileSystemWatcherMyClass
    {
        /// <summary>
        /// Catalog keeps all object
        /// </summary>
        private static List<ObjectBackUpSystem> changeLog = new List<ObjectBackUpSystem>();

        /// <summary>
        /// Variable for multi copy
        /// </summary>
        private static bool enabled = true;

        /// <summary>
        /// Instance of the file system watcher
        /// </summary>
        private FileSystemWatcher watcher;

        /// <summary>
        /// Create object file system watcher and initialize catalog
        /// </summary>
        /// <param name="path">current path</param>
        public void InitializeWatcher(string path)
        {
            if (changeLog.Count() == 0)
            {
                using (StreamReader read = new StreamReader("..\\catalog\\backup.txt"))
                {
                    while (!read.EndOfStream)
                    {
                        string[] lines = read.ReadLine().Split('|');
                        changeLog.Add(new ObjectBackUpSystem(lines[0], lines[1], lines[2], DateTime.Parse(lines[3]), changeLog.Count()));
                    }
                }
            }

            if (!string.IsNullOrEmpty(path) && Directory.Exists(path))
            {
                this.watcher = new FileSystemWatcher(path);
                this.watcher.InternalBufferSize = 10000000;
                this.watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                    | NotifyFilters.FileName | NotifyFilters.DirectoryName;

                this.watcher.Created += new FileSystemEventHandler(FileWatcherOnCreated);
                this.watcher.Changed += new FileSystemEventHandler(FileWatcherOnChanged);
                this.watcher.Deleted += new FileSystemEventHandler(FileWatcherOnDeleted);
                this.watcher.Renamed += new RenamedEventHandler(OnRenamed);

                this.watcher.IncludeSubdirectories = true;
            }
        }

        /// <summary>
        /// Enable raising events
        /// </summary>
        public void Start()
        {
            this.watcher.EnableRaisingEvents = true;
        }

        /// <summary>
        /// Stop tracking and save catalog into hidden storage file
        /// </summary>
        public void Stop()
        {
            this.watcher.EnableRaisingEvents = false;
            enabled = false;

            using (StreamWriter write = new StreamWriter("..\\catalog\\backup.txt"))
            {
                foreach (var item in changeLog)
                {
                    write.WriteLine(item.ToString());
                }
            }
        }

        /// <summary>
        /// Start back up files
        /// </summary>
        /// <param name="date">set date</param>
        public void StartBackUp(DateTime date)
        {
            DirectoryInfo directory = new DirectoryInfo(this.watcher.Path);
            directory.Empty();

            if (changeLog.Count() > 0 && date >= changeLog.First().CreateDate)
            {
                for (int i = 0; i < changeLog.Count() && changeLog[i].CreateDate <= date; i++)
                {
                    switch (changeLog[i].Action)
                    {
                        case "Created":
                        case "Renamed":
                        case "Changed":
                            BackUp(changeLog[i]);
                            break;
                        case "Deleted":
                            Delete(changeLog[i].FullName);
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Back up file or directory
        /// </summary>
        /// <param name="item">current file or directory</param>
        private static void BackUp(ObjectBackUpSystem item)
        {
            if (File.Exists(item.OldFullName) || Directory.Exists(item.OldFullName))
            {
                Delete(item.OldFullName);
            }

            if (File.Exists($"..\\catalog\\{item.Id}.txt"))
            {
                File.Copy($"..\\catalog\\{item.Id}.txt", item.FullName, true);
            }
            else
            {
                Directory.CreateDirectory(item.FullName);
            }
        }

        /// <summary>
        /// Define the event delete handler
        /// </summary>
        /// <param name="sender">App resource</param>
        /// <param name="e">Object provides information about the renaming operation</param>
        private static void FileWatcherOnDeleted(object sender, FileSystemEventArgs e)
        {
            enabled = true;
            changeLog.Add(new ObjectBackUpSystem(e.ChangeType.ToString(), e.FullPath, DateTime.Now, changeLog.Count()));
        }

        /// <summary>
        /// Define the event create handler.
        /// </summary>
        /// <param name="sender">App resource</param>
        /// <param name="e">Object provides information about the renaming operation</param>
        private static void FileWatcherOnCreated(object sender, FileSystemEventArgs e)
        {
            enabled = true;
            if (Directory.Exists(e.FullPath))
            {
                changeLog.Add(new ObjectBackUpSystem(e.ChangeType.ToString(), e.FullPath, DateTime.Now, changeLog.Count()));
            }
            else if (File.Exists(e.FullPath))
            {
                FileWatcherOnChanged(sender, e);
            }
        }

        /// <summary>
        /// Define the event change handler.
        /// </summary>
        /// <param name="sender">App resource</param>
        /// <param name="e">Object provides info about the renaming operation</param>
        private static void FileWatcherOnChanged(object sender, FileSystemEventArgs e)
        {
            if (File.Exists(e.FullPath) && enabled == true)
            {
                CopyFile(e.FullPath, e.ChangeType.ToString(), e.FullPath);
                enabled = false;
            }
        }

        /// <summary>
        /// Define the event rename handler.
        /// </summary>
        /// <param name="source">App resource</param>
        /// <param name="e">Object provides information about the renaming operation</param>
        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            enabled = true;
            if (File.GetAttributes(e.FullPath).HasFlag(FileAttributes.Directory))
            {
                var date = DateTime.Now;
                changeLog.Add(new ObjectBackUpSystem(e.ChangeType.ToString(), e.FullPath, e.OldFullPath, date, changeLog.Count()));
                DirectoryInfo d = new DirectoryInfo(e.FullPath);

                DirectoryInfo[] array = d.GetDirectories();
                foreach (DirectoryInfo item in array)
                {
                    changeLog.Add(new ObjectBackUpSystem("Renamed", Path.Combine(e.FullPath, item.Name), Path.Combine(e.OldFullPath, item.Name), date, changeLog.Count()));
                }

                FileInfo[] infos = d.GetFiles();
                foreach (FileInfo item in infos)
                {
                    // Do the renaming here
                    var newPath = Path.Combine(item.DirectoryName, item.Name);
                    changeLog.Add(new ObjectBackUpSystem("Created", newPath, item.FullName, date, changeLog.Count()));
                    File.Move(item.FullName, newPath);
                }
            }
            else if (File.Exists(e.FullPath))
            {
                CopyFile(e.FullPath, e.ChangeType.ToString(), e.OldFullPath);
            }
        }

        /// <summary>
        /// Delete current file and directory
        /// </summary>
        /// <param name="path">current path of file or directory</param>
        private static void Delete(string path)
        {
                if (File.Exists(path))
                {
                File.Delete(path);
                }
                else 
                {
                    Directory.Delete(path, true);
                }
        }

        /// <summary>
        /// Copy files into a special storage file
        /// </summary>
        /// <param name="path">current path</param>
        /// <param name="action">current action</param>
        /// <param name="oldName">old name current object</param>
        private static void CopyFile(string path, string action, string oldName)
        {
            changeLog.Add(new ObjectBackUpSystem(action, path, oldName, DateTime.Now, changeLog.Count()));
            Thread.Sleep(100);
            File.Copy(path, $"..\\catalog\\{changeLog.Last().Id}.txt", true);
        }
    }
}
