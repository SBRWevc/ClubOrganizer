using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.List_contracts.Class
{
    internal class GetContracts
    {
        internal static void Get()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/contracts.db;Version=3;";
            string query = "SELECT id, Имя, Услуга, Итого, Остаток, Создан FROM contracts_data";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            SQLiteDataAdapter da = new(cmd);
            da.Fill(Contracts.dt_contracts);
            db_conn.Close();
        }
    }
}
