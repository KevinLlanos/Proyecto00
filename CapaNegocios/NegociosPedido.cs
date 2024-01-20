using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;
using System.Transactions;

namespace CapaNegocios
{
    public class NegociosPedido
    {
        private DatosPedido datosPedido = new DatosPedido();
        public void CreatePedido(EntityPedido pedido)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                datosPedido.Create(pedido);
                datosPedido.UpdateTotal(pedido.PedidoId, pedido.Total);
                scope.Complete();
            }
        }
    }
}
