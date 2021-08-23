using System;
using System.Collections.Generic;
using UrnikGooG.Interface;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Serialization;
using UrnikGooG.BAZA;

namespace UrnikGooG.Ogrodje
{
    [DataContract(Namespace = "http://localhost:57982/Storitev/Service1.svc/ZaposleniContract")]
    public class Zaposleni
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Ime { get; set; }
        [DataMember]
        public string Priimek { get; set; }
        [DataMember]
        public string Emšo { get; set; }
        [DataMember]
        public int DatvčnaŠtevilka { get; set; }
        [DataMember]
        public double UrnaPostavka { get; set; }


        public static Zaposleni getZaposlen(int id)
        {
            return Baza.getOne("SELECT * FROM Zaposleni zap WHERE zap.Id = @Id", id, reader => new Zaposleni
            {
                Id = Convert.ToInt32(reader["Id"]),
                Ime = reader["Ime"].ToString(),
                Priimek = reader["Priimek"].ToString(),
                Emšo = reader["Emšo"].ToString(),
                DatvčnaŠtevilka = Convert.ToInt32(reader["DavčnaŠtevilka"]),
                UrnaPostavka = Convert.ToDouble(reader["UrnaPostavka"])
            });
        }



        public static List<Zaposleni> getZaposlene()
        {
            return Baza.getAll("SELECT * FROM Zaposleni", reader => new Zaposleni
            {
                Id = Convert.ToInt32(reader["Id"]),
                Ime = reader["Ime"].ToString(),
                Priimek = reader["Priimek"].ToString(),
                Emšo = reader["Emšo"].ToString(),
                DatvčnaŠtevilka = Convert.ToInt32(reader["DavčnaŠtevilka"]),
                UrnaPostavka = Convert.ToDouble(reader["UrnaPostavka"])
            });
        }

        public static bool insertZaposlen(Zaposleni zap)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Zaposleni(Id, Ime, Priimek, Emšo, DavčnaŠtevilka, UrnaPostavka) VALUES(@Id, @Ime, @Priimek, @Emšo, @DavčnaŠtevilka, @UrnaPostavka)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", zap.Id);
            cmd.Parameters.AddWithValue("@Ime", zap.Ime);
            cmd.Parameters.AddWithValue("@Priimek", zap.Priimek);
            cmd.Parameters.AddWithValue("@Emšo", zap.Emšo);
            cmd.Parameters.AddWithValue("@DavčnaŠtevilka", zap.DatvčnaŠtevilka);
            cmd.Parameters.AddWithValue("@UrnaPostavka", zap.UrnaPostavka);
            return Baza.Execute(cmd);
            
        }

        public static bool updateZaposleni(Zaposleni zap)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Zaposleni SET Ime = @Ime, Priimek = @Priimek, Emšo = @Emšo, DavčnaŠtevilka = @DavčnaŠtevilka, UrnaPostavka = @UrnaPostavka WHERE Id = @Id; ");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", zap.Id);
            cmd.Parameters.AddWithValue("@Ime", zap.Ime);
            cmd.Parameters.AddWithValue("@Priimek", zap.Priimek);
            cmd.Parameters.AddWithValue("@Emšo", zap.Emšo);
            cmd.Parameters.AddWithValue("@DavčnaŠtevilka", zap.DatvčnaŠtevilka);
            cmd.Parameters.AddWithValue("@UrnaPostavka", zap.UrnaPostavka);
            return Baza.Execute(cmd);
        }

        public static bool deleteZaposleni(string id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Zaposleni WHERE Id = @Id; ");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", id);
            return Baza.Execute(cmd);
        }

        
    }
}