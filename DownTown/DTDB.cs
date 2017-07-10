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
        
        SQLiteCommand cmd;
        public const String TABLE_ITEMS = "items";
        public const String TABLE_STOCK = "stock";
        public DTDB() {
            string sql;
            conn = new SQLiteConnection("Data Source=DTDB.sqlite;Version=3;");
            conn.Open();
            //sql = "create table IF NOT EXISTS "+TABLE_CAT+" (id int autoincrement,name varchar(20)) ";
            sql = "create table  IF NOT EXISTS " + TABLE_ITEMS + " (code INT PRIMARY KEY,name varchar(50),ml INT,category varchar(12),tax INT(1),fc real,ac real,oc real,room real,parcel real,garden real) ";
            ExecuteNonQuery(sql);
            sql = "create table  IF NOT EXISTS " + TABLE_STOCK + " (code INT,qty INT,ml INT) ";
            ExecuteNonQuery(sql);

        }
        public int ExecuteNonQuery(string txtQuery)
        {
            cmd = new SQLiteCommand(txtQuery, conn);
            return cmd.ExecuteNonQuery();
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
