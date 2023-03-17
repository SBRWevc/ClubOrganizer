using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.Fast_Tennis.Class.Contracts
{
    internal class ContractMoney
    {
        internal static void Check()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/contracts.db;Version=3;";
            string query = "SELECT * FROM contracts_data WHERE id_client=@id_client";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@id_client", NewClient.id);
            SQLiteDataReader? dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ContractData.contractPrice = dr.GetString(dr.GetOrdinal("Итого"));
                ContractData.contractRest = dr.GetString(dr.GetOrdinal("Остаток"));
            }

            db_conn.Close();
        }
    }
}
