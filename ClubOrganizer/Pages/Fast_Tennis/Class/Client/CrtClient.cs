using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.Fast_Tennis.Class.Client
{
    class CrtClient
    {
        internal static void Create()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/clients.db;Version=3;";
            string query_ins = "INSERT INTO clients_data (Фамилия, Имя, Отчество, " +
                "Телефон, Зарегистрирован, Администратор, ЧС, fullname) " +
                "VALUES (@Lastname, @Name, @Secondname, @Phone, @Registration, @Admin, " +
                "@Black, @Fullname)";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd_add = new(query_ins, db_conn);
            cmd_add.Parameters.AddWithValue("@Lastname", NewClient.Lastname);
            cmd_add.Parameters.AddWithValue("@Name", NewClient.Username);
            cmd_add.Parameters.AddWithValue("@Secondname", NewClient.Secondname);
            cmd_add.Parameters.AddWithValue("@Phone", NewClient.Phone);
            cmd_add.Parameters.AddWithValue("@Registration", NewClient.Registration);
            cmd_add.Parameters.AddWithValue("@Admin", NewClient.Admin);
            cmd_add.Parameters.AddWithValue("@Black", NewClient.Black);
            cmd_add.Parameters.AddWithValue("@Fullname", NewClient.Fullname);
            cmd_add.ExecuteNonQuery();
            db_conn.Close();

            IdClient.GetID();
        }
    }
}
