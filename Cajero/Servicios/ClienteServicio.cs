using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cajero.Entidades;

namespace Cajero.Servicios
{
    public static class ClienteServicio
    {
        private static string nombreArchivo = $@"{Environment.CurrentDirectory}\Clientes.txt";

        public static List<Cliente> Clientes = new List<Cliente>();

        public static void ObtenerClientesDelArchivo()
        {
            string[] archvioCliente = File.ReadAllLines(nombreArchivo);

            for (int i = 0; i < archvioCliente.Length; i++)
            {
                var linea = archvioCliente[i];

                var clienteNuevo = new Cliente();

                clienteNuevo.Dni = linea.Substring(0, 8);
                clienteNuevo.Apellido = linea.Substring(8, 25).Trim();
                clienteNuevo.Nombre = linea.Substring(33, 25).Trim();
                clienteNuevo.Password = linea.Substring(58, 4);

                Clientes.Add(clienteNuevo);
            }
        }

        public static Cliente ObtenerPorDni(string dni)
        {
            foreach (var cliente in Clientes)
            {
                if (cliente.Dni == dni)
                {
                    return cliente;
                }
            }

            return null;
        }

        public static void Grabar(Cliente cliente)
        {
            var archivo = new StreamWriter(nombreArchivo, true);

            var crearLinea = $"{cliente.Dni.PadLeft(8, '0')}" +
                             $"{cliente.Apellido.PadRight(25,' ')}" +
                             $"{cliente.Nombre.PadRight(25, ' ')}" +
                             $"{cliente.Password}";

            archivo.WriteLine(crearLinea);
            archivo.Close();
        }
    }
}
