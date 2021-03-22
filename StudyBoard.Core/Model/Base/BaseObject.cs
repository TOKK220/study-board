using System;

namespace StudyBoard.Core.Model.Base {

	public interface IBaseObject<T> {
        T Id { get;set; }
    }
    
    public class BaseObject: IBaseObject<Guid> {
        public Guid Id { get;set; }
	}
}