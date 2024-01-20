using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;

namespace CapaNegocios
{
    public class NegociosMesero
    {
        private DatosMesero datosMesero = new DatosMesero();
        public List<EntityMesero> GetAll()
        {
            return datosMesero.GetAll();
        }
        public EntityMesero GetById(int id)
        {
            return datosMesero.GetById(id);
        }
        //public EntityMesero SaveMesero(EntityMesero mesero)
        //{
        //    if (datosMesero.Exists(mesero.MeseroId))
        //        return datosMesero.Update(mesero);
        //    else
        //        return datosMesero.Create(mesero);
        //}
        public EntityMesero CreateMesero(EntityMesero mesero)
        {
            return datosMesero.Create(mesero);
        }
        public EntityMesero UpdateMesero(EntityMesero mesero)
        {
            return datosMesero.Update(mesero);
        }
    }
}
