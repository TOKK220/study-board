using StudyBoard.Auth.Model;

namespace StudyBoard.Auth.Repository
{
    public interface IAuthRepository
    {
        void CreateUser(User user);
        User GetUserByLoginAndPassword(string login, string password);
    }
}
