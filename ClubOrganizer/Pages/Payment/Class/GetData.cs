using System;
using System.Data.SQLite;

namespace ClubOrganizer.Pages.Payment.Class
{
    class GetData
    {
        internal static void Get()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/payment.db;Version=3;";
            string query = "SELECT * FROM payment_data WHERE id=@id";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@id", Payments.id.ToString());
            SQLiteDataReader? dr = cmd.ExecuteReader();

            while (dr.Read()) 
            {
                Payments.Type = dr.GetString(dr.GetOrdinal("Тип"));
                Payments.Name = dr.GetString(dr.GetOrdinal("Клиент"));
                Payments.Contract = dr.GetString(dr.GetOrdinal("Договор"));
                Payments.Total = dr.GetString(dr.GetOrdinal("Всего"));
                Payments.Sum = dr.GetString(dr.GetOrdinal("Сумма"));
                Payments.Rest = dr.GetString(dr.GetOrdinal("Остаток"));
            }

            db_conn.Close();

            if (Payments.Type != "Счёт")
            {
                if (Payments.Type == "Оплата")
                {
                    if (Convert.ToDouble(Payments.Rest) >= Convert.ToDouble(Payments.Sum))
                    {
                        InsertRefund();
                    }
                    else
                    {

                    }
                }
                else if (Payments.Type == "Возврат оплаты")
                {
                    if (Convert.ToDouble(Payments.Total) >= Convert.ToDouble(Payments.Sum))
                    {
                        InsertPay();
                    }
                    else
                    {

                    }
                }
                else if (Payments.Type == "Отмена возврата")
                {
                    if (Convert.ToDouble(Payments.Rest) >= Convert.ToDouble(Payments.Sum))
                    {
                        InsertRefund();
                    }
                    else
                    {

                    }
                }
            }
            else
            {

            }
        }

        private static void InsertRefund()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/payment.db;Version=3;";
            string query = "INSERT INTO payment_data (Тип, Клиент, Договор, Всего, Сумма, Остаток, Дата, Администратор) " +
                "VALUES (@type, @client, @contract, @total, @sum, @rest, @date, @admin)";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@type", "Возврат оплаты");
            cmd.Parameters.AddWithValue("@client", Payments.Name);
            cmd.Parameters.AddWithValue("@contract", Payments.Contract);
            cmd.Parameters.AddWithValue("@total", Payments.Total);
            cmd.Parameters.AddWithValue("@sum", "+" + Payments.Sum.Substring(1));
            cmd.Parameters.AddWithValue("@rest", Convert.ToString(Convert.ToDouble(Payments.Rest) + Convert.ToDouble(Payments.Sum.Substring(1))));
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("dd.MM.yy"));
            cmd.Parameters.AddWithValue("@admin", Userdata.Lastname + " " + Userdata.Name + " " + Userdata.Secondname);
            cmd.ExecuteNonQuery();
            db_conn.Close();

            InsertRefundContract();
        }

        private static void InsertRefundContract()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/contracts.db;Version=3;";
            string query = "UPDATE contracts_data SET Итого=@Price, Остаток=@Rest WHERE id_client=@idclient";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@idclient", NewClient.id);
            cmd.Parameters.AddWithValue("@Price", Payments.Total);
            cmd.Parameters.AddWithValue("@Rest", Convert.ToString(Convert.ToDouble(Payments.Rest) + Convert.ToDouble(Payments.Sum.Substring(1))));
            cmd.ExecuteNonQuery();
            db_conn.Close();
        }

        private static void InsertPay()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/payment.db;Version=3;";
            string query = "INSERT INTO payment_data (Тип, Клиент, Договор, Всего, Сумма, Остаток, Дата, Администратор) " +
                "VALUES (@type, @client, @contract, @total, @sum, @rest, @date, @admin)";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@type", "Отмена возврата");
            cmd.Parameters.AddWithValue("@client", Payments.Name);
            cmd.Parameters.AddWithValue("@contract", Payments.Contract);
            cmd.Parameters.AddWithValue("@total", Payments.Total);
            cmd.Parameters.AddWithValue("@sum", "-" + Payments.Sum.Substring(1));
            cmd.Parameters.AddWithValue("@rest", Convert.ToString(Convert.ToDouble(Payments.Rest) - Convert.ToDouble(Payments.Sum.Substring(1))));
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("dd.MM.yy"));
            cmd.Parameters.AddWithValue("@admin", Userdata.Lastname + " " + Userdata.Name + " " + Userdata.Secondname);
            cmd.ExecuteNonQuery();
            db_conn.Close();

            InsertPayContract();
        }

        private static void InsertPayContract()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/contracts.db;Version=3;";
            string query = "UPDATE contracts_data SET Итого=@Price, Остаток=@Rest WHERE id_client=@idclient";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@idclient", NewClient.id);
            cmd.Parameters.AddWithValue("@Price", Payments.Total);
            cmd.Parameters.AddWithValue("@Rest", Convert.ToString(Convert.ToDouble(Payments.Rest) - Convert.ToDouble(Payments.Sum.Substring(1))));
            cmd.ExecuteNonQuery();
            db_conn.Close();
        }
    }
}
