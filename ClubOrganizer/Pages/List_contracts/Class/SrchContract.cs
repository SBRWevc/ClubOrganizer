using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.List_contracts.Class
{
    internal class SrchContract
    {
        internal static void Get()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/contracts.db;Version=3;";
            string query = "SELECT id, Имя, Услуга, Итого, Остаток, Создан FROM contracts_data WHERE Имя=@fullname";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@fullname", ClientsData.fullname);
            SQLiteDataAdapter da = new(cmd);
            da.Fill(Contracts.dt_contracts);
            db_conn.Close();
        }
    }
}
