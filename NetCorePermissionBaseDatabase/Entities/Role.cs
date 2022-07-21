namespace NetCorePermissionBaseDatabase.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedTime { get; set; }
        public int CreatedUser { get; set; }
        public DateTime UpdatedTime { get; set; }
        public int UpdatedUser { get; set; }
        public User User{ get; set; }
        public ICollection<Permission> Permissions { get; set; }
    }
}
