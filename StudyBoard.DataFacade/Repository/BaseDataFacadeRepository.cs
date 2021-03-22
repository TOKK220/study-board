using System;

namespace StudyBoard.DataFacade.Repository
{
	public abstract class BaseDataFacadeRepository: IDataFacadeRepository
	{
		public Guid ContactId { get; set; }
	}
}
