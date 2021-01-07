using System;
using System.Windows.Forms;
using Cajero.Entidades;
using Cajero.Servicios;

namespace Cajero
{
    public partial class Principal : Form
    {
        private Cliente clienteLogin;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            var fLogin = new Login();
            fLogin.ShowDialog();

            if (fLogin.puedeIngresarSistema)
            {
                clienteLogin = fLogin.Cliente;

                lblUsuarioLogin.Text = MostrarTestingo();

            }
        }

        private string MostrarTestingo(){
            return 
                $"Usuario: {clienteLogin.ApyNomCompleto} - Saldo: {MovimientoServicio.ObtenerSaldoCliente(clienteLogin.Dni).ToString("C")}";
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            var fDeposito = new Deposito(clienteLogin);
            fDeposito.ShowDialog();
            lblUsuarioLogin.Text = MostrarTestingo();
        }

        private void btnExtraccion_Click(object sender, EventArgs e)
        {
            var fExtraccion = new Extraccion(clienteLogin);
            fExtraccion.ShowDialog();
            lblUsuarioLogin.Text = MostrarTestingo();
        }

        private void btnPagoServicio_Click(object sender, EventArgs e)
        {
            var fPagoServicio = new PagoServicio(clienteLogin);
            fPagoServicio.ShowDialog();
            lblUsuarioLogin.Text = MostrarTestingo();
        }

        private void btnRecargaTelefonica_Click(object sender, EventArgs e)
        {
            var fRecargaTelefononica = new RecargaTelefonica(clienteLogin);
            fRecargaTelefononica.ShowDialog();
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            var fMovimientos = new Movimientos(clienteLogin);
            fMovimientos.ShowDialog();
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            var fTransferencia = new Transferencias(clienteLogin);
            fTransferencia.ShowDialog();
            lblUsuarioLogin.Text = MostrarTestingo();
        }
    }
}
