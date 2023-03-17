using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.List_clients.Class
{
    class BlcClient
    {
        internal static void Block()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/clients.db;Version=3;";
            string query = "UPDATE clients_data SET ЧС=@yes WHERE id=@id";
            var id = ClientsData.id;

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@yes", "да");
            cmd.ExecuteNonQuery();
            db_conn.Close();
        }
    }
}
