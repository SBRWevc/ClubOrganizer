using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.Payment.Class
{
    class GetClientsList
    {
        internal static void Get()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/clients.db;Version=3;";
            string query = "SELECT id, fullname FROM clients_data";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            SQLiteDataAdapter da = new(cmd);
            da.Fill(Payments.lt_clients);
            db_conn.Close();
        }
    }
}
