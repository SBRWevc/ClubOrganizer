using System;
using System.IO;

namespace ClubOrganizer.Functions.Files
{
    internal class CopyFiles
    {
        // Файл договора \\
        internal static void CopyDocx()
        {
        string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string path = doc + @"\Ладога\Docx\Шаблоны";
            
            FileInfo fileInfo = new(path + @"\sample.docx");
            if (!fileInfo.Exists)
            {
                string docx_path = Environment.CurrentDirectory + @"\Resources\Docx\sample.docx";
                
                FileInfo fileDocx = new(docx_path);
                if (fileDocx.Exists)
                {
                    fileDocx.CopyTo(path + @"\sample.docx", true);
                }
            }
        }
    }
}
