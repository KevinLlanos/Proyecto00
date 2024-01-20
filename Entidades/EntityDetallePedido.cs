using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntityDetallePedido
    {
        public int DetallePedidoId { get; set; }
        public int PedidoId { get; set; }
        public int PizzaId { get; set; }
        public int MeseroId { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
    }
}
