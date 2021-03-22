using System;
using StudyBoard.Core.Model.Base;

namespace StudyBoard.DataFacade.Model
{
	public class BaseDataObject : BaseObject
	{
		public DateTime? CreatedOn { get; set; }
		public Guid? CreatedById { get; set; }
		public Contact CreatedBy { get; set; }
		public DateTime? ModifiedOn { get; set; }
		public Guid? ModifiedById { get; set; }
		public Contact ModifiedBy { get; set; }
	}
}