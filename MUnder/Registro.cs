using MUnder.Entidades;
using MUnder.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUnder
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Run(new Login());
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario
            {
                Nombre = txtNombre.Text,
                Correo = txtEmail.Text,
                Contrasena = txtContrasena.Text,
                Telefono = int.Parse(txtTelefono.Text),
                Rol = "Fan"
            };
            var servicio = new UsuarioService();
            if (servicio.Registrar(usuario))
            {
                MessageBox.Show("¡Usuario registrado exitosamente!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ya existe un usuario con ese correo.");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
