using System;
using System.Data.SQLite;
using System.IO;

namespace ClubOrganizer.Pages.Fast_Tennis.Class.Service
{
    class ClearData
    {
        internal static void Clear()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB\Счета\";

            string conn = @"Data Source=" + db_path + ContractData.CtrID + @".db" + @"; Version=3;";
            string query = "DROP TABLE IF EXISTS SER_" + ServiceData.id;

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.ExecuteNonQuery();
            db_conn.Close();

            string path = doc + @"\Ладога\Docx\Счета\" + Convert.ToString(NewClient.id_ctr) + " - " + DateTime.Now.Year.ToString() + @"\";

            FileInfo fileInfo = new(path + ServiceData.id + @".docx");
            if (fileInfo.Exists) 
            {
                fileInfo.Delete();
            }
        }
    }
}
