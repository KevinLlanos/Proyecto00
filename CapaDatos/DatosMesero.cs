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
    public class DatosMesero
    {
        public List<EntityMesero> GetAll()
        {
            List<EntityMesero> list = new List<EntityMesero>();

            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                conn.Open();
                string sql = @"SELECT MeseroId, MeseroNombre, MeseroApellido, MeseroDomicilio,
                            MeseroCi, MeseroSueldo FROM Meseros ORDER BY MeseroApellido";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(LoadMesero(reader));
                }
            }
            return list;
        }
        public EntityMesero GetById(int id)
        {
            EntityMesero mesero = null;

            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                conn.Open();
                string sql = @"SELECT MeseroId, MeseroNombre, MeseroApellido, MeseroDomicilio,
                            MeseroCi, MeseroSueldo FROM Meseros WHERE MeseroId = @idMesero";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("idMesero", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    mesero = LoadMesero(reader);
                }
            }
            return mesero;
        }
        public bool Exists(int id)
        {
            int nrorecord = 0;

            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                conn.Open();
                string sql = @"SELECT Count(*) FROM Meseros WHERE MeseroId = @idMesero";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("idMesero", id);
                nrorecord = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return nrorecord > 0;
        }
        public EntityMesero Create(EntityMesero mesero)
        {
            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                string sql = @"INSERT INTO Meseros 
                            (MeseroNombre, MeseroApellido, MeseroDomicilio, MeseroCi, MeseroSueldo)
                            VALUES 
                            (@meseroNombre, @meseroApellido, @meseroDomicilio, @meseroCi, @meseroSueldo)
                            SELECT SCOPE_IDENTITY()";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@meseroNombre", mesero.MeseroNombre);
                cmd.Parameters.AddWithValue("@meseroApellido", mesero.MeseroApellido);
                cmd.Parameters.AddWithValue("@meseroDomicilio", mesero.MeseroDomicilio);
                cmd.Parameters.AddWithValue("@meseroCi", mesero.MeseroCi);
                cmd.Parameters.AddWithValue("@meseroSueldo", mesero.MeseroSueldo);
                mesero.MeseroId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return mesero;
        }
        public EntityMesero Update(EntityMesero mesero)
        {
            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                conn.Open();
                string sql = @"UPDATE Meseros SET MeseroNombre = @meseroNombre, 
                            MeseroApellido = @meseroApellido, MeseroDomicilio = @meseroDomicilio,
                            MeseroCi = @meseroCi, MeseroSueldo = @meseroSueldo
                            WHERE MeseroId = @idMesero";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@meseroNombre", mesero.MeseroNombre);
                cmd.Parameters.AddWithValue("@meseroApellido", mesero.MeseroApellido);
                cmd.Parameters.AddWithValue("@meseroDomicilio", mesero.MeseroDomicilio);
                cmd.Parameters.AddWithValue("@meseroCi", mesero.MeseroCi);
                cmd.Parameters.AddWithValue("@meseroSueldo", mesero.MeseroSueldo);
                cmd.Parameters.AddWithValue("@idMesero", mesero.MeseroId);
                cmd.ExecuteNonQuery();
            }
            return mesero;
        }
        private EntityMesero LoadMesero(IDataReader reader)
        {
            EntityMesero mesero = new EntityMesero();
            mesero.MeseroId = Convert.ToInt32(reader["MeseroId"]);
            mesero.MeseroNombre = Convert.ToString(reader["MeseroNombre"]);
            mesero.MeseroApellido = Convert.ToString(reader["MeseroApellido"]);
            mesero.MeseroDomicilio = Convert.ToString(reader["MeseroDomicilio"]);
            mesero.MeseroCi = Convert.ToString(reader["MeseroCi"]);
            mesero.MeseroSueldo = Convert.ToDecimal(reader["MeseroSueldo"]);
            return mesero;
        }
    }
}
