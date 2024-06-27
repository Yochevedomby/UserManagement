using UserManagementApi.Models;

namespace UserManagementApi.Repositories
{
    public interface IUserRepository
    {
        void CreateUser(User user);
        void DeleteUser(int userId);
        bool ValidateUser(string userName, string userPassword);
    }
}
