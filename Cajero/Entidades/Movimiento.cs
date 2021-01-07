namespace Cajero.Entidades
{
    public class Movimiento
    {
        public string Identificacion { get; set; }

        public string Descripcion { get; set; }

        public decimal Monto { get; set; }

        public TipoMovimiento TipoMovimiento { get; set; }
    }
}
