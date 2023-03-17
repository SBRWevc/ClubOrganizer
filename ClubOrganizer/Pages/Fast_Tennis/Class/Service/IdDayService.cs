using ClubOrganizer.Pages.Fast_Tennis.Class.Docx;
using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.Fast_Tennis.Class.Service
{
    internal class IdDayService
    {
        internal static void GetID()
        {
            ContractData.CtrID = "CTR_" + Convert.ToString(NewClient.id_ctr) + "_" + DateTime.Now.Year.ToString();
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB\Счета\";

            string conn = @"Data Source=" + db_path + ContractData.CtrID + @".db" + @"; Version=3;";
            string query = "SELECT id FROM SER_" + ServiceData.id + " ORDER BY id DESC LIMIT 1";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            SQLiteDataReader? dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ServiceData.id_day = dr.GetInt32(dr.GetOrdinal("id"));
            }
            db_conn.Close();

            if (ServiceData.id_day == 1)
            {
                ServiceDocx.Create();
            }
            else
            {
                ServiceDocx.Table();
            }
        }
    }
}
