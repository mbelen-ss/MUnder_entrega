using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUnder.Entidades
{
    public class Album
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public List<Cancion> Canciones { get; set; } = new List<Cancion>();
        public string Creador { get; set; }
        public DateTime FechaLanzamiento { get; set; }

        public void AgregarCancion(Cancion c) => Canciones.Add(c);
        public void EliminarCancion(Cancion c) => Canciones.Remove(c);
    }
}
