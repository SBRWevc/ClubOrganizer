using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.Users.Class
{
    class UpdUser
    {
        internal static void Change_info()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/users.db;Version=3;";
            string query = "SELECT id, Фамилия," +
                "Имя, Отчество, Пол, Должность," +
                "Логин FROM users_data";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteDataAdapter da = new(query, db_conn);
            SQLiteCommandBuilder cmdb = new(da);
            da.Update(ClubOrganizer.Users.dt_users);
            db_conn.Close();
        }
    }
}
