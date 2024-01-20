using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;

namespace CapaNegocios
{
    public class NegociosPizza
    {
        private DatosPizza datosPizza = new DatosPizza();
        public List<EntityPizza> GetAll()
        {
            return datosPizza.GetAll();
        }
        public decimal GetPrecioByPizzaId(int id)
        {
            try
            {
                if (id >= 0)
                {
                    return datosPizza.GetPrecioByPizzaId(id);
                }
                else
                {
                    throw new Exception("Error: ID debe ser mayor o igual a 0");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
