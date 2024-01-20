using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntityCocinero
    {
        public int CocineroId { get; set; }
        public string CocineroNombre { get; set; }
        public string CocineroApellido { get; set; }
        public string CocineroDomicilio { get; set; }
        public string CocineroCi { get; set; }
        public decimal CocineroSueldo { get; set; }
    }
}
