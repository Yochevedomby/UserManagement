namespace UserManagementApi.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
    public static class UserData
    {
        public static List<User> Users = new List<User>
        {
            new User { UserId = 1, Name = "david", Password = "david123" },
            new User { UserId = 2, Name = "avi", Password = "avi#99" },
            new User { UserId = 3, Name = "yael", Password = "yaeli@123" },
            new User { UserId = 4, Name = "yehuda", Password = "yehudaPass1!" },
            new User { UserId = 5, Name = "shira", Password = "shira89" }
        };
    }
}
