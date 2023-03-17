using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace ClubOrganizer.Pages.List_services.Class
{
    internal class Docx
    {
        readonly static string yr_shortname = ClubOrganizer.Requisites.lastname + " " +
                    ClubOrganizer.Requisites.name[..(ClubOrganizer.Requisites.name.Length -
                    ClubOrganizer.Requisites.name.Length + 1)] + "." +
                    ClubOrganizer.Requisites.secondname[..(ClubOrganizer.Requisites.secondname.Length -
                    ClubOrganizer.Requisites.secondname.Length + 1)] + ".";

        internal static void Create()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string path = doc + @"\Ладога\Docx\Счета\Temp\" + Convert.ToString(Services.id_ctr) + "-" + DateTime.Now.Year.ToString() + "_" + Services.id_ser.ToString() + @".docx";

            DirectoryInfo dirinfo = new(doc + @"\Ладога\Docx\Счета\Temp\");
            if (!dirinfo.Exists)
            {
                dirinfo.Create();
            };

            DocX document = DocX.Create(path);

            document.MarginBottom = 20;
            document.MarginLeft = 45;
            document.MarginRight = 45;
            document.MarginTop = 20;

            document.InsertParagraph("Приложение № " + Convert.ToString(Services.id_ctr) + " - " + DateTime.Now.Year.ToString() + " / " + Services.id_ser.ToString()).
                Font("Times New Roman").
                FontSize(18).
                Color(Color.Black).
                Bold(true).
                Alignment = Alignment.center;

            document.InsertParagraph("").
                Font("Times New Roman").
                FontSize(16).
                Color(Color.Black).
                Bold(true).
                Alignment = Alignment.center;

            document.InsertParagraph("СЧЁТ").
                Font("Times New Roman").
                FontSize(18).
                Color(Color.Black).
                Bold(true).
                Alignment = Alignment.center;

            document.InsertParagraph("").
                Font("Times New Roman").
                FontSize(16).
                Color(Color.Black).
                Bold(true).
                Alignment = Alignment.center;

            document.InsertParagraph("Утверждаю:").
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.right;

            document.InsertParagraph("Директор ООО “Спортивный клуб Ладога”").
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.right;

            document.InsertParagraph(yr_shortname).
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.right;

            document.InsertParagraph(DateTime.Now.ToString("dd.MM.yy")).
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.right;

            document.InsertParagraph("").
                Font("Times New Roman").
                FontSize(16).
                Color(Color.Black).
                Bold(true).
                Alignment = Alignment.center;

            document.InsertParagraph("к договору № " + Convert.ToString(Services.id_ctr) + " от " + DateTime.Now.Year.ToString()).
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(true).
                Alignment = Alignment.center;

            document.Save();
        }

        internal static void Table()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string path = doc + @"\Ладога\Docx\Счета\Temp\" + Convert.ToString(Services.id_ctr) + "-" + DateTime.Now.Year.ToString() + "_" + Services.id_ser.ToString() + @".docx";

            DocX document = DocX.Load(path);

            Table table = document.AddTable(9, 8);

            table.Alignment = Alignment.center;

            table.Rows[0].MergeCells(0, 7);
            table.Rows[0].Cells[0].Paragraphs[0].Append(Services.start + " - " + Services.end).
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.center;

            table.Rows[1].MergeCells(0, 7);

            table.Rows[2].Cells[0].Paragraphs[0].Append("День недели").
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.center;
            table.Rows[2].Cells[1].Paragraphs[0].Append("Время занятий").
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.center;
            table.Rows[2].Cells[2].Paragraphs[0].Append("Часов").
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.center;
            table.Rows[2].Cells[3].Paragraphs[0].Append("Тариф. ставка").
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.center;
            table.Rows[2].Cells[4].Paragraphs[0].Append("Месяца").
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.center;
            table.Rows[2].Cells[5].Paragraphs[0].Append("Дней").
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.center;
            table.Rows[2].Cells[6].Paragraphs[0].Append("Часов").
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.center;
            table.Rows[2].Cells[7].Paragraphs[0].Append("Итого").
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.center;

            table.Rows[3].MergeCells(0, 7);

            table.Rows[4].Cells[0].Paragraphs[0].Append(Services.day).
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.center;
            table.Rows[4].Cells[1].Paragraphs[0].Append(Services.tstart + " - " + Services.tend).
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.center;
            table.Rows[4].Cells[2].Paragraphs[0].Append(Services.time).
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.center;
            table.Rows[4].Cells[3].Paragraphs[0].Append(Services.price).
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.center;
            table.Rows[4].Cells[4].Paragraphs[0].Append(ServiceData.month).
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.center;
            table.Rows[4].Cells[5].Paragraphs[0].Append(ServiceData.days).
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.center;
            table.Rows[4].Cells[6].Paragraphs[0].Append(ServiceData.hours).
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.center;
            table.Rows[4].Cells[7].Paragraphs[0].Append(ServiceData.month_price).
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.center;

            table.Rows[5].MergeCells(0, 7);

            table.Rows[6].MergeCells(0, 6);
            table.Rows[6].Cells[0].Paragraphs[0].Append("Количество зарезервированных дней").
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false);
            table.Rows[6].Cells[1].Paragraphs[0].Append(Services.days.ToString()).
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.center;

            table.Rows[7].MergeCells(0, 6);
            table.Rows[7].Cells[0].Paragraphs[0].Append("Количество зарезервированных часов").
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false);
            table.Rows[7].Cells[1].Paragraphs[0].Append(Services.hours).
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.center;

            table.Rows[8].MergeCells(0, 6);
            table.Rows[8].Cells[0].Paragraphs[0].Append("").
                Font("Times New Roman").
                FontSize(10).
                Color(Color.Black).
                Bold(false);
            table.Rows[8].Cells[1].Paragraphs[0].Append(Services.total_price).
                Font("Times New Roman").
                FontSize(12).
                Color(Color.Black).
                Bold(true).
                Alignment = Alignment.center;

            document.InsertParagraph().InsertTableAfterSelf(table);

            document.InsertParagraph("").
                Font("Times New Roman").
                FontSize(16).
                Color(Color.Black).
                Bold(true).
                Alignment = Alignment.center;

            document.Save();
        }

        internal static void Footer()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB\Счета\";

            string conn = @"Data Source=" + db_path + ContractData.CtrID + @".db" + @"; Version=3;";
            string query = "SELECT SUM(Итого) AS t FROM SER_" + Services.id_ser;
            string queryHour = "SELECT SUM(Часов) AS h FROM SER_" + Services.id_ser;

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            SQLiteDataReader? dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ServiceData.totalPrice = dr.GetDouble(dr.GetOrdinal("t"));
            }

            SQLiteCommand cmdH = new(queryHour, db_conn);
            SQLiteDataReader? drH;
            drH = cmdH.ExecuteReader();

            while (drH.Read())
            {
                ServiceData.totalHour = drH.GetDouble(drH.GetOrdinal("h"));
            }

            db_conn.Close();
            string path = doc + @"\Ладога\Docx\Счета\Temp\" + Convert.ToString(Services.id_ctr) + "-" + DateTime.Now.Year.ToString() + "_" + Services.id_ser.ToString() + @".docx";

            DocX document = DocX.Load(path);

            document.InsertParagraph("").
                Font("Times New Roman").
                FontSize(16).
                Color(Color.Black).
                Bold(true).
                Alignment = Alignment.center;

            Table table = document.AddTable(4, 2);

            table.SetBorder(TableBorderType.Top, new Border(BorderStyle.Tcbs_none, 0, 0, Color.White));
            table.SetBorder(TableBorderType.Bottom, new Border(BorderStyle.Tcbs_none, 0, 0, Color.White));
            table.SetBorder(TableBorderType.Left, new Border(BorderStyle.Tcbs_none, 0, 0, Color.White));
            table.SetBorder(TableBorderType.Right, new Border(BorderStyle.Tcbs_none, 0, 0, Color.White));
            table.SetBorder(TableBorderType.InsideH, new Border(BorderStyle.Tcbs_none, 0, 0, Color.White));
            table.SetBorder(TableBorderType.InsideV, new Border(BorderStyle.Tcbs_none, 0, 0, Color.White));

            table.Alignment = Alignment.right;
            table.Rows[2].MergeCells(0, 2);

            table.Rows[0].Cells[0].Paragraphs[0].Append("Итого к оплате:").
                Font("Times New Roman").
                FontSize(13).
                Color(Color.Black).
                Bold(true).
                Alignment = Alignment.right;

            table.Rows[0].Cells[0].Width = 120;

            table.Rows[0].Cells[1].Paragraphs[0].Append(ServiceData.totalPrice.ToString()).
                Font("Times New Roman").
                FontSize(13).
                Color(Color.Black).
                Bold(true).
                Alignment = Alignment.right;

            table.Rows[0].Cells[1].Width = 120;

            table.Rows[1].Cells[0].Paragraphs[0].Append("Итого часов:").
                Font("Times New Roman").
                FontSize(13).
                Color(Color.Black).
                Bold(true).
                Alignment = Alignment.right;

            table.Rows[1].Cells[0].Width = 120;

            table.Rows[1].Cells[1].Paragraphs[0].Append(ServiceData.totalHour.ToString()).
                Font("Times New Roman").
                FontSize(13).
                Color(Color.Black).
                Bold(true).
                Alignment = Alignment.right;

            table.Rows[1].Cells[1].Width = 120;

            table.Rows[2].Cells[0].Width = 240;

            table.Rows[3].Cells[0].Paragraphs[0].Append("Администратор:").
                Font("Times New Roman").
                FontSize(11).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.right;

            table.Rows[3].Cells[0].Width = 120;

            table.Rows[3].Cells[1].Paragraphs[0].Append(Userdata.Lastname + " " +
                    Userdata.Name[..(Userdata.Name.Length - Userdata.Name.Length + 1)] + "." +
                    Userdata.Secondname[..(Userdata.Secondname.Length - Userdata.Secondname.Length + 1)] + ".").
                Font("Times New Roman").
                FontSize(11).
                Color(Color.Black).
                Bold(false).
                Alignment = Alignment.right;

            table.Rows[3].Cells[1].Width = 120;

            document.InsertParagraph().InsertTableAfterSelf(table);

            document.Save();

            ProcessStartInfo procs_service = new()
            {
                WorkingDirectory = doc + @"\Ладога\Docx\Счета\Temp\",
                FileName = path,
                UseShellExecute = true
            };
            Process.Start(procs_service);
        }
    }
}
