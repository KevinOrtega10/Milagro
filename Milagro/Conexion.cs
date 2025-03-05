using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Milagro
{
    internal class Conexion
    {
        private string connectionString = "Server=KEV10;Database=Sony;Integrated Security=True;Encrypt=False;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(connectionString);
        }

        public void ProbarConexion()
        {
            using (var conexion = ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexión exitosa.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error de conexión: {ex.Message}");
                }
            }
        }
    }
}
