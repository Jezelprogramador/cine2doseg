using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cine2doseg.Models
{
    namespace cine2doseg.Models
    {
        public class clsSucursal
        {
            public string Clave { get; set; }
            public string Nombre { get; set; }
            public string Direccion { get; set; }
            public string Url { get; set; }
            public string Logo { get; set; }

            // Constructor sin parámetros
            public clsSucursal() { }

            // Constructor con todos los parámetros
            public clsSucursal(string clave, string nombre, string direccion, string url, string logo)
            {
                Clave = clave;
                Nombre = nombre;
                Direccion = direccion;
                Url = url;
                Logo = logo;
            }
        }
    }
}
