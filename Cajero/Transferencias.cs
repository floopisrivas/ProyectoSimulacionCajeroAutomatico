using System;
using Cajero.Entidades;
using System.Windows.Forms;
using Cajero.Servicios;

namespace Cajero
{
    public partial class Transferencias : Form
    {
        private Cliente cliente;

        public Transferencias()
        {
            InitializeComponent();
        }

        public Transferencias(Cliente cliente)
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
            if (string.IsNullOrEmpty(txtCuentaDestino.Text))
            {
                MessageBox.Show("Por favor ingrese el numero de cuenta");
                txtCuentaDestino.Focus();
                return;
            }

            if (nudMontoTransferencia.Value == 0)
            {
                MessageBox.Show("El monto a transferir debe ser mayor a CERO");
                nudMontoTransferencia.Focus();
                return;
            }

            var saldoActual = MovimientoServicio.ObtenerSaldoCliente(cliente.Dni);

            if (nudMontoTransferencia.Value > saldoActual)
            {
                MessageBox.Show($"Saldo Insuficiente. Su saldo es {saldoActual.ToString("C")}");
                nudMontoTransferencia.Value = 0;
                nudMontoTransferencia.Focus();
            }

            var clienteDestino = ClienteServicio.ObtenerPorDni(txtCuentaDestino.Text);

            if (clienteDestino == null)
            {
                MessageBox.Show("El cliente destinatario no EXISTE");
                return;
            }

            var mensaje =
                $"Esta seguro de transferir {nudMontoTransferencia.Value.ToString("C")} a {Environment.NewLine}{clienteDestino.ApyNomCompleto}";

            if (MessageBox.Show(mensaje, "Transferencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                DialogResult.OK)
            {

                CuentaServicio.Transferir(cliente.Dni, clienteDestino.Dni, nudMontoTransferencia.Value);

                MessageBox.Show("Los datos se grabaron correctamente");
                Close();
            }
        }
    }
}
