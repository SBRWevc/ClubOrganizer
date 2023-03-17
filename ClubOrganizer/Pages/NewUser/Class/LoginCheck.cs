using System;
using System.Data.SQLite;
using System.Data;

namespace ClubOrganizer.Pages.NewUser.Class
{
    class LoginCheck
    {
        internal static void Check()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/users.db;Version=3;";
            string query = "SELECT Логин FROM users_data WHERE Логин=@login";
            string login = NewDataUser.Login;

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@login", login);
            SQLiteDataAdapter da = new(cmd);
            DataTable dt = new();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                NewDataUser.Login_state = false;
            }
            else
            {
                NewDataUser.Login_state = true;
            }
        }
    }
}
