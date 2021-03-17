using StudyBoard.Auth.Model;

namespace StudyBoard.Auth
{
	public interface IAuthorizationBLL {
		void CreateUser(User user);
		void CreateContact(Contact contact);
	}
}
