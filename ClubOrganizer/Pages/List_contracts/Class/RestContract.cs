using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.List_contracts.Class
{
    internal class RestContract
    {
        internal static void Get()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/contracts.db;Version=3;";
            string query = "SELECT Остаток, Имя, Итого FROM contracts_data WHERE id=@id";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@id", Contracts.id);
            SQLiteDataReader? dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Contracts.rest = dr.GetString(dr.GetOrdinal("Остаток"));
                Contracts.Fullname = dr.GetString(dr.GetOrdinal("Имя"));
                Contracts.total = dr.GetString(dr.GetOrdinal("Итого"));
            }

            db_conn.Close();
        }
    }
}
