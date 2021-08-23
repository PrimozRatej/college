using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using UrnikGooG.BAZA;


namespace UrnikGooG.Ogrodje
{
    public class Izmena
    {
        public int Id { get; set; }
        public DateTime DatumZačetka { get; set; }
        public DateTime DatumKonca { get; set; }
        public Urnik urnik { get; set; }

        public static Izmena get(int id)
        {
            return Baza.getOne("SELECT * FROM Izmena izm WHERE izm.Id = @Id", id, reader => new Izmena
            {
                Id = Convert.ToInt32(reader["Id"]),
                DatumZačetka = DateTime.Parse(reader["DatumZacetka"].ToString()),
                DatumKonca = DateTime.Parse(reader["DatumKonca"].ToString()),
                urnik = Urnik.getUrnik(int.Parse(reader["Id_Urnik"].ToString()))

            });
        }

        public static List<Izmena> getAll()
        {
            return Baza.getAll("SELECT * FROM Izmena", reader => new Izmena
            {
                Id = Convert.ToInt32(reader["Id"]),
                DatumZačetka = DateTime.Parse(reader["DatumZacetka"].ToString()),
                DatumKonca = DateTime.Parse(reader["DatumKonca"].ToString()),
                urnik = Urnik.getUrnik(int.Parse(reader["Id_Urnik"].ToString()))

            });
        }
        //Insert update delete samo za enkraten vpis ne vnese podvojenih vrstic npr. vsa opravila te izmene.
        public static bool insert(Izmena izm)
        {       
           SqlCommand cmd = new SqlCommand("INSERT INTO Izmena(Id, DatumZacetka, DatumKonca, Id_Urnik) VALUES(@Id, @DatumZacetka ,@DatumKonca ,@Id_Urnik)");
           cmd.CommandType = CommandType.Text;
           cmd.Parameters.AddWithValue("@Id", izm.Id);
           cmd.Parameters.AddWithValue("@DatumZacetka", izm.DatumZačetka);
           cmd.Parameters.AddWithValue("@DatumKonca", izm.DatumKonca);
           cmd.Parameters.AddWithValue("@Id_Urnik", izm.urnik.Id);
            return Baza.Execute(cmd);
        }
        //Update ne nastavi vrednosti za tuji ključ
        public static bool update(Izmena izm)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Izmena SET DatumZacetka = @DatumZacetka, DatumKonca = @DatumKonca, Id_Urnik = @Id_Urnik  WHERE Id = @Id; ");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", izm.Id);
            cmd.Parameters.AddWithValue("@DatumZacetka", izm.DatumZačetka);
            cmd.Parameters.AddWithValue("@DatumKonca", izm.DatumKonca);
            cmd.Parameters.AddWithValue("@Id_Urnik", izm.urnik.Id);
            return Baza.Execute(cmd);
        }
        //Pri brisanju dependency bo prišlo do napake
        public static bool delete(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Izmena WHERE Id = @Id;");
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);
                return Baza.Execute(cmd);
            }
            catch
            {
                throw new Exception("Napaka po vsej vrjetnosti si hotu bisat ko je neka blo odvisno z nečim BAZA and that shit");
            }
            

        }

        
    }
}