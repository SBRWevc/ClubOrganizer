using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.List_services.Class
{
    internal class GetDays
    {
        internal static void Get()
        {
            ContractData.CtrID = @"CTR_" + Services.id_ctr + "_" + DateTime.Now.Year.ToString();
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB\Счета\";

            string conn = @"Data Source=" + db_path + ContractData.CtrID + @".db" + @"; Version=3;";
            string query = "SELECT id, День, Услуга, Начало, Конец, Время, Дней, Часов, Цена, Итого FROM SER_" + Services.id_ser;

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            SQLiteDataAdapter da = new(cmd);
            da.Fill(Services.dt_days);
            db_conn.Close();
        }
    }
}
