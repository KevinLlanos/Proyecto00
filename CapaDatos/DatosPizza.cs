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
    public class DatosPizza
    {
        public List<EntityPizza> GetAll()
        {
            List<EntityPizza> list = new List<EntityPizza>();

            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                conn.Open();
                string sql = @"SELECT PizzaId, CocineroId, PizzaNombre FROM Pizzas ORDER BY PizzaNombre";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(LoadPizza(reader));
                }
            }
            return list;
        }
        public decimal GetPrecioByPizzaId(int id)
        {
            decimal precio = 0;

            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                conn.Open();
                string sql = @"SELECT PrecioUnitario FROM Pizzas WHERE PizzaId = @idPizza";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idPizza", Convert.ToInt32(id));
                precio = Convert.ToDecimal(cmd.ExecuteScalar());
            }
            return precio;
        }
        private EntityPizza LoadPizza(IDataReader reader)
        {
            EntityPizza pizza = new EntityPizza();
            pizza.PizzaId = Convert.ToInt32(reader["PizzaId"]);
            pizza.CocineroId = Convert.ToInt32(reader["CocineroId"]);
            pizza.PizzaNombre = Convert.ToString(reader["PizzaNombre"]);
            return pizza;
        }
    }
}
