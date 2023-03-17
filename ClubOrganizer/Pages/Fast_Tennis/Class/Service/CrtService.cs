using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.Fast_Tennis.Class.Service
{
    class CrtService
    {
        internal static void Create()
        {
            ContractData.CtrID = "CTR_" + Convert.ToString(NewClient.id_ctr) + "_" + DateTime.Now.Year.ToString();
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB\Счета\";

            string conn = @"Data Source=" + db_path + ContractData.CtrID + @".db" + @"; Version=3;";
            string query = "CREATE TABLE IF NOT EXISTS SER_" + ServiceData.id +
                " (id INTEGER PRIMARY KEY, " +
                "id_client INTEGER NOT NULL, " +
                "День TEXT NOT NULL, " +
                "Услуга TEXT NOT NULL, " +
                "Начало TEXT NOT NULL, " +
                "Конец TEXT NOT NULL, " +
                "Start TEXT NOT NULL, " +
                "End TEXT NOT NULL, " +
                "Время TEXT NOT NULL, " +
                "Дней INTEGER NOT NULL, " +
                "Часов TEXT NOT NULL, " +
                "Цена TEXT NOT NULL, " +
                "Итого TEXT NOT NULL)";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.ExecuteNonQuery();
            db_conn.Close();

            InsService.Insert();
        }
    }
}
