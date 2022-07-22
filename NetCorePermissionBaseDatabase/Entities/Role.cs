namespace NetCorePermissionBaseDatabase.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedTime { get; set; }
        public int CreatedUser { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public int? UpdatedUser { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Permission> Permissions { get; set; }
        public ICollection<Menu> Menus { get; set; }
    }
}
