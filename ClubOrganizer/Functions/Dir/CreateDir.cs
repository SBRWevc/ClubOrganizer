using System;
using System.IO;
using System.Threading;

namespace ClubOrganizer.Functions.Dir
{
    internal class CreateDir
    {
        // Запуск создания папок \\
        internal static void Create()
        {
            DB();
            Docx();
            DocxSer();
            DocxCtr();
            DocxSamp();
        }
        // Создание директории для БД \\
        private static void DB()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string path = doc + @"\Ладога\DB";

            // Создание пути БД \\
            DirectoryInfo dirInfo = new(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
        }
        // Создание директории для документов \\
        private static void Docx()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string path = doc + @"\Ладога\Docx";

            // Создание пути Бэкапов \\
            DirectoryInfo dirInfo = new(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();

                DocxSer();
                DocxCtr();
            }
        }
        // Создание директории для счетов \\
        private static void DocxSer()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string path = doc + @"\Ладога\Docx\Счета";

            // Создание пути Бэкапов \\
            DirectoryInfo dirInfo = new(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
        }
        // Создание директории для договоров \\
        private static void DocxCtr()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string path = doc + @"\Ладога\Docx\Договоры";

            // Создание пути Бэкапов \\
            DirectoryInfo dirInfo = new(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
        }
        // Создание директории для шаблонов \\
        private static void DocxSamp()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string path = doc + @"\Ладога\Docx\Шаблоны";

            // Создание пути шаблонов \\
            DirectoryInfo dirInfo = new(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
        }
    }
}
