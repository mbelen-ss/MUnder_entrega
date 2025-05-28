using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUnder.Entidades
{
    public class Cancion
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Archivo { get; set; }
        public string Autor { get; set; } 
        public DateTime FechaSubida { get; set; }
        public string Genero { get; set; }
        public List<Album> Albumes { get; set; } = new List<Album>();
        public List<Playlist> Playlists { get; set; } = new List<Playlist>();
    }
}
