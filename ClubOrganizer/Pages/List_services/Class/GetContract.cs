using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.List_services.Class
{
    internal class GetContract
    {
        internal static void Get()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/contracts.db;Version=3;";
            string query = "SELECT id FROM contracts_data WHERE Имя=@name";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@name", ClientsData.fullname);
            SQLiteDataReader? dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Services.id_ctr = dr.GetInt32(dr.GetOrdinal("id"));
            }

            db_conn.Close();

            SrchService.Get();
        }
    }
}
