using MUnder.Entidades;
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
    public partial class VistaCanciones : Form
    {
        public VistaCanciones(List<Cancion> canciones)
        {
            InitializeComponent();

            ListaCanciones.DataSource = canciones;
            ListaCanciones.AutoGenerateColumns = true;
        }

        private void VistaCanciones_Load(object sender, EventArgs e)
        {

        }
    }
}
