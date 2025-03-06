using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Milagro
{
    internal class DiscoRepository : IDiscoRepository
    {
        private Conexion conexion = new Conexion();
        private readonly string connectionstring;

        public DiscoRepository()
        {
            var conexion = new Conexion();
            connectionstring = conexion.GetConnectionString();
        }

        public void InsertarDisco(Disco disco)
        {
            using var conexion = new SqlConnection(connectionstring);
            conexion.Open();
            using var comando = new SqlCommand("InsertarDisco", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Titulo", disco.Nombre);
            comando.Parameters.AddWithValue("@Artista", disco.Artista);
            comando.Parameters.AddWithValue("@Genero", disco.Genero);
            comando.Parameters.AddWithValue("@ANo", disco.ANO);
            comando.Parameters.AddWithValue("@Precio", disco.Precio);

            comando.ExecuteNonQuery();
        }

        public void ActualizarDisco(Disco disco)
        {
            using var conexion = new SqlConnection(connectionstring);
            conexion.Open();
            using var comando = new SqlCommand("ActualizarDisco", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@DiscoID", disco.Id);
            comando.Parameters.AddWithValue("@Titulo", disco.Nombre);
            comando.Parameters.AddWithValue("@Artista", disco.Artista);
            comando.Parameters.AddWithValue("@Genero", disco.Genero);
            comando.Parameters.AddWithValue("@ANo", disco.ANO);
            comando.Parameters.AddWithValue("@Precio", disco.Precio);

            comando.ExecuteNonQuery();
        }

        public void EliminarDisco(int id)
        {
            using var conexion = new SqlConnection(connectionstring);
            conexion.Open();
            using var comando = new SqlCommand("BorrarDisco", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@DiscoID", id);

            comando.ExecuteNonQuery();
        }

        public List<Disco> ObtenerDisco()
        {
            List<Disco> discos = new List<Disco>();

            using (var con = conexion.ObtenerConexion())
            {
                con.Open();
                using var cmd = new SqlCommand("ObtenerDDiscos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                using var reader = cmd.ExecuteReader();
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
            return discos;
        }
    }
}
