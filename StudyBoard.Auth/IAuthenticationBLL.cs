using StudyBoard.Auth.Model;

namespace StudyBoard.Auth
{
	public interface IAuthenticationBLL
	{
		void Register(User user, Contact contact);
		void Login(User user);
	}
}
