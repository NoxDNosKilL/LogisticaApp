﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad.ClienteEntidad.Request
{
    public class AddClienteRequest
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
