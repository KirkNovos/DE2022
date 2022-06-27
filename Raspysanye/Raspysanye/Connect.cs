using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Raspysanye
{
    public class Connect
    {
        DataSet ds;
        public MySqlConnection con;
        public string connectStringg;// = "server=127.0.0.1;user=root;password=111111;database=Avzal;sslmode=none";
        public MySqlDataAdapter adapter;
        public MySqlDataReader dr;
        MySqlCommand cmd;

        public Connect()
        {
            foreach (string sr in File.ReadAllLines("initti.txt"))
            {
                connectStringg = sr;
            }
        }

        public void sidu_interface(string sql)
        {
            con = new MySqlConnection(connectStringg);
            con.Open();
            cmd = con.CreateCommand();
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                con.Close(); //закрываем соединение, т.к. оно нам больше не нужно
             //   MessageBox.Show("Успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataSet CO(string query)
        {
            con = new MySqlConnection(connectStringg);
            con.Open();
            adapter = new MySqlDataAdapter(query, con);
            ds = new DataSet();
            adapter.Fill(ds);
            con.Close();
            return ds;
        }

        public void SIDU(string sql) //select;insert;update;delit
        {
            con = new MySqlConnection(connectStringg);
            con.Open();
            MySqlCommand cmd2 = con.CreateCommand();
            try
            {
                cmd2.CommandText = sql;
                cmd2.ExecuteNonQuery();
                con.Close(); //закрываем соединение, т.к. оно нам больше не нужно
             //   MessageBox.Show("Успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public string ExecuteScalar(string sql)
        {
            //SqlConnection cnn = new SqlConnection("server = server232; user = serv232; password = 123456; database = raspys_novoselov;");
            MySqlConnection cnn = new MySqlConnection(connectStringg);
            cnn.Open();
            MySqlCommand mycommand = cnn.CreateCommand();
            mycommand.CommandText = sql;
            object value = mycommand.ExecuteScalar();
            cnn.Close();
            return value.ToString();
        }

        public int ExecuteScalarInt(string sql)
        {
            MySqlConnection cnn = new MySqlConnection(connectStringg);
            cnn.Open();
            MySqlCommand mycommand = cnn.CreateCommand();
            mycommand.CommandText = sql;
            int value = Convert.ToInt32(mycommand.ExecuteScalar());
            cnn.Close();
            return value;
        }


        public List<string> ListBD(string sql, int count_col)
        {
            List<string> l1 = new List<string>();
            con = new MySqlConnection(connectStringg);
            con.Open();

            MySqlCommand cmd2 = new MySqlCommand(sql, con);
            try
            {
                MySqlDataReader dr2 = cmd2.ExecuteReader();
                dr2.Read();
                for (int i = 0; i < count_col; i++)
                {
                    l1.Add(dr2.GetValue(i).ToString());
                }
                dr2.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return l1;
        }
        public string[] MBD(string sql, int count_col)
        {
            string[] l1 = new string[count_col];
            con = new MySqlConnection(connectStringg);
            con.Open();

            MySqlCommand cmd2 = new MySqlCommand(sql, con);
            try
            {
                MySqlDataReader dr2 = cmd2.ExecuteReader();
                dr2.Read();
                for (int i = 0; i < count_col; i++)
                {
                    l1[i] = dr2.GetValue(i).ToString();
                }
                dr2.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return l1;
        }


        public DataTable ConDT(string sql)
        {
            con = new MySqlConnection(connectStringg);
            con.Open(); //открываем БД
            DataTable dt = new DataTable();
            cmd = new MySqlCommand(sql, con);
            try
            {
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
                con.Close(); //закрываем соединение, т.к. оно нам больше не нужно
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }


        public string[] MBD1(string sql, int count_col)
        {
            string[] m1 = new string[count_col];
            DataTable dt = new DataTable();
            dt = ConDT(sql);
            for (int i = 0; i < count_col; i++)
            {
                m1[i] = dt.Rows[i].ItemArray[0].ToString();
            }
            return m1;
        }


    }
}