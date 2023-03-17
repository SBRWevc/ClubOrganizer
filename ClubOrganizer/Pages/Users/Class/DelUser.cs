using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubOrganizer.Pages.Users.Class
{
    class DelUser
    {
        internal static void Del()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            string conn = @"Data Source=" + db_path + "/users.db;Version=3;";

            SQLiteConnection db_conn = new(conn);
            db_conn.Open();
            using (SQLiteCommand сmd = new("DELETE FROM users_data WHERE ID=" + ClubOrganizer.Users.id, db_conn))
            {
                сmd.ExecuteNonQuery();
            }
            db_conn.Close();
        }
    }
}
