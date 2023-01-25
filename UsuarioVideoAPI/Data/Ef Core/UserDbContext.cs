using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UsuarioVideoAPI.Data.Ef_Core {
    public class UserDbContext : IdentityDbContext<IdentityUser<int>, IdentityRole<int>, int> {

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) {
        }

        override protected void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole<int>>().HasData(
                new IdentityRole<int> { Id = 1, Name = "cadastrado", NormalizedName = "CADASTRADO" }
                );
        }
    }
}