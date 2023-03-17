using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.Auth.Class
{
    internal class Userdata
    {
        // Получение данных из БД \\
        internal static void Get_info()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/users.db;Version=3;";
            string query = "SELECT id, Фамилия, " +
                "Имя, Отчество, Пол, Должность, Логин " +
                "FROM users_data WHERE @id=id";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@id", ClubOrganizer.Userdata.id);
            SQLiteDataReader? dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ClubOrganizer.Userdata.Lastname = dr.GetString(dr.GetOrdinal("Фамилия"));
                ClubOrganizer.Userdata.Name = dr.GetString(dr.GetOrdinal("Имя"));
                ClubOrganizer.Userdata.Secondname = dr.GetString(dr.GetOrdinal("Отчество"));
                ClubOrganizer.Userdata.Gender = dr.GetString(dr.GetOrdinal("Пол"));
                ClubOrganizer.Userdata.Position = dr.GetString(dr.GetOrdinal("Должность"));
                ClubOrganizer.Userdata.Login = dr.GetString(dr.GetOrdinal("Логин"));
            }

            db_conn.Close();
        }

        // Очистка полученых данных \\
        internal static void Clear_info()
        {
            ClubOrganizer.Userdata.id = 0;
            ClubOrganizer.Userdata.Lastname = "";
            ClubOrganizer.Userdata.Name = "";
            ClubOrganizer.Userdata.Secondname = "";
            ClubOrganizer.Userdata.Gender = "";
            ClubOrganizer.Userdata.Position = "";
            ClubOrganizer.Userdata.Login = "";
        }
    }
}
