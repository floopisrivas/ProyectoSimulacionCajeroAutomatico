using System.Linq;
using System.Windows.Forms;
using Cajero.Entidades;
using Cajero.Servicios;

namespace Cajero
{
    public partial class Movimientos : Form
    {
        private Cliente cliente;

        public Movimientos()
        {
            InitializeComponent();
        }

        public Movimientos(Cliente cliente)
        : this()
        {
            this.cliente = cliente;
        }

        private void MostrarMovimientos()
        {
            dgvMovimientos.DataSource = MovimientoServicio.Obtener(cliente.Dni);

            // Formatear Grilla
            dgvMovimientos.Columns["Identificacion"].Visible = false;

            dgvMovimientos.Columns["Descripcion"].HeaderText = "Movimientos";
            dgvMovimientos.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvMovimientos.Columns["Monto"].DefaultCellStyle.Format = "C";
            dgvMovimientos.Columns["Monto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvMovimientos.Columns["TipoMovimiento"].Width = 50;
            dgvMovimientos.Columns["TipoMovimiento"].HeaderText = "Tipo";

        }

        private void Movimientos_Load(object sender, System.EventArgs e)
        {
            MostrarMovimientos();
        }
    }
}
