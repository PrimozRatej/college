using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using UrnikGooG.BAZA;
using System.Data;
using System.Data.SqlClient;

namespace UrnikGooG.Ogrodje
{
    
    public class Bolniška
    {
        public int Id { get; set; }
        public DateTime DatumZačetka { get; set; }
        public DateTime DatumKonca { get; set; }
        public string  Razlog { get; set; }
        public Urnik Urnik { get; set; }

        public static Bolniška get(int id)
        {
            return Baza.getOne("SELECT * FROM Bolniška bol WHERE bol.Id = @Id", id, reader => new Bolniška
            {
                Id = Convert.ToInt32(reader["Id"]),
                DatumZačetka = DateTime.Parse(reader["DatumZačetka"].ToString()),
                DatumKonca = DateTime.Parse(reader["DatumKonca"].ToString()),
                Razlog = reader["Razlog"].ToString(),
                Urnik = Urnik.getUrnik(int.Parse(reader["Id_Urnik"].ToString()))
            });
        }



        public static List<Bolniška> get()
        {
            return Baza.getAll("SELECT * FROM Bolniška", reader => new Bolniška
            {
                Id = Convert.ToInt32(reader["Id"]),
                DatumZačetka = DateTime.Parse(reader["DatumZačetka"].ToString()),
                DatumKonca = DateTime.Parse(reader["DatumKonca"].ToString()),
                Razlog = reader["Razlog"].ToString(),
                Urnik = Urnik.getUrnik(int.Parse(reader["Id_Urnik"].ToString()))
            });
        }

        public static bool insert(Bolniška bol)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Bolniška(Id, DatumZačetka, DatumKonca, Razlog, Id_Urnik) VALUES(@Id, @DatumZačetka, @DatumKonca, @Razlog, @Id_Urnik)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", bol.Id);
            cmd.Parameters.AddWithValue("@DatumZačetka", bol.DatumZačetka);
            cmd.Parameters.AddWithValue("@DatumKonca", bol.DatumKonca);
            cmd.Parameters.AddWithValue("@Razlog", bol.Razlog);
            cmd.Parameters.AddWithValue("@Id_Urnik", bol.Urnik.Id);
            return Baza.Execute(cmd);

        }

        public static bool update(Bolniška bol)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Bolniška SET DatumZačetka = @DatumZačetka, DatumKonca = @DatumKonca, Razlog = @Razlog Id_Urnik = @Id_Urnik WHERE Id = @Id; ");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", bol.Id);
            cmd.Parameters.AddWithValue("@DatumZačetka", bol.DatumZačetka);
            cmd.Parameters.AddWithValue("@DatumKonca", bol.DatumKonca);
            cmd.Parameters.AddWithValue("@Razlog", bol.Razlog);
            cmd.Parameters.AddWithValue("@Id_Urnik", bol.Urnik.Id);
            return Baza.Execute(cmd);
        }

        public static bool delete(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Bolniška WHERE Id = @Id; ");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", id);
            return Baza.Execute(cmd);
        }
    }
}