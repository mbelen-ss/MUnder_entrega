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
        //funcionalidad de los botones - Abrir Vistas de Canciones por Género
        private void AbrirVistaCanciones(string genero)
        {
            var servicio = new CancionService();
            var canciones = servicio.ObtenerPorGenero(genero);

            var vista = new VistaCanciones(canciones);
            vista.ShowDialog();
        }
        private void btnRockAlter2024_Click(object sender, EventArgs e)
        {
            AbrirVistaCanciones("Rock Alternativo 2024");
        }

        private void btnElectroExperimental_Click(object sender, EventArgs e)
        {
            AbrirVistaCanciones("ElectrÃ³nica Experimental");
        }

        private void btnMusica_Click(object sender, EventArgs e)
        {

        }

        private void btnIndieFolkArg_Click_1(object sender, EventArgs e)
        {
            AbrirVistaCanciones("Indie Folk Argentino");
        }

        private void btnHipHopUnder_Click_1(object sender, EventArgs e)
        {
            AbrirVistaCanciones("Hip Hop Underground");
        }

        private void btnSocial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botón 'Social' clickeado");
        }
    }
}
