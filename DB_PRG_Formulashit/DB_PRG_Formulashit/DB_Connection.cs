using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DB_PRG_Formulashit
{
    class DB_Connection
    {

            string conString = "SERVER = localhost;" +
                           "DATABASE = db_formula_drift;" +
                           "UID = root;" +
                           "pwd=;";

            MySqlConnection con = new MySqlConnection();
            MySqlDataAdapter da = new MySqlDataAdapter();

            public void conOpen()
            {
                try
                {
                    con.ConnectionString = conString;
                    con.Open();
                }
                catch (Exception ex)
                {
                   
                    throw;
                }

            }
            public void conClose()
            {
                con.Close();
            }

            public DataTable getData(string qry)
            {
                //qry = Abfrage, z.B. SELECT * FROM tbl_fahrer
                MySqlCommand cmd = new MySqlCommand();
                DataTable dt = new DataTable();
                cmd.CommandText = qry;
                cmd.Connection = con;
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }

            public bool setData(string qry)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = qry;
                cmd.Connection = con;
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }

