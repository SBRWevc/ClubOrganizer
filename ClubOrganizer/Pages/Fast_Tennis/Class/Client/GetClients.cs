using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.Fast_Tennis.Class.Client
{
    internal class GetClients
    {
        internal static void GetLast()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/clients.db;Version=3;";
            string query = "SELECT DISTINCT Фамилия " +
                "FROM clients_data WHERE ЧС=@block";

            string control = "Нет";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@block", control.ToLower());
            SQLiteDataAdapter da = new(cmd);
            da.Fill(NewClient.lt_clients_last);
            db_conn.Close();
        }
        internal static void GetUser()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/clients.db;Version=3;";
            string query = "SELECT DISTINCT Имя " +
                "FROM clients_data WHERE ЧС=@block AND Фамилия=@lastname";

            string control = "Нет";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@block", control.ToLower());
            cmd.Parameters.AddWithValue("@lastname", NewClient.Lastname);
            SQLiteDataAdapter da = new(cmd);
            da.Fill(NewClient.lt_clients_user);
            db_conn.Close();
        }
        internal static void GetSec()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/clients.db;Version=3;";
            string query = "SELECT DISTINCT Отчество " +
                "FROM clients_data WHERE ЧС=@block AND Фамилия=@lastname AND Имя=@name";

            string control = "Нет";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@block", control.ToLower());
            cmd.Parameters.AddWithValue("@lastname", NewClient.Lastname);
            cmd.Parameters.AddWithValue("@name", NewClient.Username);
            SQLiteDataAdapter da = new(cmd);
            da.Fill(NewClient.lt_clients_sec);
            db_conn.Close();
        }
        internal static void GetPhon()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/clients.db;Version=3;";
            string query = "SELECT Телефон " +
                "FROM clients_data WHERE ЧС=@block AND Фамилия=@lastname AND Имя=@name AND Отчество=@secondname";

            string control = "Нет";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@block", control.ToLower());
            cmd.Parameters.AddWithValue("@lastname", NewClient.Lastname);
            cmd.Parameters.AddWithValue("@name", NewClient.Username);
            cmd.Parameters.AddWithValue("@secondname", NewClient.Secondname);
            SQLiteDataAdapter da = new(cmd);
            da.Fill(NewClient.lt_clients_phon);
            db_conn.Close();
        }
    }
}
