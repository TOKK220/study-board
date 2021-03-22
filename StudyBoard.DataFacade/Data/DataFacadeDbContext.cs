using Microsoft.EntityFrameworkCore;
using StudyBoard.Core.Model;
using StudyBoard.DataFacade.Data.EntityConfiguration;
using StudyBoard.DataFacade.Model;

namespace StudyBoard.DataFacade.Data
{
	public class DataFacadeDbContext: DbContext {
		public DbSet<UserRoleObject> UserRoles { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DataFacadeDbContext(DbContextOptions<DataFacadeDbContext> options): base(options) {
			Database.EnsureDeleted();
			Database.EnsureCreated();
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			modelBuilder.ApplyConfiguration(new ContactConfiguration());
			DataInitializer.Initialize(this);
		}
	}
}
