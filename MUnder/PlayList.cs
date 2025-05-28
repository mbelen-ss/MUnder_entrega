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
    public partial class PlayList : Form
    {
        public PlayList()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void PlayList_Load(object sender, EventArgs e)
        {

        }

        private void btnRockAlter2024_Click(object sender, EventArgs e)
        {
            AbrirVistaCanciones("Rock Alternativo 2024");
        }
        private void AbrirVistaCanciones(string genero)
        {
            var servicio = new CancionService();
            var canciones = servicio.ObtenerPorGenero(genero);

            var vista = new VistaCanciones(canciones);
            vista.ShowDialog();
        }

        private void btnElectroExperimental_Click(object sender, EventArgs e)
        {

        }

        private void btnMusica_Click(object sender, EventArgs e)
        {

        }
    }
}
