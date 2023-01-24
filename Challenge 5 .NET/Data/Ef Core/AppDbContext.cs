using Challenge_5_.NET.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Challenge_5_.NET.Data.Ef_Core {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {           
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);

            builder.Entity<Video>()
                .HasOne(video => video.Categoria)
                .WithMany(categoria => categoria.Videos)
                .HasForeignKey(video => video.CategoriaId);
        }

        public DbSet<Video> Videos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}