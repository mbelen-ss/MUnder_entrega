using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUnder.Entidades
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Propietario { get; set; }
        public List<Cancion> Canciones { get; set; } = new List<Cancion>();

        public void AgregarCancion(Cancion c) => Canciones.Add(c);
        public void EliminarCancion(Cancion c) => Canciones.Remove(c);
    }
}
