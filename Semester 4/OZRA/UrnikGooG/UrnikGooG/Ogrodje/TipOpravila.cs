using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using UrnikGooG.BAZA;

namespace UrnikGooG.Ogrodje
{
    public class TipOpravila
    {
        public int Id { get; set; }
        public string Ime { get; set; }

        public static TipOpravila get(int id)
        {
            return Baza.getOne("SELECT * FROM TipOpravila pro WHERE pro.Id = @Id", id, reader => new TipOpravila
            {
                Id = Convert.ToInt32(reader["Id"]),
                Ime = reader["Ime"].ToString()

            });
        }

        public static List<TipOpravila> getAll()
        {
            return Baza.getAll("SELECT * FROM TipOpravila", reader => new TipOpravila
            {
                Id = Convert.ToInt32(reader["Id"]),
                Ime = reader["Ime"].ToString()
            });
        }

        public static bool insert(TipOpravila tipOpr)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO TipOpravila(Id, Ime) VALUES(@Id, @Ime)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", tipOpr.Id);
            cmd.Parameters.AddWithValue("@Ime", tipOpr.Ime);
            return Baza.Execute(cmd);

        }

        public static bool update(TipOpravila tipOpr)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TipOpravila SET Ime = @Ime WHERE Id = @Id; ");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", tipOpr.Id);
            cmd.Parameters.AddWithValue("@Ime", tipOpr.Ime);
            return Baza.Execute(cmd);
        }

        public static bool delete(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM TipOpravila WHERE Id = @Id; ");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", id);
            return Baza.Execute(cmd);
        }
    }
}