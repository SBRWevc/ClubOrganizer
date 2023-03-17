using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubOrganizer.Pages.List_contracts.Class
{
    internal class GetClient
    {
        internal static void Get()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/clients.db;Version=3;";

            string query = "SELECT * FROM clients_data WHERE id=@id";
            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@id", Contracts.id_client);
            SQLiteDataReader? dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Contracts.Lastname = dr.GetString(dr.GetOrdinal("Фамилия"));
                Contracts.Name = dr.GetString(dr.GetOrdinal("Имя")); 
                Contracts.Secondname = dr.GetString(dr.GetOrdinal("Отчество"));
                Contracts.Fullname = dr.GetString(dr.GetOrdinal("fullname"));
                Contracts.Phone = dr.GetString(dr.GetOrdinal("Телефон"));
            }
            db_conn.Close();

            Docx.Create();
        }
    }
}
