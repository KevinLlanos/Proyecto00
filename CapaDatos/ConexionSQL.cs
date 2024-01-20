using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDatos
{
    public class ConexionSQL
    {
        public static string ObtenerCadenaConexion()
        {
            return ConfigurationManager.ConnectionStrings["RestaurantePizzeria.CS"].ToString();
        }
    }
}