using System.Data.SqlClient;

namespace CRUD.Data
{
    public class Conexion
    {
        private readonly string _connectionString;

        public Conexion(string valor)
        {
            _connectionString = valor;
        }

        public SqlConnection ObtenerConexion()
        {
            Console.WriteLine("Iniciando conexion");
            var conexion = new SqlConnection(_connectionString);
            Console.WriteLine(_connectionString);
            conexion.Open();
            return conexion;
        }
    }
}
