using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.Fast_Tennis.Class.Contracts
{
    class InsPayment
    {
        internal static void Insert()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/payment.db;Version=3;";
            string query = "INSERT INTO payment_data (Тип, Клиент, Договор, Всего, Сумма, Остаток, Дата, Администратор) " + 
                "VALUES (@type, @client, @contract, @total, @sum, @rest, @date, @admin)";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@type", "Счёт");
            cmd.Parameters.AddWithValue("@client", NewClient.Fullname);
            cmd.Parameters.AddWithValue("@contract", NewClient.id_ctr);
            cmd.Parameters.AddWithValue("@total", Convert.ToString(Convert.ToDouble(ContractData.contractPrice) + ServiceData.totalPrice));
            cmd.Parameters.AddWithValue("@sum", "+" + Convert.ToString(ServiceData.totalPrice));
            cmd.Parameters.AddWithValue("@rest", Convert.ToString(Convert.ToDouble(ContractData.contractRest) + ServiceData.totalPrice));
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("dd.MM.yy"));
            cmd.Parameters.AddWithValue("@admin", Userdata.Lastname + " " + Userdata.Name + " " + Userdata.Secondname);
            cmd.ExecuteNonQuery();
            db_conn.Close();
        }
    }
}
