using NetCorePermissionBaseDatabase.Enums;

namespace NetCorePermissionBaseDatabase.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string? AccessToken { get; set; }
        public DateTime LastLoginTime { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedTime { get; set; }
        public int CreatedUser { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public int? UpdatedUser { get; set; }

        public UserInfo UserInfo { get; set; }
        public RefreshToken RefreshToken { get; set; }
        public ICollection<Role> Roles{ get; set; }
    }
}
