using StudyBoard.Auth.Model;
using System;
using System.Linq;

namespace StudyBoard.Auth.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly AuthContext _authContext;

        public AuthRepository(AuthContext authContext)
        {
            _authContext = authContext;
        }

        public void CreateUser(User user)
        {
            if (_authContext.Users.Any(dbUser => dbUser.Login.Equals(user.Login)))
            {
                throw new ArgumentException("User with the same login already exists.");
            }

            _authContext.Add(user);
            _authContext.SaveChanges();
        }

        public User GetUserByLoginAndPassword(string login, string password)
        {
            return _authContext.Users.SingleOrDefault(x => x.Login == login && x.Password == password);
        }
    }
}
