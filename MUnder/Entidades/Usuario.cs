using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUnder.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public int Telefono { get; set; }
        public string Rol { get; set; }
        //public string Imagen { get; set; } 
        public List<Playlist> Playlists { get; set; } = new List<Playlist>();
    }
}
