using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace UrnikGooG.BAZA
{
    public class Baza
    {
        public static string connectionString = "Data Source=PRIMOZ;Initial Catalog=UrnikGooG;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True";

        public static List<T> getAll<T>(string select, Func<SqlDataReader, T> f)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                var lst = new List<T>();
                using (SqlCommand command = new SqlCommand(select, con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lst.Add(f(reader));
                    }
                }
                return lst;
            }

        }

        public static List<T> getAll<T>(string select, int id, Func<SqlDataReader, T> fun, string idName = "@Id")
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                var lst = new List<T>();
                SqlCommand command = new SqlCommand(select, con);
                command.Parameters.AddWithValue(idName, id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lst.Add(fun(reader));
                    }
                }
                return lst;
            }

        }

        public static T getOne<T>(string select, int id, Func<SqlDataReader, T> f, string idName = "@Id")  where T : new()
        {
           
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                var entiteta = new T();
                SqlCommand command = new SqlCommand(select, con);
                command.Parameters.AddWithValue(idName, id);
                string komand = command.CommandText;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        entiteta = f(reader);
                    }
                }
                return entiteta;
            }

        }

        public static bool Execute (SqlCommand cmd)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                cmd.Connection = con;
                int dodanih = cmd.ExecuteNonQuery();
                return dodanih > 0;
            }

        }

    }


}