using System;

namespace StudyBoard.Core.Model {
    
    public interface IBaseObject {
        Guid Id { get;set; }
    }
    
    public class BaseObject: IBaseObject {
        public Guid Id { get;set; }
    }
}