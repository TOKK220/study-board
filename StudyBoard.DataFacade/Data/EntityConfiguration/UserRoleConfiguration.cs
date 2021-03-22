using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyBoard.Core.Model;

namespace StudyBoard.DataFacade.Data.EntityConfiguration
{
	internal class UserRoleConfiguration : IEntityTypeConfiguration<UserRoleObject>
	{
		public void Configure(EntityTypeBuilder<UserRoleObject> builder)
		{
			builder.ToTable("UserRole");
			builder.Ignore(userRole => userRole.Value);
		}
	}
}
