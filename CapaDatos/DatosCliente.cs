using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace CapaDatos
{
    public class DatosCliente
    {
        public List<EntityCliente> GetAll()
        {
            List<EntityCliente> list = new List<EntityCliente>();

            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                conn.Open();
                string sql = @"SELECT ClienteId, ClienteNombre, ClienteApellido FROM Clientes 
                            ORDER BY ClienteApellido";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(LoadCliente(reader));
                }
            }
            return list;
        }
        public EntityCliente GetById(int id)
        {
            EntityCliente cliente = null;

            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                conn.Open();
                string sql = @"SELECT ClienteId, ClienteNombre, ClienteApellido FROM Clientes 
                            WHERE ClienteId = @idCliente";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("idCliente", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cliente = LoadCliente(reader);
                }
            }
            return cliente;
        }
        public bool Exists(int id)
        {
            int nrorecord = 0;

            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                conn.Open();
                string sql = @"SELECT Count(*) FROM Clientes WHERE ClienteId = @idCliente";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("idCliente", id);
                nrorecord = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return nrorecord > 0;
        }
        public EntityCliente Create(EntityCliente cliente)
        {
            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                string sql = @"INSERT INTO Clientes (ClienteNombre, ClienteApellido) VALUES
                            (@clienteNombre, @clienteApellido) SELECT SCOPE_IDENTITY()";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@clienteNombre", cliente.ClienteNombre);
                cmd.Parameters.AddWithValue("@clienteApellido", cliente.ClienteApellido);
                cliente.ClienteId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return cliente;
        }
        public EntityCliente Update(EntityCliente cliente)
        {
            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                conn.Open();
                string sql = @"UPDATE Clientes SET ClienteNombre = @clienteNombre, 
                            ClienteApellido = @clienteApellido WHERE ClienteId = @idCliente";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@clienteNombre", cliente.ClienteNombre);
                cmd.Parameters.AddWithValue("@clienteApellido", cliente.ClienteApellido);
                cmd.Parameters.AddWithValue("@idCliente", cliente.ClienteId);
                cmd.ExecuteNonQuery();
            }
            return cliente;
        }
        private EntityCliente LoadCliente(IDataReader reader)
        {
            EntityCliente cliente = new EntityCliente();
            cliente.ClienteId = Convert.ToInt32(reader["ClienteId"]);
            cliente.ClienteNombre = Convert.ToString(reader["ClienteNombre"]);
            cliente.ClienteApellido = Convert.ToString(reader["ClienteApellido"]);
            return cliente;
        }
    }
}
