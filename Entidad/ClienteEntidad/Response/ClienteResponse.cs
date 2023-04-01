using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad.ClienteEntidad.Response
{
    public class ClienteResponse
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
