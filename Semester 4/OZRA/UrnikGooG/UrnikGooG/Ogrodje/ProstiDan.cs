using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UrnikGooG.Interface;
using System.Data;
using System.Data.SqlClient;
using UrnikGooG.BAZA;

namespace UrnikGooG.Ogrodje
{
    public class ProstiDan
    {
        public int Id { get; set; }
        public DateTime dan { get; set; }
        public string  Opis { get; set; }
        public Urnik Urnik { get; set; }

        public static ProstiDan get(int id)
        {
            return Baza.getOne("SELECT * FROM ProstiDan pro WHERE pro.Id = @Id", id, reader => new ProstiDan
            {
                Id = Convert.ToInt32(reader["Id"]),
                dan = DateTime.Parse(reader["Datum"].ToString()),
                Opis = reader["Opis"].ToString(),
                Urnik = Urnik.getUrnik(int.Parse(reader["Id_Urnik"].ToString()))
            });
        }



        public static List<ProstiDan> getAll()
        {
            return Baza.getAll("SELECT * FROM ProstiDan", reader => new ProstiDan
            {
                Id = Convert.ToInt32(reader["Id"]),
                dan = DateTime.Parse(reader["Datum"].ToString()),
                Opis = reader["Opis"].ToString(),
                Urnik = Urnik.getUrnik(int.Parse(reader["Id_Urnik"].ToString()))
            });
        }

        public static bool insert(ProstiDan date)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO ProstiDan(Id, Datum, Opis, Id_Urnik) VALUES(@Id, @Datum, @Opis, @Id_Urnik)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", date.Id);
            cmd.Parameters.AddWithValue("@Datum", date.dan);
            cmd.Parameters.AddWithValue("@Opis", date.Opis);
            cmd.Parameters.AddWithValue("@Id_Urnik", date.Urnik.Id);
            return Baza.Execute(cmd);

        }

        public static bool update(ProstiDan date)
        {
            SqlCommand cmd = new SqlCommand("UPDATE ProstiDan SET Datum = @Datum, Opis = @Opis, Id_Urnik = @Id_Urnik WHERE Id = @Id; ");
            cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", date.Id);
            cmd.Parameters.AddWithValue("@Datum", date.dan);
            cmd.Parameters.AddWithValue("@Opis", date.Opis);
            cmd.Parameters.AddWithValue("@Id_Urnik", date.Urnik.Id);
            return Baza.Execute(cmd);
        }

        public static bool delete(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM ProstiDan WHERE Id = @Id; ");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", id);
            return Baza.Execute(cmd);
        }
    }
}