using StudyBoard.Core.Model.Base;

namespace StudyBoard.Core.Repository
{
	public interface ICreateRepository<in TObject, TType> where TObject : IBaseObject<TType>
	{
		void Create(TObject item); 
	}
}