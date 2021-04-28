using StudyBoard.Auth.Model;
using StudyBoard.Auth.Repository;

namespace StudyBoard.Auth
{
    public class AuthenticationBLL : IAuthenticationBLL
    {
        private readonly IAuthRepository _authRepository;

        public AuthenticationBLL(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public void Register(User user, Contact contact)
        {
            _authRepository.CreateUser(user);
            // TODO: create contact
        }

        public User Login(string login, string password)
        {
            return _authRepository.GetUserByLoginAndPassword(login, password);
        }
    }
}
