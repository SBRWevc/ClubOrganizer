using ClubOrganizer.Functions.String;
using System;
using System.Data.SQLite;
using System.Globalization;

namespace ClubOrganizer.Pages.Fast_Tennis.Class.Service
{
    class InsService
    {
        internal static void Insert()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB\Счета\";

            string conn = @"Data Source=" + db_path + ContractData.CtrID + @".db" + @"; Version=3;";
            string query = "INSERT INTO SER_" + ServiceData.id + " (id_client, День, " +
                "Услуга, Начало, Конец, Start, End, Время, Дней, Часов, Цена, Итого) " +
                "VALUES (@idClient, @day, @service, @start, @end, @tstart, @tend, " +
                "@time, @days, @times, @price, @total)";

            string Day = CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName(ContractData.DayOfWeek);
            Day = CapString.Capitalize(Day);

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            cmd.Parameters.AddWithValue("@idClient", NewClient.id);
            cmd.Parameters.AddWithValue("@day", Day);
            cmd.Parameters.AddWithValue("@service", "Теннис");
            cmd.Parameters.AddWithValue("@start", ContractData.DateStart.ToString("dd.MM.yy"));
            cmd.Parameters.AddWithValue("@end", ContractData.DateEnd.ToString("dd.MM.yy"));
            cmd.Parameters.AddWithValue("@tstart", ContractData.tstart);
            cmd.Parameters.AddWithValue("@tend", ContractData.tend);
            cmd.Parameters.AddWithValue("@time", ContractData.time);
            cmd.Parameters.AddWithValue("@days", ContractData.days);
            cmd.Parameters.AddWithValue("@times", ContractData.days * ContractData.time);
            cmd.Parameters.AddWithValue("@price", ContractData.price);
            cmd.Parameters.AddWithValue("@total", ContractData.days * ContractData.time * Convert.ToInt32(ContractData.price));
            cmd.ExecuteNonQuery();
            db_conn.Close();

            SumService.Sum();
        }
    }
}
