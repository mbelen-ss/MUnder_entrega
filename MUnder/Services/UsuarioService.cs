using MUnder.Data;
using MUnder.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUnder.Services
{
    public class UsuarioService
    {
        private readonly AppDbContext _context = new AppDbContext();

        public bool Registrar(Usuario usuario)
        {
            if (_context.Usuarios.Any(u => u.Correo == usuario.Correo))
                return false;

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return true;
        }
        public Usuario Login(string correo, string contrasena)
        {
            return _context.Usuarios.FirstOrDefault(u =>
                u.Correo == correo && u.Contrasena == contrasena);
        }
    }
}
