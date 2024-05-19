using library_app.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace library_app.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // Estos conjuntos de datos son las futuras tablas de la base de datos
        // Esto será el mapeo que EF hará
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}