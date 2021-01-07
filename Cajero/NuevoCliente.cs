using System;
using System.Windows.Forms;
using Cajero.Entidades;
using Cajero.Servicios;

namespace Cajero
{
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Por favor ingrese un apellido");
                txtApellido.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Por favor ingrese un nombre");
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDni.Text))
            {
                MessageBox.Show("Por favor ingrese un DNI");
                txtDni.Focus();
                return;
            }
            else
            {
                if (txtDni.Text.Length < 7)
                {
                    MessageBox.Show("EL dni debe tener al menos 7 digitos");
                    txtDni.Focus();
                    return;
                }
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Por favor ingrese una contraseña");
                txtPassword.Focus();
                return;
            }
            else
            {
                if (txtPassword.Text.Length < 4)
                {
                    MessageBox.Show("EL dni debe tener al menos 7 digitos");
                    txtPassword.Focus();
                    return;
                }
            }

            var nuevoCliente = new Cliente
            {
                Apellido = txtApellido.Text, 
                Nombre = txtNombre.Text, 
                Dni = txtDni.Text, 
                Password = txtPassword.Text
            };
            
            ClienteServicio.Grabar(nuevoCliente);

            MessageBox.Show("Los datos se grabaron correctamente");
            Close();
        }
    }
}
