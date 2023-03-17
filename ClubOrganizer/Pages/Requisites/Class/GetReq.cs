using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.Requisites.Class
{
    class GetReq
    {
        internal static void Get()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string query = "SELECT * FROM requisites_data";

            string conn = @"Data Source=" + db_path + "/requisites.db;Version=3;";
            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            SQLiteDataReader? dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ClubOrganizer.Requisites.lastname = dr.GetString(dr.GetOrdinal("lastname"));
                ClubOrganizer.Requisites.name = dr.GetString(dr.GetOrdinal("name"));
                ClubOrganizer.Requisites.secondname = dr.GetString(dr.GetOrdinal("secondname"));
                ClubOrganizer.Requisites.yr_index = dr.GetString(dr.GetOrdinal("yr_index"));
                ClubOrganizer.Requisites.yr_city = dr.GetString(dr.GetOrdinal("yr_city"));
                ClubOrganizer.Requisites.yr_street = dr.GetString(dr.GetOrdinal("yr_street"));
                ClubOrganizer.Requisites.yr_house = dr.GetString(dr.GetOrdinal("yr_house"));
                ClubOrganizer.Requisites.yr_flat = dr.GetString(dr.GetOrdinal("yr_flat"));
                ClubOrganizer.Requisites.fc_index = dr.GetString(dr.GetOrdinal("fc_index"));
                ClubOrganizer.Requisites.fc_city = dr.GetString(dr.GetOrdinal("fc_city"));
                ClubOrganizer.Requisites.fc_street = dr.GetString(dr.GetOrdinal("fc_street"));
                ClubOrganizer.Requisites.fc_house = dr.GetString(dr.GetOrdinal("fc_house"));
                ClubOrganizer.Requisites.fc_flat = dr.GetString(dr.GetOrdinal("fc_flat"));
                ClubOrganizer.Requisites.inn = dr.GetString(dr.GetOrdinal("inn"));
                ClubOrganizer.Requisites.kpp = dr.GetString(dr.GetOrdinal("kpp"));
                ClubOrganizer.Requisites.rass = dr.GetString(dr.GetOrdinal("rass"));
                ClubOrganizer.Requisites.korr = dr.GetString(dr.GetOrdinal("korr"));
            }

            db_conn.Close();
        }
    }
}
