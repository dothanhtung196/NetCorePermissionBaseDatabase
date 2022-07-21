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
    }
}
