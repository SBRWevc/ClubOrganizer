using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.List_black.Class
{
    class GetInfo
    {
        internal static void Block_info()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/clients.db;Version=3;";
            string query = "SELECT * FROM block_data WHERE id_client=@id";

            var id_client = BlockData.id;

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@id", id_client);
            SQLiteDataReader? dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                BlockData.reason = dr.GetString(dr.GetOrdinal("reason"));
                BlockData.date = dr.GetString(dr.GetOrdinal("date"));
            }

            db_conn.Close();
        }
    }
}
