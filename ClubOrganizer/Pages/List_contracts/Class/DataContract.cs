using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.List_contracts.Class
{
    internal class DataContract
    {
        internal static void GetInfo()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/contracts.db;Version=3;";
            string query = "SELECT id_client FROM contracts_data WHERE id=@id";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@id", Contracts.id);
            SQLiteDataReader? dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Contracts.id_client = dr.GetInt32(dr.GetOrdinal("id_client"));
            }

            db_conn.Close();


            GetClient.Get();
        }
    }
}
