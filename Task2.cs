using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static FileSystemWatcher watcher = new FileSystemWatcher(Environment.SystemDirectory);

        static bool EnabhngRaisingEvents { get; private set; }

        static void Main(string[] args)
        {
            watcher.Filter = "*.ini";
            watcher.IncludeSubdirectories = true;
            watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.Size;
            watcher.Changed += new FileSystemEventHandler(watcher_Changed);
            EnabhngRaisingEvents = true;
            static void watcher_Changed(object sender, FileSystemEventArgs e)
            {
                Console.WriteLine("Changed: {0}", e.FullPath);
            }
        }
    }
}
