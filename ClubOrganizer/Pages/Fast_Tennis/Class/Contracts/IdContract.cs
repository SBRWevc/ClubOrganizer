using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.Fast_Tennis.Class.Contracts
{
    class IdContract
    {
        internal static void GetID()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/contracts.db;Version=3;";

            string query = "SELECT id FROM contracts_data ORDER BY id DESC LIMIT 1";
            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            SQLiteDataReader? dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                NewClient.id_ctr = dr.GetInt32(dr.GetOrdinal("id"));
            }
            db_conn.Close();
        }
    }
}
