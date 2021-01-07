using Cajero.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero.Servicios
{
    public static class SeguridadServicio
    {
        public static bool VerificarSiExiste(string usuario, string password)
        {
            bool existeCliente = false;

            foreach (var cliente in ClienteServicio.Clientes)
            {
                if (cliente.Password == password
                    && cliente.Dni == usuario)
                {
                    existeCliente = true;
                    break;
                }
            }

            return existeCliente;
        }
    }
}
