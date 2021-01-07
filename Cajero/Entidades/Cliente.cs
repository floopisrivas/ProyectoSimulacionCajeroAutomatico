using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cajero.Servicios;

namespace Cajero.Entidades
{
    public class Cliente
    {
        public string Dni { get; set; }

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string Password { get; set; }

        public string ApyNomCompleto => $"{Apellido}, {Nombre}"; // Propiedad de Solo LEctura
    }
}
