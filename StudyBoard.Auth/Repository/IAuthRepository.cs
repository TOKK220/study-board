using StudyBoard.Auth.Model;

namespace StudyBoard.Auth.Repository
{
    public interface IAuthRepository
    {
        void CreateUser(User user);
    }
}
