using System;
using System.Data.SQLite;
using System.Data;
using ClubOrganizer.Functions.String;

namespace ClubOrganizer.Pages.Auth.Class
{
    internal class Auth
    {
        internal static void DataCheck()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/users.db;Version=3;";
            string query = "SELECT * FROM users_data WHERE Логин=@login AND Пароль=@pass";

            string login = AuthData.Login;
            string? pass = HashString.Hash(AuthData.Pass);

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@pass", pass);
            SQLiteDataAdapter da = new(cmd);
            DataTable dt = new();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Userdata.Clear_info();

                SQLiteDataReader? dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ClubOrganizer.Userdata.id = dr.GetInt32(dr.GetOrdinal("id"));
                }

                AuthData.ok = true;

                AuthData.Login = "";
                AuthData.Pass = "";

                dt.Rows.Clear();
                db_conn.Close();
            }
        }
    }
}
