using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;

namespace CapaNegocios
{
    public class NegociosCliente
    {
        private DatosCliente datosCliente = new DatosCliente();
        public List<EntityCliente> GetAll()
        {
            return datosCliente.GetAll();
        }
        public EntityCliente GetById(int id)
        {
            return datosCliente.GetById(id);
        }
        //public EntityCliente SaveCliente(EntityCliente cliente)
        //{
        //    if (datosCliente.Exists(cliente.ClienteId))
        //        return datosCliente.Update(cliente);
        //    else
        //        return datosCliente.Create(cliente);
        //}
        public EntityCliente CreateCliente(EntityCliente cliente)
        {
            return datosCliente.Create(cliente);
        }
        public EntityCliente UpdateCliente(EntityCliente cliente)
        {
            return datosCliente.Update(cliente);
        }
    }
}
