using System;
using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ClubOrganizer.Functions.DB
{
    internal class CreateDB
    {
        internal static void Create()
        {
            DB_clients();
            DB_contracts();
            DB_requisites();
            DB_services();
            DB_users();
            DB_payment();
        }
        // Создание базы клиентов \\
        private static void DB_clients()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string query_clients = "CREATE TABLE IF NOT EXISTS clients_data " +
            "(id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE," +
            "Фамилия TEXT NOT NULL," +
            "Имя TEXT NOT NULL," +
            "Отчество TEXT NOT NULL," +
            "fullname TEXT NOT NULL," +
            "Телефон TEXT NOT NULL," +
            "Зарегистрирован TEXT NOT NULL," +
            "Администратор TEXT NOT NULL," +
            "ЧС TEXT NOT NULL)";

            string query_block = "CREATE TABLE IF NOT EXISTS block_data " +
            "(id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE," +
            "id_client INTEGER NOT NULL," +
            "reason TEXT NOT NULL," +
            "date TEXT NOT NULL)";

            // Создание файла \\
            FileInfo fileInfo = new(db_path + @"\clients.db");
            try
            {
                if (fileInfo.Exists)
                {
                    string conn = @"Data Source=" + db_path + "/clients.db;Version=3;";
                    SQLiteConnection db_conn = new(conn);
                    db_conn.Open();
                    SQLiteCommand cmd = new(query_clients, db_conn);
                    SQLiteCommand cmd_block = new(query_block, db_conn);
                    cmd.ExecuteNonQuery();
                    cmd_block.ExecuteNonQuery();
                    db_conn.Close();
                }
            }
            catch
            {
                File.Create(db_path + @"\clients.db");
            }
            finally
            {
                string conn = @"Data Source=" + db_path + "/clients.db;Version=3;";
                SQLiteConnection db_conn = new(conn);
                db_conn.Open();
                SQLiteCommand cmd = new(query_clients, db_conn);
                SQLiteCommand cmd_block = new(query_block, db_conn);
                cmd.ExecuteNonQuery();
                cmd_block.ExecuteNonQuery();
                db_conn.Close();
            }
        }
        // Создание базы договоров \\
        private static void DB_contracts()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string query_create = "CREATE TABLE IF NOT EXISTS contracts_data " +
            "(id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE," +
            "id_client INTEGER NOT NULL, " +
            "Имя TEXT NOT NULL, " +
            "Услуга TEXT NOT NULL, " +
            "Итого TEXT, " +
            "Остаток TEXT, " +
            "Создан TEXT NOT NULL);";

            // Создание файла \\
            FileInfo fileInfo = new(db_path + @"\contracts.db");
            try
            {
                if (fileInfo.Exists)
                {
                    string conn = @"Data Source=" + db_path + "/contracts.db;Version=3;";
                    SQLiteConnection db_conn = new(conn);
                    db_conn.Open();
                    SQLiteCommand cmd = new(query_create, db_conn);
                    cmd.ExecuteNonQuery();
                    db_conn.Close();
                }
            }
            catch
            {
                File.Create(db_path + @"\contracts.db");
            }
            finally
            {
                string conn = @"Data Source=" + db_path + "/contracts.db;Version=3;";
                SQLiteConnection db_conn = new(conn);
                db_conn.Open();
                SQLiteCommand cmd = new(query_create, db_conn);
                cmd.ExecuteNonQuery();
                db_conn.Close();
            }
        }
        // Создание базы реквизитов \\
        private static void DB_requisites()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string query = "CREATE TABLE IF NOT EXISTS requisites_data " +
                "(yr_index TEXT NOT NULL," +
                "yr_city TEXT NOT NULL," +
                "yr_street TEXT NOT NULL," +
                "yr_house TEXT NOT NULL," +
                "yr_flat TEXT NOT NULL," +
                "fc_index TEXT NOT NULL," +
                "fc_city TEXT NOT NULL," +
                "fc_street TEXT NOT NULL," +
                "fc_house TEXT NOT NULL," +
                "fc_flat TEXT NOT NULL," +
                "inn TEXT NOT NULL," +
                "kpp TEXT NOT NULL," +
                "rass TEXT NOT NULL," +
                "korr TEXT NOT NULL," +
                "lastname TEXT NOT NULL," +
                "name TEXT NOT NULL," +
                "secondname TEXT NOT NULL)";

            // Создание файла \\
            FileInfo fileInfo = new(db_path + @"\requisites.db");
            try
            {
                if (fileInfo.Exists)
                {
                    string conn = @"Data Source=" + db_path + "/requisites.db;Version=3;";
                    SQLiteConnection db_conn = new(conn);
                    db_conn.Open();
                    SQLiteCommand cmd = new(query, db_conn);
                    cmd.ExecuteNonQuery();
                    db_conn.Close();
                }
            }
            catch
            {
                File.Create(db_path + @"\requisites.db");
            }
            finally
            {
                string conn = @"Data Source=" + db_path + "/requisites.db;Version=3;";
                SQLiteConnection db_conn = new(conn);
                db_conn.Open();
                SQLiteCommand cmd = new(query, db_conn);
                cmd.ExecuteNonQuery();
                db_conn.Close();
            }
        }
        // Создание базы услуг \\
        private static void DB_services()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/services.db;Version=3;";
            string query_create = "CREATE TABLE IF NOT EXISTS Sample_service " +
                "(id INTEGER PRIMARY KEY, " +
                "id_client INTEGER NOT NULL, " +
                "День TEXT NOT NULL, "+
                "Услуга TEXT NOT NULL, " +
                "Начало TEXT NOT NULL, " +
                "Конец TEXT NOT NULL, " +
                "Время TEXT NOT NULL, " +
                "Дней INTEGER NOT NULL, " +
                "Часов TEXT NOT NULL, " +
                "Цена TEXT NOT NULL, " +
                "Итого TEXT NOT NULL)";

            // Создание файла \\
            FileInfo fileInfo = new(db_path + @"\services.db");
            try
            {
                if (fileInfo.Exists)
                {
                    SQLiteConnection db_conn = new(conn);
                    db_conn.Open();
                    SQLiteCommand cmd = new(query_create, db_conn);
                    cmd.ExecuteNonQuery();
                    db_conn.Close();
                }
            }
            catch
            {
                File.Create(db_path + @"\services.db");
            }
            finally
            {
                SQLiteConnection db_conn = new(conn);
                db_conn.Open();
                SQLiteCommand cmd = new(query_create, db_conn);
                cmd.ExecuteNonQuery();
                db_conn.Close();
            }
        }
        // Создание базы пользователей \\
        private static void DB_users()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string query_create = "CREATE TABLE IF NOT EXISTS users_data " +
                "(id INTEGER NOT NULL PRIMARY KEY UNIQUE," +
                "Фамилия TEXT NOT NULL," +
                "Имя TEXT NOT NULL," +
                "Отчество TEXT NOT NULL," +
                "Пол TEXT NOT NULL," +
                "Должность TEXT NOT NULL," +
                "Логин TEXT NOT NULL," +
                "Пароль TEXT NOT NULL)";

            string query_insert = "INSERT INTO users_data " +
                "(id, Логин, Пароль, Имя, " +
                "Фамилия, Отчество, Должность, Пол) " +
                "VALUES (@id, @login, @pass, @name, @lastname, " +
                "@secondname, @position, @gender)";

            // Создание файла \\
            FileInfo fileInfo = new(db_path + @"\users.db");
            try
            {
                if (fileInfo.Exists)
                {
                    string? pass = HashPass("admin");

                    string conn = @"Data Source=" + db_path + "/users.db;Version=3;";
                    SQLiteConnection db_conn = new(conn);
                    db_conn.Open();
                    SQLiteCommand cmd = new(query_create, db_conn);
                    cmd.ExecuteNonQuery();
                    SQLiteCommand cmd_insert = new(query_insert, db_conn);
                    cmd_insert.Parameters.AddWithValue("@id", 1);
                    cmd_insert.Parameters.AddWithValue("@login", "dev");
                    cmd_insert.Parameters.AddWithValue("@pass", pass);
                    cmd_insert.Parameters.AddWithValue("@name", "Дмитрий");
                    cmd_insert.Parameters.AddWithValue("@lastname", "Ляхов");
                    cmd_insert.Parameters.AddWithValue("@secondname", "Сергеевич");
                    cmd_insert.Parameters.AddWithValue("@position", "Разработчик");
                    cmd_insert.Parameters.AddWithValue("@gender", "Мужской");
                    cmd_insert.ExecuteNonQuery();
                    db_conn.Close();
                }
            }
            catch
            {
                File.Create(db_path + @"\users.db");
            }
            finally
            {
                string? pass = HashPass("admin");

                string conn = @"Data Source=" + db_path + "/users.db;Version=3;";
                SQLiteConnection db_conn = new(conn);
                db_conn.Open();
                SQLiteCommand cmd = new(query_create, db_conn);
                cmd.ExecuteNonQuery();
                SQLiteCommand cmd_insert = new(query_insert, db_conn);
                cmd_insert.Parameters.AddWithValue("@id", 1);
                cmd_insert.Parameters.AddWithValue("@login", "dev");
                cmd_insert.Parameters.AddWithValue("@pass", pass);
                cmd_insert.Parameters.AddWithValue("@name", "Дмитрий");
                cmd_insert.Parameters.AddWithValue("@lastname", "Ляхов");
                cmd_insert.Parameters.AddWithValue("@secondname", "Сергеевич");
                cmd_insert.Parameters.AddWithValue("@position", "Разработчик");
                cmd_insert.Parameters.AddWithValue("@gender", "Мужской");
                cmd_insert.ExecuteNonQuery();
                db_conn.Close();
            }
        }
        // Создание базы оплат \\
        private static void DB_payment()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/payment.db;Version=3;";
            string query_create = "CREATE TABLE IF NOT EXISTS payment_data " +
                "(id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, " +
                "Тип TEXT NOT NULL, " +
                "Клиент TEXT NOT NULL, " +
                "Договор TEXT NOT NULL, " +
                "Всего TEXT NOT NULL, " +
                "Сумма TEXT NOT NULL, " +
                "Остаток TEXT NOT NULL, " +
                "Дата TEXT NOT NULL, " +
                "Администратор TEXT NOT NULL)";

            // Создание файла \\
            FileInfo fileInfo = new(db_path + @"\payment.db");
            try
            {
                if (fileInfo.Exists)
                {
                    SQLiteConnection db_conn = new(conn);
                    db_conn.Open();
                    SQLiteCommand cmd = new(query_create, db_conn);
                    cmd.ExecuteNonQuery();
                    db_conn.Close();
                }
            }
            catch
            {
                File.Create(db_path + @"\payment.db");
            }
            finally
            {
                SQLiteConnection db_conn = new(conn);
                db_conn.Open();
                SQLiteCommand cmd = new(query_create, db_conn);
                cmd.ExecuteNonQuery();
                db_conn.Close();
            }
        }
        // Хэширование пароля \\
        private static string? HashPass(string password)
        {

            byte[] b = Encoding.ASCII.GetBytes(password);
            byte[] hash = MD5.HashData(b);

            StringBuilder? sb = new();
            foreach (var a in hash)
            {
                sb.Append(a.ToString("X2"));
            }

            return Convert.ToString(sb);
        }
    }
}
