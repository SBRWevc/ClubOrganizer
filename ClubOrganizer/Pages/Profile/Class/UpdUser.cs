using System;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;

namespace ClubOrganizer.Pages.Profile.Class
{
    class UpdUser
    {
        readonly static string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        readonly static string db_path = doc + @"\Ладога\DB";

        readonly static string conn = @"Data Source=" + db_path + "/users.db;Version=3;";

        // ----- \\ Изменения в БД // ----- \\
        // Обновление логина \\
        internal static void Login_update()
        {
            string query = "UPDATE users_data SET Логин=@login WHERE id=@id";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@login", Userdata.Login);
            cmd.Parameters.AddWithValue("@id", Userdata.id);
            cmd.ExecuteNonQuery();
            db_conn.Close();
        }
        // Обновление пароля \\
        internal static void Pass_update()
        {
            string query = "UPDATE users_data SET Пароль=@pass WHERE id=@id";

            string? hash = HashPass(Userdata.Pass);

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@pass", hash);
            cmd.Parameters.AddWithValue("@id", Userdata.id);
            cmd.ExecuteNonQuery();
            db_conn.Close();
        }
        // Обновление всех данных \\
        internal static void All_update()
        {
            string query = "UPDATE users_data SET Пароль=@pass, Логин=@login WHERE id=@id";

            string? hash = HashPass(Userdata.Pass);

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@login", Userdata.Login);
            cmd.Parameters.AddWithValue("@pass", hash);
            cmd.Parameters.AddWithValue("@id", Userdata.id);
            cmd.ExecuteNonQuery();
            db_conn.Close();
        }

        // Хеширование пароля \\
        private static string? HashPass(string password)
        {

            byte[] b = Encoding.ASCII.GetBytes(password);
            byte[] hash = MD5.HashData(b);

            StringBuilder sb = new();
            foreach (var a in hash)
            {
                sb.Append(a.ToString("X2"));
            }

            return Convert.ToString(sb);
        }
    }
}
