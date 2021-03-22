using StudyBoard.Auth.Model;
using System;
using StudyBoard.Auth.Repository;

namespace StudyBoard.Auth
{
    class AuthenticationBLL : IAuthenticationBLL
    {
        private readonly IAuthRepository _authRepository;

        public AuthenticationBLL(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public void Register(User user, Contact contact)
        {
            _authRepository.TryCreateUser(user);
            // TODO: create contact
        }

        public void Login(User user)
        {
            throw new NotImplementedException();
        }
    }
}
