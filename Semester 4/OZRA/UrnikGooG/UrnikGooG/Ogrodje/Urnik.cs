using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UrnikGooG.Interface;
using UrnikGooG.BAZA;
using System.Data.SqlClient;
using System.Data;

namespace UrnikGooG.Ogrodje
{
    public class Urnik
    {
        public Zaposleni Zaposleni { get; set; }
        public int Id { get; set; }
        public int Leto { get; set; }
        public int Mesec { get; set; }


        public static Urnik getUrnik(int Id)
        {
            return Baza.getOne("SELECT * FROM MesečniUrnik urn WHERE urn.Id = @Id", Id, reader => new Urnik
            {
                Id = Convert.ToInt32(reader["Id"]),
                Leto = int.Parse(reader["Leto"].ToString()),
                Mesec = int.Parse(reader["Mesec"].ToString()),
                Zaposleni = Zaposleni.getZaposlen(int.Parse(reader["Id_Zaposleni"].ToString()))
            });
        }

        public static List<Urnik> getUrnikZaposleni(int Id_zap)
        {
            return Baza.getAll("SELECT * FROM MesečniUrnik WHERE Id_Zaposleni = @Id", Id_zap, reader => new Urnik
            {
                Id = Convert.ToInt32(reader["Id"]),
                Leto = int.Parse(reader["Leto"].ToString()),
                Mesec = int.Parse(reader["Mesec"].ToString()),
                Zaposleni = Zaposleni.getZaposlen(int.Parse(reader["Id_Zaposleni"].ToString()))
            });
        }

        public static List<Urnik> getUrnike()
        {
            return Baza.getAll("SELECT * FROM MesečniUrnik", reader => new Urnik
            {
                Id = Convert.ToInt32(reader["Id"]),
                Leto = int.Parse(reader["Leto"].ToString()),
                Mesec = int.Parse(reader["Mesec"].ToString()),
                Zaposleni = Zaposleni.getZaposlen(int.Parse(reader["Id_Zaposleni"].ToString()))
            });
        }

        public static bool insertUrnik(Urnik urnik)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO MesečniUrnik(Id, Leto, Mesec, Id_Zaposleni) VALUES(@Id, @Leto ,@Mesec, @Id_Zaposleni)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", urnik.Id);
            cmd.Parameters.AddWithValue("@Leto", urnik.Leto);
            cmd.Parameters.AddWithValue("@Mesec", urnik.Mesec);
            cmd.Parameters.AddWithValue("@Id_Zaposleni", urnik.Zaposleni.Id);
            return Baza.Execute(cmd);
        }

        public static bool updateUrnik(Urnik urnik)
        {
            SqlCommand cmd = new SqlCommand("UPDATE MesečniUrnik SET Id = @Id, Leto = @Leto, Mesec = @Mesec, Id_Zaposleni = @Id_Zaposleni WHERE Id = @Id; ");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", urnik.Id);
            cmd.Parameters.AddWithValue("@Leto", urnik.Leto);
            cmd.Parameters.AddWithValue("@Mesec", urnik.Mesec);
            cmd.Parameters.AddWithValue("@Id_Zaposleni", urnik.Zaposleni.Id);
            return Baza.Execute(cmd);
        }

       
    }
}