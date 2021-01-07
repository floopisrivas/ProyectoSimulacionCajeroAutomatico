using System.Windows.Forms;
using Cajero.Entidades;
using Cajero.Servicios;

namespace Cajero
{
    public partial class Deposito : Form
    {
        private Cliente cliente;

        public Deposito() // Constructor por defecto
        {
            InitializeComponent();
        }

        public Deposito(Cliente cliente) // constructor sobrecrgado
         : this() // llama al constructor por defecto
        {
            this.cliente = cliente;
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (nudMontoDepositar.Value == 0)
            {
                MessageBox.Show("El valor a depositar debe ser mayor a CERO");
                return;
            }

            CuentaServicio.Depositar(cliente.Dni, nudMontoDepositar.Value);

            MessageBox.Show("Los datos se grabaron correctamente");

            Close();
        }
    }
}
