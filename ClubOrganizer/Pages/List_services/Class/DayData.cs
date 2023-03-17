using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace ClubOrganizer.Pages.List_services.Class
{
    internal class DayData
    {
        internal static void Get()
        {
            ContractData.CtrID = @"CTR_" + Services.id_ctr + "_" + DateTime.Now.Year.ToString();
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB\Счета\";

            string conn = @"Data Source=" + db_path + ContractData.CtrID + @".db" + @"; Version=3;";
            string query = "SELECT id FROM SER_" + Services.id_ser + " ORDER BY id DESC LIMIT 1";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            SQLiteCommand cmd = new(query, db_conn);
            SQLiteDataReader? dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Services.count = dr.GetInt32(dr.GetOrdinal("id"));
            }

            db_conn.Close();

            for (int i = 1; i <= Services.count; i++) 
            {
                string query_sel = "SELECT * FROM SER_" + Services.id_ser + " WHERE id=@id";

                SQLiteConnection db = new(conn);
                db.Open();
                SQLiteCommand cmd_sel = new(query_sel, db);
                cmd_sel.Parameters.AddWithValue("@id", i);
                SQLiteDataReader? dr_sel = cmd_sel.ExecuteReader();

                while (dr_sel.Read())
                {
                    Services.day = dr_sel.GetString(dr_sel.GetOrdinal("День"));
                    Services.start = dr_sel.GetString(dr_sel.GetOrdinal("Начало"));
                    Services.end = dr_sel.GetString(dr_sel.GetOrdinal("Конец"));
                    Services.tstart = dr_sel.GetString(dr_sel.GetOrdinal("Start"));
                    Services.tend = dr_sel.GetString(dr_sel.GetOrdinal("End"));
                    Services.time = dr_sel.GetString(dr_sel.GetOrdinal("Время"));
                    Services.days = dr_sel.GetInt32(dr_sel.GetOrdinal("Дней"));
                    Services.hours = dr_sel.GetString(dr_sel.GetOrdinal("Часов"));
                    Services.price = dr_sel.GetString(dr_sel.GetOrdinal("Цена"));
                    Services.total_price = dr_sel.GetString(dr_sel.GetOrdinal("Итого"));                    
                }

                db.Close();

                CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
                double d = double.Parse(Services.time);
                Thread.CurrentThread.CurrentCulture = temp_culture;

                DateTime dt = Convert.ToDateTime(Services.start);
                DateTime dt2 = Convert.ToDateTime(Services.end);
                Dictionary<int, int> di = new();
                int tek_month = dt.Month;
                for (DateTime m = dt; m <= dt2; m = m.AddDays(1))
                {
                    if (!di.ContainsKey(m.Month))
                    {
                        di.Add(m.Month, 0);
                    }
                    if (m.DayOfWeek == ContractData.DayOfWeek)
                    {
                        di[m.Month]++;
                    }
                }
                ServiceData.month = string.Join("      \n", di.Select(p => $"{new DateTime(2000, p.Key, 1):MMMM}").ToList());
                ServiceData.days = string.Join("      \n", di.Select(p => $"{p.Value}").ToList());
                ServiceData.hours = string.Join("       \n", di.Select(p => Convert.ToDouble($"{p.Value}") * d));
                ServiceData.month_price = string.Join("       \n", di.Select(p => Convert.ToDouble($"{p.Value}") * d * Convert.ToDouble(Services.price)));

                Docx.Table();
            }
        }
    }
}
