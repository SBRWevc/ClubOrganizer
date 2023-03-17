﻿using ClubOrganizer.Functions.String;
using System;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;

namespace ClubOrganizer.Pages.Auth.Class
{
    internal class Registration
    {
        // Внесение дынных нового пользователя \\
        internal static void New_user()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/users.db;Version=3;";
            string query = "INSERT INTO users_data (id, Логин, Пароль, Имя, " +
                "Фамилия, Отчество, Должность, Пол) " +
                "VALUES (@id, @login, @pass, @name, @lastname, @secondname, @position, " +
                "@gender)";

            string login = RegData.Login;
            string? pass = HashString.Hash(RegData.Pass);
            string name = RegData.Name;
            string lastname = RegData.Lastname;
            string secondname = RegData.Secondname;
            string position = RegData.Position;
            string gender = RegData.Gender;

            New_id();

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd_add = new(query, db_conn);
            cmd_add.Parameters.AddWithValue("@login", login);
            cmd_add.Parameters.AddWithValue("@pass", pass);
            cmd_add.Parameters.AddWithValue("@name", name);
            cmd_add.Parameters.AddWithValue("@lastname", lastname);
            cmd_add.Parameters.AddWithValue("@secondname", secondname);
            cmd_add.Parameters.AddWithValue("@position", position);
            cmd_add.Parameters.AddWithValue("@gender", gender);
            cmd_add.Parameters.AddWithValue("@id", RegData.id + 1);
            cmd_add.ExecuteNonQuery();
            db_conn.Close();
        }
        // Создание нового ID \\
        private static void New_id()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/users.db;Version=3;";
            string query = "SELECT id FROM users_data ORDER BY id DESC LIMIT 1";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            SQLiteDataReader? dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                RegData.id = dr.GetInt32(dr.GetOrdinal("id"));
            }

            db_conn.Close();
        }
    }
}
