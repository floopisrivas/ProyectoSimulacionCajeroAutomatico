using System.Windows.Forms;
using Cajero.Entidades;
using Cajero.Servicios;

namespace Cajero
{
    public partial class Extraccion : Form
    {
        private Cliente cliente;

        public Extraccion()
        {
            InitializeComponent();
        }

        public Extraccion(Cliente cliente)
            : this()
        {
            this.cliente = cliente;
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (nudMontoExtraer.Value == 0)
            {
                MessageBox.Show("El monto a extraer debe ser mayor a CERO");
                return;
            }

            var saldoActual = MovimientoServicio.ObtenerSaldoCliente(cliente.Dni);

            if (nudMontoExtraer.Value > saldoActual)
            {
                MessageBox.Show($"Saldo insuficiente. Saldo Actual: {saldoActual.ToString("C")}");
                nudMontoExtraer.Value = 0;
                nudMontoExtraer.Focus();
                return;
            }

            CuentaServicio.Extraer(cliente.Dni, nudMontoExtraer.Value);

            MessageBox.Show("Los datos se grabaron correctamente");
            Close();
        }
    }
}
