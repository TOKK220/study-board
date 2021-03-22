namespace StudyBoard.Core.Model.Base
{
	public class BaseEnumObject<T> : IBaseObject<int> where T : System.Enum
	{
		public int Id { get; set; }
		public T Value => (T)System.Enum.ToObject(typeof(T), Id);
		public string DisplayValue { get; set; }
	}
}