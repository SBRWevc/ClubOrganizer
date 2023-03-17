using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using TemplateEngine.Docx;

namespace ClubOrganizer.Pages.List_contracts.Class
{
    internal class Docx
    {
        internal static void Create()
        {
            string yr_shortname = ClubOrganizer.Requisites.lastname + " " +
                ClubOrganizer.Requisites.name[..(ClubOrganizer.Requisites.name.Length -
                ClubOrganizer.Requisites.name.Length + 1)] + "." +
                ClubOrganizer.Requisites.secondname[..(ClubOrganizer.Requisites.secondname.Length -
                ClubOrganizer.Requisites.secondname.Length + 1)] + ".";

            string yr_adress = ClubOrganizer.Requisites.yr_index + ", " + ClubOrganizer.Requisites.yr_city + ", " + ClubOrganizer.Requisites.yr_street + ", " + ClubOrganizer.Requisites.yr_house + ", " + ClubOrganizer.Requisites.yr_flat;

            string fc_adress = ClubOrganizer.Requisites.fc_index + ", " + ClubOrganizer.Requisites.fc_city + ", " + ClubOrganizer.Requisites.fc_street + ", " + ClubOrganizer.Requisites.fc_house + ", " + ClubOrganizer.Requisites.fc_flat;

            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string path = doc + @"\Ладога\";
            string path_1 = doc + @"\Ладога\Docx\Договоры\Temp\";

            DirectoryInfo dirInfo = new(path_1);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            FileInfo fileInfo = new(path + @"Docx\Шаблоны\sample.docx");
            if (fileInfo.Exists)
            {
                fileInfo.CopyTo(path_1 + Convert.ToString(Contracts.id) + @" - " + DateTime.Now.Year.ToString() + @"temp.docx", true);
            }
            else
            {
                MessageBox.Show("!");
            }

            var valuesToFill = new Content(
                new FieldContent("CTR_number", Convert.ToString(Contracts.id) + " - " + DateTime.Now.Year.ToString()),
                new FieldContent("Shortname", yr_shortname),
                new FieldContent("CTR_fullname", Contracts.Lastname + " " + Contracts.Name + " " + Contracts.Secondname),
                new FieldContent("CLT_shortname", Contracts.Fullname),
                new FieldContent("Yr_adress", yr_adress),
                new FieldContent("Inn", ClubOrganizer.Requisites.inn),
                new FieldContent("KPP", ClubOrganizer.Requisites.kpp),
                new FieldContent("Rass", ClubOrganizer.Requisites.rass),
                new FieldContent("Korr", ClubOrganizer.Requisites.korr),
                new FieldContent("Fc_adress", fc_adress),
                new FieldContent("CLT_phone", Contracts.Phone),
                new FieldContent("Shortname_2", yr_shortname),
                new FieldContent("CLT_shortname_1", Contracts.Fullname),
                new FieldContent("CRT_date_1", DateTime.Now.ToString("d")),
                new FieldContent("CRT_date_2", DateTime.Now.ToString("d")),
                new FieldContent("CRT_date_3", DateTime.Now.ToString("d"))
            );

            using var outputDocument = new TemplateProcessor(path_1 + Convert.ToString(Contracts.id) + @" - " + DateTime.Now.Year.ToString() + "temp.docx").SetRemoveContentControls(true);
            outputDocument.FillContent(valuesToFill);
            outputDocument.SaveChanges();

            string path_contract = doc + @"\Ладога\Docx\Договоры\Temp\";

            ProcessStartInfo procs_contract = new()
            {
                WorkingDirectory = path_contract,
                FileName = Convert.ToString(Contracts.id) + @" - " + DateTime.Now.Year.ToString() + @"temp.docx",
                UseShellExecute = true
            };
            Process.Start(procs_contract);
        }
    }
}
