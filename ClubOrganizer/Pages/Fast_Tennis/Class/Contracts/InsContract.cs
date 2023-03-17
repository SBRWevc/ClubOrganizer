using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.Fast_Tennis.Class.Contracts
{
    class InsContract
    {
        internal static void Insert()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/contracts.db;Version=3;";
            string query = "UPDATE contracts_data SET Итого=@Price, Остаток=@Rest WHERE id_client=@idclient";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@idclient", NewClient.id);
            cmd.Parameters.AddWithValue("@Price", Convert.ToString(Convert.ToDouble(ContractData.contractPrice) + ServiceData.totalPrice));
            cmd.Parameters.AddWithValue("@Rest", Convert.ToString(Convert.ToDouble(ContractData.contractRest) + ServiceData.totalPrice));
            cmd.ExecuteNonQuery();
            db_conn.Close();

            InsPayment.Insert();
        }
    }
}
