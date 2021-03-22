using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyBoard.DataFacade.Model;

namespace StudyBoard.DataFacade.Data.EntityConfiguration {
	internal class ContactConfiguration : IEntityTypeConfiguration<Contact> {
		public void Configure(EntityTypeBuilder<Contact> builder) {
			builder.HasKey(c => c.Id);
			builder.Property(p => p.FirstName).IsRequired().HasMaxLength(30);
		}
	}
}