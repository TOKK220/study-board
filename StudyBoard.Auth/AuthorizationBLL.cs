using StudyBoard.Auth.Model;
using System;

namespace StudyBoard.Auth
{
    class AuthorizationBLL : IAuthorizationBLL
    {
        private readonly AuthContext _authContext;

        public AuthorizationBLL(AuthContext authContext)
        {
            _authContext = authContext;
        }

        public void CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void CreateContact(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
