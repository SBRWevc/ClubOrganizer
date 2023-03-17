using ClubOrganizer.Pages.Fast_Tennis.Class.Docx;
using ClubOrganizer.Pages.Fast_Tennis.Class.Service;
using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.Fast_Tennis.Class.Contracts
{
    class CrtContract
    {
        internal static void Create()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/contracts.db;Version=3;";
            string query = "INSERT INTO contracts_data (id_client, Имя, Услуга, Итого, Остаток, Создан) " +
                "VALUES (@idclient, @Name, @Label, @Price, @Rest, @Create)";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@idclient", NewClient.id);
            cmd.Parameters.AddWithValue("@Name", NewClient.Fullname);
            cmd.Parameters.AddWithValue("@Label", "Теннис");
            cmd.Parameters.AddWithValue("@Create", DateTime.Now.ToString("dd/MM/yy"));
            cmd.Parameters.AddWithValue("@Price", "0");
            cmd.Parameters.AddWithValue("@Rest", "0");
            cmd.ExecuteNonQuery();
            db_conn.Close();

            IdContract.GetID();
            ContractDocx.Save();
            DtService.Create();
        }
    }
}
