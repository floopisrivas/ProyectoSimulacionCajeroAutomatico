using Cajero.Entidades;
using System.Windows.Forms;

namespace Cajero
{
    public partial class RecargaTelefonica : Form
    {
        private Cliente cliente;

        public RecargaTelefonica()
        {
            InitializeComponent();
        }

        public RecargaTelefonica(Cliente cliente)
        : this()
        {
            this.cliente = cliente;
        }
    }
}
