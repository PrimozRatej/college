using System;
using System.Collections.Generic;
using UrnikGooG.BAZA;
using System.Data.SqlClient;
using System.Data;

namespace UrnikGooG.Ogrodje
{
    public class Dopust
    {
        public int Id { get; set; }
        public DateTime DatumZačetka { get; set; }
        public DateTime DatumKonca { get; set; }
        public bool Redni { get; set; }
        public Urnik urnik { get; set; }

        public static Dopust get(int id)
        {
            return Baza.getOne("SELECT * FROM Dopust pro WHERE pro.Id = @Id", id, reader => new Dopust
            {
                Id = Convert.ToInt32(reader["Id"]),
                DatumZačetka = DateTime.Parse(reader["DatumZačetka"].ToString()),
                DatumKonca = DateTime.Parse(reader["DatumKonca"].ToString()),
                Redni = bool.Parse(reader["Redni"].ToString()),
                urnik = Urnik.getUrnik(int.Parse(reader["Id_Urnik"].ToString()))

            });
        }

        public static List<Dopust> getAll()
        {
            return Baza.getAll("SELECT * FROM Dopust", reader => new Dopust
            {
                Id = Convert.ToInt32(reader["Id"]),
                DatumZačetka = DateTime.Parse(reader["DatumZačetka"].ToString()),
                DatumKonca = DateTime.Parse(reader["DatumKonca"].ToString()),
                Redni = bool.Parse(reader["Redni"].ToString()),
                urnik = Urnik.getUrnik(int.Parse(reader["Id_Urnik"].ToString()))
            });
        }

        public static bool insert(Dopust dop)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Dopust(Id, DatumZačetka, DatumKonca, Redni, Id_Urnik) VALUES(@Id, @DatumZačetka, @DatumKonca, @Redni, @Id_Urnik)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", dop.Id);
            cmd.Parameters.AddWithValue("@DatumZačetka", dop.DatumZačetka);
            cmd.Parameters.AddWithValue("@DatumKonca", dop.DatumKonca);
            cmd.Parameters.AddWithValue("@Redni", dop.Redni);
            cmd.Parameters.AddWithValue("@Id_Urnik", dop.urnik.Id);
            return Baza.Execute(cmd);

        }

        public static bool update(Dopust dop)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Dopust SET DatumZačetka = @DatumZačetka, DatumKonca = @DatumKonca, Redni = @Redni, Id_Urnik = @Id_Urnik WHERE Id = @Id; ");
            cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", dop.Id);
            cmd.Parameters.AddWithValue("@DatumZačetka", dop.DatumZačetka);
            cmd.Parameters.AddWithValue("@DatumKonca", dop.DatumKonca);
            cmd.Parameters.AddWithValue("@Redni", dop.Redni);
            cmd.Parameters.AddWithValue("@Id_Urnik", dop.urnik.Id);
            return Baza.Execute(cmd);
        }

        public static bool delete(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Dopust WHERE Id = @Id; ");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", id);
            return Baza.Execute(cmd);
        }
    }
}