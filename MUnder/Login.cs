using MUnder.Services;

namespace MUnder
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registroForm = new Registro();
            registroForm.ShowDialog();
            this.Show();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string correo = txtUsuario.Text.Trim();
            string contrasena = txtClave.Text;

            var servicio = new UsuarioService();
            var usuario = servicio.Login(correo, contrasena);

            if (usuario != null)
            {
                MessageBox.Show($"¡Bienvenido {usuario.Nombre}!", "Login exitoso");

                // Acá podés abrir el menú principal o dashboard:
                var mainForm = new PantallaPrincipal(); // suponiendo que exista
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
