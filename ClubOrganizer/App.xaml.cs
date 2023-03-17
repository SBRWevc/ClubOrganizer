using ClubOrganizer.Functions.DB;
using ClubOrganizer.Functions.Dir;
using ClubOrganizer.Functions.Files;
using System;
using System.IO;
using System.Windows;

namespace ClubOrganizer
{
    public partial class App : Application
    {
        public App()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string path = doc + @"\Ладога";

            DirectoryInfo dirInfo = new(path);
            if(!dirInfo.Exists) 
            {
                CreateDir.Create();
                CreateDB.Create();
                CopyFiles.CopyDocx();
            }
        }
    }
}
