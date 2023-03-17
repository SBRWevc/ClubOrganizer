using ClubOrganizer.Pages.Fast_Tennis.Class.Contracts;
using System;
using System.Data;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.Fast_Tennis.Class.Client
{
    class ChClient
    {
        internal static void Check()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/clients.db;Version=3;";
            string query = "SELECT * FROM clients_data WHERE Фамилия=@Lastname AND Имя=@Username AND " +
                "Отчество=@Secondname AND Телефон=@Phone";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@Lastname", NewClient.Lastname);
            cmd.Parameters.AddWithValue("@Username", NewClient.Username);
            cmd.Parameters.AddWithValue("@Secondname", NewClient.Secondname);
            cmd.Parameters.AddWithValue("@Phone", NewClient.Phone);
            SQLiteDataAdapter da = new(cmd);
            DataTable dt = new();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                SQLiteDataReader? dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    NewClient.id = dr.GetInt32(dr.GetOrdinal("id"));
                }

                db_conn.Close();

                ChContract.Check();
            }
            else
            {
                CrtClient.Create();
            }
        }
    }
}
