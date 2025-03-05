using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Milagro
{
    internal class DiscoRepository : IDiscoRepository
    {
        private Conexion conexion = new Conexion();

        public void InsertarDisco(Disco disco)
        {
            using (var con = conexion.ObtenerConexion())
            {
                con.Open();
                var query = "INSERT INTO Discos (Nombre, Artista, Genero, ANO, Precio) VALUES (@Nombre, @Artista, @Genero, @ANO, @Precio)";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", disco.Nombre);
                    cmd.Parameters.AddWithValue("@Artista", disco.Artista);
                    cmd.Parameters.AddWithValue("@Genero", disco.Genero);
                    cmd.Parameters.AddWithValue("@ANO", disco.ANO);
                    cmd.Parameters.AddWithValue("@Precio", disco.Precio);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarDisco(Disco disco)
        {
            using (var con = conexion.ObtenerConexion())
            {
                con.Open();
                var query = "UPDATE Discos SET Nombre=@Nombre, Artista=@Artista, Genero=@Genero, ANO=@ANO, Precio=@Precio WHERE Id=@Id";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", disco.Id);
                    cmd.Parameters.AddWithValue("@Nombre", disco.Nombre);
                    cmd.Parameters.AddWithValue("@Artista", disco.Artista);
                    cmd.Parameters.AddWithValue("@Genero", disco.Genero);
                    cmd.Parameters.AddWithValue("@ANO", disco.ANO);
                    cmd.Parameters.AddWithValue("@Precio", disco.Precio);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarDisco(int id)
        {
            using (var con = conexion.ObtenerConexion())
            {
                con.Open();
                var query = "DELETE FROM Discos WHERE Id=@Id";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Disco> ObtenerDisco()
        {
            List<Disco> discos = new List<Disco>();

            using (var con = conexion.ObtenerConexion())
            {
                con.Open();
                var query = "SELECT * FROM Discos";
                using (var cmd = new SqlCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        discos.Add(new Disco
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Artista = reader.GetString(2),
                            Genero = reader.GetString(3),
                            ANO = reader.GetInt32(4),
                            Precio = reader.GetDecimal(5)
                        });
                    }
                }
            }
            return discos;
        }
    }
}
