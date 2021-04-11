using Microsoft.EntityFrameworkCore;
using StudyBoard.Auth.Model;

namespace StudyBoard.Auth
{
    public class AuthContext : DbContext
    {
        public AuthContext(DbContextOptions<AuthContext> options) : base(options) { }

        public AuthContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
    }
}
