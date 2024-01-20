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
    public class DatosPedido
    {
        public void Create(EntityPedido pedido)
        {
            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                conn.Open();
                string sqlPedido = @"INSERT INTO Pedidos (ClienteId, PedidoFecha, Total) 
                                    VALUES (@idCliente, @pedidoFecha, @total)
                                    SELECT SCOPE_IDENTITY()";
                using (SqlCommand cmd = new SqlCommand(sqlPedido, conn))
                {

                    cmd.Parameters.AddWithValue("@idCliente", pedido.ClienteId);
                    cmd.Parameters.AddWithValue("@pedidoFecha", pedido.PedidoFecha);
                    cmd.Parameters.AddWithValue("@total", 0);
                    pedido.PedidoId = Convert.ToInt32(cmd.ExecuteScalar());
                }
                string sqlLineaPedido = @"INSERT INTO DetallePedidos 
                                        (PedidoId, PizzaId, MeseroId, PrecioUnitario, Cantidad) 
                                        VALUES (@idPedido, @idPizza, @idMesero, @precioUnitario, @cantidad)
                                        SELECT SCOPE_IDENTITY()";
                using (SqlCommand cmd = new SqlCommand(sqlLineaPedido, conn))
                {
                    foreach (EntityDetallePedido detallePedido in pedido.Lineas)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@idPedido", pedido.PedidoId);
                        cmd.Parameters.AddWithValue("@idPizza", detallePedido.PizzaId);
                        cmd.Parameters.AddWithValue("@idMesero", detallePedido.MeseroId);
                        cmd.Parameters.AddWithValue("@precioUnitario", detallePedido.PrecioUnitario);
                        cmd.Parameters.AddWithValue("@cantidad", detallePedido.Cantidad);
                        detallePedido.DetallePedidoId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
        }
        public void UpdateTotal(int idPedido, decimal total)
        {
            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                conn.Open();
                string sqlUpdateTotal = @"UPDATE Pedidos SET Total = @total WHERE PedidoId = @idPedido";
                using (SqlCommand cmd = new SqlCommand(sqlUpdateTotal, conn))
                {
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@idPedido", idPedido);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
