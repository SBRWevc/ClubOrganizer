using System;
using System.Data.SQLite;
using System.IO;

namespace ClubOrganizer.Pages.Fast_Tennis.Class.Service
{
    class DtService
    {
        internal static void Create()
        {
            ContractData.CtrID = "CTR_" + Convert.ToString(NewClient.id_ctr) + "_" + DateTime.Now.Year.ToString();
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            DirectoryInfo dirInfo = new(db_path + @"\Счета\");
            FileInfo fileInfo = new(db_path + @"\Счета\" + ContractData.CtrID + @".db");
            try
            {
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();

                    if (fileInfo.Exists)
                    {

                    }
                }
            }
            catch
            {
                File.Create(db_path + @"\Счета\" + ContractData.CtrID + @".db");
            }
            finally
            {
                string conn = @"Data Source=" + db_path + @"\Счета\" + ContractData.CtrID + @".db" + @"; Version=3;";
                string query = "CREATE TABLE IF NOT EXISTS " + ContractData.CtrID +
                    " (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, " +
                    "id_client TEXT NOT NULL, " +
                    "Договор TEXT NOT NULL, " +
                    "Дата TEXT NOT NULL, " +
                    "Клиент TEXT NOT NULL)";

                SQLiteConnection db_conn = new(conn);
                db_conn.Open();
                SQLiteCommand cmd = new(query, db_conn);
                cmd.ExecuteNonQuery();
                db_conn.Close();

                IdService.GetID();
            }
        }
    }
}
