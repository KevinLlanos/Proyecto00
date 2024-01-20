using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntityPedido
    {
        public EntityPedido()
        {
            this.Lineas = new List<EntityDetallePedido>();
        }
        public int PedidoId { get; set; }
        public int ClienteId { get; set; }
        public DateTime PedidoFecha { get; set; }
        public List<EntityDetallePedido> Lineas { get; set; }
        public decimal Total
        {
            get { return this.Lineas.Sum(x => x.PrecioUnitario * x.Cantidad); }
        }
    }
}
