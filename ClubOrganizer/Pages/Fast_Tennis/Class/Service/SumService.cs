using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.Fast_Tennis.Class.Service
{
    class SumService
    {
        internal static void Sum()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB\Счета\";

            string conn = @"Data Source=" + db_path + ContractData.CtrID + @".db" + @"; Version=3;";
            string query = "SELECT SUM(Итого) AS t FROM SER_" + ServiceData.id;
            string queryHour = "SELECT SUM(Часов) AS h FROM SER_" + ServiceData.id;

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            SQLiteDataReader? dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ServiceData.totalPrice = dr.GetDouble(dr.GetOrdinal("t"));
            }

            SQLiteCommand cmdH = new(queryHour, db_conn);
            SQLiteDataReader? drH;
            drH = cmdH.ExecuteReader();

            while (drH.Read())
            {
                ServiceData.totalHour = drH.GetDouble(drH.GetOrdinal("h"));
            }

            db_conn.Close();

            IdDayService.GetID();
        }
    }
}
