using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.Requisites.Class
{
    class WriteReq
    {
        internal static void Write()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string query_insert = "INSERT INTO requisites_data " +
            "(yr_index, yr_city, yr_street, yr_house, yr_flat, " +
            "fc_index, fc_city, fc_street, fc_house, fc_flat, " +
            "inn, kpp, rass, korr, lastname, name, secondname) VALUES " +
            "(@yr_index, @yr_city, @yr_street, @yr_house, @yr_flat, " +
            "@fc_index, @fc_city, @fc_street, @fc_house, @fc_flat, " +
            "@inn, @kpp, @rass, @korr, @lastname, @name, @secondname)";

            string conn = @"Data Source=" + db_path + "/requisites.db;Version=3;";
            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd_insert = new(query_insert, db_conn);
            cmd_insert.Parameters.AddWithValue("@yr_index", ClubOrganizer.Requisites.yr_index);
            cmd_insert.Parameters.AddWithValue("@yr_city", ClubOrganizer.Requisites.yr_city);
            cmd_insert.Parameters.AddWithValue("@yr_street", ClubOrganizer.Requisites.yr_street);
            cmd_insert.Parameters.AddWithValue("@yr_house", ClubOrganizer.Requisites.yr_house);
            cmd_insert.Parameters.AddWithValue("@yr_flat", ClubOrganizer.Requisites.yr_flat);
            cmd_insert.Parameters.AddWithValue("@fc_index", ClubOrganizer.Requisites.fc_index);
            cmd_insert.Parameters.AddWithValue("@fc_city", ClubOrganizer.Requisites.fc_city);
            cmd_insert.Parameters.AddWithValue("@fc_street", ClubOrganizer.Requisites.fc_street);
            cmd_insert.Parameters.AddWithValue("@fc_house", ClubOrganizer.Requisites.fc_house);
            cmd_insert.Parameters.AddWithValue("@fc_flat", ClubOrganizer.Requisites.fc_flat);
            cmd_insert.Parameters.AddWithValue("@inn", ClubOrganizer.Requisites.inn);
            cmd_insert.Parameters.AddWithValue("@kpp", ClubOrganizer.Requisites.kpp);
            cmd_insert.Parameters.AddWithValue("@rass", ClubOrganizer.Requisites.rass);
            cmd_insert.Parameters.AddWithValue("@korr", ClubOrganizer.Requisites.korr);
            cmd_insert.Parameters.AddWithValue("@lastname", ClubOrganizer.Requisites.lastname);
            cmd_insert.Parameters.AddWithValue("@name", ClubOrganizer.Requisites.name);
            cmd_insert.Parameters.AddWithValue("@secondname", ClubOrganizer.Requisites.secondname);
            cmd_insert.ExecuteNonQuery();
            db_conn.Close();
        }        
    }
}
