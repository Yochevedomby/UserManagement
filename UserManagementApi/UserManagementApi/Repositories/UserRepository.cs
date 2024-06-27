using UserManagementApi.Models;
using System.Collections.Generic;
using System.Linq;


namespace UserManagementApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users = UserData.Users;

        public void CreateUser(User user)
        {
            _users.Add(user);
        }

        public void DeleteUser(int userId)
        {
            var user = _users.FirstOrDefault(u => u.UserId == userId);
            if (user != null)
            {
                _users.Remove(user);
            }
        }

        public bool ValidateUser(string userName, string userPassword)
        {
            return _users.Any(u => u.Name == userName && u.Password == userPassword);
        }
    }
}
