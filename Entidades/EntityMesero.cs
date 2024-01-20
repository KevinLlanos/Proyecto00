using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntityMesero
    {
        public int MeseroId { get; set; }
        public string MeseroNombre { get; set; }
        public string MeseroApellido { get; set; }
        public string MeseroDomicilio { get; set; }
        public string MeseroCi { get; set; }
        public decimal MeseroSueldo { get; set; }
    }
}
