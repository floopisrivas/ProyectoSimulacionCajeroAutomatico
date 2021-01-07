using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cajero.Entidades;

namespace Cajero.Servicios
{
    public static class MovimientoServicio
    {
        private static string nombreArchivo = $@"{Environment.CurrentDirectory}\Movimientos.txt";

        public static List<Movimiento> Movimientos = new List<Movimiento>();

        public static void ObtenerMovimientosDelArchivo()
        {
            string[] archvioCliente = File.ReadAllLines(nombreArchivo);

            for (int i = 0; i < archvioCliente.Length; i++)
            {
                var linea = archvioCliente[i];

                if (!string.IsNullOrEmpty(linea))
                {
                    var movimientoNuevo = new Movimiento();

                    movimientoNuevo.Identificacion = linea.Substring(0, 8);
                    movimientoNuevo.Descripcion = linea.Substring(8, 68);
                    movimientoNuevo.Monto = decimal.Parse(linea.Substring(76, 14));
                    movimientoNuevo.TipoMovimiento = linea.Substring(90, 2) == "-1"
                        ? TipoMovimiento.Egreso
                        : TipoMovimiento.Ingreso;

                    Movimientos.Add(movimientoNuevo);
                }
            }
        }

        public static decimal ObtenerSaldoCliente(string id)
        {
            var saldo = 0m;

            foreach (var mov in Movimientos)
            {
                if (mov.Identificacion == id)
                {
                    saldo += mov.Monto * (int) mov.TipoMovimiento;
                }
            }

            return saldo;
        }

        public static List<Movimiento> Obtener(string identificacion)
        {
            return Movimientos
                .Where(x => x.Identificacion == identificacion)
                .ToList();
        }

        public static void Add(Movimiento movimiento)
        {
            // Actulizo el Archivo
            var archivo = new StreamWriter(nombreArchivo, true);

            string tipo = movimiento.TipoMovimiento == TipoMovimiento.Ingreso
                ? " 1"
                : "-1";

            var crearLinea = $"{movimiento.Identificacion.PadLeft(8, '0')}" +
                             $"{movimiento.Descripcion.PadRight(68, ' ')}" +
                             $"{movimiento.Monto.ToString().PadLeft(14, ' ')}" +
                             $"{tipo}";

            archivo.WriteLine(crearLinea);
            archivo.Close();

            // Actualizo la Lista
            Movimientos.Add(movimiento);
        }
    }
}
