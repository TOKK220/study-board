using StudyBoard.Auth.Model;

namespace StudyBoard.Auth
{
	public interface IAuthenticationBLL
	{
		void Register(User user, Contact contact);
        User Login(string login, string password);
	}
}
