﻿using System;
using System.IO;

namespace Task1
{
    class Task1
    {
        static void ShowDirectory(DirectoryInfo dir)
        {
            foreach (FileInfo file in dir.GetFiles())
            {
                Console.WriteLine("File:{0}", file.FullName);
            }
            foreach (DirectoryInfo subDir in dir.GetDirectories())
            {
                ShowDirectory(subDir);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(Environment.SystemDirectory);
            ShowDirectory(dir);
        }
    }
}
