using StudyBoard.Core.Model.Base;

namespace StudyBoard.Core.Repository
{
	public interface IUpdateRepository<in TObject, TType> where TObject : IBaseObject<TType>
	{
		void Update(TObject item);
	}
}
