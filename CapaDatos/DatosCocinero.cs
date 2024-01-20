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
    public class DatosCocinero
    {
        public List<EntityCocinero> GetAll()
        {
            List<EntityCocinero> list = new List<EntityCocinero>();

            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                conn.Open();
                string sql = @"SELECT CocineroId, CocineroNombre, CocineroApellido, CocineroDomicilio,
                            CocineroCi, CocineroSueldo FROM Cocineros ORDER BY CocineroApellido";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(LoadCocinero(reader));
                }
            }
            return list;
        }
        public EntityCocinero GetById(int id)
        {
            EntityCocinero cocinero = null;

            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                conn.Open();
                string sql = @"SELECT CocineroId, CocineroNombre, CocineroApellido, CocineroDomicilio,
                            CocineroCi, CocineroSueldo FROM Cocineros WHERE CocineroId = @idCocinero";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("idCocinero", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cocinero = LoadCocinero(reader);
                }
            }
            return cocinero;
        }
        public bool Exists(int id)
        {
            int nrorecord = 0;

            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                conn.Open();
                string sql = @"SELECT Count(*) FROM Cocineros WHERE CocineroId = @idCocinero";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("idCocinero", id);
                nrorecord = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return nrorecord > 0;
        }
        public EntityCocinero Create(EntityCocinero cocinero)
        {
            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                string sql = @"INSERT INTO Cocineros 
                            (CocineroNombre, CocineroApellido, CocineroDomicilio, CocineroCi, CocineroSueldo)
                            VALUES 
                            (@cocineroNombre, @cocineroApellido, @cocineroDomicilio, @cocineroCi, @cocineroSueldo)
                            SELECT SCOPE_IDENTITY()";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cocineroNombre", cocinero.CocineroNombre);
                cmd.Parameters.AddWithValue("@cocineroApellido", cocinero.CocineroApellido);
                cmd.Parameters.AddWithValue("@cocineroDomicilio", cocinero.CocineroDomicilio);
                cmd.Parameters.AddWithValue("@cocineroCi", cocinero.CocineroCi);
                cmd.Parameters.AddWithValue("@cocineroSueldo", cocinero.CocineroSueldo);
                cocinero.CocineroId = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
            }
            return cocinero;
        }
        public EntityCocinero Update(EntityCocinero cocinero)
        {
            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                conn.Open();
                string sql = @"UPDATE Cocineros SET CocineroNombre = @CocineroNombre, 
                            CocineroApellido = @cocineroApellido, CocineroDomicilio = @cocineroDomicilio,
                            CocineroCi = @cocineroCi, CocineroSueldo = @cocineroSueldo
                            WHERE CocineroId = @idCocinero";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cocineroNombre", cocinero.CocineroNombre);
                cmd.Parameters.AddWithValue("@cocineroApellido", cocinero.CocineroApellido);
                cmd.Parameters.AddWithValue("@cocineroDomicilio", cocinero.CocineroDomicilio);
                cmd.Parameters.AddWithValue("@cocineroCi", cocinero.CocineroCi);
                cmd.Parameters.AddWithValue("@cocineroSueldo", cocinero.CocineroSueldo);
                cmd.Parameters.AddWithValue("@idCocinero", cocinero.CocineroId);
                cmd.ExecuteNonQuery();
            }
            return cocinero;
        }
        private EntityCocinero LoadCocinero(IDataReader reader)
        {
            EntityCocinero cocinero = new EntityCocinero();
            cocinero.CocineroId = Convert.ToInt32(reader["MeseroId"]);
            cocinero.CocineroNombre = Convert.ToString(reader["MeseroNombre"]);
            cocinero.CocineroApellido = Convert.ToString(reader["MeseroApellido"]);
            cocinero.CocineroDomicilio = Convert.ToString(reader["MeseroDomicilio"]);
            cocinero.CocineroCi = Convert.ToString(reader["MeseroCi"]);
            cocinero.CocineroSueldo = Convert.ToDecimal(reader["MeseroSueldo"]);
            return cocinero;
        }
    }
}
