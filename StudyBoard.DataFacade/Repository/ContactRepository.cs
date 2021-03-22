using System;
using StudyBoard.Core.Repository;
using StudyBoard.DataFacade.Data;
using StudyBoard.DataFacade.Model;

namespace StudyBoard.DataFacade.Repository
{
	public interface IContactRepository : ICreateRepository<Contact, Guid> { }

	public class ContactRepository: BaseDataFacadeRepository, IContactRepository
	{
		protected DataFacadeDbContext Context { get; }
		public ContactRepository(DataFacadeDbContext context)
		{
			Context = context;
		}
		public void Create(Contact item)
		{
			Context.Contacts.Add(item);
			Context.SaveChanges();
		}
	}
}
