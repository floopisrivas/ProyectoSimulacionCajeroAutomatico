using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Cajero
{
    public partial class TecladoAlfaNumerico : Form
    {
        private TextBox txtActual;

        public TecladoAlfaNumerico(TextBox txtParam)
        {
            InitializeComponent();

            txtActual = txtParam;

            CrearTeclado();
        }

        private void CrearTeclado()
        {
            for (int i = 65; i <= 90; i++)
            {
                var nuevoBoton = new Button
                {
                    Name = $"btn{(char)i}",
                    Text = $"{(char)i}",
                    Size = new Size(40, 40),
                    Font = new Font("Arial", 18, FontStyle.Bold),
                    BackColor = Color.Gray,
                    FlatStyle = FlatStyle.Flat
                };

                nuevoBoton.Click += btn_Click;

                flpTeclado.Controls.Add(nuevoBoton);
            }

            for (int i = 0; i <= 9; i++)
            {
                var nuevoBoton = new Button
                {
                    Name = $"btn{i}",
                    Text = $"{i}",
                    Size = new Size(40, 40),
                    Font = new Font("Arial", 18, FontStyle.Bold),
                    BackColor = Color.Gray,
                    FlatStyle = FlatStyle.Flat
                };

                nuevoBoton.Click += btn_Click;

                flpTeclado.Controls.Add(nuevoBoton);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            txtActual.Text += ((Button) sender).Text;
        }

        private void btnCerrarTeclado_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
