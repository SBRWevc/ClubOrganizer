using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.Users.Class
{
    class GetUsers
    {
        internal static void Get_info()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/users.db;Version=3;";
            string query = "SELECT id, Фамилия," +
                "Имя, Отчество, Пол, Должность," +
                "Логин FROM users_data";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            SQLiteDataAdapter da = new(cmd);
            da.Fill(ClubOrganizer.Users.dt_users);
            db_conn.Close();
        }
    }
}
