using Microsoft.EntityFrameworkCore;
using MUnder.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUnder.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cancion> Canciones { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Album> Albumes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {         
            optionsBuilder.UseSqlServer("Server=MUnderbd.mssql.somee.com;Database=MUnderbd;User Id=msclavi_SQLLogin_3;Password=ystdye7w3y;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>()
                .HasMany(a => a.Canciones)
                .WithMany(c => c.Albumes);

            modelBuilder.Entity<Playlist>()
                .HasMany(p => p.Canciones)
                .WithMany(c => c.Playlists);

            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Playlists)
                .WithOne(p => p.Propietario)
                .HasForeignKey(p => p.UsuarioId);
        }

    }
}
