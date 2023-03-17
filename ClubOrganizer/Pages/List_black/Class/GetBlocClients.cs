using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.List_black.Class
{
    class GetBlocClients
    {
        internal static void Get()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/clients.db;Version=3;";
            string query = "SELECT id, Фамилия," +
                "Имя, Отчество, Телефон," +
                "Зарегистрирован, Администратор, ЧС FROM clients_data WHERE ЧС=@block";

            string control = "Да";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@block", control.ToLower());
            SQLiteDataAdapter da = new(cmd);
            da.Fill(BlockData.dt_clients);
            db_conn.Close();
        }
    }
}
