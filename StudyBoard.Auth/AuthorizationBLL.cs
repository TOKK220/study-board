using StudyBoard.Auth.Model;
using System;

namespace StudyBoard.Auth
{
    class AuthenticationBLL : IAuthenticationBLL
    {
        private readonly AuthContext _authContext;

        public AuthenticationBLL(AuthContext authContext)
        {
            _authContext = authContext;
        }

        public void Register(User user, Contact contact)
        {
        }

        public void Login(User user)
        {
            throw new NotImplementedException();
        }
    }
}
