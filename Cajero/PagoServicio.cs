using System;
using System.Windows.Forms;
using Cajero.Entidades;
using Cajero.Servicios;

namespace Cajero
{
    public partial class PagoServicio : Form
    {
        private Cliente cliente;

        public PagoServicio()
        {
            InitializeComponent();
        }

        public PagoServicio(Cliente cliente)
        : this()
        {
            this.cliente = cliente;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CuentaServicio.PagoServicio(cliente.Dni, cmbServicio.Text, txtNumeroReferencia.Text, nudMontoPagar.Value);
        }
    }
}
