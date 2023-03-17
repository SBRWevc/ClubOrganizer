using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.List_contracts.Class
{
    internal class PayRest
    {
        internal static void Pay()
        {
            Contracts.endRest = Convert.ToInt32(Contracts.rest) - Convert.ToInt32(Contracts.payRest);

            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/contracts.db;Version=3;";
            string query = "UPDATE contracts_data SET Остаток=@rest WHERE id=@id";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@id", Contracts.id);
            cmd.Parameters.AddWithValue("@rest", Contracts.endRest.ToString());
            cmd.ExecuteNonQuery();
            db_conn.Close();

            Insert();
        }

        private static void Insert()
        {
            Contracts.endRest = Convert.ToInt32(Contracts.rest) - Convert.ToInt32(Contracts.payRest);

            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/payment.db;Version=3;";
            string query = "INSERT INTO payment_data (Тип, Клиент, Договор, Всего, Сумма, Остаток, Дата, Администратор) " +
                "VALUES (@type, @client, @contract, @total, @sum, @rest, @date, @admin)";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@type", "Оплата");
            cmd.Parameters.AddWithValue("@client", Contracts.Fullname);
            cmd.Parameters.AddWithValue("@contract", Contracts.id);
            cmd.Parameters.AddWithValue("@total", Contracts.total);
            cmd.Parameters.AddWithValue("@sum", "-" + Contracts.payRest);
            cmd.Parameters.AddWithValue("@rest", Contracts.endRest);
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("dd.MM.yy"));
            cmd.Parameters.AddWithValue("@admin", Userdata.Lastname + " " + Userdata.Name + " " + Userdata.Secondname);
            cmd.ExecuteNonQuery();
            db_conn.Close();
        }
    }
}
