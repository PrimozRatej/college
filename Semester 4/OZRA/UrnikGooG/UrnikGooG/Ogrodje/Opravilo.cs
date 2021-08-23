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
    public class Opravilo
    {
        public int Id { get; set; }
        public DateTime ZačetekOpravila { get; set; }
        public DateTime KonecOpravila { get; set; }
        public bool Opravljeno { get; set; }
        public string Opis { get; set; }
        public TipOpravila TipOpravila { get; set; }
        public Izmena Izmena { get; set; }

        public static Opravilo get(int id)
        {
            return Baza.getOne("SELECT * FROM Opravilo pro WHERE pro.Id = @Id", id, reader => new Opravilo
            {
                Id = Convert.ToInt32(reader["Id"]),
                ZačetekOpravila = DateTime.Parse(reader["ZačetekOpravila"].ToString()),
                KonecOpravila = DateTime.Parse(reader["KonecOpravila"].ToString()),
                Opravljeno = bool.Parse(reader["Opravljeno"].ToString()),
                Opis = reader["Opis"].ToString(),
                TipOpravila = TipOpravila.get(int.Parse(reader["Id_TipOpravila"].ToString())),
                Izmena = Izmena.get(int.Parse(reader["Id_Izmena"].ToString()))

            });
        }

        public static Opravilo get(string id)
        {
            return Baza.getOne("SELECT * FROM Opravilo pro WHERE pro.Id = @Id", int.Parse(id), reader => new Opravilo
            {
                Id = Convert.ToInt32(reader["Id"]),
                ZačetekOpravila = DateTime.Parse(reader["ZačetekOpravila"].ToString()),
                KonecOpravila = DateTime.Parse(reader["KonecOpravila"].ToString()),
                Opravljeno = bool.Parse(reader["Opravljeno"].ToString()),
                Opis = reader["Opis"].ToString(),
                TipOpravila = TipOpravila.get(int.Parse(reader["Id_TipOpravila"].ToString())),
                Izmena = Izmena.get(int.Parse(reader["Id_Izmena"].ToString()))

            });
        }
        /// <summary>
        /// //////////////////////////////////////////////////TU SI OSTAV
        /// </summary>
        /// <returns></returns>
        public static List<Opravilo> getAll()
        {
            return Baza.getAll("SELECT * FROM Opravilo", reader => new Opravilo
            {
                //TU TI NIKA NENA VREDI PARSA
                //4.4.17 Ne parsa če je datum null
                Id = Convert.ToInt32(reader["Id"]),
                ZačetekOpravila = DateTime.Parse(reader["ZačetekOpravila"].ToString()),
                KonecOpravila = DateTime.Parse(reader["KonecOpravila"].ToString()),
                Opravljeno = bool.Parse(reader["Opravljeno"].ToString()),
                Opis = reader["Opis"].ToString(),
                TipOpravila = TipOpravila.get(int.Parse(reader["Id_TipOpravila"].ToString())),
                Izmena = Izmena.get(int.Parse(reader["Id_Izmena"].ToString()))

            });
        }

        public static List<Opravilo> getAll(int idOpravila)
        {
            return Baza.getAll("SELECT * FROM Opravilo pro WHERE pro.Id = @Id",idOpravila, reader => new Opravilo
            {
                Id = Convert.ToInt32(reader["Id"]),
                ZačetekOpravila = DateTime.Parse(reader["ZačetekOpravila"].ToString()),
                KonecOpravila = DateTime.Parse(reader["KonecOpravila"].ToString()),
                Opravljeno = bool.Parse(reader["Opravljeno"].ToString()),
                Opis = reader["Opis"].ToString(),
                TipOpravila = TipOpravila.get(int.Parse(reader["Id_TipOpravila"].ToString())),
                Izmena = Izmena.get(int.Parse(reader["Id_Izmena"].ToString()))

            });
        }



        public static bool insert(Opravilo opra)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Opravilo(Id, ZačetekOpravila, KonecOpravila, Opravljeno, Opis, Id_TipOpravila, Id_Izmena) VALUES(@Id, @ZačetekOpravila ,@KonecOpravila ,@Opravljeno ,@Opis ,@Id_TipOpravila, @Id_Izmena)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", opra.Id);
            cmd.Parameters.AddWithValue("@ZačetekOpravila", opra.ZačetekOpravila);
            cmd.Parameters.AddWithValue("@KonecOpravila", opra.KonecOpravila);
            cmd.Parameters.AddWithValue("@Opravljeno", opra.Opravljeno);
            cmd.Parameters.AddWithValue("@Opis", opra.Opis);
            cmd.Parameters.AddWithValue("@Id_TipOpravila", opra.TipOpravila.Id);
            cmd.Parameters.AddWithValue("@Id_Izmena", opra.Izmena.Id);
            return Baza.Execute(cmd);

        }

        public static bool update(Opravilo opra)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Opravilo SET ZačetekOpravila = @ZačetekOpravila, KonecOpravila = @KonecOpravila, Opravljeno = @Opravljeno, Opis = @Opis, Id_TipOpravila = @Id_TipOpravila  WHERE Id = @Id; ");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", opra.Id);
            cmd.Parameters.AddWithValue("@ZačetekOpravila", opra.ZačetekOpravila);
            cmd.Parameters.AddWithValue("@KonecOpravila", opra.KonecOpravila);
            cmd.Parameters.AddWithValue("@Opravljeno", opra.Opravljeno);
            cmd.Parameters.AddWithValue("@Opis", opra.Opis);
            cmd.Parameters.AddWithValue("@Id_TipOpravila", opra.TipOpravila.Id);
            cmd.Parameters.AddWithValue("@Id_Izmena", opra.Izmena.Id);
            return Baza.Execute(cmd);
        }

        public static bool delete(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Opravilo WHERE Id = @Id; ");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", id);
            return Baza.Execute(cmd);
        }
    }
}