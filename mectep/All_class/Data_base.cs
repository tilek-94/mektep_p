using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace mectep.All_class
{
    class Data_base
    {
        SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\ProgramData\\mektep\\basa.db;Version=3;New=False;Compress=True;");
        public void SoursData(string s)
        {

            connection.Open();
            SQLiteCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            DataTable dta1 = new DataTable();
            SQLiteDataAdapter dataadap = new SQLiteDataAdapter(cmd);
            dataadap.Fill(dta1);
            //dataGridView1.ItemsSource = dta1.DefaultView; ;
            connection.Close();
        }
        public void Registr(string s)
        {
            connection.Open();
            SQLiteCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public string muzic_name = "";
        public string DisplayReturn(string s)
        {
            connection.Open();
            string sql = s, value = "";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                value = reader[0].ToString();
            }
            connection.Close();
            return value;
        }
        public void Adres(string s)
        {
            connection.Open();
            string sql = s, val = "";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                val = reader[0].ToString();
            }
            muzic_name = val;
            connection.Close();
        }
    }
}
