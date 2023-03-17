using System;
using System.IO;
using System.Windows;
using TemplateEngine.Docx;

namespace ClubOrganizer.Pages.Fast_Tennis.Class.Docx
{
    internal class ContractDocx
    {
        internal static void Save()
        {
            string shortname = NewClient.Fullname;

            string yr_shortname = ClubOrganizer.Requisites.lastname + " " +
                ClubOrganizer.Requisites.name[..(ClubOrganizer.Requisites.name.Length -
                ClubOrganizer.Requisites.name.Length + 1)] + "." +
                ClubOrganizer.Requisites.secondname[..(ClubOrganizer.Requisites.secondname.Length -
                ClubOrganizer.Requisites.secondname.Length + 1)] + ".";

            string yr_adress = ClubOrganizer.Requisites.yr_index + ", " + ClubOrganizer.Requisites.yr_city + ", " + ClubOrganizer.Requisites.yr_street + ", " + ClubOrganizer.Requisites.yr_house + ", " + ClubOrganizer.Requisites.yr_flat;

            string fc_adress = ClubOrganizer.Requisites.fc_index + ", " + ClubOrganizer.Requisites.fc_city + ", " + ClubOrganizer.Requisites.fc_street + ", " + ClubOrganizer.Requisites.fc_house + ", " + ClubOrganizer.Requisites.fc_flat;

            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string path = doc + @"\Ладога\";
            string path_1 = doc + @"\Ладога\Docx\Договоры\" + NewClient.Lastname + "_" + NewClient.Username + "_" + NewClient.Secondname + @"\";

            DirectoryInfo dirInfo = new(path_1);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            FileInfo fileInfo = new(path + @"Docx\Шаблоны\sample.docx");
            if (fileInfo.Exists)
            {
                fileInfo.CopyTo(path_1 + Convert.ToString(NewClient.id_ctr) + @" - " + DateTime.Now.Year.ToString() + @".docx", true);
            }
            else
            {
                MessageBox.Show("!");
            }

            var valuesToFill = new Content(
                new FieldContent("CTR_number", Convert.ToString(NewClient.id_ctr) + " - " + DateTime.Now.Year.ToString()),
                new FieldContent("Shortname", yr_shortname),
                new FieldContent("CTR_fullname", NewClient.Lastname + " " + NewClient.Username + " " + NewClient.Secondname),
                new FieldContent("CLT_shortname", shortname),
                new FieldContent("Yr_adress", yr_adress),
                new FieldContent("Inn", ClubOrganizer.Requisites.inn),
                new FieldContent("KPP", ClubOrganizer.Requisites.kpp),
                new FieldContent("Rass", ClubOrganizer.Requisites.rass),
                new FieldContent("Korr", ClubOrganizer.Requisites.korr),
                new FieldContent("Fc_adress", fc_adress),
                new FieldContent("CLT_phone", NewClient.Phone),
                new FieldContent("Shortname_2", yr_shortname),
                new FieldContent("CLT_shortname_1", shortname),
                new FieldContent("CRT_date_1", DateTime.Now.ToString("d")),
                new FieldContent("CRT_date_2", DateTime.Now.ToString("d")),
                new FieldContent("CRT_date_3", DateTime.Now.ToString("d"))
            );

            using var outputDocument = new TemplateProcessor(path_1 + Convert.ToString(NewClient.id_ctr) + @" - " + DateTime.Now.Year.ToString() + ".docx").SetRemoveContentControls(true);
            outputDocument.FillContent(valuesToFill);
            outputDocument.SaveChanges();
        }
    }
}
