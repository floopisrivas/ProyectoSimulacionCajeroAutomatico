using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cajero.Entidades;
using Cajero.Servicios;

namespace Cajero
{
    public partial class Login : Form
    {
        private bool ejecutoElBotonCancelar;
        private bool ejecutoElBotonIngresar;

        private TecladoNumerico fTecladoNumerico;
        private TecladoAlfaNumerico fTecladoAlfaNumerico;
        private Cliente clienteLogin;

        public bool puedeIngresarSistema;

        public bool PuedeIngresarSistema => puedeIngresarSistema;

        public Cliente Cliente
        {
            get { return clienteLogin; }
        }

        // public Cliente ClienteLogin => clienteLogin;

        public Login()
        {
            InitializeComponent();

            ejecutoElBotonCancelar = false;
            ejecutoElBotonIngresar = false;
            puedeIngresarSistema = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de salir del sistema"
                    ,"Atención"
                    , MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
            {
                ejecutoElBotonCancelar = true;
                puedeIngresarSistema = false;
                Application.Exit();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ejecutoElBotonIngresar)
            {
                if (!ejecutoElBotonCancelar)
                {
                    btnCancelar.PerformClick(); // Hacer un click por codigo
                }
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            fTecladoNumerico = new TecladoNumerico(txtUsuario);
            fTecladoNumerico.Show();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            fTecladoNumerico.Close();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            fTecladoAlfaNumerico = new TecladoAlfaNumerico(txtPassword);
            fTecladoAlfaNumerico.Show();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            fTecladoAlfaNumerico.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Por favor ingrese un Usuario");
                return;
            }
            
            if(string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Por favor ingrese una Contraseña");
                return;
            }

            if (SeguridadServicio.VerificarSiExiste(txtUsuario.Text, txtPassword.Text))
            {
                clienteLogin = ClienteServicio.ObtenerPorDni(txtUsuario.Text);
                ejecutoElBotonIngresar = true;
                puedeIngresarSistema = true;
                Close();
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos");
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void linkRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var fNuevoCliente = new NuevoCliente();
            fNuevoCliente.ShowDialog();
        }
    }
}
