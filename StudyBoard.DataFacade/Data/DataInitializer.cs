using System;
using StudyBoard.DataFacade.Model;

namespace StudyBoard.DataFacade.Data
{
	internal class DataInitializer
	{
		public static void Initialize(DataFacadeDbContext context)
		{
			context.Contacts.Add(new Contact
				{Id = Guid.Parse("7F6125FF-C7D1-4687-B4A1-92484A18FD2A"), FirstName = "Admin", Email = "Admin"});
			context.SaveChanges();
		}
	}
}