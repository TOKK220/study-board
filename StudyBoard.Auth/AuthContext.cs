using Microsoft.EntityFrameworkCore;
using StudyBoard.Auth.Model;

namespace StudyBoard.Auth
{
    public class AuthContext : DbContext
    {
        public AuthContext()
        {
            Database.EnsureCreated();
        }

        private DbSet<User> Users { get; set; }
    }
}
