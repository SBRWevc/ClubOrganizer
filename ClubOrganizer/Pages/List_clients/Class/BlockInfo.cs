using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.List_clients.Class
{
    class BlockInfo
    {
        internal static void Info()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/clients.db;Version=3;";
            string query = "INSERT INTO block_data (id_client, reason, date) " +
                "VALUES (@id_client, @reason, @date)";


            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@id_client", ClientsData.id);
            cmd.Parameters.AddWithValue("@reason", ClientsData.reason);
            cmd.Parameters.AddWithValue("@date", ClientsData.date);
            cmd.ExecuteNonQuery();
            db_conn.Close();
        }
    }
}
