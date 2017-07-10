using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
namespace DownTown
{

    public class DTDB
    {
        public SQLiteConnection conn;
        public string sql;
        SQLiteCommand cmd;
        public const String TABLE_ITEMS = "items";
        public DTDB() {
            //SQLiteConnection.CreateFile("DTDB.sqlite");
            conn = new SQLiteConnection("Data Source=DTDB.sqlite;Version=3;");
            conn.Open();

            sql = "create table  IF NOT EXISTS " + TABLE_ITEMS + " (code INT,name varchar(50),qty INT,ml INT,category varchar(10),) ";
 
        }
        public void ExecuteNonQuery(string txtQuery)
        {
            cmd = new SQLiteCommand(txtQuery, conn);
            cmd.ExecuteNonQuery();
        }

        public DataSet GetDataSet(String sql)
        {
             SQLiteDataAdapter DB;
             DataSet DS = new DataSet();
             DataTable DT = new DataTable();
                DB = new SQLiteDataAdapter(sql, conn);
                DS.Reset();
                DB.Fill(DS);
            return DS;
        }

        public SQLiteDataReader GetDataReader(String sql) {
            SQLiteCommand command = new SQLiteCommand(sql, conn);
           return command.ExecuteReader();
        }

    }
}
