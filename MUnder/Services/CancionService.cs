using MUnder.Data;
using MUnder.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUnder.Services
{
    public class CancionService
    {
        private readonly AppDbContext _context = new AppDbContext();

        public List<Cancion> ObtenerPorGenero(string genero)
        {
            return _context.Canciones
                           .Where(c => c.Genero == genero)
                           .ToList();
        }
    }
}
