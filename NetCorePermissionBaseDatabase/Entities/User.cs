namespace NetCorePermissionBaseDatabase.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime CreatedTime { get; set; }
        public int CreatedUser { get; set; }
        public DateTime UpdatedTime { get; set; }
        public int UpdatedUser { get; set; }
        public ICollection<Role> Roles{ get; set; }
    }
}
