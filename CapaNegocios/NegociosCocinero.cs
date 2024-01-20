using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;

namespace CapaNegocios
{
    public class NegociosCocinero
    {
        private DatosCocinero datosCocinero = new DatosCocinero();
        public List<EntityCocinero> GetAll()
        {
            return datosCocinero.GetAll();
        }
        public EntityCocinero GetById(int id)
        {
            return datosCocinero.GetById(id);
        }
        //public EntityCocinero SaveCocinero(EntityCocinero cocinero)
        //{
        //    if (datosCocinero.Exists(cocinero.CocineroId))
        //        return datosCocinero.Update(cocinero);
        //    else
        //        return datosCocinero.Create(cocinero);
        //}
        public EntityCocinero CreateCocinero(EntityCocinero cocinero)
        {
            return datosCocinero.Create(cocinero);
        }
        public EntityCocinero UpdateCocinero(EntityCocinero cocinero)
        {
            return datosCocinero.Update(cocinero);
        }
    }
}
