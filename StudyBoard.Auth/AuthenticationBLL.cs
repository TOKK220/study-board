using StudyBoard.Auth.Model;
using StudyBoard.Auth.Repository;
using System;

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
            _authRepository.CreateUser(user);
            // TODO: create contact
        }

        public void Login(User user)
        {
            throw new NotImplementedException();
        }
    }
}
