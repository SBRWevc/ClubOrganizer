using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubOrganizer.Pages.Fast_Tennis.Class.Service
{
    class InsDtService
    {
        internal static void Insert()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB\Счета\";

            string conn = @"Data Source=" + db_path + ContractData.CtrID + @".db" + @"; Version=3;";
            string query = "INSERT INTO " + ContractData.CtrID + " (id_client, Договор, " +
                "Дата, Клиент) VALUES (@id_client, @contract, @date, @client)";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@id_client", NewClient.id);
            cmd.Parameters.AddWithValue("@contract", ContractData.CtrID);
            cmd.Parameters.AddWithValue("@client", NewClient.Fullname);
            cmd.Parameters.AddWithValue("@date", ContractData.DateStart.ToString("dd.MM.yy"));
            cmd.ExecuteNonQuery();
            db_conn.Close();
        }
    }
}
