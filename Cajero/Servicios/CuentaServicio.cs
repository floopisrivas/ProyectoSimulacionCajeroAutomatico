using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cajero.Entidades;

namespace Cajero.Servicios
{
    public static class CuentaServicio
    {
        public static void Depositar(string identificacion, decimal montoDepositar)
        {
            var movimiento = new Movimiento();

            movimiento.Monto = montoDepositar;
            movimiento.Identificacion = identificacion;
            movimiento.TipoMovimiento = TipoMovimiento.Ingreso;
            movimiento.Descripcion = $"Deposito - Fecha: {DateTime.Now.ToString()}";

            MovimientoServicio.Add(movimiento);
        }

        public static void PagoServicio(string identificacion, string servicio, string nroReferencia, decimal montoPagar)
        {
            var movimiento = new Movimiento();

            movimiento.Monto = montoPagar;
            movimiento.Identificacion = identificacion;
            movimiento.TipoMovimiento = TipoMovimiento.Egreso;
            movimiento.Descripcion = $"Pago Serv. {servicio} - Ref: {nroReferencia} - Fecha: {DateTime.Now.ToString()}";

            MovimientoServicio.Add(movimiento);
        }

        public static void Extraer(string identificacion, decimal montoExtraer)
        {
            var movimiento = new Movimiento();

            movimiento.Monto = montoExtraer;
            movimiento.Identificacion = identificacion;
            movimiento.TipoMovimiento = TipoMovimiento.Egreso;
            movimiento.Descripcion = $"Extracción - Fecha: {DateTime.Now.ToString()}";

            MovimientoServicio.Add(movimiento);
        }

        public static void Transferir(string cuentaOrigen, string cuentaDestino, decimal montoTransferir)
        {
            var movimientoExtraer = new Movimiento();

            movimientoExtraer.Monto = montoTransferir;
            movimientoExtraer.Identificacion = cuentaOrigen;
            movimientoExtraer.TipoMovimiento = TipoMovimiento.Egreso;
            movimientoExtraer.Descripcion = $"Transf. de Cta: {cuentaOrigen} a Cta: {cuentaDestino} - Fecha: {DateTime.Now.ToString()}";

            var movimientoDepositar = new Movimiento();

            movimientoDepositar.Monto = montoTransferir;
            movimientoDepositar.Identificacion = cuentaDestino;
            movimientoDepositar.TipoMovimiento = TipoMovimiento.Ingreso;
            movimientoDepositar.Descripcion = $"Transf. de Cta: {cuentaOrigen} a Cta: {cuentaDestino} - Fecha: {DateTime.Now.ToString()}";

            MovimientoServicio.Add(movimientoExtraer);
            MovimientoServicio.Add(movimientoDepositar);
        }
    }
}
